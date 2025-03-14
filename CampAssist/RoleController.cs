using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampAssist
{
    public class RoleController
    {
        public List<Role> GetRoles()
        {
            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                List<Role> roles = db.Roles.ToList<Role>();
                return roles;
            }
        }
    }
}
