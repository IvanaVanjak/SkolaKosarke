using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;

namespace SkolaKosarke.Common
{
    public interface IDodavanjeStatistike
    {
        bool ShowForm();
        Natjecanje Natjecanje { get; }
        Utakmica Utakmica { get; }
        Statistika Statistika { get; }
        int Kosevi { get; }
        int Skokovi { get; }
        int Asistencije { get;  }
        int Osobne { get; }
        void Message(string m);
    }
}
