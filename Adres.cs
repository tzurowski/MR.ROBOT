using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Adres : Uzytkownik
    {
        public string _ulica;
        public string _miejscowosc;
        public string _kodPocztowy;
        public Adres(string login, string haslo, string mail, string ulica, string miejscowosc, string kodPocztowy) : base(login, haslo, mail)
        {
            _ulica = ulica;
            _miejscowosc = miejscowosc;
            _kodPocztowy = kodPocztowy;
        }
    }
}
