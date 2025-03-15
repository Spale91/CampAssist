using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampAssist
{
    public class TypeController
    {
        public List<Type> GetTypes()
        {
            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                List<Type> types = db.Types.ToList();
                return types;
            }
        }

        public bool AddType(string typeName, float priceSeason, float priceOffSeason, int capacity)
        {
            Type type = new Type
            {
                TypeName = typeName,
                PriceSeason = priceSeason,
                PriceOffSeason = priceOffSeason,
                Capacity = capacity
            };

            using (CampAssistDBEntities db = new CampAssistDBEntities())
            {
                if(db.Types.Any(t => t.TypeName == typeName))
                {
                    return false;
                }
                else
                {
                    db.Types.Add(type);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public void EditType(Type selectedType, string typeName, float priceSeason, float priceOffSeason, int capacity)
        {
            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                db.Types.Attach(selectedType);
                selectedType.TypeName = typeName;
                selectedType.PriceSeason = priceSeason;
                selectedType.PriceOffSeason = priceOffSeason;
                selectedType.Capacity = capacity;
                db.SaveChanges();


                List<AccommodationUnit> accommodationUnits = db.AccommodationUnits.Where(au => au.TypeID == selectedType.TypeID).ToList<AccommodationUnit>();

                foreach (AccommodationUnit accommodationUnit in accommodationUnits)
                {
                    db.AccommodationUnits.Attach(accommodationUnit);
                    accommodationUnit.PriceSeason = priceSeason;
                    accommodationUnit.PriceOffSeason = priceOffSeason;
                    accommodationUnit.Capacity = capacity;
                    accommodationUnit.TypeID = selectedType.TypeID;
                }
                db.SaveChanges();
            }
        }

        public void DeleteType(Type selectedType)
        {
            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                List<AccommodationUnit> accommodationUnits = db.AccommodationUnits.Where(au => au.TypeID == selectedType.TypeID).ToList<AccommodationUnit>();
                foreach (AccommodationUnit accommodationUnit in accommodationUnits)
                {
                    db.AccommodationUnits.Attach(accommodationUnit);
                    db.AccommodationUnits.Remove(accommodationUnit);
                    db.SaveChanges();
                }


                db.Types.Attach(selectedType);
                db.Types.Remove(selectedType);
                db.SaveChanges();
            }
        }

        public List<Type> SearchType(string search)
        {
            using(CampAssistDBEntities db = new CampAssistDBEntities())
            {
                List<Type> searchResult = db.Types.Where(t  => t.TypeName.Contains(search)).ToList<Type>();
                return searchResult;
            }
        }
    }
}
