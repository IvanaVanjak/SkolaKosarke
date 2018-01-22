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
    public partial class PregledTreningaForm : Form, IPregledTreninga
    {
        TreningController treningController = new TreningController();

        public PregledTreningaForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void update()
        {
            UcitajTreninge();
        }

        private void UcitajTreninge()
        {
            treeViewTreninzi.Nodes.Clear();
            treningController.UcitajTreninge(this);
        }


        public void UcitajTrening(string id, string datum, string grupa)
        {
            TreeNode node = new TreeNode("Trening" + id + ": " + datum + " " +grupa );
            node.Name = id;

            treeViewTreninzi.Nodes.Add(node);
            treeViewTreninzi.EndUpdate();
        }

        public void UcitajIgraceNaTreningu(string id,string datum, string grupa, string igrac)
        {
            TreeNode[] node = treeViewTreninzi.Nodes.Find(id, true);
            node[0].Nodes.Add(new TreeNode(igrac));
        }

        private void PregledTreninga_Load(object sender, EventArgs e)
        {
            UcitajTreninge();
        }
    }
}
