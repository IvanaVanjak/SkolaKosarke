using NHibernate;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using SkolaKosarke.Model.Repositories;

namespace SkolaKosarke.Data.Repositories
{
    public class NatjecanjeRepository : INatjecanjeRepository
    {
        public NatjecanjeRepository()
        {
        }

        public void dodajNovoNatjecanje(Natjecanje n)
        {
            if (n.Naziv == "")
            {
                throw new NatjecanjeNazivPrazno();
            }
            using (ISession session = FluentNHibernate.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(n);
                    transaction.Commit();
                }
            }
        }

        public List<Natjecanje> dohvatiSvaNatjecanja()
        {
            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<Natjecanje> query = (from i in nSession.Query<Natjecanje>()
                                                select i);
                List<Natjecanje> natjecanja = query.ToList<Natjecanje>();
                return natjecanja;
            }
        }

        public void dodajUtakmicuNaNatjecanje(Natjecanje n, Utakmica u)
        {
            using (ISession session = FluentNHibernate.OpenSession())
            {
                n.dodajUtakmicu(u);

                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(n);
                    transaction.Commit();
                }
            }
        }

        public Natjecanje dohvatiNatjecanjeID(string id)
        {
            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<Natjecanje> query = (from i in nSession.Query<Natjecanje>()
                                                where i.Id.ToString() == id
                                                select i);
                Natjecanje natjecanja = query.ToList<Natjecanje>().ElementAt(0);
                return natjecanja;
            }
            throw new NatjecanjeDoesntExists();
        }

        public IList<Utakmica> dohvatiUtakmiceNaNatjecanju(string natjecanjeId)
        {
            Natjecanje n = dohvatiNatjecanjeID(natjecanjeId);
            return n.Utakmice;
            throw new NatjecanjeDoesntExists();
        }


        public IList<Statistika> dohvatiStatistike(string id)
        {

            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<Utakmica> query = (from i in nSession.Query<Utakmica>()
                                              where i.Id.ToString() == id
                                              orderby i.Datum descending
                                              select i);
                Utakmica u = query.ToList<Utakmica>().ElementAt(0);
                return u.StatistikeIgraca;
            }

        }

        public void dodajStatistiku(Natjecanje natjecanje, Utakmica utakmica, Statistika s)
        {

            using (ISession session = FluentNHibernate.OpenSession())
            {
                if (s != null)
                {
                    s.PostignutiKosevi = s.PostignutiKosevi;
                    s.Asistencije = s.Asistencije;
                    s.Skokovi = s.Skokovi;
                    s.OsobnePogreske = s.OsobnePogreske;


                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Update(s);
                        transaction.Commit();
                    }
                }
            }
        }

        public List<Natjecanje> dohvatiTurnireLige()
        {
            List<Natjecanje> nat = new List<Natjecanje>();
            List<Natjecanje> natjecanja = dohvatiSvaNatjecanja();
            foreach (Natjecanje n in natjecanja)
            {
                if (!(n is PrijateljskaUtakmica))
                {
                    nat.Add(n);
                }
            }
            return nat;
        }



        public void izmijeni(Natjecanje n)
        {
            using (ISession session = FluentNHibernate.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(n);
                    transaction.Commit();
                }
            }
        }
    }
}

