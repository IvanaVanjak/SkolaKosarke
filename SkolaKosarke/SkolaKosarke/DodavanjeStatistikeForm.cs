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
    public partial class DodavanjeStatistikeForm : Form, IDodavanjeStatistike
    {
        NatjecanjeController natjecanjeController = new NatjecanjeController();

        public DodavanjeStatistikeForm()
        {
            InitializeComponent();
        }

        private void DodavanjeStatistike_Load(object sender, EventArgs e)
        {
            var natjecanja = natjecanjeController.ucitajNatjecanjaCombo();
            this.UcitajNatjecanja(natjecanja);
        }

        private void UcitajNatjecanja(List<Natjecanje> natjecanja)
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

        public Natjecanje Natjecanje
        {
            get { return comboBoxNatjecanje.SelectedItem as Natjecanje; }
        }

        public Utakmica Utakmica
        {
            get { return comboBoxUtakmica.SelectedItem as Utakmica; }
        }

        public Statistika Statistika
        {
            get { return comboBoxIgrac.SelectedItem as Statistika; }
        }

        public int Kosevi
        {
            get { return Convert.ToInt32(numericUpDownKosevi.Value); }
        }

        public int Skokovi
        {
            get { return Convert.ToInt32(numericUpDownSkokovi.Value); }
        }

        int IDodavanjeStatistike.Asistencije
        {
            get { return Convert.ToInt32(numericUpDownAsistencije.Value); }
        }

        public int Osobne
        {
            get { return Convert.ToInt32(numericUpDownOsobne.Value); }
        }

        private void ComboBoxNatjecanje_Changed(object sender, EventArgs e)
        {
            var utakmice = natjecanjeController.ucitajUtakmiceCombo(comboBoxNatjecanje.SelectedItem as Natjecanje);
            this.UcitajNatjecanjaUtakmice(utakmice);
        }

        private void UcitajNatjecanjaUtakmice(IList<Utakmica> utakmice)
        {
            comboBoxUtakmica.DisplayMember = "Id";
            comboBoxUtakmica.DataSource = utakmice;
        }

        private void ComboBoxUtakmica_Changed(object sender, EventArgs e)
        {
            var statistike = natjecanjeController.ucitajStatistikeCombo(comboBoxUtakmica.SelectedItem as Utakmica);
            this.UcitajStatistike(statistike);
        }

        private void UcitajStatistike(IList<Statistika> statistike)
        {
            comboBoxIgrac.DisplayMember = "Id";
            comboBoxIgrac.DataSource = statistike;
        }

        private void ComboBoxIgrac_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Statistika)e.ListItem).Igrac.ToString();
        }

        private void IgracComboBox_Changed(object sender, EventArgs e)
        {
            numericUpDownOsobne.Value = (comboBoxIgrac.SelectedItem as Statistika).OsobnePogreske;
            numericUpDownKosevi.Value = (comboBoxIgrac.SelectedItem as Statistika).PostignutiKosevi;
            numericUpDownSkokovi.Value = (comboBoxIgrac.SelectedItem as Statistika).Skokovi;
            numericUpDownAsistencije.Value = (comboBoxIgrac.SelectedItem as Statistika).Asistencije;
        }


        public void Message(string m)
        {
            MessageBox.Show(m);
        }

        private void ComboBoxUtakmica_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = "Protivnik: " + ((Utakmica)e.ListItem).ProtivnickiKlub.NazivKluba;
        }
    }
}
