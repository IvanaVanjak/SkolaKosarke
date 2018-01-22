using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories
{
    public interface  IGrupaTreningaRepository
    {
        void dodajGrupu(GrupaTreninga grupa);
        List<GrupaTreninga> dohvatiSveGrupe();
        void dodajIgracaUGrupu(Igrac igrac, GrupaTreninga grupa);
    }
}
