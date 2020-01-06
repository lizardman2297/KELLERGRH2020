using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KELLERGRH2020
{
    public static class ListeRegion
    {
        private static List<Region> lesRegions;

        public static List<Region> getRegions()
        {
            if (lesRegions == null)
            {
                lesRegions = RegionDAO.getRegions();
            }
            return lesRegions;
        }

        public static Region getRegionByLibelle(string unLibelle)
        {
            return lesRegions.FirstOrDefault(r => r.Libelle == unLibelle);
        }

        public static Region getRegionByCode(int unCode)
        {
            return lesRegions.FirstOrDefault(r => r.Code == unCode);
        }
    }
}
