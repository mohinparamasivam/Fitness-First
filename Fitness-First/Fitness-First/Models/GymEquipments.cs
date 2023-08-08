using System.ComponentModel.DataAnnotations;
using System;


namespace Fitness_First.Models
{
    public class GymEquipments
    {

        [Key]
        public int EquipmentID { get; set; }

        public string EquipmentName { get; set; }

        public int Quantity { get; set; }

        public string Availability { get; set; }

        public string EquipmentPicturePath { get; set; }
    }
}
