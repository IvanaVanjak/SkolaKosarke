using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Common
{
    public interface IDodavanjeKluba
    {
        bool ShowForm();
        string NazivKluba { get; }
        string BrojTelefona { get; }
        string Ulica { get; }
        string KucniBroj { get; }
        string PostanskiBroj { get; }
        string Mjesto { get; }
        string Drzava { get; }
        void Message(string m);
    }
}
