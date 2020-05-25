using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class Kategoria
    {
        public string _nazwaKategorii { get; set; }
        public string _opisKategorii { get; set; }
        public int _kategoriaID { get; set; }
        public Kategoria(string nazwaKategorii, string opisKategorii)
        {
            _nazwaKategorii = nazwaKategorii;
            _opisKategorii = opisKategorii;
        }
        public Kategoria()
        {
        }
        public bool DodajKategorie()
        {
            BazaTableAdapters.KategoriaTableAdapter nowaKategoria = new BazaTableAdapters.KategoriaTableAdapter();
            nowaKategoria.Insert(_nazwaKategorii, _opisKategorii);
            return true;
        }
        public bool UsunKategorie(Kategoria kategoria)
        {
            BazaTableAdapters.KategoriaTableAdapter usunKategorie = new BazaTableAdapters.KategoriaTableAdapter();
            usunKategorie.Delete(kategoria._kategoriaID, kategoria._nazwaKategorii, kategoria._opisKategorii);
            return true;
        }

        public List<Kategoria> PobierzListeKategorii()
        {
            List<Kategoria> listaKategorii = new List<Kategoria>();
            BazaTableAdapters.KategoriaTableAdapter kategorie = new BazaTableAdapters.KategoriaTableAdapter();
            kategorie.GetData();
            foreach (Baza.KategoriaRow row in kategorie.GetData().Rows)
            {
                Kategoria kat = new Kategoria(row.KatNazwa.Trim(), row.KatOpis.Trim());
                kat._kategoriaID = row.KatID;
                listaKategorii.Add(kat);
            }
            return listaKategorii;
        }
    }
}
