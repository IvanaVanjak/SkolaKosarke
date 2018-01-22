using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories
{
    public interface ITreningRepository
    {
        void DodajNoviTrening(Trening trening);
        List<Trening> DohvatiSveTreninge();
    }
}
