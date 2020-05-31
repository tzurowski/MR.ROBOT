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
    public partial class FormOrderFulfillment : Form
    {
        FormMainMenu _form;
        List<Zamowienie> _pelnaLista = new List<Zamowienie>();
        private int userID;

        public FormOrderFulfillment(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            _pelnaLista = PobierzPelnaListeZamowien();
            dataGridView1.DataSource = _pelnaLista;
        }
        private List<Zamowienie> PrzeszukajListe(string tekstWyszukiwania)
        {
            List<Zamowienie> list = new List<Zamowienie>();
            BazaTableAdapters.ZamowienieNaglowekTableAdapter zamowienieNaglowekTableAdapter = new BazaTableAdapters.ZamowienieNaglowekTableAdapter();
            foreach (Baza.ZamowienieNaglowekRow zm in zamowienieNaglowekTableAdapter.GetData().Rows)
            {
                if (zm.ZamNagStan.Trim() == tekstWyszukiwania)
                {
                    Zamowienie zam = new Zamowienie();
                    zam.userID = zm.UserID;
                    zam.zamID = zm.ZamNagID;
                    zam.dataZamowienia = zm.ZamNagDataZamowienia;
                    zam.kwota = zm.ZamNagKwota;
                    zam.status = zm.ZamNagStan;
                    zam.listaProduktow = PobierzListeProduktow(zm.ZamNagID);
                    list.Add(zam);
                }
            }
            return list;
        }

        private List<Produkt> PobierzListeProduktow(int idZamowienia)
        {
            List<Produkt> listaZamowionychProduktow = new List<Produkt>();

            BazaTableAdapters.ZamowienieElementTableAdapter zamowienieNaglowekTableAdapter = new BazaTableAdapters.ZamowienieElementTableAdapter();
            foreach (Baza.ZamowienieElementRow zm in zamowienieNaglowekTableAdapter.GetData().Rows)
            {
                if (zm.ZamElemZamNagID == idZamowienia)
                {
                    Sprzedawca sprz = new Sprzedawca();
                    for (int i = 0; i < zm.ZamElemIlosc; i++)
                    {
                        foreach (var produkt in sprz.PobierzListeProduktow())
                        {
                            if (produkt._produktID == zm.ZamElemProdID)
                            {
                                listaZamowionychProduktow.Add(produkt);
                            }
                        }
                    }

                }
            }

            return listaZamowionychProduktow;
        }

        private List<Zamowienie> PobierzPelnaListeZamowien()
        {
            List<Zamowienie> list = new List<Zamowienie>();
            BazaTableAdapters.ZamowienieNaglowekTableAdapter zamowienieNaglowekTableAdapter = new BazaTableAdapters.ZamowienieNaglowekTableAdapter();
            foreach (Baza.ZamowienieNaglowekRow zm in zamowienieNaglowekTableAdapter.GetData().Rows)
            {
                Zamowienie zam = new Zamowienie();
                zam.userID = zm.UserID;
                zam.zamID = zm.ZamNagID;
                zam.dataZamowienia = zm.ZamNagDataZamowienia;
                zam.kwota = zm.ZamNagKwota;
                zam.status = zm.ZamNagStan;
                zam.listaProduktow = PobierzListeProduktow(zm.ZamNagID);
                list.Add(zam);
            }
            return list;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PrzeszukajListe("Wysłane do realizacji");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PrzeszukajListe("Zrealizowane");
        }


        private string PrzeszukajListeUzytkownikow(int textID)
        {
            string imieINazwisko = "";
            BazaTableAdapters.UzytkownikTableAdapter uzytkownikTableAdapter = new BazaTableAdapters.UzytkownikTableAdapter();
            Baza.UzytkownikDataTable tableUzytkownik = new Baza.UzytkownikDataTable();

            foreach (Baza.UzytkownikRow item in uzytkownikTableAdapter.GetData().Rows)
            {
                if(item.UserID == textID)
                {
                    string[] elementy = item.UserLogin.Split('|');
                    imieINazwisko = elementy[1] + " " + elementy[2];
                }    
            }
            return imieINazwisko;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idZam = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            foreach (var item in _pelnaLista)
            {
                if (item.zamID == idZam)
                {
                    userID = item.userID;
                    textBox1.Text = item.zamID.ToString();
                    textBox2.Text = PrzeszukajListeUzytkownikow(item.userID);
                    textBox3.Text = item.kwota.ToString();
                    dateTimePicker1.Value = item.dataZamowienia;
                    listBox1.DataSource = item.listaProduktow;
                    listBox1.DisplayMember = "_nazwa";
                    listBox1.ValueMember = "_nazwa";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BazaTableAdapters.ZamowienieNaglowekTableAdapter zamowienieNaglowekTableAdapter = new BazaTableAdapters.ZamowienieNaglowekTableAdapter();
            zamowienieNaglowekTableAdapter.Update(dateTimePicker1.Value, decimal.Parse(textBox3.Text), "Zrealizowane", userID, int.Parse(textBox1.Text), dateTimePicker1.Value, decimal.Parse(textBox3.Text), "Wysłane do realizacji", userID);
        }
    }
}
