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
    public partial class FormOrderDetails : Form
    {
        FormMainMenu _form;
        public FormOrderDetails(FormMainMenu form, int idZamowienia)
        {
            InitializeComponent();
            _form = form;
            listBox1.DataSource = PobierzListeProduktow(idZamowienia);
            listBox1.DisplayMember = "_nazwa";
            listBox1.ValueMember = "_nazwa";
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


    }
}
