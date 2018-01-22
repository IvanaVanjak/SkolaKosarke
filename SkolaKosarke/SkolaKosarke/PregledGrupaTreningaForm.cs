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
    public partial class PregledGrupaTreningaForm : Form, IPregledGrupaTreninga
    {
        GrupaTreningaController grupaTreningaController = new GrupaTreningaController();

        public PregledGrupaTreningaForm()
        {
            InitializeComponent();
        }

        private void PregledGrupa_Load(object sender, EventArgs e)
        {
            UcitajGrupe();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void update()
        {
            UcitajGrupe();
        }

        private void UcitajGrupe()
        {

            treeViewPregledavanjeGrupaTreninga.Nodes.Clear();
            grupaTreningaController.UcitajGrupe(this);
        }

        public void UcitajGrupuIgraca(string naziv)
        {
            TreeNode node = new TreeNode(naziv);
            node.Name = naziv;

            treeViewPregledavanjeGrupaTreninga.Nodes.Add(node);
            treeViewPregledavanjeGrupaTreninga.EndUpdate();
        }

        public void UcitajIgraceUGrupi(string grupa, string igrac)
        {
            TreeNode[] node = treeViewPregledavanjeGrupaTreninga.Nodes.Find(grupa, true);
            node[0].Nodes.Add(new TreeNode(igrac.ToString()));
        }
    }
}
