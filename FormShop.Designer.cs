namespace MrRobot
{
    partial class FormShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutShopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxFiltruj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutShopPanel
            // 
            this.tableLayoutShopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutShopPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutShopPanel.ColumnCount = 3;
            this.tableLayoutShopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutShopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutShopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutShopPanel.Location = new System.Drawing.Point(12, 55);
            this.tableLayoutShopPanel.Name = "tableLayoutShopPanel";
            this.tableLayoutShopPanel.RowCount = 3;
            this.tableLayoutShopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutShopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutShopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutShopPanel.Size = new System.Drawing.Size(1124, 767);
            this.tableLayoutShopPanel.TabIndex = 0;
            // 
            // comboBoxFiltruj
            // 
            this.comboBoxFiltruj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFiltruj.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFiltruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltruj.FormattingEnabled = true;
            this.comboBoxFiltruj.Items.AddRange(new object[] {
            "malejaco",
            "rosnaco"});
            this.comboBoxFiltruj.Location = new System.Drawing.Point(880, 12);
            this.comboBoxFiltruj.Name = "comboBoxFiltruj";
            this.comboBoxFiltruj.Size = new System.Drawing.Size(256, 37);
            this.comboBoxFiltruj.TabIndex = 0;
            this.comboBoxFiltruj.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltruj_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sortuj produkty wedlug ceny";
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 823);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFiltruj);
            this.Controls.Add(this.tableLayoutShopPanel);
            this.Name = "FormShop";
            this.Text = "FormShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutShopPanel;
        private System.Windows.Forms.ComboBox comboBoxFiltruj;
        private System.Windows.Forms.Label label1;
    }
}