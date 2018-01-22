using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SkolaKosarke.Common;

namespace SkolaKosarke
{
    public partial class DodavanjeKlubaForm : Form, IDodavanjeKluba
    {
        public DodavanjeKlubaForm()
        {
            InitializeComponent();
        }

        public bool ShowForm()
        {
            DialogResult res = this.ShowDialog();

            if (res == DialogResult.OK)
                return true;
            else
                return false;
        }

        public string NazivKluba
        {
            get { return textBoxNazivKluba.Text; }
        }

        public string BrojTelefona
        {
            get { return textBoxBrojTelefona.Text; }
        }

        public string Ulica
        {
            get { return textBoxUlica.Text; }
        }

        public string KucniBroj
        {
            get { return textBoxKucniBroj.Text; }
        }

        public string PostanskiBroj
        {
            get { return textBoxPostanskiBroj.Text; }
        }

        public string Mjesto
        {
            get { return textBoxMjesto.Text; }
        }

        public string Drzava
        {
            get { return textBoxDrzava.Text; }
        }


        public void Message(string m)
        {
            MessageBox.Show(m);
        }
    }
}
