using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Zamowienie
    {
        public List<Produkt> listaProduktow = new List<Produkt>();

        public DateTime dataZamowienia;
        public decimal kwota;
        public string status;

        

    }
}
