using Fitness_First.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Fitness_First.Models;
using Fitness_First.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Amazon; //Connect to AWS Account 
using Amazon.S3;
using Amazon.S3.Model;
using System.Net;
using Microsoft.Extensions.Configuration;   //appsettings.json settings




namespace Fitness_First.Controllers
{
    public class AdminController : Controller
    {

        //define S3 Bucket Name
        public const string S3BucketName = "fitnessfirstbucket";

        //connection string to AWS Account
        private List<string> getKeys()
        {
            List<string> keys = new List<string>();

            //link to appsettings.json get key values

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            IConfigurationRoot configure = builder.Build(); //build json file

            //read the key values

            keys.Add(configure["Keys:key1"]);
            keys.Add(configure["Keys:key2"]);
            keys.Add(configure["Keys:key3"]);
            return keys;
        }




        //create variable for connection to db
        private readonly Fitness_FirstContext _dbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<AdminController> _logger;


        //create constructor for database connection
        public AdminController(Fitness_FirstContext dbContext, IWebHostEnvironment webHostEnvironment, ILogger<AdminController> logger)
        {
            _dbContext = dbContext;
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPackages()
        {
            return View();
        }

        //function to add Packages Data to database
        [HttpPost]
        public async Task<IActionResult> AddPackagesPostRequest(GymPackages gymPackages, IFormFile packagePicture)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (packagePicture != null && packagePicture.Length > 0)
                    {
                        // Upload to S3 and generate URL to store in the database
                        List<string> keys = getKeys();
                        var awsS3client = new AmazonS3Client(keys[0], keys[1], keys[2], RegionEndpoint.USEast1);

                        // Upload to S3 Bucket
                        PutObjectRequest uploadRequest = new PutObjectRequest
                        {
                            InputStream = packagePicture.OpenReadStream(),
                            BucketName = S3BucketName,
                            Key = "uploads/"+packagePicture.FileName,
                            CannedACL = S3CannedACL.PublicRead
                        };

                        // Send out the request to upload to S3
                        PutObjectResponse putResponse = await awsS3client.PutObjectAsync(uploadRequest);

                        if (putResponse.HttpStatusCode == HttpStatusCode.OK)
                        {
                            // The upload was successful
                            string s3ImageUrl = $"https://d3w54omocn56lm.cloudfront.net/uploads/{packagePicture.FileName}";
                            gymPackages.PackagePicturePath = s3ImageUrl;
                        }
                        else
                        {
                            // The upload failed
                            ModelState.AddModelError("", "Failed to upload picture to S3.");
                            return View("AddPackages", gymPackages);
                        }
                    }

                    // Add the gymPackages object to the context
                    _dbContext.GymPackages.Add(gymPackages);

                    // Save changes to the database
                    await _dbContext.SaveChangesAsync();

                    return RedirectToAction("ViewPackages");
                }
                catch (Exception ex)
                {
                    // Log the exception for debugging purposes
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    ModelState.AddModelError("", "An error occurred while processing the form.");
                    return View("AddPackages", gymPackages);
                }
            }

            return View("AddPackages", gymPackages);
        }



        public IActionResult ViewPackages()
        {
            var packages = _dbContext.GymPackages.ToList(); // Retrieve the data from the database
            return View("ViewPackages", packages); // Pass the data to the "EditPackages" view
        }

        // Add a new action to handle editing a package
        [HttpGet]
        public IActionResult EditPackage(int id)
        {
            var package = _dbContext.GymPackages.FirstOrDefault(p => p.PackageID == id);

            if (package == null)
            {
                return NotFound();
            }

            return View("EditPackage", package);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPackagePostRequest(GymPackages updatedPackage, string deleteButton, IFormFile packagePicture)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existingPackage = await _dbContext.GymPackages.FindAsync(updatedPackage.PackageID);

                    if (existingPackage == null)
                    {
                        return NotFound();
                    }

                    if (!string.IsNullOrEmpty(deleteButton) && deleteButton == "delete")
                    {
                        // Remove the picture from the S3 bucket
                        await RemovePictureFromS3(existingPackage.PackagePicturePath);

                        _dbContext.GymPackages.Remove(existingPackage);
                        await _dbContext.SaveChangesAsync();
                        return RedirectToAction("ViewPackages");
                    }
                    else
                    {
                        existingPackage.PackageName = updatedPackage.PackageName;
                        existingPackage.PackagePrice = updatedPackage.PackagePrice;
                        existingPackage.InstructorName = updatedPackage.InstructorName;
                        existingPackage.Session1 = updatedPackage.Session1;
                        existingPackage.Session2 = updatedPackage.Session2;
                        existingPackage.Session3 = updatedPackage.Session3;
                        existingPackage.Session4 = updatedPackage.Session4;
                        existingPackage.Session5 = updatedPackage.Session5;
                        existingPackage.Session6 = updatedPackage.Session6;
                        existingPackage.Session7 = updatedPackage.Session7;
                        existingPackage.Session8 = updatedPackage.Session8;

                        if (packagePicture != null && packagePicture.Length > 0)
                        {
                            // Remove the old picture from the S3 bucket
                            await RemovePictureFromS3(existingPackage.PackagePicturePath);

                            // Upload the new picture to S3
                            string newImageUrl = await UploadPictureToS3(packagePicture);
                            existingPackage.PackagePicturePath = newImageUrl;
                        }

                        _dbContext.GymPackages.Update(existingPackage);
                        await _dbContext.SaveChangesAsync();
                        return RedirectToAction("ViewPackages");
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception for debugging purposes
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    ModelState.AddModelError("", "An error occurred while processing the form.");
                    return View("EditPackage", updatedPackage);
                }
            }

            return View("EditPackage", updatedPackage);
        }

        private async Task<string> UploadPictureToS3(IFormFile packagePicture)
        {
            List<string> keys = getKeys();
            var awsS3client = new AmazonS3Client(keys[0], keys[1], keys[2], RegionEndpoint.USEast1);

            // Upload to S3 Bucket
            string newFileName = packagePicture.FileName;
            PutObjectRequest uploadRequest = new PutObjectRequest
            {
                InputStream = packagePicture.OpenReadStream(),
                BucketName = S3BucketName,
                Key = "uploads/" + newFileName,
                CannedACL = S3CannedACL.PublicRead
            };

            await awsS3client.PutObjectAsync(uploadRequest);

            // Return the new S3 image URL
            return $"https://d3w54omocn56lm.cloudfront.net/uploads/{newFileName}";
        }

        private async Task RemovePictureFromS3(string imageUrl)
        {
            if (!string.IsNullOrEmpty(imageUrl))
            {
                string objectKey = imageUrl.Substring(imageUrl.LastIndexOf('/') + 1);

                List<string> keys = getKeys();
                var awsS3client = new AmazonS3Client(keys[0], keys[1], keys[2], RegionEndpoint.USEast1);

                DeleteObjectRequest deleteRequest = new DeleteObjectRequest
                {
                    BucketName = S3BucketName,
                    Key = "uploads/" + objectKey
                };

                await awsS3client.DeleteObjectAsync(deleteRequest);
            }
        }


        public IActionResult AddProducts()
        {
            return View();
        }


        //function to add Products Data to database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProductsPostRequest(Products products, IFormFile productPicture)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //LATER EDIT THIS CODE TO UPLOAD TO S3 BUCKET INSTEAD
                    if (productPicture != null && productPicture.Length > 0)
                    {
                        // Upload to S3 and generate URL to store in the database
                        List<string> keys = getKeys();
                        var awsS3client = new AmazonS3Client(keys[0], keys[1], keys[2], RegionEndpoint.USEast1);

                        var uniqueFileName = productPicture.FileName;

                        // Upload to S3 Bucket
                        PutObjectRequest uploadRequest = new PutObjectRequest
                        {
                            InputStream = productPicture.OpenReadStream(),
                            BucketName = S3BucketName,
                            Key = "uploads/" + uniqueFileName,
                            CannedACL = S3CannedACL.PublicRead
                        };

                        // Send out the request to upload to S3
                        PutObjectResponse putResponse = await awsS3client.PutObjectAsync(uploadRequest);

                        if (putResponse.HttpStatusCode == HttpStatusCode.OK)
                        {
                            // The upload was successful
                            string s3ImageUrl = $"https://d3w54omocn56lm.cloudfront.net/uploads/{uniqueFileName}";
                            products.ProductPicturePath = s3ImageUrl;
                        }
                        else
                        {
                            // The upload failed
                            ModelState.AddModelError("", "Failed to upload picture to S3.");
                            return View("AddProducts", products);
                        }
                    }

                    _dbContext.Products.Add(products);
                    await _dbContext.SaveChangesAsync();
                    return RedirectToAction("ViewProducts");
                }
                catch (Exception ex)
                {
                    // Log the exception for debugging purposes
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    ModelState.AddModelError("", "An error occurred while processing the form.");
                    return View("AddProducts", products);
                }
            }

            return View("AddProducts", products);
        }


        public IActionResult ViewProducts()
        {
            var products = _dbContext.Products.ToList(); // Retrieve the data from the database
            return View("ViewProducts", products); // Pass the data to the "EditProducts" view
        }


        // Add a new action to handle editing a package
        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.ProductID == id);

            if (product == null)
            {
                return NotFound();
            }

            return View("EditProduct", product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProductPostRequest(Products updatedProduct, string deleteButton, IFormFile productPicture)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existingProduct = await _dbContext.Products.FindAsync(updatedProduct.ProductID);

                    if (existingProduct == null)
                    {
                        return NotFound();
                    }

                    if (!string.IsNullOrEmpty(deleteButton) && deleteButton == "delete")
                    {
                        // Remove the picture from S3 bucket
                        await RemovePictureFromS3(existingProduct.ProductPicturePath);

                        _dbContext.Products.Remove(existingProduct);
                        await _dbContext.SaveChangesAsync();
                        return RedirectToAction("ViewProducts");
                    }
                    else
                    {
                        existingProduct.ProductName = updatedProduct.ProductName;
                        existingProduct.ProductPrice = updatedProduct.ProductPrice;
                        existingProduct.ProductType = updatedProduct.ProductType;

                        if (productPicture != null && productPicture.Length > 0)
                        {
                            // Remove the old picture from S3 bucket
                            await RemoveProductPictureFromS3(existingProduct.ProductPicturePath);

                            // Upload new picture to S3 and update S3 URL
                            string newImageUrl = await UploadProductPictureToS3(productPicture);

                            existingProduct.ProductPicturePath = newImageUrl;
                        }

                        _dbContext.Products.Update(existingProduct);
                        await _dbContext.SaveChangesAsync();
                        return RedirectToAction("ViewProducts");
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception for debugging purposes
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    ModelState.AddModelError("", "An error occurred while processing the form.");
                    return View("EditProduct", updatedProduct);
                }
            }

            return View("EditProduct", updatedProduct);
        }

        private async Task<string> UploadProductPictureToS3(IFormFile productPicture)
        {
            List<string> keys = getKeys();
            var awsS3client = new AmazonS3Client(keys[0], keys[1], keys[2], RegionEndpoint.USEast1);

            var uniqueFileName = productPicture.FileName;

            // Upload to S3 Bucket
            PutObjectRequest uploadRequest = new PutObjectRequest
            {
                InputStream = productPicture.OpenReadStream(),
                BucketName = S3BucketName,
                Key = "uploads/" + uniqueFileName,
                CannedACL = S3CannedACL.PublicRead
            };

            // Send out the request to upload to S3
            PutObjectResponse putResponse = await awsS3client.PutObjectAsync(uploadRequest);

            if (putResponse.HttpStatusCode == HttpStatusCode.OK)
            {
                // The upload was successful
                string s3ImageUrl = $"https://d3w54omocn56lm.cloudfront.net/uploads/{uniqueFileName}";
                return s3ImageUrl;
            }
            else
            {
                // The upload failed
                return null;
            }
        }

        private async Task RemoveProductPictureFromS3(string imageUrl)
        {
            if (!string.IsNullOrEmpty(imageUrl))
            {
                string objectKey = imageUrl.Substring(imageUrl.LastIndexOf('/') + 1);

                List<string> keys = getKeys();
                var awsS3client = new AmazonS3Client(keys[0], keys[1], keys[2], RegionEndpoint.USEast1);

                DeleteObjectRequest deleteRequest = new DeleteObjectRequest
                {
                    BucketName = S3BucketName,
                    Key = "uploads/" + objectKey
                };

                await awsS3client.DeleteObjectAsync(deleteRequest);
            }
        }


        public IActionResult AddEquipments()
        {
            return View();
        }

        //function to add Equipments Data to database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEquipmentsPostRequest(GymEquipments equipments, IFormFile equipmentPicture)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (equipmentPicture != null && equipmentPicture.Length > 0)
                    {
                        // Upload equipment picture to S3 and get the S3 URL
                        string s3ImageUrl = await UploadEquipmentPictureToS3(equipmentPicture);

                        // Set the EquipmentPicturePath property before adding to the database
                        equipments.EquipmentPicturePath = s3ImageUrl;
                    }

                    _dbContext.GymEquipments.Add(equipments);
                    await _dbContext.SaveChangesAsync();
                    return RedirectToAction("ViewEquipments");
                }
                catch (Exception ex)
                {
                    // Log the exception for debugging purposes
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    ModelState.AddModelError("", "An error occurred while processing the form.");
                    return View("AddEquipments", equipments);
                }
            }

            return View("AddEquipments", equipments);
        }

        private async Task<string> UploadEquipmentPictureToS3(IFormFile equipmentPicture)
        {
            List<string> keys = getKeys();
            var awsS3client = new AmazonS3Client(keys[0], keys[1], keys[2], RegionEndpoint.USEast1);

            var uniqueFileName = equipmentPicture.FileName;
            var objectKey = "uploads/" + uniqueFileName; // Modify the path as needed

            using (var memoryStream = new MemoryStream())
            {
                await equipmentPicture.CopyToAsync(memoryStream);

                PutObjectRequest uploadRequest = new PutObjectRequest
                {
                    InputStream = memoryStream,
                    BucketName = S3BucketName,
                    Key = objectKey,
                    CannedACL = S3CannedACL.PublicRead
                };

                PutObjectResponse putResponse = await awsS3client.PutObjectAsync(uploadRequest);

                if (putResponse.HttpStatusCode == HttpStatusCode.OK)
                {
                    // The upload was successful
                    string s3ImageUrl = $"https://d3w54omocn56lm.cloudfront.net/uploads/{uniqueFileName}";
                    return s3ImageUrl;
                }
                else
                {
                    // The upload failed
                    throw new Exception("Failed to upload picture to S3.");
                }
            }
        }

        private async Task RemoveEquipmentPictureFromS3(string imageUrl)
        {
            if (!string.IsNullOrEmpty(imageUrl))
            {
                string objectKey = imageUrl.Substring(imageUrl.LastIndexOf('/') + 1);

                List<string> keys = getKeys();
                var awsS3client = new AmazonS3Client(keys[0], keys[1], keys[2], RegionEndpoint.USEast1);

                DeleteObjectRequest deleteRequest = new DeleteObjectRequest
                {
                    BucketName = S3BucketName,
                    Key = "uploads/" + objectKey // Modify the path as needed
                };

                await awsS3client.DeleteObjectAsync(deleteRequest);
            }
        }

        public IActionResult ViewEquipments()
        {
            var equipments = _dbContext.GymEquipments.ToList(); // Retrieve the data from the database
            return View("ViewEquipments", equipments); // Pass the data to the "EditEquipments" view
        }


        // Add a new action to handle editing a package
        [HttpGet]
        public IActionResult EditEquipment(int id)
        {
            var equipments = _dbContext.GymEquipments.FirstOrDefault(p => p.EquipmentID == id);

            if (equipments == null)
            {
                return NotFound();
            }

            return View("EditEquipment", equipments);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEquipmentPostRequest(GymEquipments updatedEquipment, string deleteButton, IFormFile equipmentPicture)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existingEquipment = await _dbContext.GymEquipments.FindAsync(updatedEquipment.EquipmentID);

                    if (existingEquipment == null)
                    {
                        return NotFound();
                    }

                    if (!string.IsNullOrEmpty(deleteButton) && deleteButton == "delete")
                    {
                        // Remove the picture from S3 bucket
                        await RemovePictureFromS3(existingEquipment.EquipmentPicturePath);

                        _dbContext.GymEquipments.Remove(existingEquipment);
                        await _dbContext.SaveChangesAsync();
                        return RedirectToAction("ViewEquipments");
                    }
                    else
                    {
                        existingEquipment.EquipmentName = updatedEquipment.EquipmentName;
                        existingEquipment.Quantity = updatedEquipment.Quantity;
                        existingEquipment.Availability = updatedEquipment.Availability;

                        if (equipmentPicture != null && equipmentPicture.Length > 0)
                        {
                            // Remove the old picture from S3 bucket
                            await RemoveProductPictureFromS3(existingEquipment.EquipmentPicturePath);

                            // Upload new picture to S3 and update S3 URL
                            string newImageUrl = await UploadProductPictureToS3(equipmentPicture);

                            existingEquipment.EquipmentPicturePath = newImageUrl;
                        }

                        _dbContext.GymEquipments.Update(existingEquipment);
                        await _dbContext.SaveChangesAsync();
                        return RedirectToAction("ViewEquipments");
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception for debugging purposes
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    ModelState.AddModelError("", "An error occurred while processing the form.");
                    return View("EditEquipments", updatedEquipment);
                }
            }

            return View("EditEquipments", updatedEquipment);
        }


        public async Task<IActionResult> ViewPackageEnrollment(int id, string packagename)
        {
            var package = await _dbContext.GymPackages.FindAsync(id);
            if (package == null)
            {
                return NotFound();
            }

            var enrollments = await _dbContext.PackageEnrollments
                .Where(e => e.PackageName == packagename)
                .ToListAsync();

            ViewBag.PackageName = package.PackageName;

            return View(enrollments);
        }

        public IActionResult RevenueSummary()
        {
            // Retrieve product and package purchase data from the database and calculate sums
            var productPurchases = _dbContext.ProductPurchases.ToList();
            var packagePurchases = _dbContext.PackageEnrollments.ToList();

            var productSum = productPurchases.Sum(p => p.ProductPrice * p.Quantity);
            var packageSum = packagePurchases.Sum(p => p.PackagePrice);

            var totalAmount = productSum + packageSum;

            // Create a PurchaseSummaryViewModel and populate its properties
            var viewModel = new PurchaseSummaryViewModel
            {
                ProductPurchases = productPurchases,
                PackagePurchases = packagePurchases,
                ProductSum = productSum,
                PackageSum = packageSum,
                TotalAmount = totalAmount,
            };

            return View(viewModel);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
