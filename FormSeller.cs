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
    public partial class FormSeller : Form
    {
        FormMainMenu _form;
        Produkt edytowany = new Produkt();
        string nazwa, opis, platforma, zdjecie;
        decimal cena;
        int kategoria;
        int id;
        bool isFind = false;


        public FormSeller(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            UstawComboBox();
        }

        private void UstawComboBox()
        {
            Kategoria kat = new Kategoria();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = kat.PobierzListeKategorii();
            comboBoxKategoria.DataSource = bindingSource.DataSource;

            comboBoxKategoria.DisplayMember = "_nazwaKategorii";
            comboBoxKategoria.ValueMember = "_kategoriaID";
        }

        private List<Produkt> PrzeszukajListe(string text)
        {
            Sprzedawca sprz = new Sprzedawca();
            List<Produkt> list = new List<Produkt>();
            if (String.IsNullOrEmpty(text))
            {
                list = sprz.PobierzListeProduktow();
            }
            else
            {
                foreach (var produkt in sprz.PobierzListeProduktow())
                {
                    if (produkt._nazwa.Trim().StartsWith(text.ToLower()))
                    {
                        list.Add(produkt);
                    }
                }
            }

            return list;
        }

        private void buttonUsunProdukt_Click(object sender, EventArgs e)
        {
            //UstawDane();
            nazwa = textBoxNazwaProduktu.Text.Trim();
            Sprzedawca sprzedawca = new Sprzedawca();
            List<Produkt> listaProduktow = sprzedawca.PobierzListeProduktow();
            foreach (var pro in listaProduktow)
            {
                if (pro._nazwa.Trim() == nazwa)
                {
                    sprzedawca.UsunProdukt(pro);
                }
            }
            MessageBox.Show("Usunieto produkt");
            WyswietlListe("");
        }

        private void buttonSzukajProdukt_Click(object sender, EventArgs e)
        {
            WyswietlListe(textBoxSzukajProduktu.Text.Trim());
        }
        private void WyswietlListe(string szukany)
        {
            List<Produkt> list = new List<Produkt>();
            list = PrzeszukajListe(textBoxSzukajProduktu.Text);
            dataGridViewProdukty.DataSource = list;
        }

        private void dataGridViewProdukty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edytowany._produktID = int.Parse(dataGridViewProdukty.Rows[e.RowIndex].Cells[0].Value.ToString());
            edytowany._nazwa = dataGridViewProdukty.Rows[e.RowIndex].Cells[1].Value.ToString();
            edytowany._kategoria = int.Parse(dataGridViewProdukty.Rows[e.RowIndex].Cells[2].Value.ToString());
            edytowany._cena = decimal.Parse(dataGridViewProdukty.Rows[e.RowIndex].Cells[3].Value.ToString());
            edytowany._platforma = dataGridViewProdukty.Rows[e.RowIndex].Cells[4].Value.ToString();
            edytowany._opis = dataGridViewProdukty.Rows[e.RowIndex].Cells[5].Value.ToString();
            edytowany._zdjecie = dataGridViewProdukty.Rows[e.RowIndex].Cells[6].Value.ToString();

            UstawPolaDoEdycji();
        }

        private void UstawPolaDoEdycji()
        {
            textBoxNazwaProduktu.Text = edytowany._nazwa.Trim();
            textBoxOpis.Text = edytowany._opis.Trim();
            textBoxPlatforma.Text = edytowany._platforma.Trim();

            Kategoria kat = new Kategoria();
            foreach (var item in kat.PobierzListeKategorii())
            {
                if (item._kategoriaID == edytowany._kategoria)
                {
                    comboBoxKategoria.Text = item._nazwaKategorii;
                }
            }

            textBoxCena.Text = edytowany._cena.ToString();
            textBoxZdjecie.Text = edytowany._zdjecie;
                
        }

        private void buttonEdytujProdukt_Click(object sender, EventArgs e)
        {
            UstawDane();
            Sprzedawca produkt = new Sprzedawca();
            produkt.EdytujProdukt(edytowany, nazwa, cena, platforma, opis, zdjecie, kategoria);


            textBoxNazwaProduktu.Text = "";
            textBoxOpis.Text = "";
            textBoxPlatforma.Text = "";
            comboBoxKategoria.Text = "";
            textBoxCena.Text = "";
            textBoxZdjecie.Text = "";

            MessageBox.Show("Pomyślnie edytowano produkt");

            WyswietlListe("");
        }

        private void buttonEdytujKategorie_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(_form.iconButtonAccount);
            _form.OpenChildForm(new FormCategory(_form));
            _form.labelTitleChildForm.Text = "Panel Kategorii";
            _form.iconButtonAccount.Text = "Konto";
        }
        private void UstawDane()
        {
            nazwa = textBoxNazwaProduktu.Text.Trim();
            opis = textBoxOpis.Text.Trim();
            platforma = textBoxPlatforma.Text.Trim();
            zdjecie = textBoxZdjecie.Text.Trim();
            cena = decimal.Parse(textBoxCena.Text);

            Kategoria kat = new Kategoria();
            foreach (var item in kat.PobierzListeKategorii())
            {
                if (item._nazwaKategorii == comboBoxKategoria.Text)
                {
                    kategoria = item._kategoriaID;
                }
            }
        }
        private void buttonDodajProdukt_Click(object sender, EventArgs e)
        {
            UstawDane();
            Sprzedawca sprzedawca = new Sprzedawca();
            sprzedawca.DodajProdukt(nazwa, kategoria, cena, platforma, opis, zdjecie);
        }
    }
}
