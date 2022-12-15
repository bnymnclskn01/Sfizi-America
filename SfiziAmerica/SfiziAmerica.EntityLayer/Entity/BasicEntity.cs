using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Entity
{
    public class BasicEntity
    {
        public BasicEntity()
        {
            this.ID = Guid.NewGuid();
        }
        [Key]
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime LastDate { get; set; } = DateTime.Now;
    }
}
