using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Fitness_First.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Fitness_FirstUser class
    public class Fitness_FirstUser : IdentityUser
    {
        public int AdminCount { get; set; } // Add this property
    }
}
