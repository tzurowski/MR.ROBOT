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
            if (_form.isAdmin == true) button3.Visible = true;
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pomyślnie wylogowano");
            _form.isAdmin = false;
            _form.ActivateButton(_form.iconButton5, Color.FromArgb(0, 150, 136));
            _form.OpenChildForm(new FormLogIn(_form));
            _form.labelTitleChildForm.Text = "Zaloguj";
            _form.iconButton5.Text = "Zaloguj";
            _form.login = "";
        }
    }
}
