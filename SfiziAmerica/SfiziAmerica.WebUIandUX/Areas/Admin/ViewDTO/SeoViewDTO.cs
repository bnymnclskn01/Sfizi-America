using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class SeoViewDTO
    {
        [Required, MaxLength(110)] public string seoTitle { get; set; } //


        [Required, MaxLength(180)] public string seoKeywords { get; set; } //
        [Required, MaxLength(180)] public string seoDescription { get; set; } //

        [MaxLength(70)] public string seoReply { get; set; } // 

        public string seoAuthor { get; set; }
        public string seoCopyright { get; set; }
        public string seoDesign { get; set; }
        public string seoSubject { get; set; }

        [MaxLength(110), Required] public string seoTwitterTitle { get; set; }

        [Required, MaxLength(180)] public string seoTwitterKeywords { get; set; }

        [Required, MaxLength(180)] public string seoTwitterDescription { get; set; }

        [Required, MaxLength(110)] public string seoTwitterUrl { get; set; }


        [Required, MaxLength(110)] public string seoFacebookTitle { get; set; }

        [Required, MaxLength(180)] public string seoFacebookKeywrods { get; set; }

        [Required, MaxLength(180)] public string seoFacebookDescription { get; set; }

        [Required, MaxLength(110)] public string seoFacebookUrl { get; set; }
    }
}
