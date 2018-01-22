using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SkolaKosarke.Controller;
using SkolaKosarke.Model;
using SkolaKosarke.Common;

namespace SkolaKosarke
{
    public partial class DodavanjeTreningaForm : Form, IDodavanjeTreninga
    {
        TreningController treningController = new TreningController();

        public DodavanjeTreningaForm()
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

        private void DodavanjeTreninga_Load(object sender, EventArgs e)
        {
            var grupe = treningController.UcitajGrupe();
            this.UcitajGrupe(grupe);
        }

        private void UcitajGrupe(IList<GrupaTreninga> grupe)
        {
            comboBoxGrupa.DisplayMember = "NazivGrupe";
            comboBoxGrupa.DataSource = grupe;
        }

        public GrupaTreninga Grupa
        {
            get { return comboBoxGrupa.SelectedItem as GrupaTreninga; }
        }

        public DateTime Datum
        {
            get { return dateTimePickerDatum.Value; }
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

        private void GrupaComboBox_Changed(object sender, EventArgs e)
        {
            checkedListBoxIgraci.Items.Clear();
            IList<Igrac> igraci = treningController.DohvatiIgraceUgrupi(comboBoxGrupa.SelectedItem as GrupaTreninga);

            foreach (Igrac i in igraci)
            {
                checkedListBoxIgraci.Items.Add(i);
            }
        }

    }
}
