using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebApp.Models  
{
    public class VehicleMake
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } 

        [Required, MaxLength(10)]
        public string Abrv { get; set; } 

        public ICollection<VehicleModel> VehicleModels { get; set; } = new List<VehicleModel>();
    }
}
