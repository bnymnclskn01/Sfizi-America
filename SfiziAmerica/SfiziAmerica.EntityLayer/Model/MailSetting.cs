using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("MailSetting", Schema = "dbo")]
    public class MailSetting : BasicEntity, IEntity
    {
        public string senderMail { get; set; }
        public string senderMailPassword { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string serverMail { get; set; }
        public string serverPort { get; set; }
    }
}
