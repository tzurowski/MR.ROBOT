using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Uzytkownik
    {
        public string _login { get => _login; private set { } }
        private string _mail;
        private string _haslo;
        public string status = "aktywny";

        public Uzytkownik(string login, string haslo, string mail)
        {
            _login = login;
            _mail = mail;
            _haslo = haslo;
        }
        public string PobierzStatus(string login)
        {
            return "";
        }
        public void Zaloguj(string login, string haslo)
        {

        }
        public void Wyloguj(string login)
        {

        }
    }
}
