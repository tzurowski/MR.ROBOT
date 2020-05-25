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
