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

namespace SkolaKosarke
{
    public partial class PregledKlubovaForm : Form, IPregledKlubova
    {
        ProtivnickiKlubController klubController = new ProtivnickiKlubController();

        public PregledKlubovaForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void update()
        {
            UcitajKlubove();
        }

        private void UcitajKlubove()
        {

            listViewPregledKlubova.Items.Clear();
            klubController.UcitajKlubove(this);
        }

        public void UcitajKlub(string naziv, string brojTelefona, string ulica, string kucniBroj, 
            string postanskiBroj, string mjesto, string drzava)
        {
            ListViewItem lvt = new ListViewItem(naziv);
            lvt.SubItems.Add(brojTelefona);
            lvt.SubItems.Add(ulica);
            lvt.SubItems.Add(kucniBroj);
            lvt.SubItems.Add(postanskiBroj);
            lvt.SubItems.Add(mjesto);
            lvt.SubItems.Add(drzava);

            listViewPregledKlubova.Items.Add(lvt);
        }

        private void PregledKlubovaForm_Load(object sender, EventArgs e)
        {
            UcitajKlubove();
        }
    }
}
