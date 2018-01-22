using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class PrijateljskaUtakmica : Natjecanje
    {
        public PrijateljskaUtakmica(string inNaziv, int inGodiste) : base(inNaziv, inGodiste) { }

        public PrijateljskaUtakmica() { }
    }
}
