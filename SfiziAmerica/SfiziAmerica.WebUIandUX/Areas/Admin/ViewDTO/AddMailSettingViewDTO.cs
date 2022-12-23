using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class AddMailSettingViewDTO
    {
        [Required]
        public string senderMail { get; set; }
        [Required]
        public string senderMailPassword { get; set; }
        [Required]
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        [Required]
        public string serverMail { get; set; }
        [Required]
        public string serverPort { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
