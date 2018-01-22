using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Common
{
    public interface IDodavanjeIgraca
    {
        bool ShowDodavanjeIgracaForm();
        string Ime { get; }
        string Prezime { get;  }
        string Nadimak { get; }
        string OIB { get; }
        string ImeRoditelja { get; }
        string PrezimeRoditelja { get; }
        DateTime DatumRodenja { get; }
        string BrojTelefona { get; }
        void Message(string m);
    }
}
