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
using SkolaKosarke.Model;
using SkolaKosarke.Controller;

namespace SkolaKosarke
{
    public partial class DodavanjeUtakmiceForm : Form, IDodavanjeUtakmice
    {
        NatjecanjeController natjecanjeController = new NatjecanjeController();

        public DodavanjeUtakmiceForm()
        {
            InitializeComponent();
        }

        private void ComboBoxNatjecanje_Changed(object sender, EventArgs e)
        {
            checkedListBoxIgraci.Items.Clear();
            IList<Igrac> igraci = natjecanjeController.DohvatiIgraceMladeIliJednake((comboBoxNatjecanje.SelectedItem as Natjecanje).Godiste);

            foreach (Igrac i in igraci)
            {
                checkedListBoxIgraci.Items.Add(i);
            }
        }

        public bool ShowForm()
        {
            DialogResult res = this.ShowDialog();

            if (res == DialogResult.OK)
                return true;
            else
                return false;
        }

        public DateTime Datum
        {
            get { return dateTimePickerDatum.Value; }
        }

        public ProtivnickiKlub Klub
        {
            get { return comboBoxProtivnickiKlub.SelectedItem as ProtivnickiKlub; }
        }

        public int BrojPostignutihKoseva
        {
            get { return Convert.ToInt32(numericUpDownBrojPostgnutih.Value); }
        }

        public int BrojPrimljenihKoseva
        {
            get { return Convert.ToInt32(numericUpDownBrojPrimljenih.Value); }
        }

        public List<Igrac> Igraci
        {
            get
            {
                var selected = new List<Igrac>();
                foreach (int index in checkedListBoxIgraci.CheckedIndices)
                {
                    selected.Add((Igrac)checkedListBoxIgraci.Items[index]);
                }
                return selected;
            }
        }

        private void DodavanjeUtakmice_Load(object sender, EventArgs e)
        {
            List<Natjecanje> natjecanja = natjecanjeController.ucitajNatjecanjaCombo();
            this.UcitajNatjecanja(natjecanja);
            List<ProtivnickiKlub> protivnickiKlubovi = natjecanjeController.ucitajProtivnickeKluboveCombo();
            this.UcitajProtivnickeKlubove(protivnickiKlubovi);
        }

        private void UcitajProtivnickeKlubove(List<ProtivnickiKlub> protivnickiKlubovi)
        {
            comboBoxProtivnickiKlub.DisplayMember = "NazivKluba";
            comboBoxProtivnickiKlub.DataSource = protivnickiKlubovi;
        }

        private void UcitajNatjecanja(List<Natjecanje> natjecanja)
        {
            comboBoxNatjecanje.DisplayMember = "Naziv";
            comboBoxNatjecanje.DataSource = natjecanja;
        }


        public Natjecanje Natjecanje
        {
            get { return comboBoxNatjecanje.SelectedItem as Natjecanje; }
        }


        public void Message(string m)
        {
            MessageBox.Show(m);
        }
    }
}
