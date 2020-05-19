using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Kupujacy : Uzytkownik
    {
        public Kupujacy(string login, string haslo, string mail) : base(login, haslo, mail)
        {
            
        }
        public bool DodajDoKoszyka(Produkt produkt)
        {
            return true;
        }
        public void ZobaczProdukt(Produkt produkt)
        {

        }
        public void Filtrowanie(int cenaMin, int cenaMax)
        {

        }

    }
}
