using Microsoft.EntityFrameworkCore;
using SfiziAmerica.EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.DataAccessLayer.ModelContext
{
    public class SfizilDatabaseModelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=94.73.170.33;Database=u8434080_Sfizi;User ID=u8434080_Sfizi;Password=4muAUi47wFmP7bl;Trusted_Connection=False;");
        }
        public virtual DbSet<About> Abouts { get; set; } // BİTTİ
        public virtual DbSet<ApplicationForm> ApplicationForms { get; set; } //BİTTİ
        public virtual DbSet<BookComment> BookComments { get; set; } //BİTTİ
        public virtual DbSet<CategoryMenu> CategoryMenus { get; set; } //BİTTİ
        public virtual DbSet<Catering> Caterings { get; set; } //BİTTİ
        public virtual DbSet<CateringMenu> CateringMenus { get; set; } //BİTTİ
        public virtual DbSet<ContactForm> ContactForms { get; set; } //BİTTİ
        public virtual DbSet<ContactInformation> ContactInformations { get; set; } // BİTTİ
        public virtual DbSet<CustomerSigin> CustomerSigin { get; set; }//BİTTİ
        public virtual DbSet<Event> Events { get; set; } // BİTTİ
        public virtual DbSet<HR> HR { get; set; } //BİTTİ
        public virtual DbSet<MailSetting> MailSettings { get; set; } // BİTTİ
        public virtual DbSet<Menu> Menus { get; set; } //BİTTİ
        public virtual DbSet<MenuCategory> MenuCategories { get; set; } // BİTTİ
        public virtual DbSet<MenuSeo> MenuSeo { get; set; } //BİTTİ
        public virtual DbSet<Mision> Misions { get; set; } // BİTTİ
        public virtual DbSet<Rezervation> Rezervations { get; set; } // BİTTİ
        public virtual DbSet<Slider> Sliders { get; set; } // BİTTİ
        public virtual DbSet<SocialMedia> SocialMedias { get; set; } //BİTTİ
        public virtual DbSet<UserMember> UserMembers { get; set; } // BİTTİ
        public virtual DbSet<UserRole> UserRoles { get; set; } // BİTTİ
        public virtual DbSet<Vision> Visions { get; set; } // BİTTİ

    }
}
