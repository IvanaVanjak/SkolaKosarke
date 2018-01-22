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
    public partial class PregledNatjecanjaForm : Form, IPregledNatjecanja
    {
        NatjecanjeController natjecanjeController = new NatjecanjeController();

        public PregledNatjecanjaForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void UcitajNatjecanje(string id, string naziv, string godiste)
        {
            ListViewItem lvt = new ListViewItem(id);
            lvt.SubItems.Add(naziv);
            lvt.SubItems.Add(godiste);
            listViewNatjecanje.Items.Add(lvt);
        }

        public void update()
        {
            listViewNatjecanje.Items.Clear();
            listViewLige.Items.Clear();
            listViewTurniri.Items.Clear();
            listViewUtakmica.Items.Clear();
            listViewStatistike.Items.Clear();
            UcitajNatjecanja();
        }

        private void UcitajNatjecanja()
        {
            listViewNatjecanje.Items.Clear();
            natjecanjeController.ucitajNatjecanja(this);
        }

        private void PregledNatjecanja_Load(object sender, EventArgs e)
        {
            listViewNatjecanje.Items.Clear();
            listViewLige.Items.Clear();
            listViewTurniri.Items.Clear();
            UcitajNatjecanja();
        }

        private void Natjecanje_Click(object sender, EventArgs e)
        {
            listViewStatistike.Items.Clear();
            listViewUtakmica.Items.Clear();
            var selected = listViewNatjecanje.SelectedItems[0];
            natjecanjeController.ucitajUtakmice(this, selected.Text);
        }

        public void UcitajUtakmice(string id, string datum, string klub, string postignuti, string primljeni)
        {
            ListViewItem lvt = new ListViewItem(id);
            lvt.SubItems.Add(datum);
            lvt.SubItems.Add(klub);
            lvt.SubItems.Add(postignuti);
            lvt.SubItems.Add(primljeni);
            listViewUtakmica.Items.Add(lvt);
        }

        private void PregledNatjecanja_Click(object sender, EventArgs e)
        {
            listViewStatistike.Items.Clear();
            var selected = listViewUtakmica.SelectedItems[0];
            natjecanjeController.ucitajStatistike(this, selected.Text);
        }


        public void UcitajStatistike(string igrac, string kosevi, string skokovi, string asistencije, string osobne)
        {
            ListViewItem lvt = new ListViewItem(igrac);
            lvt.SubItems.Add(kosevi);
            lvt.SubItems.Add(skokovi);
            lvt.SubItems.Add(asistencije);
            lvt.SubItems.Add(osobne);
            listViewStatistike.Items.Add(lvt);
        }


        public void Message(string m)
        {
            MessageBox.Show(m);
        }


        public void UcitajNatjecanje(Natjecanje n)
        {
            
            if (n as PrijateljskaUtakmica != null)
            {
                ListViewItem lvt = new ListViewItem(n.Id.ToString());
                lvt.SubItems.Add(n.Naziv);
                lvt.SubItems.Add(n.Godiste.ToString());
                listViewNatjecanje.Items.Add(lvt);
            }
            else if (n as Liga != null) {
                Liga l = (Liga)n;
                ListViewItem lvt = new ListViewItem(n.Id.ToString());
                lvt.SubItems.Add(n.Naziv);
                lvt.SubItems.Add(n.Godiste.ToString());
                lvt.SubItems.Add(l.Rang.ToString());
                lvt.SubItems.Add(l.BrojKlubova.ToString());
                lvt.SubItems.Add(l.BrojBodova.ToString());
                listViewLige.Items.Add(lvt);
            }
            else if (n as Turnir != null)
            {
                Turnir l = (Turnir)n;
                ListViewItem lvt = new ListViewItem(n.Id.ToString());
                lvt.SubItems.Add(n.Naziv);
                lvt.SubItems.Add(n.Godiste.ToString());
                lvt.SubItems.Add(l.Rang.ToString());
                lvt.SubItems.Add(l.BrojKlubova.ToString());
                listViewTurniri.Items.Add(lvt);
            }
        }

        private void PregledLiga_Click(object sender, EventArgs e)
        {
            listViewUtakmica.Items.Clear();
            listViewStatistike.Items.Clear();
            var selected = listViewLige.SelectedItems[0];
            natjecanjeController.ucitajUtakmice(this, selected.Text);
        }

        private void PregledTurnira_Click(object sender, EventArgs e)
        {
            listViewUtakmica.Items.Clear();
            listViewStatistike.Items.Clear();
            var selected = listViewTurniri.SelectedItems[0];
            natjecanjeController.ucitajUtakmice(this, selected.Text);
        }
    }
}
