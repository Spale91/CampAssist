using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampAssist
{
    public class TypeController
    {
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
    }
}
