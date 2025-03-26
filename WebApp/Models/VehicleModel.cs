using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models  
{
    public class VehicleModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Abrv { get; set; }

        [ForeignKey("VehicleMake")]
        public int MakeId { get; set; }
        public VehicleMake VehicleMake { get; set; }
    }
}
