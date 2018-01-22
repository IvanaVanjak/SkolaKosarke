using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkolaKosarke.Model;
using SkolaKosarke.Model.Repositories;
using System;
using System.Collections.Generic;

namespace SkolaKosarke.Test
{
    [TestClass]
    public class IgracTest
    {
        private IgracRepository2 igracRepository = IgracRepository2.getInstance();

        [TestMethod]
        [ExpectedException(typeof(IgracNadimakAlreadyExists))]
        public void IstoImePrezimeNadimak()
        {
            string ime = "Ivana";
            string prezime = "Vanjak";
            string nadimak = "Ivanks";
            Igrac i = new Igrac(ime, prezime, nadimak, "11100022233", new DateTime(1991, 11, 12), "Ivan", "Vanjak", "00000");
            Igrac i2 = new Igrac(ime, prezime, nadimak, "33322244455", new DateTime(1992, 10, 9), "Ivan", "Vanjak", "00000");

            igracRepository.dodajIgraca(i);
            igracRepository.dodajIgraca(i2);
        }

        [TestMethod]
        [ExpectedException(typeof(IgracOIBAlreadyExists))]
        public void IgracIstiOib() 
        {
            string oib = "11122233344";
            Igrac i = new Igrac("Ivan", "Ivić", "a", oib, new DateTime(1991, 11, 12), "Ivan", "Vanjak", "00000");
            Igrac i2 = new Igrac("Marko", "Perić", "r", oib, new DateTime(1992, 10, 9), "Ivan", "Vanjak", "00000");

            igracRepository.dodajIgraca(i);
            igracRepository.dodajIgraca(i2);

        }

        [TestMethod]
        public void IgraciMladeIliJednakoGodiste()
        {
            int brojIgracaPrijeDodavanja = IgracRepository2.getInstance().dohvatiIgraceMladeIliJednake(2002).Count;

            Igrac i = new Igrac("Ivan", "Marić", "Ive", "12312312355", new DateTime(1993, 11, 12), "Ante", "Marić", "00000");
            Igrac i2 = new Igrac("Marko", "Perić", "Maki", "99988877766", new DateTime(2002, 10, 9), "Mate", "Perić", "00000");


            igracRepository.dodajIgraca(i);
            igracRepository.dodajIgraca(i2);

            Assert.AreEqual(brojIgracaPrijeDodavanja+1, IgracRepository2.getInstance().dohvatiIgraceMladeIliJednake(2002).Count);
        }
    }
}
