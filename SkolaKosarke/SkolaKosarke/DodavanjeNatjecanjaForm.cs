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

namespace SkolaKosarke
{
    public partial class DodavanjeNatjecanjaForm : Form, IDodavanjeNatjecanja
    {
        NatjecanjeController natjecanjeController = new NatjecanjeController();

        public DodavanjeNatjecanjaForm()
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


        public string Naziv
        {
            get { return textBoxNaziv.Text; }
        }

        public int Godiste
        {
            get { return Convert.ToInt32(numericUpDownGodiste.Value); }
        }

        public int Rang
        {
            get { return Convert.ToInt32(numericUpDownRang.Value); }
        }

        public int BrojKlubova
        {
            get { return Convert.ToInt32(numericUpDownBrojKlubova.Value); }
        }

        public int BrojBodova
        {
            get { return Convert.ToInt32(numericUpDownBrojBodova.Value); }
        }


        public string Vrsta
        {
            get { return comboBoxVrsta.Text; }
        }

        private void DodavanjeNatjecanja_Load(object sender, EventArgs e)
        {
            var vrste = natjecanjeController.ucitajVrste();
            this.UcitajVrste(vrste);
        }

        private void UcitajVrste(List<string> vrste)
        {
            comboBoxVrsta.DataSource = vrste;
        }

        private void ComboBoxVrsta_Changed(object sender, EventArgs e)
        {
            switch (comboBoxVrsta.SelectedItem.ToString()) { 
                case "Liga":
                    labelRang.Show();
                    numericUpDownRang.Show();
                    labelBrojKlubova.Show();
                    numericUpDownBrojKlubova.Show();
                    labelBrojBodova.Show();
                    numericUpDownBrojBodova.Show();
                    break;
                case "Turnir":
                    labelRang.Show();
                    numericUpDownRang.Show();
                    labelBrojKlubova.Show();
                    numericUpDownBrojKlubova.Show();
                    labelBrojBodova.Hide();
                    numericUpDownBrojBodova.Hide();
                    break;
                case "Prijateljska utakmica":
                    labelRang.Hide();
                    numericUpDownRang.Hide();
                    labelBrojKlubova.Hide();
                    numericUpDownBrojKlubova.Hide();
                    labelBrojBodova.Hide();
                    numericUpDownBrojBodova.Hide();
                    break;
            }
        }


        public void Message(string m)
        {
            MessageBox.Show(m);
        }
    }
}
