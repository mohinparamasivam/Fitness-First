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

namespace Fitness_First.Controllers
{
    public class AdminController : Controller
    {

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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPackagesPostRequest(GymPackages gymPackages, IFormFile packagePicture)
        {
            if (ModelState.IsValid)
            {
                try
                {       //LATER EDIT THIS CODE TO UPLOAD TO S3 BUCKET INSTEAD
                    if (packagePicture != null && packagePicture.Length > 0)
                    {
                        var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + packagePicture.FileName;
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await packagePicture.CopyToAsync(fileStream);
                        }

                        // Set the PackagePicturePath property before adding to the database
                        gymPackages.PackagePicturePath = "~/uploads/" + uniqueFileName;
                    }

                    _dbContext.GymPackages.Add(gymPackages);
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
        public async Task<IActionResult> EditPackagePostRequest(GymPackages updatedPackage,string deleteButton)
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

                        //LATER EDIT THIS CODE TO UPLOAD TO S3 BUCKET INSTEAD

                        existingPackage.PackagePicturePath = "coach2.jpg"; // Set to the S3 bucket value

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
                {       //LATER EDIT THIS CODE TO UPLOAD TO S3 BUCKET INSTEAD
                    if (productPicture != null && productPicture.Length > 0)
                    {
                        var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + productPicture.FileName;
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await productPicture.CopyToAsync(fileStream);
                        }

                        // Set the PackagePicturePath property before adding to the database
                        products.ProductPicturePath = "~/uploads/" + uniqueFileName;
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
            return View("ViewProducts", products); // Pass the data to the "EditPackages" view
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
