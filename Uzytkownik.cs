using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Uzytkownik
    {
        public string _login;
        public string _mail;
        public string _haslo;
        public bool _isAdmin;
        public bool _isSeller;
        public int _IDAddress;
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
