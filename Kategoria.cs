using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Kategoria
    {
        private string _nazwaKategorii;
        private string _opisKategorii;

        public bool DodajKategorie(string nazwaKategorii, string opisKategorii)
        {
            _nazwaKategorii = nazwaKategorii;
            _opisKategorii = opisKategorii;
            return true;
        }
        public bool UsunKategorie(Kategoria kategoria)
        {
            return true;
        }

        public List<Kategoria> PobierzListeKategorii()
        {
            return new List<Kategoria>();
        }
    }
}
