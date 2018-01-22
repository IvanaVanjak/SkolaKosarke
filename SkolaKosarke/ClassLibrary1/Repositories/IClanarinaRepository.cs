using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories
{
    public interface IClanarinaRepository
    {
        void dodajClanarinu(Clanarina c);
        void platioClanarinu(Clanarina c, Igrac i);
        List<Clanarina> dohvatiClanarine();
        List<Igrac> nisuPlatiliClanarinu(Clanarina c);
    }
}
