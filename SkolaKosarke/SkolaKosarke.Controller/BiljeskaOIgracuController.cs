using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;
using SkolaKosarke.Common;
using SkolaKosarke.Model.Repositories;
using SkolaKosarke.Data.Repositories;

namespace SkolaKosarke.Controller
{
    public class BiljeskaOIgracuController : Subject
    {
        IBiljeskaOIgracuRepository br = new BiljeskaOIgracuRepository();
        IIgracRepository ir = new IgracRepository();

        public void DodajBiljesku(IDodavanjeBiljeske inForm)
        {

            if (inForm.ShowForm())
            {
                try
                {
                    Igrac Igrac = inForm.Igrac;
                    DateTime Datum = inForm.Datum;
                    string Biljeska = inForm.Biljeska;

                    BiljeskaOIgracu b = new BiljeskaOIgracu(Igrac, Datum, Biljeska);

                    br.dodajBiljesku(b);
                    notifyObservers();
                }
                catch (BiljeskaTekstPrazno) {
                    inForm.Message("Unesite tekst bilješke.");
                }
            }
        }

        public IList<Igrac> UcitajIgrace()
        {
            return ir.dohvatiSveIgrace();
        }

        public void DohvatiBiljeske(IPregledBiljeski inForm)
        {
            addObserver(inForm);
            inForm.ShowForm();
        }

        public void UcitajBiljeske(IPregledBiljeski inForm, Igrac igrac)
        {
            List<BiljeskaOIgracu> biljeske = br.dohvatiBiljeskeOIgracu(igrac);

            foreach (BiljeskaOIgracu b in biljeske)
            {
                inForm.UcitajBiljesku(b.Datum.ToShortDateString(), b.Biljeska);
            }
        }
    }
}
