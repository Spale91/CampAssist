using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampAssist
{
    public class GuestController
    {
        public bool AddGuest(string name, string surname, DateTime birthDate, int OIB)
        {
            Guest guest = new Guest()
            {
                Name = name,
                Surname = surname,
                BirthDate = birthDate,
                OIB = OIB
            };

            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                if(db.Guests.Any(g => g.OIB == OIB))
                {
                    return false;
                }
                else
                {
                    db.Guests.Add(guest);
                    db.SaveChanges();
                    return true;
                }
            }
        }

    }
}
