﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KELLERGRH2020
{
    public static class ListeSecteurs
    {
        private static List<Secteur> lesSecteurs;

        public static List<Secteur> getSecteurs()
        {
            if (lesSecteurs == null)
            {
                lesSecteurs = SecteurDAO.getSecteurs();
            }
            return lesSecteurs;
        }

        public static Secteur getSecteurByCode(int unCode)
        {
            return lesSecteurs.FirstOrDefault(s => s.Code == unCode);
        }

        public static Secteur getSecteurByLibelle(string unLibelle)
        {
            return lesSecteurs.FirstOrDefault(s => s.Libelle == unLibelle);
        }
    }
}
// while !jeu.read() {
// idCollab courant = jeu(n) 
//while idCollabcourant = jeu(n)