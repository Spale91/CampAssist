using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CampAssist
{
    public class RegisterController
    {
        public bool Register(string name, string surname, string username, string password, int roleID)
        {
            User user = new User()
            {
                Name = name,
                Surname = surname,
                Username = username,
                Password = password,
                RoleID = roleID,
            };

            using (CampAssistDBEntities db = new CampAssistDBEntities())
            {
                if (db.Users.Any(u => u.Username == username))
                {
                    return false;
                }
                else
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return true;
                }
            }
        } 
    }
 }
