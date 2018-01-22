using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Common
{
    public interface IDodavanjeGrupeTreninga
    {
        bool ShowForm();
        string NazivGrupeTreninga { get; }
        void Message(string m);
    }
}
