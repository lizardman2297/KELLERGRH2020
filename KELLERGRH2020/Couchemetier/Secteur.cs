using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KELLERGRH2020
{
    public class Secteur
    {

        private int leCode;
        private string leLibelle;
        private List<Region> lesRegions;

        public Secteur(int unCode, string unLibelle)
        {
            leCode = unCode;
            leLibelle = unLibelle;
            lesRegions = new List<Region>();
        }

        public int Code
        {
            get { return leCode; }
            set
            { leCode = value; }
        }

        public string Libelle
        {
            get { return leLibelle; }
            set
            { leLibelle = value; }
        }

        public List<Region> _Regions
        {
            get { return lesRegions; }
            set
            { lesRegions = value; }
        }
    }
}
