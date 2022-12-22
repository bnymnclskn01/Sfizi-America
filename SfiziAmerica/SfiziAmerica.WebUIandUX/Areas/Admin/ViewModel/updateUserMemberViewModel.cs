using SfiziAmerica.EntityLayer.Model;
using System.Collections;
using System.Collections.Generic;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel
{
    public class updateUserMemberViewModel
    {
        public IList<UserRole> UserRoles { get; set; }
        public UserMember UserMember { get; set; }
    }
}
