using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace MrRobot
{
    public partial class FormLogIn : Form
    {

        FormMainMenu _form;
        public static bool isLogin = false;
        public FormLogIn(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Zaloguj(textBox1.Text.Trim(), textBox2.Text.Trim());
        }

        public void Zaloguj(string login, string haslo)
        {
            Uzytkownik uzytkownik = new Uzytkownik();
            BazaTableAdapters.UzytkownikTableAdapter tableadapterUzytkownik = new BazaTableAdapters.UzytkownikTableAdapter();
            Baza.UzytkownikDataTable tableUzytkownik = new Baza.UzytkownikDataTable();

            foreach (Baza.UzytkownikRow row in tableadapterUzytkownik.GetData().Rows)
            {
                string[] elementy = row.UserLogin.Split('|');
                if(elementy[0] == login && row.UserHaslo.Trim() == haslo)
                {
                    tableadapterUzytkownik.GetUser(tableUzytkownik, row.UserLogin, haslo);
                    foreach (Baza.UzytkownikRow item in tableUzytkownik.Rows)
                    {

                        uzytkownik._login = login;
                        uzytkownik._haslo = item.UserHaslo;
                        uzytkownik._isAdmin = item.UserAdmin;
                        uzytkownik._isSeller = item.UserSprzedawca;
                        uzytkownik._IDAddress = item.IsUserAdrIDNull() ? -1 : item.UserAdrID;
                    }
                }
            }
            if(uzytkownik._login != null)
            {
                if (uzytkownik._isAdmin == true)
                    _form.isAdmin = true;
                if (uzytkownik._isSeller == true)
                    _form.isSeller = true;
                _form.ActivateButton(_form.iconButtonShop);
                _form.OpenChildForm(new FormShop(_form));
                _form.labelTitleChildForm.Text = "Sklep";
                _form.iconButtonAccount.Text = " Konto";
                _form.login = login;
                _form.isLoggedIn = true;
            }
            else
            {
                MessageBox.Show("Podano błędne dane");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(_form.iconButtonAccount);
            _form.OpenChildForm(new FormRegistration(_form));
            _form.labelTitleChildForm.Text = " Rejestracja";
            _form.iconButtonAccount.Text = "Zarejestruj";
        }
    }
}
