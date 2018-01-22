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
    public partial class PregledBiljeskiForm : Form, IPregledBiljeski
    {
        BiljeskaOIgracuController biljeskaController = new BiljeskaOIgracuController();

        public PregledBiljeskiForm()
        {
            InitializeComponent();
        }

        private void ComboBoxIgrac_Changed(object sender, EventArgs e)
        {
            UcitajBiljeske(comboBoxIgrac.SelectedItem as Igrac);
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void UcitajBiljeske(Igrac igrac) {
            listViewBiljeska.Items.Clear();
            listViewBiljeska.Show();
            biljeskaController.UcitajBiljeske(this, igrac);
        }

        public void UcitajBiljesku(string datum, string biljeska)
        {
            ListViewItem lvt = new ListViewItem(datum);
            lvt.SubItems.Add(biljeska);

            listViewBiljeska.Items.Add(lvt);
        }

        private void ComboBoxIgrac_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Igrac)e.ListItem).ToString();
        }

        private void PregledBiljeski_Load(object sender, EventArgs e)
        {
            var igraci = biljeskaController.UcitajIgrace();
            this.UcitajIgrace(igraci);
        }

        private void UcitajIgrace(IList<Igrac> igraci)
        {
            comboBoxIgrac.DisplayMember = "Ime";
            comboBoxIgrac.DataSource = igraci;
        }

        public void update()
        {
            UcitajBiljeske(comboBoxIgrac.SelectedItem as Igrac);
        }
    }
}
