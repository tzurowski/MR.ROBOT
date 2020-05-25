using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Produkt
    {
        public int _produktID;
        public string _nazwa;
        public int _kategoria;
        public decimal _cena;
        public string _platforma;
        public string _opis;
        public string _zdjecie;

        public Produkt(string nazwa, int kategoria, decimal cena, string platforma, string opis, string zdjecie)
        {
            _nazwa = nazwa;
            _kategoria = kategoria;
            _cena = cena;
            _platforma = platforma;
            _opis = opis;
            _zdjecie = zdjecie;
        }
    }
}
