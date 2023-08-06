using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fitness_First.Models
{
    public class GymPackage
    {
        [Key]
        public int PackageID { get; set; }

        public string PackageName { get; set; }

        public float PackagePrice { get; set; }

        public DateTime TimeSlots { get; set; }

        public string InstructorName { get; set; }

        public string PackagePicturePath { get; set; }
    }
}
