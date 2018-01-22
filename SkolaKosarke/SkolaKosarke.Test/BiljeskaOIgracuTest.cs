using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;
using SkolaKosarke.Model.Repositories;

namespace SkolaKosarke.Test
{
    [TestClass]
    public class BiljeskaOIgracuTest
    {
        BiljeskaOIgracuRepository2 repository = BiljeskaOIgracuRepository2.getInstance();
        [TestMethod]
        [ExpectedException(typeof(BiljeskaTekstPrazno))]
        public void praznoPolje()
        {
            Igrac i = new Igrac("Ivana", "Marić", "Ive", "12316777355", new DateTime(1993, 11, 12), "Ante", "Marić", "00000");
            BiljeskaOIgracu b = new BiljeskaOIgracu(i, DateTime.Now, "");

            repository.dodajBiljesku(b);
        }

    }
}
