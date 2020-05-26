using FontAwesome.Sharp;
using MrRobot.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrRobot
{
    public partial class FormShop : Form
    {
        FormMainMenu _form;
        Produkt aktualnyProdukt = new Produkt();
        public List<int> products = new List<int>();
        public FormShop(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            comboBoxFiltruj.SelectedIndex = 0;
            UstawProdukty();
        }

        private void UstawProdukty()
        {
            tableLayoutShopPanel.Controls.Clear();
            int i = 0;
            int j = 0;
            foreach (var item in Filtruj(comboBoxFiltruj.Text))
            {
                if (i > 2)
                {
                    i = 0;
                    j++;
                }
                Kategoria kat = new Kategoria();
                foreach (var kategoria in kat.PobierzListeKategorii())
                {
                    if (kategoria._kategoriaID == item._kategoria)
                    {
                        aktualnyProdukt = item;
                        StworzWidokProduktu(item._zdjecie, item._nazwa, item._cena.ToString(), kategoria._nazwaKategorii, item._produktID, i, j);
                    }
                }

            }
        }

        
        private void StworzWidokProduktu(string zdjecie, string nazwa, string cena, string kategoria, int id, int kolumna, int wiersz)
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = 2;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            panel.RowCount = 4;
            panel.Size = new Size(tableLayoutShopPanel.Width / 3, (int)(tableLayoutShopPanel.Height * 0.33));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);

            Image image = (Image)Properties.Resources.ResourceManager.GetObject($"{zdjecie}");

            //Zdjecie button
            Button btn = new Button();
            btn.Name = $"btn{id}";
            btn.Click += PokazProdukt;
            btn.BackgroundImage = image;
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

            //Cena label
            Label lblCena = new Label();
            lblCena.Text = cena + " zł";
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
            iconButton.Name = $"iconButton{id}";
            iconButton.IconChar = IconChar.ShoppingCart;
            iconButton.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton.IconSize = (int)(iconButton.Height * 1.65);
            iconButton.Font = new Font("Times New Roman", iconButton.Height / 2);
            iconButton.TextAlign = ContentAlignment.MiddleRight;
            iconButton.Text = "DO KOSZYKA";
            iconButton.Dock = DockStyle.Fill;
            iconButton.Click += DodajDoKoszyka_Click;
            panel.Controls.Add(iconButton, 1, 3);

            if (_form.isLoggedIn == false)
            {
                iconButton.Visible = false;
            }

            tableLayoutShopPanel.Controls.Add(panel, kolumna, wiersz);
            tableLayoutShopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void DodajDoKoszyka_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string idProdukt = btn.Name.Replace("iconButton", "");
            products.Add(int.Parse(idProdukt));
            DialogResult result = MessageBox.Show("Pomyslnie dodano do koszyka, chcesz kontynuowac zakupy?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.No)
            {
                _form.ActivateButton(_form.iconButtonCart);
                _form.OpenChildForm(new FormCart(products, _form));
                _form.labelTitleChildForm.Text = "Koszyk";
            }
        }

        private List<Produkt> Filtruj(string filtr)
        {
            Sprzedawca produkty = new Sprzedawca();
            List<Produkt> temp = produkty.PobierzListeProduktow();
            switch (filtr)
            {
                case "malejaco":
                    temp = temp.OrderBy(o => o._cena).ToList();
                    break;
                case "rosnaco":
                    temp = temp.OrderBy(o => o._cena).ToList();
                    temp.Reverse();
                    break;

                default:
                    break;
            }
            return temp;
        }
        private void PokazProdukt(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string idProdukt = btn.Name.Replace("btn", "");
            _form.ActivateButton(_form.iconButtonShop);
            _form.OpenChildForm(new FormProduct(int.Parse(idProdukt), _form));
            //_form.labelTitleChildForm.Text = aktualnyProdukt._nazwa;
        }

        private void comboBoxFiltruj_SelectedIndexChanged(object sender, EventArgs e)
        {
            UstawProdukty();
        }
    }
}
