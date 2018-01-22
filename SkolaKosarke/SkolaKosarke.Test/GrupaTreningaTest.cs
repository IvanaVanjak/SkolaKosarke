using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;
using SkolaKosarke.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkolaKosarke.Test
{
    [TestClass]
    public class GrupaTreningaTest
    {
        private GrupaTreningaRepository2 repository = GrupaTreningaRepository2.getInstance();

        [TestMethod]
        [ExpectedException(typeof(GrupaTreningaAlreadyExists))]
        public void GrupaIstiNaziv() {
            GrupaTreninga g = new GrupaTreninga("Nova");
            repository.dodajGrupu(g);
            repository.dodajGrupu(g);
        }

        [TestMethod]
        public void IstiIgracUDvijeGrupe()
        {
            Igrac i = new Igrac("Ivan", "Marić", "Ive", "12312312355", new DateTime(1993, 11, 12), "Ante", "Marić", "00000");
            GrupaTreninga g = new GrupaTreninga("Nova1");

            repository.dodajGrupu(g);
            int brojIgracaPrijeDodavanjaG1 = g.IgraciUGrupi.Count;
            
            repository.dodajIgracaUGrupu(i, g);

            Assert.AreEqual(brojIgracaPrijeDodavanjaG1+1, g.IgraciUGrupi.Count);


            GrupaTreninga g2 = new GrupaTreninga("Nova2");
            int brojIgracaPrijeDodavanjaG2 = g2.IgraciUGrupi.Count;

            repository.dodajGrupu(g2);
            repository.dodajIgracaUGrupu(i, g2);

            Assert.AreEqual(brojIgracaPrijeDodavanjaG1, g.IgraciUGrupi.Count);
            Assert.AreEqual(brojIgracaPrijeDodavanjaG2+1, g2.IgraciUGrupi.Count);
        }
        
    }
}
