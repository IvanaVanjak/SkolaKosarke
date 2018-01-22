using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;

namespace SkolaKosarke.Common
{
    public interface IPregledClanarina : Observer
    {
        void ShowForm();
        void UcitajIgraceKojiNisuPlatili(string OIB, string igrac, string brojTelefona);
        List<string> CheckedList { get; }
        Clanarina Clanarina { get; }
        void CloseForm();
        void UpdateListView();
    }
}
