using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Common;
using SkolaKosarke.Model;
using SkolaKosarke.Data.Repositories;
using SkolaKosarke.Model.Repositories;

namespace SkolaKosarke.Controller
{
    public class ClanarinaController : Subject
    {
        IClanarinaRepository cr = new ClanarinaRepository();
        IIgracRepository ir = new IgracRepository();

        public void DodajClanarinu(IDodavanjeClanarine inForm)
        {

            if (inForm.ShowForm())
            {
                try
                {
                    int mjesec = inForm.Mjesec;
                    int godina = inForm.Godina;
                    int iznos = inForm.Iznos;

                    Clanarina c = new Clanarina(mjesec, godina, iznos);

                    cr.dodajClanarinu(c);
                    notifyObservers();
                }
                catch (ClanarinaAlreadyExists)
                {
                    inForm.Message("Članarina za " + inForm.Mjesec.ToString() + ".mjesec " + inForm.Godina + ". godine je već definirana.");
                }
            }
        }

        public void DohvatiClanarine(IPregledClanarina inForm)
        {
            addObserver(inForm);
            inForm.ShowForm();
        }

        public List<Clanarina> UcitajClanarine()
        {
            return cr.dohvatiClanarine();
        }

        public void UcitajIgrace(IPregledClanarina inForm, Clanarina clanarina)
        {
            List<Igrac> igraci = cr.nisuPlatiliClanarinu(clanarina);

            foreach (Igrac i in igraci)
            {
                inForm.UcitajIgraceKojiNisuPlatili(i.OIB.ToString(), i.ToString(), i.BrojTelefona);
            }
        }

        public void PlatioClanarinu(IPregledClanarina inForm)
        {
            List<string> platili = new List<string>();
            platili = inForm.CheckedList;
            List<Igrac> igraci = new List<Igrac>();

            foreach (string oib in platili)
            {
                var igrac = ir.dohvatiIgracePoOIBu(oib);
                cr.platioClanarinu(inForm.Clanarina, igrac);
                notifyObservers();
            }

            inForm.update();
            inForm.UpdateListView();
        }
    }
}
