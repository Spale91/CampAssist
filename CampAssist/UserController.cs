using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampAssist
{
    public class UserController
    {
        public List<User> GetUsers()
        {
            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                List<User> users = db.Users.ToList<User>();
                return users;
            }
        }
    }
}
