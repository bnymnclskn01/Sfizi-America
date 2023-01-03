using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class updateBookCommentViewDTO
    {
        [Required]
        public Guid ID { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
