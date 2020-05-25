using FontAwesome.Sharp;
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
    public partial class FormShop : Form
    {
        public FormShop()
        {
            InitializeComponent();
            UstawProdukty();
        }

        private void UstawProdukty()
        {
            Sprzedawca produkty = new Sprzedawca();
            int i = 0;
            int j = 1;
            foreach (var item in produkty.PobierzListeProduktow())
            {
                if(i > 2)
                {
                    i = 0;
                    j++;
                }
                Kategoria kat = new Kategoria();
                foreach (var kategoria in kat.PobierzListeKategorii())
                {
                    if(kategoria._kategoriaID == item._kategoria)
                    {
                        StworzWidokProduktu(item, item._zdjecie, item._nazwa, item._cena.ToString(), kategoria._nazwaKategorii, item._produktID, i, j);
                    }
                }
                
            }
        }
        private void StworzWidokProduktu(Produkt produkt, string zdjecie, string nazwa, string cena, string kategoria, int id, int kolumna, int wiersz)
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = 2;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            panel.RowCount = 4;
            panel.Size = new Size(tableLayoutShopPanel.Width / 3, (int)(tableLayoutShopPanel.Height*0.33));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);


            //Zdjecie button
            Button btn = new Button();
            btn.Text = nazwa;
            btn.Name = $"btn{id}";
            btn.BackgroundImage = new Bitmap(Properties.Resources._64495);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Dock = DockStyle.Fill;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
            panel.Controls.Add(btn, 0, 0);
            panel.SetRowSpan(btn, 4);

            //Nazwa label
            Label lblNazwa = new Label();
            lblNazwa.Text = nazwa;
            lblNazwa.Font = new Font("Times New Roman", 12);
            lblNazwa.Size = new Size(panel.Width - 85, 50);
            lblNazwa.Anchor = AnchorStyles.None;
            panel.Controls.Add(lblNazwa, 1, 0);

            //Kategoria label
            Label lblCena = new Label();
            lblCena.Text = cena;
            lblCena.Font = new Font("Times New Roman", 12);
            lblCena.Size = new Size(panel.Width - 85, 30);
            lblCena.Anchor = AnchorStyles.None;
            panel.Controls.Add(lblCena, 1, 1);

            //Kategoria label
            Label lblKategoria = new Label();
            lblKategoria.Text = kategoria;
            lblKategoria.Font = new Font("Times New Roman", 12);
            lblKategoria.Size = new Size(panel.Width - 85, 30);
            lblKategoria.Anchor = AnchorStyles.None;
            panel.Controls.Add(lblKategoria, 1, 2);

            //Koszyk przycisk
            IconButton iconButton = new IconButton();
            iconButton.IconChar = IconChar.ShoppingCart;
            iconButton.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton.IconSize = (int)(iconButton.Height * 1.65);
            iconButton.Font = new Font("Times New Roman", iconButton.Height/2);
            iconButton.TextAlign = ContentAlignment.MiddleRight;
            iconButton.Text = "DO KOSZYKA";
            iconButton.Dock = DockStyle.Fill;
            panel.Controls.Add(iconButton, 1, 3);

            tableLayoutShopPanel.Controls.Add(panel, kolumna, wiersz);
            tableLayoutShopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
    }
}
