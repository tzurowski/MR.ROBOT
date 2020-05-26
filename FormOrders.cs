﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrRobot
{
    public partial class FormOrders : Form
    {
        FormMainMenu _form;
        public FormOrders(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            PokazMojeZamowienia();
        }
        private List<Zamowienie> PrzeszukajListe(int idUser)
        {
            List<Zamowienie> list = new List<Zamowienie>();
            BazaTableAdapters.ZamowienieNaglowekTableAdapter zamowienieNaglowekTableAdapter = new BazaTableAdapters.ZamowienieNaglowekTableAdapter();
            foreach (Baza.ZamowienieNaglowekRow zm in zamowienieNaglowekTableAdapter.GetData().Rows)
            {
                if (zm.UserID == idUser)
                {
                    Zamowienie zam = new Zamowienie();
                    zam.dataZamowienia = zm.ZamNagDataZamowienia;
                    zam.kwota = zm.ZamNagKwota;
                    zam.status = zm.ZamNagStan;
                    list.Add(zam);
                }
            }
            return list;
        }

        private void PokazMojeZamowienia()
        {
            if (_form.isLoggedIn == true)
            {
                BazaTableAdapters.UzytkownikTableAdapter uzytkownikTableAdapter = new BazaTableAdapters.UzytkownikTableAdapter();
                foreach (Baza.UzytkownikRow row in uzytkownikTableAdapter.GetData().Rows)
                {
                    string[] elementy = row.UserLogin.Split('|');
                    if (elementy[0] == _form.login)
                    {
                        BazaTableAdapters.ZamowienieNaglowekTableAdapter zamowienieNaglowekTableAdapter = new BazaTableAdapters.ZamowienieNaglowekTableAdapter();
                        foreach (Baza.ZamowienieNaglowekRow zm in zamowienieNaglowekTableAdapter.GetData().Rows)
                        {
                            if (zm.UserID == row.UserID)
                            {
                                WyswietlListe(row.UserID);
                            }
                        }

                    }
                }
            }
        }

        private void WyswietlListe(int idUser)
        {
            List<Zamowienie> list = new List<Zamowienie>();
            list = PrzeszukajListe(idUser);
            dataGridViewZamowienia.DataSource = list;
        }

        private void PokazZamowienia()
        {
            List<Zamowienie> zamowienie = new List<Zamowienie>();
            Zamowienie zamow = new Zamowienie();
            if (_form.isLoggedIn == true)
            {
                BazaTableAdapters.UzytkownikTableAdapter uzytkownikTableAdapter = new BazaTableAdapters.UzytkownikTableAdapter();
                foreach (Baza.UzytkownikRow row in uzytkownikTableAdapter.GetData().Rows)
                {
                    string[] elementy = row.UserLogin.Split('|');
                    if (elementy[0] == _form.login)
                    {
                        BazaTableAdapters.ZamowienieNaglowekTableAdapter zamowienieNaglowekTableAdapter = new BazaTableAdapters.ZamowienieNaglowekTableAdapter();
                        foreach (Baza.ZamowienieNaglowekRow zm in zamowienieNaglowekTableAdapter.GetData().Rows)
                        {
                            if (zm.UserID == row.UserID)
                            {
                                zamow.dataZamowienia = zm.ZamNagDataZamowienia;
                                zamow.kwota = zm.ZamNagKwota;
                                zamow.status = zm.ZamNagStan;
                                BazaTableAdapters.ZamowienieElementTableAdapter zamowienieElementTableAdapter = new BazaTableAdapters.ZamowienieElementTableAdapter();
                                foreach (Baza.ZamowienieElementRow item in zamowienieElementTableAdapter.GetData().Rows)
                                {
                                    if (item.ZamElemZamNagID == zm.ZamNagID)
                                    {
                                        BazaTableAdapters.ProduktTableAdapter produktTableAdapter = new BazaTableAdapters.ProduktTableAdapter();
                                        foreach (Baza.ProduktRow produ in produktTableAdapter.GetData().Rows)
                                        {
                                            if (produ.ProdID == item.ZamElemProdID)
                                            {
                                                Produkt nowyProdukt = new Produkt(produ.ProdNazwa, produ.ProdKatID, produ.ProdCena, produ.ProdPlatforma, produ.ProdOpis, produ.ProdZdjecie);
                                                nowyProdukt._produktID = produ.ProdID;
                                                zamow.listaProduktow.Add(nowyProdukt);
                                                zamowienie.Add(zamow);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            dataGridViewZamowienia.DataSource = zamowienie;
        }
    }
}
