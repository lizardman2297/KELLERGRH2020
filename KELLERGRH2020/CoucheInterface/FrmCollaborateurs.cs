using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KELLERGRH2020
{
    public partial class FrmCollaborateurs : Form
    {
        

        public FrmCollaborateurs()
        {
            InitializeComponent();

            // TODO    :       Affichage de l'arborescence présentant les secteurs, les régions et les collaborateurs en poste
           
        }

        private void ConstructionTreeview()
        {
            TreeNode n;
            TreeNode racine;

            // TODO : Requete LINQ pour obtenir les secteurs
            

            racine = tvOrganisation.Nodes.Add("KELLER THOMANN & TASSET - Gestion des ressources humaines");

            foreach (Secteur s in req.ToList())
            {
                n = racine.Nodes.Add(s.Libelle);
                n.Nodes.Add("-");   // noeud fictif
            }
        }

        private void tvOrganisation_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode n = (TreeNode)e.Node;
            TreeNode parent = (TreeNode) n.Parent;
            TreeNode enfant;
  
            char[] delimiterChars = {'\\'};

            // TO DO éclater le fullpath
           // string[] words = ...
   
            if (words.Length == 2)
            {
                // traitement secteur
                n.Nodes[0].Remove();
                Secteur s = ListeSecteurs.getSecteurByLibelle(n.Text);

   

                
            }
            else
            {
                if (words.Length == 3)
                {
                    // traitement région


                    Region r = // TODO

                    var req =  // TODO

                    // suppression du noeud fictif

                    if (req.ToList().Count > 0)
                    {
                        n.Nodes[0].Remove();
                    }



                }

                }
        }

       
    }
}
