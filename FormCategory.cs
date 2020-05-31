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
        bool isFind = false;
        string nazwa, opis;
        BazaTableAdapters.KategoriaTableAdapter kategoria = new BazaTableAdapters.KategoriaTableAdapter();
        Kategoria edytowana = new Kategoria();
        public FormCategory(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            this.iconButtonEdytujKategorie.Click += new System.EventHandler(this.EdytujKategorie);
            dataGridViewKategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        public void UstawPolaDoEdycji()
        {
            textBoxNazwaKategorii.Text = edytowana._nazwaKategorii.Trim();
            textBoxOpis.Text = edytowana._opisKategorii.Trim();
        }

        private void EdytujKategorie(object sender, EventArgs e)
        {
            WyswietlListe("");
            UstawDane();
            Kategoria kat = new Kategoria();
            foreach (var item in kat.PobierzListeKategorii())
            {
                if (item._nazwaKategorii.Trim().ToLower() == nazwa.ToLower())
                {
                    edytowana._kategoriaID = item._kategoriaID;
                    edytowana._nazwaKategorii = item._nazwaKategorii;
                    edytowana._opisKategorii = item._opisKategorii;
                    UstawPolaDoEdycji();
                    isFind = true;
                }
            }
            if (isFind == true)
            {
                MessageBox.Show("Podaj nowe dane","Uwaga!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxOpis.Enabled = true;
                iconButtonEdytujKategorie.Text = "Zatwierdz";
                this.iconButtonEdytujKategorie.Click -= new System.EventHandler(this.EdytujKategorie);
                this.iconButtonEdytujKategorie.Click += new System.EventHandler(this.ZatwierdzKategorie);
                UstawPolaDoEdycji();
                isFind = false;
            }
            else
            {
                MessageBox.Show("Nie znaleziono takiej kategorii", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void ZatwierdzKategorie(object sender, EventArgs e)
        {
            UstawDane();
            kategoria.Update(nazwa, opis, edytowana._kategoriaID, edytowana._nazwaKategorii, edytowana._opisKategorii);
            MessageBox.Show("Pomyślnie zaktualizowano", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            textBoxNazwaKategorii.Text = "";
            textBoxOpis.Text = "";
            iconButtonEdytujKategorie.Text = "Edytuj";
            this.iconButtonEdytujKategorie.Click -= new System.EventHandler(this.ZatwierdzKategorie);
            this.iconButtonEdytujKategorie.Click += new System.EventHandler(this.EdytujKategorie);
            WyswietlListe("");
        }

        private void UstawDane()
        {
            nazwa = textBoxNazwaKategorii.Text.Trim();
            opis = textBoxOpis.Text.Trim();
        }

        private void iconButtonUsunKategorie_Click(object sender, EventArgs e)
        {
            UstawDane();
            Kategoria kat = new Kategoria(nazwa, opis);
            List<Kategoria> listaKategorii = kat.PobierzListeKategorii();
            foreach (var kategoria in listaKategorii)
            {
                if (kategoria._nazwaKategorii.Trim() == kat._nazwaKategorii.Trim() &&
                    kategoria._opisKategorii.Trim() == kat._opisKategorii.Trim())
                {
                    kat._kategoriaID = kategoria._kategoriaID;
                    kat.UsunKategorie(kat);
                }
            }
            MessageBox.Show("Usunieto kategorię", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void iconButtonSzukajKategorie_Click(object sender, EventArgs e)
        {
            WyswietlListe(textBoxSzukajKategorii.Text);
        }

        private void WyswietlListe(string szukany)
        {
            List<Kategoria> list = new List<Kategoria>();
            list = PrzeszukajListe(szukany);
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

        private void dataGridViewKategorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edytowana._kategoriaID = int.Parse(dataGridViewKategorie.Rows[e.RowIndex].Cells[2].Value.ToString());
                edytowana._nazwaKategorii = dataGridViewKategorie.Rows[e.RowIndex].Cells[0].Value.ToString();
                edytowana._opisKategorii = dataGridViewKategorie.Rows[e.RowIndex].Cells[1].Value.ToString();

                UstawPolaDoEdycji();
                textBoxOpis.Enabled = false;
            }
        }

        

        private void iconButtonDodaj_Click(object sender, EventArgs e)
        {
            UstawDane();
            Kategoria kat = new Kategoria(nazwa, opis);
            if (kat.DodajKategorie())
            {
                MessageBox.Show("Dodano kategorię", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
