using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model.Factory;

namespace SkolaKosarke.Model.Repositories
{
    public class NatjecanjeRepository2 : INatjecanjeRepository
    {
        private static NatjecanjeRepository2 instance = null;

        List<Natjecanje> natjecanja = new List<Natjecanje>();

        private NatjecanjeRepository2()
        {
            Natjecanje natjecanje = NatjecanjeFactory.CreateNatjecanje("MiniBasket 2014", 2002, "Liga",
                0, 7, 0);
            natjecanja.Add(natjecanje);
            natjecanje = NatjecanjeFactory.CreateNatjecanje("Zadar 2014", 2000, "Turnir",
                0, 3, 0);
            natjecanja.Add(natjecanje);
            natjecanje = NatjecanjeFactory.CreateNatjecanje("Sukošan 2014", 2001, "Turnir",
                0, 3, 0);
            natjecanja.Add(natjecanje);
            natjecanje = NatjecanjeFactory.CreateNatjecanje("Ljetna Liga", 2000, "Liga",
                0, 5, 0);
            natjecanja.Add(natjecanje);
            natjecanje = NatjecanjeFactory.CreateNatjecanje("Bibinje Sukošan", 2001, "Prijateljska utakmica",
                0, 0, 0);
            natjecanja.Add(natjecanje);
        }

        public static NatjecanjeRepository2 getInstance()
        {
            if (instance == null)
                instance = new NatjecanjeRepository2();

            return instance;
        }

        public int Count()
        {
            return natjecanja.Count;
        }

        public void dodajNovoNatjecanje(Natjecanje n)
        {
            if (n.Naziv == "") {
                throw new NatjecanjeNazivPrazno();
            }
            natjecanja.Add(n);
        }

        public List<Natjecanje> dohvatiSvaNatjecanja()
        {
            return natjecanja;
        }

        public void dodajUtakmicuNaNatjecanje(Natjecanje n, Utakmica u)
        {
            n.dodajUtakmicu(u);
        }

        public Natjecanje dohvatiNatjecanjeID(string id)
        {
            foreach (var n in natjecanja)
            {
                if (n.Id.ToString() == id)
                {
                    return n;
                }
            }
            throw new NatjecanjeDoesntExists();
        }

        public IList<Utakmica> dohvatiUtakmiceNaNatjecanju(string natjecanjeId)
        {
            foreach (var n in natjecanja)
            {
                if (n.Id.ToString() == natjecanjeId)
                {
                    return n.Utakmice;
                }
            }
            throw new NatjecanjeDoesntExists();
        }


        public IList<Statistika> dohvatiStatistike(string id)
        {
            foreach (Natjecanje n in natjecanja)
            {
                foreach (Utakmica u in n.Utakmice)
                {
                    if (u.Id.ToString() == id)
                    {
                        return u.StatistikeIgraca;
                    }
                }
            }
            return null;
        }

        public void dodajStatistiku(Natjecanje natjecanje, Utakmica utakmica, Statistika s)
        {
            foreach (Natjecanje n in natjecanja)
            {
                if (n.Id == natjecanje.Id)
                {
                    foreach (Utakmica u in n.Utakmice)
                    {
                        if (u.Id == utakmica.Id)
                        {
                            foreach (Statistika st in u.StatistikeIgraca)
                            {
                                if (st.Igrac.OIB == s.Igrac.OIB)
                                {
                                    st.PostignutiKosevi = s.PostignutiKosevi;
                                    st.Asistencije = s.Asistencije;
                                    st.Skokovi = s.Skokovi;
                                    st.OsobnePogreske = s.OsobnePogreske;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public List<Natjecanje> dohvatiTurnireLige() {
            List<Natjecanje> nat = new List<Natjecanje>();
            foreach (Natjecanje n in natjecanja) {
                if (!(n is PrijateljskaUtakmica)) {
                    nat.Add(n);
                }
            }
            return nat;
        }



        public void izmijeni(Natjecanje n)
        {
            throw new NotImplementedException();
        }
    }
}
