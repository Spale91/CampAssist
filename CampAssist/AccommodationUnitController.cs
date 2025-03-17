using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CampAssist
{
    public class AccommodationUnitController
    {
        public List<AccommodationUnit> GetAccommodationUnits(Type type)
        {
            using (CampAssistDBEntities db = new CampAssistDBEntities())
            {
                List<AccommodationUnit> accommodationUnits = db.AccommodationUnits.Where(au => au.TypeID == type.TypeID).ToList<AccommodationUnit>();
                return accommodationUnits;
            } 
        }

        public List<AccommodationUnit> GetReservedAccommodationUnits(Type type)
        {
            DateTime currentTime = DateTime.Now;

            using (CampAssistDBEntities db = new CampAssistDBEntities())
            {
                var reservedUnits = db.AccommodationUnits
                                    .Where(au => au.TypeID == type.TypeID && 
                                    db.ReservationDates.Any(rd =>
                                    rd.AccommodationUnitID == au.AccommodationUnitID &&
                                    ((currentTime.Date >= rd.StartDate && currentTime.Date <= rd.EndDate)
                                    ))).ToList();

                return reservedUnits;
            }
        }

        public List<AccommodationUnit> GetFreeAccommodationUnits(Type type)
        {
            DateTime currentTime = DateTime.Now;

            using (CampAssistDBEntities db = new CampAssistDBEntities())
            {
                var reservedUnits = db.AccommodationUnits
                                    .Where(au => au.TypeID == type.TypeID &&
                                    !db.ReservationDates.Any(rd =>
                                    rd.AccommodationUnitID == au.AccommodationUnitID &&
                                    ((currentTime.Date >= rd.StartDate && currentTime.Date <= rd.EndDate)
                                    ))).ToList();

                return reservedUnits;
            }
        }

        public bool AddUnit(string unitName, float priceSeason, float priceOffSeason, int capacity, int typeID)
        {
            AccommodationUnit accommodationUnit = new AccommodationUnit
            {
                Name = unitName,
                PriceSeason = priceSeason,
                PriceOffSeason = priceOffSeason,
                Capacity = capacity,
                TypeID = typeID
            };

            using (CampAssistDBEntities db = new CampAssistDBEntities())
            {
                if (db.AccommodationUnits.Any(au => au.Name == unitName))
                {
                    return false;
                }
                else
                {
                    accommodationUnit.Type = db.Types.Where(t => t.TypeID == typeID).FirstOrDefault();
                    db.AccommodationUnits.Add(accommodationUnit);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public void EditUnit(AccommodationUnit selectedUnit, string unitName, float priceSeason, float priceOffSeason, int capacity, int typeID)
        {
            using (CampAssistDBEntities db = new CampAssistDBEntities())
            {
                db.AccommodationUnits.Attach(selectedUnit);
                selectedUnit.Name = unitName;
                selectedUnit.PriceSeason = priceSeason;
                selectedUnit.PriceOffSeason = priceOffSeason;
                selectedUnit.Capacity = capacity;
                selectedUnit.TypeID = typeID;
                selectedUnit.Type = db.Types.Where(t => t.TypeID == typeID).FirstOrDefault();
                db.SaveChanges();
            }
        }

        public void DeleteUnit(AccommodationUnit accommodationUnit)
        {
            using (CampAssistDBEntities db = new CampAssistDBEntities())
            {
                db.AccommodationUnits.Attach(accommodationUnit);
                db.AccommodationUnits.Remove(accommodationUnit);
                db.SaveChanges();
            }
        }

        public List<AccommodationUnit> CboIndexChange(Type type)
        {
            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                List<AccommodationUnit> accommodationUnits = db.AccommodationUnits.Where(au => au.TypeID == type.TypeID).ToList<AccommodationUnit>();
                return accommodationUnits;
            }
        }

        public List<AccommodationUnit> CboIndexChangeOnReservation(Type type, DateTime startDate, DateTime endDate)
        {
                using (CampAssistDBEntities db = new CampAssistDBEntities())
                {
                    var availableUnits = db.AccommodationUnits
                        .Where(au => au.TypeID == type.TypeID &&
                                     !db.ReservationDates.Any(rd =>
                                         rd.AccommodationUnitID == au.AccommodationUnitID &&
                                         ((startDate >= rd.StartDate && startDate <= rd.EndDate) ||
                                          (endDate >= rd.StartDate && endDate <= rd.EndDate))
                                     ))
                        .ToList();

                    return availableUnits;
                }
        }
    }
}
