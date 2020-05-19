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
    public partial class FormRegistration : Form
    {
        FormMainMenu _form;
        public FormRegistration(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(_form.iconButton5, Color.FromArgb(0, 150, 136));
            _form.OpenChildForm(new FormLogIn(_form));
            _form.labelTitleChildForm.Text = "Zaloguj";
            _form.iconButton5.Text = "Zaloguj";
        }
    }
}
