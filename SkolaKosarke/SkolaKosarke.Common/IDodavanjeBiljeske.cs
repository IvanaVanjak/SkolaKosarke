using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;

namespace SkolaKosarke.Common
{
    public interface IDodavanjeBiljeske
    {
        bool ShowForm();
        Igrac Igrac { get; }
        DateTime Datum { get; }
        String Biljeska { get; }
        void Message(string m);
    }
}
