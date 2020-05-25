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
    public partial class FormCategory : Form
    {
        FormMainMenu _form;
        string nazwa, opis;
        BazaTableAdapters.KategoriaTableAdapter kategoria = new BazaTableAdapters.KategoriaTableAdapter();
        Kategoria edytowana = new Kategoria();
        public FormCategory(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            this.buttonEdytujKategorie.Click += new System.EventHandler(this.EdytujKategorie);
        }

        private void EdytujKategorie(object sender, EventArgs e)
        {
            UstawDane();
            Kategoria kat = new Kategoria();
            foreach (var item in kat.PobierzListeKategorii())
            {
                if (item._nazwaKategorii.Trim().ToLower().StartsWith(nazwa.ToLower()))
                {
                    edytowana._kategoriaID = item._kategoriaID;
                    edytowana._nazwaKategorii = item._nazwaKategorii;
                    edytowana._opisKategorii = item._opisKategorii;
                }
            }
            MessageBox.Show("Podaj nowe dane");
            buttonEdytujKategorie.Text = "Zatwierdz";
            this.buttonEdytujKategorie.Click -= new System.EventHandler(this.EdytujKategorie);
            this.buttonEdytujKategorie.Click += new System.EventHandler(this.ZatwierdzKategorie);
            
        }

        private void ZatwierdzKategorie(object sender, EventArgs e)
        {
            UstawDane();
            kategoria.Update(nazwa, opis, edytowana._kategoriaID, edytowana._nazwaKategorii, edytowana._opisKategorii);
            MessageBox.Show("Pomyślnie zupdateowano");
            this.buttonEdytujKategorie.Click -= new System.EventHandler(this.ZatwierdzKategorie);
            this.buttonEdytujKategorie.Click += new System.EventHandler(this.EdytujKategorie);

        }

        private void UstawDane()
        {
            nazwa = textBoxNazwaKategorii.Text.Trim();
            opis = textBoxOpis.Text.Trim();
        }

        private void buttonUsunKategorie_Click(object sender, EventArgs e)
        {
            UstawDane();
            Kategoria kat = new Kategoria(nazwa, opis);
            List<Kategoria> listaKategorii = kat.PobierzListeKategorii();
            foreach (var kategoria in listaKategorii)
            {
                if(kategoria._nazwaKategorii.Trim() == kat._nazwaKategorii.Trim() &&
                    kategoria._opisKategorii.Trim() == kat._opisKategorii.Trim())
                {
                    kat._kategoriaID = kategoria._kategoriaID;
                    kat.UsunKategorie(kat);
                }
            }
            MessageBox.Show("Usunieto kategorie");
        }
        private void buttonSzukajKategorii_Click(object sender, EventArgs e)
        {
            List<Kategoria> list = new List<Kategoria>();
            list =  PrzeszukajListe(textBoxSzukajKategorii.Text);
            dataGridViewKategorie.DataSource = list;

        }

        private List<Kategoria> PrzeszukajListe(string text)
        {
            Kategoria kat = new Kategoria();
            List<Kategoria> list = new List<Kategoria>();
            if(String.IsNullOrEmpty(text))
            {
                list = kat.PobierzListeKategorii();
            }
            else
            {
                foreach (var item in kat.PobierzListeKategorii())
                {
                    if (item._nazwaKategorii.Trim().ToLower().StartsWith(text.ToLower()))
                    {
                        list.Add(item);
                    }
                }
            }

            return list;
        }

        private void buttonDodajKategorie_Click(object sender, EventArgs e)
        {
            UstawDane();
            Kategoria kat = new Kategoria(nazwa, opis);
            if (kat.DodajKategorie())
            {
                MessageBox.Show("Dodano kategorie!");
            }
        }
    }
}
