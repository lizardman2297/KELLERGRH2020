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

            ConstructionTreeview();

        }

        private void ConstructionTreeview()
        {
            TreeNode n;
            TreeNode racine;
            TreeNode second;
            TreeNode troisieme;
            Poste p;
            // TODO : Requete LINQ pour obtenir les secteurs
            var req = from secteur in ListeSecteurs.getSecteurs()
                      select secteur;
            var req2 = from collab in ListeCollaborateurs.getLesCollaborateurs()
                       select collab;

            racine = tvOrganisation.Nodes.Add("KELLER THOMANN & TASSET - Gestion des ressources humaines");
            foreach (Secteur s in req.ToList())
            {
                n = racine.Nodes.Add(s.Libelle);
                second = n;
                foreach (Region r in s._Regions)
                {
                    n = second.Nodes.Add(r.Libelle);
                    troisieme = n;
                    foreach (Collaborateur c in ListeCollaborateurs.getLesCollaborateurs())
                    {
                        if (c._Postes.Count() > 0)
                        {
                            p = c._Postes.Last();
                            if (p.Region == r.Code)
                            {
                                n = troisieme.Nodes.Add(c.Prenom + " " + c.Nom);

                            }
                        }
                    }
                }
            }
            racine.Nodes[0].Remove();
        }

        private void tvOrganisation_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode n = (TreeNode)e.Node;
            TreeNode parent = (TreeNode)n.Parent;
            TreeNode enfant;
            char[] delimiterChars = { '\\' };
            // TO DO éclater le fullpath
            string[] words = n.FullPath.Split(delimiterChars);
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
                    Region r = ListeRegion.getRegionByLibelle(n.Text);
                    var req = from region in ListeRegion.getRegions()
                              select region;
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
