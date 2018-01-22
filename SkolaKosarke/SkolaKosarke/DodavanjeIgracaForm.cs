using SkolaKosarke.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkolaKosarke
{
    public partial class DodavanjeIgracaForm : Form, IDodavanjeIgraca
    {
        public DodavanjeIgracaForm()
        {
            InitializeComponent();
        }

        public bool ShowDodavanjeIgracaForm()
        {
            DialogResult res = this.ShowDialog();

            if (res == DialogResult.OK)
                return true;
            else
                return false;
        }

        public string Ime
        {
            get { return textBoxIme.Text; }
        }

        public string Prezime
        {
            get { return textBoxPrezime.Text; }
        }

        public string OIB
        {
            get { return textBoxOIB.Text; }
        }

        public string ImeRoditelja
        {
            get { return textBoxImeRoditelja.Text; }
        }

        public string PrezimeRoditelja
        {
            get { return textBoxPrezimeRoditelja.Text; }
        }

        public DateTime DatumRodenja
        {
            get { return dateTimePickerDatumRodenja.Value; }
        }

        public string BrojTelefona
        {
            get { return textBoxBrojTelefona.Text; }
        }


        public string Nadimak
        {
            get { return textBoxNadimak.Text; }
        }


        public void Message(string m)
        {
            MessageBox.Show(m);
        }
    }
}
