﻿namespace Panda.HotelBooking.Models
{
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    public class Hotel : Audit
    {
        [Key]
        public string HotelId { get; set; }

        [Required(ErrorMessage = "Require Hotel's Name.")]
        [Display(Name="Hotel Name")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Require Hotel's Address.")]
        public string Address { get; set; }
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Require Phone Number.")]
        public string Phone_1 { get; set; }

        [Display(Name = "Phone")]
        public string Phone_2 { get; set; }

        [Display(Name = "Phone")]
        public string Phone_3 { get; set; }

        [Display(Name = "City Name")]
        [Required(ErrorMessage = "Require City Location.")]
        public string CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }

        [Display(Name = "TownShip Name")]
        [Required(ErrorMessage = "Require Township Location.")]
        public string TownshipId { get; set; }


        [ForeignKey("TownshipId")]
        public Township Township { get; set; }

        public ICollection<Room> Rooms { get; set; }

        [Display(Name = "Photo")]
        public ICollection<HotelPhoto> HotelPhotos { get; set; }

        [Display(Name="Upload Photos")]
        [NotMapped]
        public IFormFileCollection FormFiles { get;set;} = new FormFileCollection();

    }
}
