using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories
{
    public class TreningRepository2 : ITreningRepository
    {
        private static TreningRepository2 instance = null;

        List<Trening> treninzi = new List<Trening>();

        private TreningRepository2()
        {
        }

        public static TreningRepository2 getInstance()
        {
            if (instance == null)
                instance = new TreningRepository2();

            return instance;
        }

        public int Count()
        {
            return treninzi.Count;
        }

        public void DodajNoviTrening(Trening trening) {
            treninzi.Add(trening);
        }

        public List<Trening> DohvatiSveTreninge() {
            return treninzi;
        }
    }
}
