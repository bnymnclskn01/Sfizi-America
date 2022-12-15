using Microsoft.EntityFrameworkCore;
using SfiziAmerica.EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.DataAccessLayer.ModelContext
{
    public class CanadaSchoolDatabaseModelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<ApplicationForm> ApplicationForms { get; set; }
        public virtual DbSet<BookComment> BookComments { get; set; }
        public virtual DbSet<CategoryMenu> CategoryMenus { get; set; }
        public virtual DbSet<Catering> Caterings { get; set; }
        public virtual DbSet<CateringMenu> CateringMenus { get; set; }
        public virtual DbSet<ContactForm> ContactForms { get; set; }
        public virtual DbSet<ContactInformation> ContactInformations { get; set; }
        public virtual DbSet<CustomerSigin> CustomerSigin { get; set; }
        public virtual DbSet<HR> HR { get; set; }
        public virtual DbSet<MailSetting> MailSettings { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuCategory> MenuCategories { get; set; }
        public virtual DbSet<MenuSeo> MenuSeo { get; set; }
        public virtual DbSet<Mision> Misions { get; set; }
        public virtual DbSet<Rezervation> Rezervations { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<SocialMedia> SocialMedias { get; set; }
        public virtual DbSet<UserMember> UserMembers { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Vision> Visions { get; set; }

    }
}
