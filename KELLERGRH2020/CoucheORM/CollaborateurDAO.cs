using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;  // pour connection state
using System.Windows.Forms;

namespace KELLERGRH2020
{
    public static class CollaborateurDAO
    {
        public static List<Collaborateur> getCollaborateurs()
        {
            List<Collaborateur> lesCollaborateurs = new List<Collaborateur>();
            List<Poste> lesPostes = new List<Poste>();
            List<Role> lesRoles = RoleDAO.getRoles();
            List<Secteur> lesSecteurs = SecteurDAO.getSecteurs();
            List<Region> lesRegions = RegionDAO.getRegions();
            Collaborateur unCollaborateur;
            SqlConnection ctn = new SqlConnection(Connexion.getChaine());
            ctn.Open();
            string req = "SELECT * FROM COLLABORATEUR";
            SqlCommand cmd = new SqlCommand(req, ctn);
            SqlDataReader jeu = cmd.ExecuteReader();
            while (jeu.Read())
            {
                unCollaborateur = new Collaborateur(Convert.ToInt16(jeu[0].ToString()), jeu[1].ToString(), jeu[2].ToString(), jeu[3].ToString(), jeu[4].ToString(), jeu[5].ToString(), DateTime.Parse(jeu[6].ToString()));
                lesCollaborateurs.Add(unCollaborateur);
            }
            jeu.Close();
            // TODO : Ajouter les postes à l'objet unCollaborateur
            string req2 = "select * from poste order by idCollaborateur asc, dateDebut asc";
            cmd = new SqlCommand(req2, ctn);
            jeu = cmd.ExecuteReader();
            bool continuer = jeu.Read();
            while (continuer)
            {
                Collaborateur unCollab = lesCollaborateurs.FirstOrDefault(c => c.Id == Convert.ToInt16(jeu[4].ToString()));
                while (continuer && unCollab.Id == Convert.ToByte(jeu[4]))
                {
                    unCollab._Postes.Add(new Poste(Convert.ToInt16(jeu[1].ToString()), Convert.ToInt16(jeu[4].ToString()), Convert.ToInt16(jeu[2].ToString()), Convert.ToInt16(jeu[3].ToString()), DateTime.Parse(jeu[5].ToString()), DateTime.Parse(jeu[0].ToString())));
                    continuer = jeu.Read();
                }

            }
            ctn.Close();
            return lesCollaborateurs;
        }
    }
}
