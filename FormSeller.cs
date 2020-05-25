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
    public partial class FormSeller : Form
    {
        FormMainMenu _form;
        string nazwa, opis, platforma, zdjecie;
        decimal cena;
        int kategoria;


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
            comboBoxKategoria.ValueMember = "_nazwaKategorii";
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
        }

        private void buttonSzukajProdukt_Click(object sender, EventArgs e)
        {
            List<Produkt> list = new List<Produkt>();
            list = PrzeszukajListe(textBoxSzukajProduktu.Text);
            dataGridViewProdukty.DataSource = list;
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
            kategoria = comboBoxKategoria.SelectedIndex;
        }
        private void buttonDodajProdukt_Click(object sender, EventArgs e)
        {
            UstawDane();
            Sprzedawca sprzedawca = new Sprzedawca();
            sprzedawca.DodajProdukt(nazwa, kategoria, cena, platforma, opis, zdjecie);
        }
    }
}
