using System.ComponentModel.DataAnnotations;
using System;

namespace Fitness_First.Models
{
    public class PackageEnrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        public int MemberName { get; set; }

        public int MemberEmail { get; set; }

        public string PackageName { get; set; }

        public double PackagePrice { get; set; }

        public string InstructorName { get; set; }
        public DateTime EnrolledAt { get; set; }

        public DateTime Session1 { get; set; }
        public DateTime Session2 { get; set; }
        public DateTime Session3 { get; set; }
        public DateTime Session4 { get; set; }
        public DateTime Session5 { get; set; }
        public DateTime Session6 { get; set; }
        public DateTime Session7 { get; set; }
        public DateTime Session8 { get; set; }

       
    }
}
