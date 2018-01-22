using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Common
{
    public interface IPregledIgraca : Observer
    {
        void UcitajIgraca(string ime, string prezime, string nadimak, string OIB, string datumRodenja, string imeRoditelja,
                string prezimeRoditelja, string brojTelefona);
        void ShowForm();
    }
}
