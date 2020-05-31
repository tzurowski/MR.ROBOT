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
    public partial class FormAdmin : Form
    {
        FormMainMenu _form;
        int userID;
        int userIdAdress;
        public FormAdmin(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            dataGridViewUzytkownicy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void iconButtonSzukaj_Click(object sender, EventArgs e)
        {
            WyswietlListe(textBoxSzukaj.Text.Trim());
        }

        
        private void WyswietlListe(string szukany)
        {
            List<Uzytkownik> list = new List<Uzytkownik>();
            list = PrzeszukajListe(szukany);
            dataGridViewUzytkownicy.DataSource = list;
        }

        private List<Uzytkownik> PrzeszukajListe(string text)
        {
            Uzytkownik user = new Uzytkownik();
            List<Uzytkownik> list = new List<Uzytkownik>();
            List<Uzytkownik> returnList = new List<Uzytkownik>();

            BazaTableAdapters.UzytkownikTableAdapter uzytkownikTableAdapter = new BazaTableAdapters.UzytkownikTableAdapter();
            Baza.UzytkownikDataTable tableUzytkownik = new Baza.UzytkownikDataTable();

            foreach (Baza.UzytkownikRow item in uzytkownikTableAdapter.GetData().Rows)
            {
                list.Add(new Uzytkownik() { _mail = item.UserMail, _haslo = item.UserHaslo, _login = item.UserLogin, _IDAddress = item.UserAdrID, _isAdmin = item.UserAdmin, _isSeller = item.UserSprzedawca });
            }
            if (String.IsNullOrEmpty(text))
            {
                returnList = list;
            }
            else
            {
                foreach (var uzytkownik in list)
                {
                    string[] elementy = uzytkownik._login.Split('|');
                    if (uzytkownik._login.Trim().ToLower().StartsWith(text.ToLower()))
                    {
                        returnList.Add(uzytkownik);
                    }
                }
            }

            return returnList;
        }

        private void dataGridViewUzytkownicy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                string[] elementy = dataGridViewUzytkownicy.Rows[e.RowIndex].Cells[0].Value.ToString().Split('|');
                UstawDane(elementy[0]);
            }
        }

        private void UstawDane(string login)
        {
            BazaTableAdapters.UzytkownikTableAdapter uzytkownikTableAdapter = new BazaTableAdapters.UzytkownikTableAdapter();
            Baza.UzytkownikDataTable tableUzytkownik = new Baza.UzytkownikDataTable();

            foreach (Baza.UzytkownikRow row in uzytkownikTableAdapter.GetData().Rows)
            {
                string[] elementy = row.UserLogin.Split('|');
                if (elementy[0].Trim() == login.Trim())
                {
                    uzytkownikTableAdapter.GetUser(tableUzytkownik, row.UserLogin, row.UserHaslo);
                    foreach (Baza.UzytkownikRow item in tableUzytkownik.Rows)
                    {
                        userID = item.UserID;
                        textBoxNazwaUzytkownika.Text = elementy[0].Trim();
                        textBoxHaslo.Text = item.UserHaslo.Trim();
                        textBoxImie.Text = elementy[1].Trim();
                        textBoxNazwisko.Text = elementy[2].Trim();
                        textBoxPotwierdzHaslo.Text = "";
                        textBoxMail.Text = item.UserMail.Trim();
                        comboBoxCzyAdmin.Text = item.UserAdmin.ToString();
                        comboBoxCzySprzedawca.Text = item.UserSprzedawca.ToString();
                        userIdAdress = item.IsUserAdrIDNull() ? -1 : item.UserAdrID;
                        if (userIdAdress != -1)
                        {
                            BazaTableAdapters.AdresTableAdapter adres = new BazaTableAdapters.AdresTableAdapter();
                            foreach (Baza.AdresRow ad in adres.GetData().Rows)
                            {
                                if (ad.AdrID == item.UserAdrID)
                                {
                                    textBoxMiejscowosc.Text = ad.AdrNazwa;
                                    textBoxKod.Text = ad.AdrKodPocztowy;
                                    textBoxUlica.Text = ad.AdrUlica;
                                }
                            }
                        }
                    }
                }
            }


        }

        private void WyczyscDane()
        {
            textBoxNazwaUzytkownika.Text = "";
            textBoxHaslo.Text = "";
            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxPotwierdzHaslo.Text = "";
            textBoxMail.Text = "";
            comboBoxCzyAdmin.Text = "";
            comboBoxCzySprzedawca.Text = "";
            textBoxMiejscowosc.Text = "";
            textBoxKod.Text = "";
            textBoxUlica.Text = "";
        }

        private void iconButtonDodaj_Click(object sender, EventArgs e)
        {
            BazaTableAdapters.UzytkownikTableAdapter uzytkownikTableAdapter = new BazaTableAdapters.UzytkownikTableAdapter();
            string nowyLogin = textBoxNazwaUzytkownika.Text + "|" + textBoxImie.Text + "|" + textBoxNazwisko.Text;

            BazaTableAdapters.AdresTableAdapter insertAdres = new BazaTableAdapters.AdresTableAdapter();
            insertAdres.Insert(textBoxUlica.Text, textBoxMiejscowosc.Text, textBoxKod.Text);

            foreach (Baza.AdresRow adr in insertAdres.GetData().Rows)
            {
                if (textBoxUlica.Text.Trim() == adr.AdrUlica.Trim() && textBoxMiejscowosc.Text.Trim() == adr.AdrNazwa.Trim() && textBoxKod.Text.Trim() == adr.AdrKodPocztowy.Trim())
                {
                    uzytkownikTableAdapter.Insert(textBoxMail.Text, textBoxHaslo.Text, bool.Parse(comboBoxCzySprzedawca.Text), bool.Parse(comboBoxCzyAdmin.Text), adr.AdrID, nowyLogin);
                }
            }
            MessageBox.Show("Dodano uzytkownika", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            WyczyscDane();
        }

        private void iconButtonUsun_Click(object sender, EventArgs e)
        {
            BazaTableAdapters.UzytkownikTableAdapter uzytkownikTableAdapter = new BazaTableAdapters.UzytkownikTableAdapter();
            string nowyLogin = textBoxNazwaUzytkownika.Text + "|" + textBoxImie.Text + "|" + textBoxNazwisko.Text;

            BazaTableAdapters.AdresTableAdapter deleteAdres = new BazaTableAdapters.AdresTableAdapter();
            foreach (Baza.UzytkownikRow row in uzytkownikTableAdapter.GetData().Rows)
            {
                if (userID == row.UserID)
                {
                    foreach (Baza.AdresRow adr in deleteAdres.GetData().Rows)
                    {
                        if (userIdAdress == adr.AdrID)
                        {
                            deleteAdres.Delete(adr.AdrID, adr.AdrUlica, adr.AdrNazwa, adr.AdrKodPocztowy);
                        }
                    }
                    uzytkownikTableAdapter.Delete(userID, row.UserMail, row.UserHaslo, row.UserSprzedawca, row.UserAdmin, row.UserAdrID, row.UserLogin);
                }
            }

            MessageBox.Show("Usunieto uzytkownika", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            WyczyscDane();
        }

        private void iconButtonEdytuj_Click(object sender, EventArgs e)
        {
            BazaTableAdapters.UzytkownikTableAdapter uzytkownikTableAdapter = new BazaTableAdapters.UzytkownikTableAdapter();
            string nowyLogin = textBoxNazwaUzytkownika.Text + "|" + textBoxImie.Text + "|" + textBoxNazwisko.Text;

            foreach (Baza.UzytkownikRow row in uzytkownikTableAdapter.GetData().Rows)
            {
                if (userID == row.UserID)
                {
                    uzytkownikTableAdapter.Update(textBoxMail.Text, textBoxHaslo.Text, bool.Parse(comboBoxCzySprzedawca.Text), bool.Parse(comboBoxCzyAdmin.Text), userIdAdress, nowyLogin,
                    userID, row.UserMail, row.UserHaslo, row.UserSprzedawca, row.UserAdmin, row.UserAdrID, row.UserLogin);

                    BazaTableAdapters.AdresTableAdapter updateAdres = new BazaTableAdapters.AdresTableAdapter();
                    foreach (Baza.AdresRow adr in updateAdres.GetData().Rows)
                    {
                        if (userIdAdress != -1 && adr.AdrID == row.UserAdrID)
                        {
                            updateAdres.Update(textBoxUlica.Text, textBoxMiejscowosc.Text, textBoxKod.Text, adr.AdrID,
                                adr.AdrUlica, adr.AdrNazwa, adr.AdrKodPocztowy);
                        }
                    }
                }
            }
            MessageBox.Show("Zmieniono dane uzytkownika", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            WyczyscDane();
        }

        private void iconButtonWroc_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(_form.iconButtonAccount);
            _form.OpenChildForm(new FormProfile(_form));
            _form.labelTitleChildForm.Text = "Profil użytkownika";
            _form.iconButtonAccount.Text = "Konto";
        }
    }
}
