using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;

namespace SkolaKosarke.Common
{
    public interface IIzmjenaRangaIBodova
    {
        bool ShowForm();
        int Rang { get; }
        int BrojBodova { get; }
        Natjecanje Natjecanje { get; }
    }
}
