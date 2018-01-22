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
using SkolaKosarke.Controller;
using SkolaKosarke.Model;

namespace SkolaKosarke
{
    public partial class DodavanjeClanarineForm : Form, IDodavanjeClanarine
    {
        public DodavanjeClanarineForm()
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

        public int Mjesec
        {
            get { return Convert.ToInt32(numericUpDownMjesec.Value); }
        }

        public int Godina
        {
            get { return Convert.ToInt32(numericUpDownGodina.Value); }
        }

        public int Iznos
        {
            get { return Convert.ToInt32(numericUpDownIznos.Value); }
        }

        public void Message(string m)
        {
            MessageBox.Show(m);
        }
    }
}
