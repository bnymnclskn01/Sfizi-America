﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class UpdateAboutDTO
    {

        [Required]
        public Guid ID { get; set; }
        [Required]
        public string Title { get; set; }

        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        public IFormFile ImageUrl { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
