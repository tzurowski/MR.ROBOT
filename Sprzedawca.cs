using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Sprzedawca : Uzytkownik
    {
        public Sprzedawca(string login, string haslo, string mail) : base(login, haslo, mail)
        {

        }

        public void DodajProdukt(string nazwa, string kategoria, decimal cena, string platforma, string opis, string zdjecie)
        {

        }
        public void UsunProdukt(Produkt produkt)
        {

        }

        public void EdytujProdukt(Produkt produkt)
        {
            
        }
        public void ZmienStatusZamowienia(Zamowienie zamowienie)
        {

        }
    }
}
