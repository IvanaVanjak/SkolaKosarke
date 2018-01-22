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
    public partial class PregledClanarinaForm : Form, IPregledClanarina
    {
        ClanarinaController clanarinaController = new ClanarinaController();

        public PregledClanarinaForm()
        {
            InitializeComponent();
        }

        private void PregledClanarina_Load(object sender, EventArgs e)
        {
            var clanarine = clanarinaController.UcitajClanarine();
            this.UcitajClanarine(clanarine);
        }

        private void UcitajClanarine(List<Clanarina> clanarine)
        {
            BindingList<Clanarina> bindinglist = new BindingList<Clanarina>(clanarine);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = bindinglist;
            comboBoxClanarina.DisplayMember = "Mjesec";
            comboBoxClanarina.DataSource = bSource;
        }

        private void ComboBoxClanarina_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Clanarina)e.ListItem).Mjesec.ToString() + ". mjesec " + ((Clanarina)e.ListItem).Godina.ToString() + " - " + ((Clanarina)e.ListItem).Iznos.ToString();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void UcitajIgraceKojiNisuPlatili(string oib, string igrac, string brojTelefona)
        {
            ListViewItem lvt = new ListViewItem(oib);
            lvt.SubItems.Add(igrac);
            lvt.SubItems.Add(brojTelefona);

            listView1.Items.Add(lvt);
        }

        public void update()
        {
            var clanarine = clanarinaController.UcitajClanarine();
            this.UcitajClanarine(clanarine);
        }

        private void ComboBoxClanarina_Changed(object sender, EventArgs e)
        {
            UcitajIgrace(comboBoxClanarina.SelectedItem as Clanarina);
        }

        private void UcitajIgrace(Clanarina clanarina)
        {
            listView1.Items.Clear();
            listView1.Show();
            clanarinaController.UcitajIgrace(this, clanarina);
        }

        public List<string> CheckedList {
            get
            {
                ListView.CheckedListViewItemCollection checkedItems = listView1.CheckedItems;
                List<string> platili = new List<string>();

                foreach (ListViewItem item in checkedItems)
                {
                    platili.Add(item.SubItems[0].Text);
                }
                return platili;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clanarinaController.PlatioClanarinu(this);
        }



        public Clanarina Clanarina
        {
            get { return comboBoxClanarina.SelectedItem as Clanarina; }
        }


        public void CloseForm()
        {
           this.Close(); 
        }


        public void UpdateListView()
        {
            UcitajIgrace(comboBoxClanarina.SelectedItem as Clanarina);
        }
    }
}
