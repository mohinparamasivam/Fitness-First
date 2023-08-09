using Fitness_First.Data;
using Fitness_First.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Fitness_First.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;



namespace Fitness_First.Controllers
{
    public class UserController : Controller
    {

        //create variable for connection to db
        private readonly Fitness_FirstContext _dbContext;
        private readonly UserManager<Fitness_FirstUser> _userManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<UserController> _logger;

        //create constructor for database connection
        public UserController(Fitness_FirstContext dbContext, UserManager<Fitness_FirstUser> userManager,IWebHostEnvironment webHostEnvironment, ILogger<UserController> logger)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }


        public IActionResult Index()
            {
                return View();
            }

            public IActionResult ViewPackages()
            {
                var packages = _dbContext.GymPackages.ToList(); // Retrieve the data from the database
                return View("ViewPackages", packages); // Pass the data to the "ViewPackageInfo" view
            }



        // Add a new action to handle viewing a package
        [HttpGet]
        public IActionResult ViewPackageInfo(int id)
        {
            try
            {
                var package = _dbContext.GymPackages.FirstOrDefault(p => p.PackageID == id);

                if (package == null)
                {
                    return NotFound();
                }

                var existingEnrollments = _dbContext.PackageEnrollments
         .Where(e => e.MemberEmail == User.Identity.Name)
         .ToList();

                ViewData["ExistingEnrollments"] = existingEnrollments;

                return View("ViewPackageInfo", package);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving package information.");
                return RedirectToAction("Error"); // Handle the error appropriately in your "Error" action
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnrollPackage(int packageId)
        {
            var user = await _userManager.GetUserAsync(User);

            var package = _dbContext.GymPackages.FirstOrDefault(p => p.PackageID == packageId);

           

            var enrollment = new PackageEnrollment // Use "new" to create a new instance of PackageEnrollment
            {
                MemberName = user.MemberName,
                MemberEmail = user.Email,
                PackageName = package.PackageName,
                PackagePrice = package.PackagePrice,
                InstructorName = package.InstructorName,
                PackagePicturePath = package.PackagePicturePath,
                Session1 = package.Session1,
                Session2 = package.Session2,
                Session3 = package.Session3,
                Session4 = package.Session4,
                Session5 = package.Session5,
                Session6 = package.Session6,
                Session7 = package.Session7,
                Session8 = package.Session8,
                EnrolledAt = DateTime.Now
            };

            _dbContext.PackageEnrollments.Add(enrollment); // Use PackageEnrollments to access the table
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("ViewPackagesEnrolled"); // Change to your desired action and controller
        }

       

        public IActionResult ViewPackagesEnrolled()
        {
            var packages = _dbContext.PackageEnrollments.ToList(); // Retrieve the data from the database
            return View("ViewPackagesEnrolled", packages); // Pass the data to the "ViewPackageInfo" view
        }

        public IActionResult ViewEnrollmentInfo(int id)
        {
            var enrollment = _dbContext.PackageEnrollments.FirstOrDefault(e => e.EnrollmentID == id);

            if (enrollment == null)
            {
                return NotFound();
            }

            return View(enrollment);
        }

        [HttpPost]
        public IActionResult RemoveEnrollment(int id)
        {
            var enrollment = _dbContext.PackageEnrollments.Find(id);

            if (enrollment == null)
            {
                return NotFound();
            }

            _dbContext.PackageEnrollments.Remove(enrollment);
            _dbContext.SaveChanges();

            return RedirectToAction("ViewPackagesEnrolled"); // Redirect back to the list of enrolled packages
        }

        public IActionResult ViewProducts()
        {
            var packages = _dbContext.Products.ToList(); // Retrieve the data from the database
            return View("ViewProducts", packages); // Pass the data to the "ViewPackageInfo" view
        }


        public IActionResult ViewProductInfo(int id)
        {
            var product = _dbContext.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            return View("ViewProductInfo",product);
        }

        [HttpPost]
        public IActionResult PurchaseProduct(int productId)
        {
            // Retrieve the product from the database
            var product = _dbContext.Products.Find(productId);

            if (product == null)
            {
                return NotFound();
            }


            // Get the current user's email
            string userEmail = User.Identity.Name;

            // Create a new ProductPurchase instance
            var purchase = new ProductPurchase
            {
                ProductName = product.ProductName,
                ProductType = product.ProductType,
                ProductPrice = product.ProductPrice,
                PurchasedBy = userEmail
            };

            // Add the purchase to the database
            _dbContext.ProductPurchases.Add(purchase);
            _dbContext.SaveChanges();

            return RedirectToAction("PurchaseSummary", "User"); // Redirect to a relevant page
        }

        public IActionResult PurchaseSummary()
        {
            return View();
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
