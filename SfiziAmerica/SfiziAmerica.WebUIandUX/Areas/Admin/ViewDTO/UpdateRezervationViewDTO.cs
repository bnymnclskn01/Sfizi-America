using System;
using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class UpdateRezervationViewDTO
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public string NameSurname { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int? Person { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public string TableType { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
