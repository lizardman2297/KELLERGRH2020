using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace KELLERGRH2020
{
    public static class SecteurDAO
    {
        private static List<Secteur> lesSecteurs;

        public static List<Secteur> getSecteurs()
        {
            if (lesSecteurs == null)
            {

                SqlCommand cmd;
                SqlDataReader jeu;
                lesSecteurs = new List<Secteur>();
                Secteur unSecteur;
                SqlConnection ctn = new SqlConnection(Connexion.getChaine());
                ctn.Open();
                string req = "select * from SECTEUR";
                cmd = new SqlCommand(req, ctn);
                jeu = cmd.ExecuteReader();
                while (jeu.Read())
                {
                    unSecteur = new Secteur(int.Parse(jeu[0].ToString()), jeu[1].ToString());
                    lesSecteurs.Add(unSecteur);
                }
                jeu.Close();
                foreach (Secteur s in lesSecteurs)
                {
                    string req2 = "select * from REGION where codeSecteur = '" + s.Code + "'";
                    cmd = new SqlCommand(req2, ctn);
                    jeu = cmd.ExecuteReader();
                    while (jeu.Read())
                    {
                        Region uneRegion = new Region(int.Parse(jeu[0].ToString()), jeu[1].ToString());
                        s._Regions.Add(uneRegion);
                    }
                    jeu.Close();
                }
                ctn.Close();
            }
            return lesSecteurs;
        }
    }
}
