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
    public partial class FormProduct : Form
    {
        FormMainMenu _form;
        Produkt _produkt;
        public FormProduct(Produkt pr, FormMainMenu form)
        {
            InitializeComponent();
            _produkt = pr;
            _form = form;
            ZaladujDane();

        }

        private void ZaladujDane()
        {
            Image image = (Image)Properties.Resources.ResourceManager.GetObject($"{_produkt._zdjecie}");
            pictureBoxObrazek.BackgroundImage = image;
            textBoxNazwa.Text = _produkt._nazwa;
            textBoxPlatforma.Text = _produkt._platforma;
            textBoxCena.Text = _produkt._cena.ToString() + " zł";
            Kategoria kat = new Kategoria();
            foreach (var kategoria in kat.PobierzListeKategorii())
            {
                if (kategoria._kategoriaID == _produkt._kategoria)
                {
                    textBoxKategoria.Text = kategoria._nazwaKategorii;
                }
            }
            textBoxOpis.Text = _produkt._opis;
            if(_form.isLoggedIn == false)
            {
                buttonDodajDoKoszyka.Visible = false;
            }


        }

        private void buttonWroc_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(_form.iconButtonShop);
            _form.OpenChildForm(new FormShop(_form));
            _form.labelTitleChildForm.Text = "Sklep";
        }
    }
}
