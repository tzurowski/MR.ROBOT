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
        public Sprzedawca()
        {

        }

        public void DodajProdukt(string nazwa, int kategoria, decimal cena, string platforma, string opis, string zdjecie)
        {
            BazaTableAdapters.ProduktTableAdapter nowyProdukt = new BazaTableAdapters.ProduktTableAdapter();
            nowyProdukt.Insert(nazwa, cena, platforma, opis, zdjecie, kategoria);
        }
        public void UsunProdukt(Produkt produkt)
        {
            BazaTableAdapters.ProduktTableAdapter produktDoUsuniecia = new BazaTableAdapters.ProduktTableAdapter();
            produktDoUsuniecia.Delete(produkt._produktID, produkt._nazwa, produkt._cena, produkt._platforma, produkt._opis, produkt._zdjecie, produkt._kategoria);
        }

        public void EdytujProdukt(Produkt produkt, string nazwa, decimal cena, string platforma, string opis, string zdjecie, int kategoria)
        {
            BazaTableAdapters.ProduktTableAdapter edytujProdukt = new BazaTableAdapters.ProduktTableAdapter();
            edytujProdukt.Update(nazwa, cena, platforma, opis, zdjecie, kategoria, produkt._produktID, produkt._nazwa, produkt._cena, produkt._platforma, produkt._opis, produkt._zdjecie, produkt._kategoria);
        }
        public void ZmienStatusZamowienia(Zamowienie zamowienie)
        {

        }
    }
}
