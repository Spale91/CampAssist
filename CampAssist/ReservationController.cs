using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampAssist
{
    public class ReservationController
    {
        public float CalculatePrice(Type type, DateTime startDate, DateTime endDate, List<Guest> reservationGuests)
        {
            GuestController guestController = new GuestController();

            float price = 0;
            DateTime checkStartDate = startDate;
            int startYear = checkStartDate.Year;
            int startMonth = checkStartDate.Month;
            int startDay = checkStartDate.Day;

            DateTime checkEndDate = endDate;
            int endDateYear = endDate.Year;
            int endMonth = checkEndDate.Month;
            int endDay = checkEndDate.Day;

            if((startMonth >= 6 && (startMonth <= 8 && startDay <= 30)) || (endMonth >= 6 && (endMonth <= 8 && endDay <= 30)))
            {
                price += (float)type.PriceSeason;
                foreach(Guest guest in reservationGuests)
                {
                    int age = guestController.CalculateAge(guest);
                    if(age <= 4)
                    {
                        price += 0;
                    }
                    else if(age >= 5 && age <= 12)
                    {
                        price += 30;
                    }
                    else
                    {
                        price += 60;
                    }
                }
            }
            else
            {
                price += (float)type.PriceOffSeason;
                foreach (Guest guest in reservationGuests)
                {
                    int age = guestController.CalculateAge(guest);
                    if (age <= 4)
                    {
                        price += 0;
                    }
                    else if (age >= 5 && age <= 12)
                    {
                        price += 20;
                    }
                    else
                    {
                        price += 40;
                    }
                }
            }

            return price;
        }
    }
}
