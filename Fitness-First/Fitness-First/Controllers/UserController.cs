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

namespace Fitness_First.Controllers
{
    public class UserController : Controller
    {

        //create variable for connection to db
        private readonly Fitness_FirstContext _dbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<UserController> _logger;

        //create constructor for database connection
        public UserController(Fitness_FirstContext dbContext, IWebHostEnvironment webHostEnvironment, ILogger<UserController> logger)
        {
            _dbContext = dbContext;
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
            var package = _dbContext.GymPackages.FirstOrDefault(p => p.PackageID == id);

            if (package == null)
            {
                return NotFound();
            }

            return View("ViewPackageInfo", package);
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
