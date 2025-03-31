using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Service.Models
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
