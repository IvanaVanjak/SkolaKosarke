using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;

namespace SkolaKosarke.Common
{
    public interface IDodavanjeIgracaUGrupu
    {
        bool ShowForm();
        Igrac Igrac { get; }
        GrupaTreninga Grupa { get; }
        void Message(string m);
    }
}
