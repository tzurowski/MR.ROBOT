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
    }
}
