using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Common;
using SkolaKosarke.Model;
using SkolaKosarke.Model.Repositories;
using SkolaKosarke.Data.Repositories;

namespace SkolaKosarke.Controller
{
    public class IgracController : Subject
    {
        IIgracRepository r = new IgracRepository();

        public void DodajNovogIgraca(IDodavanjeIgraca inForm)
        {

            if (inForm.ShowDodavanjeIgracaForm())
            {
                try
                {
                    string Ime = inForm.Ime;
                    string Prezime = inForm.Prezime;
                    string Nadimak = inForm.Nadimak;
                    string OIB = inForm.OIB;
                    string ImeRoditelja = inForm.ImeRoditelja;
                    string PrezimeRoditelja = inForm.PrezimeRoditelja;
                    DateTime DatumRodenja = inForm.DatumRodenja;
                    string BrojTelefona = inForm.BrojTelefona;

                    Igrac igrac = new Igrac(Ime, Prezime, Nadimak, OIB, DatumRodenja, ImeRoditelja, PrezimeRoditelja, BrojTelefona);
                    r.dodajIgraca(igrac);
                    notifyObservers();
                }
                catch (IgracPraznoPolje) {
                    inForm.Message("Popunite sva polja.");
                }
                catch (OIBLengthException)
                {
                    inForm.Message("OIB mora imati 11 znamenaka.");
                }
                catch (OIBFormatException)
                {
                    inForm.Message("OIB smije sadržavati samo znamenke.");
                }
                catch (IgracOIBAlreadyExists)
                {
                    inForm.Message("Igrač s istim OIB-om već postoji.");
                }
                catch (IgracNadimakAlreadyExists)
                {
                    inForm.Message("Igrač s istim imenom, prezimenom i nadimkom već postoji.");
                }
                catch (Exception)
                {
                    inForm.Message("Pogreška prilikom unosa.");
                }
            }
        }

        public void DohvatiIgrace(IPregledIgraca inForm)
        {
            addObserver(inForm);
            inForm.ShowForm();
        }

        public void UcitajIgrace(IPregledIgraca inForm)
        {
            IList<Igrac> igraci = new List<Igrac>();
            igraci = r.dohvatiSveIgrace();
            
            foreach (Igrac i in igraci)
            {
                inForm.UcitajIgraca(i.Ime, i.Prezime, i.Nadimak, i.OIB.ToString(), i.DatumRodenja.ToShortDateString(), i.ImeRoditelja, i.PrezimeRoditelja, i.BrojTelefona);
            }
        }

    }
}
