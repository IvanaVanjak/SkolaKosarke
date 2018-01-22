using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Common;
using SkolaKosarke.Model;
//using SkolaKosarke.Model.Repositories;
using SkolaKosarke.Data.Repositories;
using SkolaKosarke.Model.Repositories;

namespace SkolaKosarke.Controller
{
    public class TreningController : Subject
    {
        ITreningRepository tr = new TreningRepository();
        IGrupaTreningaRepository gr = new GrupaTreningaRepository();

        public void DodajNoviTrening(IDodavanjeTreninga inForm)
        {

            if (inForm.ShowForm())
            {
                DateTime Datum = inForm.Datum;
                GrupaTreninga Grupa = inForm.Grupa;
                List<Igrac> Igraci = inForm.Igraci;

                Trening trening = new Trening(Datum, Grupa.NazivGrupe, Igraci);

                tr.DodajNoviTrening(trening);
                notifyObservers();
            }
        }

        public IList<GrupaTreninga> UcitajGrupe()
        {
            IList<GrupaTreninga> grupe = gr.dohvatiSveGrupe();
            return grupe;
        }

        public IList<Igrac> DohvatiIgraceUgrupi(GrupaTreninga grupa) {
            return grupa.IgraciUGrupi;
        }

        public void DohvatiTreninge(IPregledTreninga inForm)
        {
            addObserver(inForm);
            inForm.ShowForm();
        }

        public void UcitajTreninge(IPregledTreninga inForm)
        {
            IList<Trening> treninzi = tr.DohvatiSveTreninge();

            foreach (Trening t in treninzi) {
                inForm.UcitajTrening(t.Id.ToString(), t.Datum.ToShortDateString(), t.Grupa);
                foreach (Igrac i in t.IgraciNaTreningu)
                {
                    inForm.UcitajIgraceNaTreningu(t.Id.ToString(), t.Datum.ToShortDateString(), t.Grupa, i.ToString());
                }
            
            }
        }
    }
}
