﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Zamowienie
    {
        public List<Produkt> listaProduktow = new List<Produkt>();

        public int zamID { get; set; }
        public int userID { get; set; }
        public DateTime dataZamowienia { get; set; }
        public decimal kwota { get; set; }
        public string status { get; set; }



    }
}
