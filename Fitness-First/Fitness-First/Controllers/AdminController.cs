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
                        gymPackages.PackagePicturePath = "/uploads/" + uniqueFileName;
                    }

                    _dbContext.GymPackages.Add(gymPackages);
                    await _dbContext.SaveChangesAsync();
                    return RedirectToAction("Index");
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
