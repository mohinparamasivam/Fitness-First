using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Fitness_First.Models
{
    public class GymPackages
    {
        [Key] //primary key for column below
        public int PackageID { get; set; }

        public string PackageName { get; set; }

        public float PackagePrice { get; set; }

        public DateTime TimeSlots { get; set; }

        public string InstructorName { get; set; }

        public string PackagePicturePath { get; set; }

       

    }
}
