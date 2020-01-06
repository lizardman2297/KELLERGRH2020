using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KELLERGRH2020
{
    public class Role
    {
        private int leCode;
        private string leLibelle;

        public Role(int unCode, string unLibelle)
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
