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
    public partial class FormEditProfile : Form
    {
        FormMainMenu _form;
        Uzytkownik uzytkownik = new Uzytkownik();
        int userID;
        public FormEditProfile(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            UstawDane();
        }

        private void buttonWroc_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(_form.iconButtonAccount);
            _form.OpenChildForm(new FormProfile(_form));
            _form.labelTitleChildForm.Text = "Profil użytkownika";
            _form.iconButtonAccount.Text = "Konto";
        }

        private void buttonEdytujProdukt_Click(object sender, EventArgs e)
        {
            BazaTableAdapters.UzytkownikTableAdapter uzytkownikTableAdapter = new BazaTableAdapters.UzytkownikTableAdapter();
            string nowyLogin = textBoxNazwaUzytkownika.Text + "|" + textBoxImie.Text + "|" + textBoxNazwisko.Text;
            if(textBoxHaslo.Text == textBoxPotwierdzHaslo.Text)
            {
                foreach (Baza.UzytkownikRow row in uzytkownikTableAdapter.GetData().Rows)
                {
                    if (userID == row.UserID)
                    {
                        uzytkownikTableAdapter.Update(textBoxMail.Text, textBoxHaslo.Text, row.UserSprzedawca, row.UserAdmin, uzytkownik._IDAddress, nowyLogin,
                        userID, row.UserMail, row.UserHaslo, row.UserSprzedawca, row.UserAdmin, row.UserAdrID, row.UserLogin);

                        BazaTableAdapters.AdresTableAdapter updateAdres = new BazaTableAdapters.AdresTableAdapter();
                        foreach (Baza.AdresRow adr in updateAdres.GetData().Rows)
                        {
                            if ((row.IsUserAdrIDNull() ? -1 : row.UserAdrID) != -1 && adr.AdrID == row.UserAdrID)
                            {
                                updateAdres.Update(textBoxUlica.Text, textBoxMiejscowosc.Text, textBoxKod.Text, adr.AdrID,
                                    adr.AdrUlica, adr.AdrNazwa, adr.AdrKodPocztowy);
                            }
                        }
                    }
                }
                MessageBox.Show("Poprawnie zmieniono dane");
                _form.ActivateButton(_form.iconButtonAccount);
                _form.OpenChildForm(new FormProfile(_form));
                _form.labelTitleChildForm.Text = "Profil użytkownika";
                _form.iconButtonAccount.Text = "Konto";
            }
            else
            {
                MessageBox.Show("Podaj poprawne haslo");
            }
            


        }

        private void UstawDane()
        {
            BazaTableAdapters.UzytkownikTableAdapter uzytkownikTableAdapter = new BazaTableAdapters.UzytkownikTableAdapter();
            Baza.UzytkownikDataTable tableUzytkownik= new Baza.UzytkownikDataTable();
            
            foreach (Baza.UzytkownikRow row in uzytkownikTableAdapter.GetData().Rows)
            {
                string[] elementy = row.UserLogin.Split('|');
                if(elementy[0].Trim() == _form.login.Trim())
                {
                    uzytkownikTableAdapter.GetUser(tableUzytkownik, row.UserLogin, row.UserHaslo);
                    foreach (Baza.UzytkownikRow item in tableUzytkownik.Rows)
                    {

                        textBoxNazwaUzytkownika.Text = elementy[0].Trim();
                        textBoxHaslo.Text = item.UserHaslo.Trim();
                        textBoxImie.Text = elementy[1].Trim();
                        textBoxNazwisko.Text = elementy[2].Trim();
                        textBoxPotwierdzHaslo.Text = "";
                        textBoxMail.Text = item.UserMail.Trim();
                        userID = item.UserID;
                        if((item.IsUserAdrIDNull() ? -1 : item.UserAdrID) != -1)
                        {
                            BazaTableAdapters.AdresTableAdapter adres = new BazaTableAdapters.AdresTableAdapter();
                            foreach (Baza.AdresRow ad in adres.GetData().Rows)
                            {
                                if (ad.AdrID == item.UserAdrID)
                                {
                                    textBoxMiejscowosc.Text = ad.AdrNazwa;
                                    textBoxKod.Text = ad.AdrKodPocztowy;
                                    textBoxUlica.Text = ad.AdrUlica;
                                    uzytkownik._IDAddress = ad.AdrID;
                                }
                            }
                        }
                    }
                }
            }


        }
    }
}
