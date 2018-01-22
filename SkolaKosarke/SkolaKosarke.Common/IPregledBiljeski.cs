using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;

namespace SkolaKosarke.Common
{
    public interface IPregledBiljeski : Observer
    {
        void ShowForm();
        void UcitajBiljesku(string datum, string biljeska);
    }
}
