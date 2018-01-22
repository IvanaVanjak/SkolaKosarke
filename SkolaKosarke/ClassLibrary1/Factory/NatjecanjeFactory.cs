using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Factory
{
    public class NatjecanjeFactory
    {
        public static Natjecanje CreateNatjecanje(string inNaziv, int inGodiste, string inVrsta,
            int inRang, int inBrojKlubova, int inBrojBodova)
        {
            switch (inVrsta)
            {
                case "Liga":
                    return new Liga(inNaziv, inGodiste, inRang, inBrojBodova, inBrojKlubova);
                case "Turnir":
                    return new Turnir(inNaziv, inGodiste, inRang, inBrojKlubova);
                case "Prijateljska utakmica":
                    return new PrijateljskaUtakmica(inNaziv, inGodiste);

            }
            return null;
        }

        public static List<string> GetVrsteNatjecanja()
        {
            var list = new List<string> { "Prijateljska utakmica", "Liga", "Turnir"  };

            return list;
        }
    }
}
