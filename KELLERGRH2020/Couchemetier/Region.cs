using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KELLERGRH2020
{
    public class Region
    {

        private int leCode;
        private string leLibelle;


        public Region(int unCode, string unLibelle)
        {
            leCode = unCode;
            leLibelle = unLibelle;

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

    }
}
