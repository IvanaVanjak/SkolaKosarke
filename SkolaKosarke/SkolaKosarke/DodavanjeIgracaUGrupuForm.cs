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
using SkolaKosarke.Common;
using SkolaKosarke.Model;

namespace SkolaKosarke
{
    public partial class DodavanjeIgracaUGrupuForm : Form, IDodavanjeIgracaUGrupu
    {
        GrupaTreningaController grupaTreningaController = new GrupaTreningaController();

        public DodavanjeIgracaUGrupuForm()
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

        private void DodavanjeIgraca_Load(object sender, EventArgs e)
        {
            var igraci = grupaTreningaController.UcitajIgrace();
            this.UcitajIgrace(igraci);
            var grupe = grupaTreningaController.UcitajGrupe();
            this.UcitajGrupe(grupe);
        }

        private void UcitajIgrace(IList<Igrac> igraci)
        {
            comboBoxIgrac.DisplayMember = "Ime";
            comboBoxIgrac.DataSource = igraci;
        }

        private void UcitajGrupe(List<GrupaTreninga> grupe)
        {
            comboBoxGrupa.DisplayMember = "NazivGrupe";
            comboBoxGrupa.DataSource = grupe;
        }


        public Igrac Igrac
        {
            get { return comboBoxIgrac.SelectedItem as Igrac; }
        }

        public GrupaTreninga Grupa
        {
            get { return comboBoxGrupa.SelectedItem as GrupaTreninga; }
        }

        private void IgracComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Igrac)e.ListItem).Ime;
            string prezime = ((Igrac)e.ListItem).Prezime;
            e.Value = ((Igrac)e.ListItem).ToString();
        }


        public void Message(string m)
        {
            MessageBox.Show(m);
        }
    }
}
