using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampAssist
{
    public class GuestController
    {
        public static List<Guest> tempReservationGuests = new List<Guest>();
        public bool AddGuest(string name, string surname, DateTime birthDate, int OIB)
        {
            Guest guest = new Guest()
            {
                Name = name,
                Surname = surname,
                BirthDate = birthDate,
                OIB = OIB,
                OldGuest = false
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
                    AddGuestToReservation(guest);
                    return true;
                }
            }
        }

        public void AddGuestToReservation(Guest selectedGuest)
        {
            tempReservationGuests.Add(new Guest
            {
                GuestID = selectedGuest.GuestID,
                Name = selectedGuest.Name,
                Surname= selectedGuest.Surname,
                BirthDate = selectedGuest.BirthDate,
                OIB = selectedGuest.OIB,
                OldGuest = selectedGuest.OldGuest
            });
        }

        public List<Guest> GetGuestList()
        {
            return tempReservationGuests.ToList();
        }

        public void RemoveGuest(Guest selectedGuest)
        {
            tempReservationGuests.Remove(selectedGuest);
            if(selectedGuest.OldGuest == false)
            {
                using(CampAssistDBEntities db = new CampAssistDBEntities())
                {
                    db.Guests.Attach(selectedGuest);
                    db.Guests.Remove(selectedGuest);
                    db.SaveChanges();
                }
            }
        }

        public List<Guest> GetOldGuests()
        {
            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                List<Guest> oldGuests = db.Guests.ToList<Guest>();
                return oldGuests;
            }
        }

        public Guest GetGuest(Guest selectedGuest)
        {
            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                Guest guest = db.Guests.FirstOrDefault(g => g.GuestID == selectedGuest.GuestID);
                return guest;
            }
        }
    }
}
