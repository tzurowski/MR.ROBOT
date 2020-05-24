using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Gosc : Adres
    {
        public Gosc(string login, string haslo, string mail, string ulica, string miejscowosc, string kodPocztowy) : base(login, haslo, mail, ulica, miejscowosc, kodPocztowy)
        {

        }

        public void Logowanie(string login, string haslo)
        {
            Zaloguj(login, haslo);
            status = "aktywny";
        }
        public bool Rejestracja()
        {
            BazaTableAdapters.UzytkownikTableAdapter nowyUzytkownik = new BazaTableAdapters.UzytkownikTableAdapter();
            BazaTableAdapters.AdresTableAdapter nowyAdres = new BazaTableAdapters.AdresTableAdapter();
            nowyAdres.Insert(_ulica, _miejscowosc, _kodPocztowy);
            foreach (Baza.AdresRow row in nowyAdres.GetData().Rows)
            {
                if(row.AdrNazwa.Trim() == _miejscowosc && row.AdrUlica.Trim() == _ulica && row.AdrKodPocztowy.Trim() == _kodPocztowy)
                {
                    nowyUzytkownik.Insert(_mail, _haslo, false, false, row.AdrID, _login);
                }
            }
            return true;
        }
    }
}
