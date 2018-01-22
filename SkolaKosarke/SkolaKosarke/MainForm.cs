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

namespace SkolaKosarke
{
    public partial class MainForm : Form
    {

        private IgracController igracController = new IgracController();
        private ProtivnickiKlubController protivnickiKlubController = new ProtivnickiKlubController();
        private GrupaTreningaController grupaTreningaController = new GrupaTreningaController();
        private TreningController treningController = new TreningController();
        private NatjecanjeController natjecanjeController = new NatjecanjeController();
        private BiljeskaOIgracuController biljeskaController = new BiljeskaOIgracuController();
        private ClanarinaController clanarinaController = new ClanarinaController();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void dodavanjeIgracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeIgracaForm frm = new DodavanjeIgracaForm();
            igracController.DodajNovogIgraca(frm);
        }

        private void pregledIgracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledIgracaForm frm = new PregledIgracaForm();
            igracController.DohvatiIgrace(frm);
        }

        private void pregledKlubovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledKlubovaForm frm = new PregledKlubovaForm();
            protivnickiKlubController.DohvatiKlubove(frm);
        }

        private void dodavanjeKlubovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeKlubaForm frm = new DodavanjeKlubaForm();
            protivnickiKlubController.DodajNoviKlub(frm);
        }

        private void pregledGrupaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledGrupaTreningaForm frm = new PregledGrupaTreningaForm();
            grupaTreningaController.DohvatiGrupeTreninga(frm);
        }

        private void dodavanjeGrupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeGrupeTreningaForm frm = new DodavanjeGrupeTreningaForm();
            grupaTreningaController.DodajNovuGrupuTreninga(frm);
        }

        private void dodavanjeIgračaUGrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeIgracaUGrupuForm frm = new DodavanjeIgracaUGrupuForm();
            grupaTreningaController.DodajIgracaUGrupu(frm);
        }

        private void dodavanjeTreningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeTreningaForm frm = new DodavanjeTreningaForm();
            treningController.DodajNoviTrening(frm);
        }

        private void pregledTreningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledTreningaForm frm = new PregledTreningaForm();
            treningController.DohvatiTreninge(frm);
        }

        private void dodavanjeNatjecanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeNatjecanjaForm frm = new DodavanjeNatjecanjaForm();
            natjecanjeController.dodajNovoNatjecanje(frm);
        }

        private void dodavanjeUtakmiceNaNatjecanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeUtakmiceForm frm = new DodavanjeUtakmiceForm();
            natjecanjeController.dodajNovuUtakmicuNaNatjecanje(frm);
        }

        private void dodavanjeStatistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeStatistikeForm frm = new DodavanjeStatistikeForm();
            natjecanjeController.dodajStatistiku(frm);
        }

        private void dodavanjaBilješkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeBiljeskeForm frm = new DodavanjeBiljeskeForm();
            biljeskaController.DodajBiljesku(frm);
        }

        private void pregledBilješkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledBiljeskiForm frm = new PregledBiljeskiForm();
            biljeskaController.DohvatiBiljeske(frm);
        }

        private void dodavanjeClanarineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeClanarineForm frm = new DodavanjeClanarineForm();
            clanarinaController.DodajClanarinu(frm);
        }

        private void pregledČlanarinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledClanarinaForm frm = new PregledClanarinaForm();
            clanarinaController.DohvatiClanarine(frm);
        }

        private void pregledSvihNatjecanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledNatjecanjaForm frm = new PregledNatjecanjaForm();
            natjecanjeController.DohvatiNatjecanja(frm);
        }

        private void izmjenaRangaIBrojaBodovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzmjenaRangaIBrojaBodova frm = new IzmjenaRangaIBrojaBodova();
            natjecanjeController.izmijeni(frm);
        }      
    }
}
