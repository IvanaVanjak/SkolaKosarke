using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Common
{
    public interface IDodavanjeNatjecanja
    {
        bool ShowForm();
        string Naziv { get; }
        int Godiste { get; }
        string Vrsta { get; }
        int Rang { get; }
        int BrojKlubova { get; }
        int BrojBodova { get; }
        void Message(string m);
    }
}
