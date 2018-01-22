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
    public partial class DodavanjeBiljeskeForm : Form, IDodavanjeBiljeske
    {
        BiljeskaOIgracuController bController = new BiljeskaOIgracuController();

        public DodavanjeBiljeskeForm()
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

        public Igrac Igrac
        {
            get { return comboBoxIgrac.SelectedItem as Igrac; }
        }

        public DateTime Datum
        {
            get { return dateTimePickerDatum.Value; }
        }

        public string Biljeska
        {
            get { return textBoxBiljeska.Text; }
        }

        public void Message(string m)
        {
            MessageBox.Show(m);
        }

        private void DodavanjeBiljeske_Load(object sender, EventArgs e)
        {
            var igraci = bController.UcitajIgrace();
            this.UcitajIgrace(igraci);
        }

        private void UcitajIgrace(IList<Igrac> igraci)
        {
            comboBoxIgrac.DisplayMember = "Ime";
            comboBoxIgrac.DataSource = igraci;
        }

        private void ComboBoxIgrac_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Igrac)e.ListItem).ToString();
        }
    }
}
