using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories
{
    public class BiljeskaOIgracuRepository2 : IBiljeskaOIgracuRepository
    {
        private static BiljeskaOIgracuRepository2 instance = null;

        List<BiljeskaOIgracu> biljeske = new List<BiljeskaOIgracu>();

        private BiljeskaOIgracuRepository2()
        {
        }

        public static BiljeskaOIgracuRepository2 getInstance()
        {
            if (instance == null)
                instance = new BiljeskaOIgracuRepository2();

            return instance;
        }

        public int Count()
        {
            return biljeske.Count;
        }

        public void dodajBiljesku(BiljeskaOIgracu b)
        {
            if (b.Biljeska == "") {
                throw new BiljeskaTekstPrazno();
            }
            biljeske.Add(b);
        }

        public List<BiljeskaOIgracu> dohvatiSveBiljeske()
        {
            return biljeske;
        }

        public List<BiljeskaOIgracu> dohvatiBiljeskeOIgracu(Igrac i) {
            List<BiljeskaOIgracu> bilj = new List<BiljeskaOIgracu>();

            foreach (BiljeskaOIgracu b in biljeske) {
                if (b.Igrac.OIB == i.OIB) {
                    bilj.Add(b);
                }
            }
            return bilj;
            
        }

        
    }
}
