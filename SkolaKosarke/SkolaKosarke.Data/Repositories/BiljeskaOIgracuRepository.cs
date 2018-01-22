using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;

using SkolaKosarke.Model;
using SkolaKosarke.Model.Repositories;
using NHibernate;

namespace SkolaKosarke.Data.Repositories
{
    public class BiljeskaOIgracuRepository : IBiljeskaOIgracuRepository
    {
        
        public  BiljeskaOIgracuRepository()
        {
        }


        public void dodajBiljesku(BiljeskaOIgracu b)
        {
            if (b.Biljeska == "")
            {
                throw new BiljeskaTekstPrazno();
            }
            using (ISession session = FluentNHibernate.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(b);
                    transaction.Commit();
                }
            }
        }

        public List<BiljeskaOIgracu> dohvatiSveBiljeske()
        {
            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<BiljeskaOIgracu> query = (from i in nSession.Query<BiljeskaOIgracu>()
                                                     orderby i.Datum descending
                                                     select i);
                List<BiljeskaOIgracu> biljeske = query.ToList<BiljeskaOIgracu>();
                return biljeske;
            }
        }

        public List<BiljeskaOIgracu> dohvatiBiljeskeOIgracu(Igrac i)
        {
            List<BiljeskaOIgracu> bilj = new List<BiljeskaOIgracu>();

            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<BiljeskaOIgracu> query = (from b in nSession.Query<BiljeskaOIgracu>()
                                                     where b.Igrac.OIB == i.OIB
                                                     orderby b.Datum descending
                                                     select b);
                List<BiljeskaOIgracu>  biljeske = query.ToList<BiljeskaOIgracu>();
                return biljeske;
            }
        }
    }
}

