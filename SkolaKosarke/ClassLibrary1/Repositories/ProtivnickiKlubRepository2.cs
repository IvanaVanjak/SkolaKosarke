using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model.Factory;

namespace SkolaKosarke.Model.Repositories
{
    public class ProtivnickiKlubRepository2 : IProtivnickiKlubRepository
    {
        private static ProtivnickiKlubRepository2 instance = null;

        List<ProtivnickiKlub> klubovi = new List<ProtivnickiKlub>();

        private ProtivnickiKlubRepository2()
        {
            ProtivnickiKlub pk = ProtivnickiKlubFactory.createProtivnickiKlub("Zadar", "023/333-222",
                "Ive Andrića", "45a", 23000, "Zadar", "Hrvatska");
            klubovi.Add(pk);
            pk = ProtivnickiKlubFactory.createProtivnickiKlub("Pristan", "023/345-876",
                "Marka Marulića", "10", 23222, "Sv. Filip i Jakov", "Hrvatska");
            klubovi.Add(pk);
            pk = ProtivnickiKlubFactory.createProtivnickiKlub("Bibinje", "023/261-222",
                "Marina Držića", "21", 23205, "Bibinje", "Hrvatska");
            klubovi.Add(pk);
            pk = ProtivnickiKlubFactory.createProtivnickiKlub("Pakoštane", "023/345-987",
                "Augusta Šenoe", "34", 23399, "Pakoštane", "Hrvatska");
            klubovi.Add(pk);
        }

        public static ProtivnickiKlubRepository2 getInstance()
        {
            if (instance == null)
                instance = new ProtivnickiKlubRepository2();

            return instance;
        }

        public int Count()
        {
            return klubovi.Count;
        }

        public void dodajKlub(ProtivnickiKlub klub)
        {
            if(klub.NazivKluba == "" || klub.BrojTelefona == ""){
                throw new KlubPraznoPolje();
            }
            foreach (ProtivnickiKlub k in klubovi)
            {
                if (k.NazivKluba == klub.NazivKluba)
                {
                    throw new KlubAlreadyExists();
                }
            }
            klubovi.Add(klub);
        }

        public List<ProtivnickiKlub> dohvatiSveKlubove()
        {
            return new List<ProtivnickiKlub>(klubovi);
        }
    }
}
