using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Administrator : Uzytkownik
    {
        public Administrator(string login, string haslo, string mail) : base(login, haslo, mail)
        {

        }

        public bool UsunUzytkownika(Uzytkownik uzytkownik)
        {
            return true;
        }

        public bool SendMsg(string tresc)
        {
            return true;
        }
    }
}
