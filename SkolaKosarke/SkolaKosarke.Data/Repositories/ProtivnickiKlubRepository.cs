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
    public class ProtivnickiKlubRepository : IProtivnickiKlubRepository
    {
        public ProtivnickiKlubRepository()
        {
        }

        public void dodajKlub(ProtivnickiKlub klub)
        {
            List<ProtivnickiKlub> klubovi = dohvatiSveKlubove();
            if (klub.NazivKluba == "" || klub.BrojTelefona == "")
            {
                throw new KlubPraznoPolje();
            }
            foreach (ProtivnickiKlub k in klubovi)
            {
                if (k.NazivKluba == klub.NazivKluba)
                {
                    throw new KlubAlreadyExists();
                }
            }
            using (ISession session = FluentNHibernate.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(klub);
                    transaction.Commit();
                }
            }
        }

        public List<ProtivnickiKlub> dohvatiSveKlubove()
        {
            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<ProtivnickiKlub> query = (from i in nSession.Query<ProtivnickiKlub>()
                                                     orderby i.NazivKluba
                                                     select i);
                List<ProtivnickiKlub> klubovi = query.ToList<ProtivnickiKlub>();
                return klubovi.ToList();
            }
        }
    }
}
