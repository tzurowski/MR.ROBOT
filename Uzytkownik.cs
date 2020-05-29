using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Uzytkownik
    {
        public string _login { get; set; }
        public string _mail { get; set; }
        public string _haslo { get; set; }
        public bool _isAdmin { get; set; }
        public bool _isSeller { get; set; }
        public int _IDAddress { get; set; }
        public string status = "aktywny";

        public Uzytkownik()
        {

        }

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
