using System;
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
    public partial class FormCart : Form
    {
        List<int> _products;
        FormMainMenu _form;
        bool isFind = false;
        List<Produkt> list = new List<Produkt>();
        public FormCart(List<int> products, FormMainMenu form)
        {
            InitializeComponent();
            _products = products;
            _form = form;

            iconButtonDodajZamowienie.Enabled = true;
            iconButtonUsunZListy.Enabled = true;
            iconButtonDodajZamowienie.IconColor = Color.White;
            iconButtonUsunZListy.IconColor = Color.White;

            WyswietlListe(_products);
        }
        public FormCart(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            iconButtonDodajZamowienie.Enabled = false;
            iconButtonUsunZListy.Enabled = false;
            iconButtonDodajZamowienie.IconColor = Color.FromArgb(0, 0, 0);
            iconButtonUsunZListy.IconColor = Color.FromArgb(0, 0, 0);
        }

        private void WyswietlListe(List<int> idPr)
        {
            list = PrzeszukajListe(idPr);
            foreach (var item in list)
            {
                listBoxProdukty.Items.Add(item);
            }
            listBoxProdukty.DisplayMember = "_nazwa";
            listBoxProdukty.ValueMember = "_cena";
        }

        private List<Produkt> PrzeszukajListe(List<int> idPr)
        {
            Sprzedawca sprz = new Sprzedawca();
            List<Produkt> list = new List<Produkt>();
            foreach (var item in idPr)
            {
                foreach (var produkt in sprz.PobierzListeProduktow())
                {
                    if (produkt._produktID == item)
                    {
                        list.Add(produkt);
                    }
                }
            }
            return list;
        }

        private void DodajElementJakoZamowienie(int idZamNagID)
        {
            foreach (var item in list)
            {
                BazaTableAdapters.ZamowienieElementTableAdapter zamowienieElementTableAdapter = new BazaTableAdapters.ZamowienieElementTableAdapter();
                foreach (Baza.ZamowienieElementRow row in zamowienieElementTableAdapter.GetData().Rows)
                {
                    if (row.ZamElemZamNagID == idZamNagID)
                    {
                        if(item._produktID == row.ZamElemProdID)
                        {
                            int ilosc = row.ZamElemIlosc + 1;
                            zamowienieElementTableAdapter.Update(row.ZamElemProdID,row.ZamElemZamNagID, ilosc, row.ZamElemID,
                                row.ZamElemProdID, row.ZamElemZamNagID, row.ZamElemIlosc);
                            isFind = true;
                        }
                    }
                }
                if(isFind == false)
                {
                    zamowienieElementTableAdapter.Insert(item._produktID, idZamNagID, 1);
                }
                isFind = false;
            }
            
        }


        private void iconButtonUsunZListy_Click(object sender, EventArgs e)
        {
            if(listBoxProdukty.SelectedIndex != -1)
            {
                list.RemoveAt(listBoxProdukty.SelectedIndex);
                FormShop.produktyWKoszyku.RemoveAt(listBoxProdukty.SelectedIndex);
                listBoxProdukty.Items.Remove(listBoxProdukty.Items[listBoxProdukty.SelectedIndex]);
            }
        }

        private void iconButtonDodajZamowienie_Click(object sender, EventArgs e)
        {
            if(listBoxProdukty.Items.Count != 0)
            {
                Zamowienie zamowienie = new Zamowienie();
                zamowienie.listaProduktow = listBoxProdukty.Items.Cast<Produkt>().ToList();
                zamowienie.dataZamowienia = DateTime.Now;
                decimal kwota = 0;
                foreach (var item in zamowienie.listaProduktow)
                {
                    kwota += item._cena;
                }
                zamowienie.kwota = kwota;
                zamowienie.status = "Wysłane do realizacji";
                BazaTableAdapters.ZamowienieNaglowekTableAdapter zamowienieNaglowekTableAdapter = new BazaTableAdapters.ZamowienieNaglowekTableAdapter();

                BazaTableAdapters.UzytkownikTableAdapter uzytkownikTableAdapter = new BazaTableAdapters.UzytkownikTableAdapter();
                foreach (Baza.UzytkownikRow row in uzytkownikTableAdapter.GetData().Rows)
                {
                    string[] elementy = row.UserLogin.Split('|');
                    if (_form.login == elementy[0])
                    {
                        zamowienieNaglowekTableAdapter.Insert(zamowienie.dataZamowienia, zamowienie.kwota, zamowienie.status, row.UserID);
                        MessageBox.Show("Dodano zamówienie do wykonania", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                foreach (Baza.ZamowienieNaglowekRow row in zamowienieNaglowekTableAdapter.GetData().Rows)
                {
                    if (row.ZamNagDataZamowienia.ToString().Trim() == zamowienie.dataZamowienia.ToString().Trim())
                    {
                        DodajElementJakoZamowienie(row.ZamNagID);
                    }
                }
                listBoxProdukty.Items.Clear();
                FormShop.produktyWKoszyku.Clear();
            }
        }
    }
}
