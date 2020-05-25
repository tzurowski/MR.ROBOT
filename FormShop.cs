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
                if(i > 3)
                {
                    i = 0;
                    j++;
                }
                StworzWidokProduktu(item._nazwa, item._produktID, i, j);
            }
        }
        private void StworzWidokProduktu(string nazwa, int id, int kolumna, int wiersz)
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = 1;
            panel.RowCount = 2;
            panel.Size = new Size(tableLayoutShopPanel.Width / 4, (int)(tableLayoutShopPanel.Height*0.33));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 30));
            panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);

            Button btn = new Button();
            btn.Text = nazwa;
            btn.Name = $"btn{id}";
            btn.Size = new Size(panel.Width-85, 150);
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);

            Label lbl = new Label();
            lbl.Text = "Kliknij w zdjęcie by zobaczyć szczegóły";
            lbl.Font = new Font("Times New Roman", 12);
            lbl.Size = new Size(panel.Width - 85, 50);
            panel.Controls.Add(btn, 0, 0);
            panel.Controls.Add(lbl, 0, 1);

            tableLayoutShopPanel.Controls.Add(panel, kolumna, wiersz);
            tableLayoutShopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
    }
}
