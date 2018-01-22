using SkolaKosarke.Common;
using SkolaKosarke.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkolaKosarke
{
    public partial class PregledIgracaForm : Form, IPregledIgraca
    {
        IgracController igraciController = new IgracController();
        

        public PregledIgracaForm()
        {
            InitializeComponent();
        }

        public void ShowForm() {
            this.Show();
        }

        public void update()
        {
            UcitajIgrace();
        }

        private void UcitajIgrace() {

            listViewPregledIgraca.Items.Clear();

            igraciController.UcitajIgrace(this);
        }

        private void PregledIgracaForm_Load(object sender, EventArgs e)
        {
            UcitajIgrace();
        }

        public void UcitajIgraca(string ime, string prezime, string nadimak, string OIB, string datumRodenja, string imeRoditelja, 
                string prezimeRoditelja, string brojTelefona)
        {
            ListViewItem lvt = new ListViewItem(ime);
            lvt.SubItems.Add(prezime);
            lvt.SubItems.Add(nadimak);
            lvt.SubItems.Add(OIB);
            lvt.SubItems.Add(datumRodenja);
            lvt.SubItems.Add(imeRoditelja);
            lvt.SubItems.Add(prezimeRoditelja);
            lvt.SubItems.Add(brojTelefona);

            listViewPregledIgraca.Items.Add(lvt);
        }
    }
}
