using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;

namespace SkolaKosarke.Common
{
    public interface IDodavanjeClanarine
    {
        bool ShowForm();
        int Mjesec { get; }
        int Godina { get; }
        int Iznos { get; }
        void Message(string m);

    }
}
