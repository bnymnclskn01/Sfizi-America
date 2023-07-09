using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class AddBookCommentViewDTO
    {
        public IFormFile ImageUrl { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
