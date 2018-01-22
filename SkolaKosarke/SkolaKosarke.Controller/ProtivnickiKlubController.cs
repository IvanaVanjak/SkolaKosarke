using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Common;
using SkolaKosarke.Model;
using SkolaKosarke.Model.Factory;
using SkolaKosarke.Data.Repositories;
using SkolaKosarke.Model.Repositories;

namespace SkolaKosarke.Controller
{
    public class ProtivnickiKlubController : Subject
    {
        IProtivnickiKlubRepository r = new ProtivnickiKlubRepository();

        public void DodajNoviKlub(IDodavanjeKluba inForm)
        {

            if (inForm.ShowForm())
            {
                try
                {
                    string nazivKluba = inForm.NazivKluba;
                    string brojTelefona = inForm.BrojTelefona;
                    string ulica = inForm.Ulica;
                    string kucniBroj = inForm.KucniBroj;
                    long postanskiBroj = Convert.ToInt64(inForm.PostanskiBroj);
                    string mjesto = inForm.Mjesto;
                    string drzava = inForm.Drzava;

                    ProtivnickiKlub klub = ProtivnickiKlubFactory.createProtivnickiKlub(nazivKluba, brojTelefona,
                        ulica, kucniBroj, postanskiBroj, mjesto, drzava);

                    r.dodajKlub(klub);
                    notifyObservers();
                }
                catch (KlubPraznoPolje) {
                    inForm.Message("Popunite sva polja.");
                }
                catch (KlubAlreadyExists)
                {
                    inForm.Message("Klub s istim imenom već postoji");
                }
                catch (Exception)
                {
                    inForm.Message("Pogreška prilikom unosa.");
                }
            }
        }

        public void DohvatiKlubove(IPregledKlubova inForm)
        {
            addObserver(inForm);
            inForm.ShowForm();
        }

        public void UcitajKlubove(IPregledKlubova inForm)
        {
            List<ProtivnickiKlub> klubovi = new List<ProtivnickiKlub>();
            klubovi = r.dohvatiSveKlubove();
            foreach (ProtivnickiKlub k in klubovi)
            {
                inForm.UcitajKlub(k.NazivKluba, k.BrojTelefona, k.Adresa.Ulica, k.Adresa.KucniBroj,
                    k.Adresa.PostanskiBroj.ToString(), k.Adresa.Mjesto, k.Adresa.Drzava);
            }
        }
    }
}
