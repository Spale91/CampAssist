using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampAssist
{
    public class LoginController
    {
        public bool CheckCredentials(string username, string password)
        {
            User user = new User();

            using (CampAssistDBEntities db = new CampAssistDBEntities())
            {
                user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if(user == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
