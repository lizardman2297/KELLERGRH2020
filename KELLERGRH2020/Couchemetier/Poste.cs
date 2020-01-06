using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KELLERGRH2020
{
    public class Poste
    {
        private int lIdCollaborateur;
        private int lIdRole;
        private int lIdRegion;
        private int lIdSecteur;
        private DateTime laDateDebutPoste;
        private DateTime laDateFinPoste;

        public Poste(int unCollaborateur, int unRole, int uneRegion, int unSecteur, DateTime uneDateDebutPoste, DateTime uneDateFinPoste)
        {
            lIdCollaborateur = unCollaborateur;
            lIdRole = unRole;
            lIdRegion = uneRegion;
            lIdSecteur = unSecteur;
            laDateDebutPoste = uneDateDebutPoste;
            laDateFinPoste = uneDateFinPoste;
        }

        public int Collaborateur
        {
            get { return lIdCollaborateur; }
            set
            { lIdCollaborateur = value; }
        }

        public int Role
        {
            get { return lIdRole; }
            set
            { lIdRole = value; }
        }

        public int Region
        {
            get { return lIdRegion; }
            set
            { lIdRegion = value; }
        }

        public int Secteur
        {
            get { return lIdSecteur; }
            set
            { lIdSecteur = value; }
        }

        public DateTime DateDebutPoste
        {
            get { return laDateDebutPoste; }
            set
            { laDateDebutPoste = value; }
        }

        public DateTime DateFinPoste
        {
            get { return laDateFinPoste; }
            set
            { laDateFinPoste = value; }
        }
    }
}
