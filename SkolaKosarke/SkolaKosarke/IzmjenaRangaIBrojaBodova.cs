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
    public partial class IzmjenaRangaIBrojaBodova : Form, IIzmjenaRangaIBodova
    {
        NatjecanjeController natjecanjeController = new NatjecanjeController();

        public IzmjenaRangaIBrojaBodova()
        {
            InitializeComponent();
        }

        private void ComboBoxNatjecanje_Changed(object sender, EventArgs e)
        {
            var podatak = comboBoxNatjecanje.SelectedItem as Natjecanje;
            this.PrikaziPodatke(podatak);
        }

        private void PrikaziPodatke(Natjecanje podatak)
        {
            if (podatak is Liga) {
                numericUpDownRang.Value = ((Liga)podatak).Rang;
                numericUpDownBrojBodova.Show();
                labelBrojBodova.Show();
                numericUpDownBrojBodova.Value = ((Liga)podatak).BrojBodova;
            }
            else if (podatak is Turnir) {
                numericUpDownRang.Value = ((Turnir)podatak).Rang;
                numericUpDownBrojBodova.Hide();
                labelBrojBodova.Hide();
            }
        }

        private void Izmjena_Load(object sender, EventArgs e)
        {
            var natjecanja = natjecanjeController.ucitajTurnireILigeCombo();
            this.UcitajTurnireILige(natjecanja);
        }

        private void UcitajTurnireILige(IList<Natjecanje> natjecanja)
        {
            comboBoxNatjecanje.DisplayMember = "Naziv";
            comboBoxNatjecanje.DataSource = natjecanja;
        }

        public bool ShowForm()
        {
            DialogResult res = this.ShowDialog();

            if (res == DialogResult.OK)
                return true;
            else
                return false;
        }

        public int Rang
        {
            get { return Convert.ToInt32(numericUpDownRang.Value); }
        }

        public int BrojBodova
        {
            get { return Convert.ToInt32(numericUpDownBrojBodova.Value); }
        }


        public Natjecanje Natjecanje
        {
            get { return comboBoxNatjecanje.SelectedValue as Natjecanje; }
        }
    }
}
