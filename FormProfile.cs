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
    public partial class FormProfile : Form
    {
        FormMainMenu _form;
        public FormProfile(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            label2.Text = _form.login;
            if (_form.isAdmin == true) iconButtonAdminPanel.Visible = true;
            if (_form.isSeller == true) iconButtonSellerPanel.Visible = true;

        }

        

        private void iconButtonEdytujDane_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(_form.iconButtonAccount);
            _form.OpenChildForm(new FormEditProfile(_form));
            _form.labelTitleChildForm.Text = "Edycja profilu";
            _form.iconButtonAccount.Text = "Konto";
        }

        private void iconButtonAdminPanel_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(_form.iconButtonAccount);
            _form.OpenChildForm(new FormAdmin(_form));
            _form.labelTitleChildForm.Text = "Panel administratora";
            _form.iconButtonAccount.Text = "Konto";
        }

        private void iconButtonSellerPanel_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(_form.iconButtonAccount);
            _form.OpenChildForm(new FormSeller(_form));
            _form.labelTitleChildForm.Text = "Panel sprzedawcy";
            _form.iconButtonAccount.Text = "Konto";
        }

       
    }
}
