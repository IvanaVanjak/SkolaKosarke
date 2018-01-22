using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Common;
using SkolaKosarke.Model;
//using SkolaKosarke.Model.Repositories;
using SkolaKosarke.Model.Factory;
using SkolaKosarke.Data.Repositories;
using SkolaKosarke.Model.Repositories;

namespace SkolaKosarke.Controller
{
    public class NatjecanjeController : Subject
    {
        INatjecanjeRepository nr = new NatjecanjeRepository();
        IProtivnickiKlubRepository pr = new ProtivnickiKlubRepository();
        IIgracRepository ir = new IgracRepository();

        public void dodajNovoNatjecanje(IDodavanjeNatjecanja inForm)
        {

            if (inForm.ShowForm())
            {
                try
                {
                    Natjecanje n = NatjecanjeFactory.CreateNatjecanje(inForm.Naziv, inForm.Godiste, inForm.Vrsta, inForm.Rang,
                        inForm.BrojKlubova, inForm.BrojBodova);

                    nr.dodajNovoNatjecanje(n);
                    notifyObservers();
                }
                catch (NatjecanjeNazivPrazno) {
                    inForm.Message("Unesite naziv natjecanja.");
                }
                catch (Exception)
                {
                    inForm.Message("Pogreška kod unosa.");
                }
            }

        }

        public List<string> ucitajVrste()
        {
            return NatjecanjeFactory.GetVrsteNatjecanja();
        }

        public void dodajNovuUtakmicuNaNatjecanje(IDodavanjeUtakmice inForm)
        {
            if (inForm.ShowForm())
            {
                try
                {
                    DateTime Datum = inForm.Datum;
                    Natjecanje Natjecanje = inForm.Natjecanje;
                    ProtivnickiKlub Protivnicki = inForm.Klub;
                    int BrojPostignutih = inForm.BrojPostignutihKoseva;
                    int brojPrimljenih = inForm.BrojPrimljenihKoseva;
                    List<Igrac> Igraci = inForm.Igraci;
                    

                    Utakmica u = new Utakmica(Datum, Protivnicki, BrojPostignutih, brojPrimljenih);
                    List<Statistika> statistike = new List<Statistika>();
                    foreach (Igrac i in Igraci)
                    {
                        Statistika s = new Statistika(i, u);
                        statistike.Add(s);
                    }
                    u.StatistikeIgraca = statistike;

                    nr.dodajUtakmicuNaNatjecanje(Natjecanje, u);
                    notifyObservers();
                }
                catch (Exception) {
                    inForm.Message("Pogreška prilikom unosa.");
                }
            }
        }

        public List<Natjecanje> ucitajNatjecanjaCombo()
        {
            return nr.dohvatiSvaNatjecanja();
        }

        public List<ProtivnickiKlub> ucitajProtivnickeKluboveCombo()
        {
            return pr.dohvatiSveKlubove();
        }

        public IList<Igrac> DohvatiIgraceMladeIliJednake(int p)
        {
            return ir.dohvatiIgraceMladeIliJednake(p);
        }

        public void DohvatiNatjecanja(IPregledNatjecanja inForm)
        {
            addObserver(inForm);
            inForm.ShowForm();
        }

        public void ucitajNatjecanja(IPregledNatjecanja inForm)
        {
            List<Natjecanje> natjecanja = new List<Natjecanje>();
            natjecanja = nr.dohvatiSvaNatjecanja();
            foreach (Natjecanje n in natjecanja)
            {
                inForm.UcitajNatjecanje(n);
            }
        }

        public void ucitajUtakmice(IPregledNatjecanja inForm, string idNatjecanje)
        {
            try
            {
                IList<Utakmica> utakmice = new List<Utakmica>();
                utakmice = nr.dohvatiUtakmiceNaNatjecanju(idNatjecanje);
                foreach (Utakmica u in utakmice)
                {
                    inForm.UcitajUtakmice(u.Id.ToString(), u.Datum.ToShortDateString(), u.ProtivnickiKlub.NazivKluba, u.BrojPostignutihKoseva.ToString(), u.BrojPrimljenihKoseva.ToString());
                }
            }
            catch (NatjecanjeDoesntExists)
            {
                inForm.Message("Natjecanje ne postoji.");
            }
            catch (Exception)
            {
                inForm.Message("Greška.");
            }

        }

        public void ucitajStatistike(IPregledNatjecanja inForm, string p)
        {
            IList<Statistika> statistike = new List<Statistika>();
            statistike = nr.dohvatiStatistike(p);
            foreach (Statistika s in statistike)
            {
                inForm.UcitajStatistike(s.Igrac.ToString(), s.PostignutiKosevi.ToString(), s.Skokovi.ToString(),
                    s.Asistencije.ToString(), s.OsobnePogreske.ToString());
            }
        }

        public void dodajStatistiku(IDodavanjeStatistike inForm)
        {
            if (inForm.ShowForm())
            {
                try
                {
                    inForm.Statistika.Asistencije = inForm.Asistencije;
                    inForm.Statistika.PostignutiKosevi = inForm.Kosevi;
                    inForm.Statistika.OsobnePogreske = inForm.Osobne;
                    inForm.Statistika.Skokovi = inForm.Skokovi;

                    nr.dodajStatistiku(inForm.Natjecanje, inForm.Utakmica, inForm.Statistika);
                    notifyObservers();
                }
                catch (Exception)
                {
                    inForm.Message("Pogreška prilikom unosa.");
                }
            }
        }

        public IList<Utakmica> ucitajUtakmiceCombo(Natjecanje n)
        {
            return nr.dohvatiUtakmiceNaNatjecanju(n.Id.ToString());
        }

        public IList<Statistika> ucitajStatistikeCombo(Utakmica utakmica)
        {
            return nr.dohvatiStatistike(utakmica.Id.ToString());
        }

        public IList<Natjecanje> ucitajTurnireILigeCombo()
        {
            return nr.dohvatiTurnireLige();
        }

        public void izmijeni(IIzmjenaRangaIBodova inForm)
        {
            if (inForm.ShowForm())
            {
                Natjecanje nat = inForm.Natjecanje;
                if (nat is Liga) {
                    ((Liga)nat).BrojBodova = inForm.BrojBodova;
                    ((Liga)nat).Rang = inForm.Rang;
                    nr.izmijeni(nat);
                }
                else if (nat is Turnir) {
                    ((Turnir)nat).Rang = inForm.Rang;
                    nr.izmijeni(nat);
                }
                    notifyObservers();
                
            }
        }
    }
}
