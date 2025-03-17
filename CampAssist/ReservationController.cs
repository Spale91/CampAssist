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

            float days;
            TimeSpan difference = endDate - startDate;
            days = (int)difference.TotalDays + 1;

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
                if(type.TypeName != "Mobilna Kućica")
                {
                    foreach (Guest guest in reservationGuests)
                    {
                        float guestPrice = 0;
                        int age = guestController.CalculateAge(guest);
                        if (age <= 4)
                        {
                            guestPrice += 0;
                        }
                        else if (age >= 5 && age <= 12)
                        {
                            guestPrice += 30;
                        }
                        else
                        {
                            guestPrice += 60;
                        }
                        if(guest.OldGuest == true)
                        {
                            guestPrice = (float)(guestPrice - (guestPrice*0.05));
                        }
                        price += guestPrice;
                    }
                }
            }
            else
            {
                price += (float)type.PriceOffSeason;
                if(type.TypeName != "Mobilna Kućica")
                {
                    foreach (Guest guest in reservationGuests)
                    {
                        float guestPrice = 0;
                        int age = guestController.CalculateAge(guest);
                        if (age <= 4)
                        {
                            guestPrice += 0;
                        }
                        else if (age >= 5 && age <= 12)
                        {
                            guestPrice += 20;
                        }
                        else
                        {
                            guestPrice += 40;
                        }
                        if (guest.OldGuest == true)
                        {
                            guestPrice = (float)(guestPrice - (guestPrice * 0.05));
                        }
                        price += guestPrice;
                    }
                }
            }
            price = price * days;
            return price;
        }

        public Reservation AddReservation(Type type, AccommodationUnit accommodationUnit, float price, DateTime startDate, DateTime endDate)
        {
            Reservation reservation = new Reservation
            {
                TypeID = type.TypeID,
                AccommodationUnitID = accommodationUnit.AccommodationUnitID,
                Price = price,
                StartDate = startDate,
                EndDate = endDate,
            };

            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                db.Reservations.Add(reservation);
                db.SaveChanges();
            }
            return reservation;
        }

        public void AddReservationDate(Reservation reservation, AccommodationUnit accommodationUnit, List<Guest> guests)
        {
            ReservationDate reservationDate = new ReservationDate
            {
                StartDate = reservation.StartDate,
                EndDate = reservation.EndDate,
                AccommodationUnitID = accommodationUnit.AccommodationUnitID,
                ReservationID = reservation.ReservationID,
            };

            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                db.ReservationDates.Add(reservationDate);
                db.SaveChanges();
            }
        }

        public void AddAccommodationUnitGuest(AccommodationUnit unit, List<Guest> guests)
        {
            foreach(Guest guest in guests)
            {
                AccommodationUnitGuest accommodationUnitGuest = new AccommodationUnitGuest
                {
                    AccommodationUnitID = unit.AccommodationUnitID,
                    GuestID = guest.GuestID,
                };
                using (CampAssistDBEntities db = new CampAssistDBEntities())
                {
                    db.AccommodationUnitGuests.Add(accommodationUnitGuest);
                    db.SaveChanges();
                }
            }
        }

        public void AddReservationGuest(Reservation reservation, List<Guest> guests)
        {
            foreach (Guest guest in guests)
            {
                ReservationGuest reservationGuest = new ReservationGuest
                {
                    ReservationID = reservation.ReservationID,
                    GuestID = guest.GuestID,
                };
                using (CampAssistDBEntities db = new CampAssistDBEntities())
                {
                    db.ReservationGuests.Add(reservationGuest);
                    db.SaveChanges();
                }
            }
        }

        public void changeOldGuest(Reservation reservation)
        {
            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                List<ReservationGuest> reservationGuests = db.ReservationGuests.Where(rg => rg.ReservationID == reservation.ReservationID).ToList<ReservationGuest>();

                foreach (ReservationGuest reservationGuest in reservationGuests)
                {
                    reservationGuest.Guest.OldGuest = true;
                    db.SaveChanges();
                }
            }
        }

        public bool CheckDates(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public float GetAverageGuestNumber()
        {
            float totalGuests = 0;
            float totalReservations = 0;
            float averageGuestNumber = 0;

            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                List<Reservation> reservations = db.Reservations.ToList<Reservation>();
                foreach (Reservation reservation in reservations)
                {
                    totalGuests += reservation.ReservationGuests.Count();
                    totalReservations += 1;
                }
            }
            averageGuestNumber = (float)(totalGuests / totalReservations);
            return averageGuestNumber;
        }

        public float GetYearlyIncome()
        {
            DateTime dateTime = DateTime.Now;
            int currentYear = dateTime.Year;
            DateTime yearBegin = new DateTime(currentYear, 1, 1);
            DateTime yearEnd = new DateTime(currentYear, 12, 31);

            float yearlyIncome = 0;

            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                List<Reservation> yearlyReservations = db.Reservations.Where(r => r.StartDate >= yearBegin || r.StartDate <= yearEnd).ToList<Reservation>();
                
                foreach(Reservation yearlyReservation in yearlyReservations)
                {
                    yearlyIncome += (float)yearlyReservation.Price;
                }
                return yearlyIncome;
            }
        }
    }
}
