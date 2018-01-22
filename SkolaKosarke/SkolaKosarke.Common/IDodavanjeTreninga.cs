using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;

namespace SkolaKosarke.Common
{
    public interface IDodavanjeTreninga
    {
        bool ShowForm();
        DateTime Datum { get; }
        GrupaTreninga Grupa { get; }
        List<Igrac> Igraci { get; }
    }
}
