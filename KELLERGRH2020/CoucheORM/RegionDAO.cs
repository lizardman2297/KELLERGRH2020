using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace KELLERGRH2020
{
    public static class RegionDAO
    {
        private static List<Region> lesRegions;

        public static List<Region> getRegions()
        {
            SqlCommand cmd;
            SqlDataReader jeu;
            lesRegions = new List<Region>();
            Region uneRegion;
            SqlConnection ctn = new SqlConnection(Connexion.getChaine());
            ctn.Open();
            string req = "select * from REGION";
            cmd = new SqlCommand(req, ctn);
            jeu = cmd.ExecuteReader();
            while (jeu.Read())
            {
                uneRegion = new Region(int.Parse(jeu[0].ToString()), jeu[1].ToString());
                lesRegions.Add(uneRegion);
            }
            jeu.Close();
            ctn.Close();
            return lesRegions;
        }
    }
}
