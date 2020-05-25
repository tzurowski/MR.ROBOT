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
        int _idProdukt;
        public FormProduct(int idProdukt, FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            _idProdukt = idProdukt;
            ZaladujDane();

        }

        private void ZaladujDane()
        {
            Produkt _produkt = new Produkt();

            BazaTableAdapters.ProduktTableAdapter produktTableAdapter = new BazaTableAdapters.ProduktTableAdapter();
            foreach (Baza.ProduktRow item in produktTableAdapter.GetData().Rows)
            {
                if(item.ProdID == _idProdukt)
                {
                    _produkt._produktID = item.ProdID;
                    _produkt._cena = item.ProdCena;
                    _produkt._kategoria = item.ProdKatID;
                    _produkt._nazwa = item.ProdNazwa;
                    _produkt._opis = item.ProdOpis;
                    _produkt._platforma = item.ProdPlatforma;
                    _produkt._zdjecie = item.ProdZdjecie.Trim();
                }
            }
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
