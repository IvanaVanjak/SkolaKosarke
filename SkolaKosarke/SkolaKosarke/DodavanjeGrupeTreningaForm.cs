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
    public partial class DodavanjeGrupeTreningaForm : Form, IDodavanjeGrupeTreninga
    {
        public DodavanjeGrupeTreningaForm()
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

        public string NazivGrupeTreninga
        {
            get { return textBoxNazivGrupe.Text; }
        }


        public void Message(string m)
        {
            MessageBox.Show(m);
        }
    }
}
