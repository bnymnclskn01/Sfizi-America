using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("SocialMedia", Schema = "dbo")]
    public class SocialMedia : BasicEntity, IEntity
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
