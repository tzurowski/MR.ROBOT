using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Gosc : Uzytkownik
    {
        public Gosc(string login, string haslo, string mail) : base(login, haslo, mail)
        {

        }

        public void Logowanie(string login, string haslo)
        {
            Zaloguj(login, haslo);
            status = "aktywny";
        }
        public bool Rejestracja()
        {

            return true;
        }
    }
}
