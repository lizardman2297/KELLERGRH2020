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
                // List<Role> lesRoles = ...
                List<Secteur> lesSecteurs = SecteurDAO.getSecteurs();
               // List<Region> lesRegions = ...
                

                Collaborateur unCollaborateur;
                
                SqlConnection ctn = new SqlConnection(Connexion.getChaine());
                ctn.Open();
                string req = "select * from COLLABORATEUR";

                SqlCommand cmd = new SqlCommand(req, ctn);
                SqlDataReader jeu = cmd.ExecuteReader();
                while (jeu.Read())
                {
                    //unCollaborateur = new Collaborateur(jeu[0].ToString(), jeu[...].ToString(), jeu[...].ToString(),.., DateTime.Parse(jeu[...].ToString()));
                    //lesCollaborateurs.Add(unCollaborateur);
                }
                jeu.Close();

                // TODO : Ajouter les postes à l'objet unCollaborateur

                

            
            ctn.Close();
            return lesCollaborateurs;
        }

       
        
 
    }
}
