using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("Slider", Schema = "dbo")]
    public class Slider : BasicEntity, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }
        public string ImageVideoUrl { get; set; }
    }
}
