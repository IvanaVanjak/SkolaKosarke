using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Common;
using SkolaKosarke.Model;
using SkolaKosarke.Model.Repositories;
using SkolaKosarke.Data.Repositories;

namespace SkolaKosarke.Controller
{
    public class GrupaTreningaController : Subject
    {
        IGrupaTreningaRepository gr = new GrupaTreningaRepository();
        IIgracRepository ir = new IgracRepository();

        public void DodajNovuGrupuTreninga(IDodavanjeGrupeTreninga inForm)
        {

            if (inForm.ShowForm())
            {
                try
                {
                    string nazivGrupe = inForm.NazivGrupeTreninga;

                    GrupaTreninga grupa = new GrupaTreninga(nazivGrupe);

                    gr.dodajGrupu(grupa);
                    notifyObservers();
                }
                catch (GrupaTreningaPraznoImeExists)
                {
                    inForm.Message("Unesite ime.");
                }
                catch (GrupaTreningaAlreadyExists)
                {
                    inForm.Message("Grupa treninga već postoji.");
                }
                catch (Exception)
                {
                    inForm.Message("Pogreška prilikom unosa.");
                }
            }
        }

        public void DohvatiGrupeTreninga(IPregledGrupaTreninga inForm)
        {
            addObserver(inForm);
            inForm.ShowForm();
        }

        public void UcitajGrupe(IPregledGrupaTreninga inForm)
        {
            List<GrupaTreninga> grupe = gr.dohvatiSveGrupe();

            foreach (GrupaTreninga g in grupe)
            {
                inForm.UcitajGrupuIgraca(g.NazivGrupe);
                foreach (Igrac i in g.IgraciUGrupi)
                {
                    inForm.UcitajIgraceUGrupi(g.NazivGrupe, i.ToString());
                }
            }
        }

        public IList<Igrac> UcitajIgrace()
        {
            IList<Igrac> igraci = ir.dohvatiSveIgrace();
            return igraci;
        }

        public void DodajIgracaUGrupu(IDodavanjeIgracaUGrupu inForm)
        {

            if (inForm.ShowForm())
            {
                Igrac Igrac = inForm.Igrac;
                GrupaTreninga Grupa = inForm.Grupa;

                try
                {
                    gr.dodajIgracaUGrupu(Igrac, Grupa);
                    notifyObservers();
                }
                catch (IgracDoesntExists) {
                    inForm.Message("Odaberite igrača.");
                }
            }
        }

        public List<GrupaTreninga> UcitajGrupe()
        {
            List<GrupaTreninga> grupe = gr.dohvatiSveGrupe();
            return grupe;
        }
    }
}
