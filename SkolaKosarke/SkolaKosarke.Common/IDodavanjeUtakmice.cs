using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;

namespace SkolaKosarke.Common
{
    public interface IDodavanjeUtakmice
    {
        bool ShowForm();
        Natjecanje Natjecanje { get; }
        DateTime Datum { get; }
        ProtivnickiKlub Klub { get; }
        int BrojPostignutihKoseva { get; }
        int BrojPrimljenihKoseva { get; }
        List<Igrac> Igraci { get; }
        void Message(string m);
    }
}
