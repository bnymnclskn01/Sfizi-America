using Microsoft.EntityFrameworkCore;
using SfiziAmerica.EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.BusinessLayer.Repository.Concrete
{
    public class UnitOfWork
    {
        readonly DbContext _context;
        public EntityRepositoryBase<About> aboutRepository { get; set; }
        public EntityRepositoryBase<ApplicationForm> applicationFormRepository { get; set; }
        public EntityRepositoryBase<BookComment> bookCommentRepository { get; set; }
        public EntityRepositoryBase<CategoryMenu> categoryMenuRepository { get; set; }
        public EntityRepositoryBase<Catering> cateringRepository { get; set; }
        public EntityRepositoryBase<CateringMenu> cateringMenuRepository { get; set; }
        public EntityRepositoryBase<ContactForm> contactFormRepository { get; set; }
        public EntityRepositoryBase<ContactInformation> contactInformationRepository { get; set; }
        public EntityRepositoryBase<CustomerSigin> customerSiginRepository { get; set; }
        public EntityRepositoryBase<Event> eventRepository { get; set; }
        public EntityRepositoryBase<HR> hrRepository { get; set; }
        public EntityRepositoryBase<MailSetting> mailSettingRepository { get; set; }
        public EntityRepositoryBase<Menu> menuRepository { get; set; }
        public EntityRepositoryBase<MenuCategory> menuCategoryRepository { get; set; }
        public EntityRepositoryBase<MenuSeo> menuSeoRepository { get; set; }
        public EntityRepositoryBase<Mision> missionRepository { get; set; }
        public EntityRepositoryBase<Rezervation> rezervationRepository { get; set; }
        public EntityRepositoryBase<Slider> sliderRepository { get; set; }
        public EntityRepositoryBase<SocialMedia> socialMediaRepository { get; set; }
        public EntityRepositoryBase<UserMember> userMemberRepository { get; set; }
        public EntityRepositoryBase<UserRole> userRoleRepository { get; set; }
        public EntityRepositoryBase<Vision> visionRepository { get; set; }

        public UnitOfWork(DbContext context)
        {
            _context = context;
            aboutRepository = new(context);
            applicationFormRepository = new(context);
            bookCommentRepository = new(context);
            categoryMenuRepository = new(context);
            cateringRepository = new(context);
            cateringMenuRepository = new(context);
            contactFormRepository = new(context);
            contactInformationRepository = new(context);
            customerSiginRepository = new(context);
            eventRepository = new(context);
            hrRepository = new(context);
            mailSettingRepository = new(context);
            menuRepository = new(context);
            menuCategoryRepository = new(context);
            menuSeoRepository = new(context);
            missionRepository = new(context);
            rezervationRepository = new(context);
            sliderRepository = new(context);
            socialMediaRepository = new(context);
            userMemberRepository = new(context);
            userRoleRepository = new(context);
            visionRepository = new(context);
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
