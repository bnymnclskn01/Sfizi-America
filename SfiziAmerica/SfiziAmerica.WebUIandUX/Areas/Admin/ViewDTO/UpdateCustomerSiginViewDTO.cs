﻿using System.ComponentModel.DataAnnotations;
using System;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class UpdateCustomerSiginViewDTO
    {
        [Required]
        public Guid ID { get; set; }

        [Required]
        public string NameSurname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
