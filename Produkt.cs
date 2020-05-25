using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    public class Produkt
    {
        public int _produktID { get; set; }
        public string _nazwa { get; set; }
        public int _kategoria { get; set; }
        public decimal _cena { get; set; }
        public string _platforma { get; set; }
        public string _opis { get; set; }
        public string _zdjecie { get; set; }

        public Produkt(string nazwa, int kategoria, decimal cena, string platforma, string opis, string zdjecie)
        {
            _nazwa = nazwa;
            _kategoria = kategoria;
            _cena = cena;
            _platforma = platforma;
            _opis = opis;
            _zdjecie = zdjecie;
        }
        public Produkt()
        {

        }
        
    }
}
