﻿using System.ComponentModel.DataAnnotations;

namespace Project.MVC.ViewModels
{
    public class VehicleModelViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Abbreviation is required.")]
        public string Abrv { get; set; }

        [Required(ErrorMessage = "Make ID is required.")]
        public int MakeId { get; set; }

    }
}
