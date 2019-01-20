using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core.Tests
{
    [TestClass]
    public class Linientests
    {
        [TestMethod]
        public void VierInEinerReiheWerdenErkannt()
        {
            var plätze = new List<Platz>()
            {
                new Platz(0,0){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(0,1){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(0,2){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(0,3){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")}
            };

            var testTarget = new LinienDummy(plätze);

            var spielername = testTarget.ÜberprüfeObEinSpielerVierInEinerReiheHat();

            Assert.AreEqual("Foo", spielername);
        }

        [TestMethod]
        public void VierInEinerReiheMitUnterbrechungWerdenKorrektErkannt()
        {
            var plätze = new List<Platz>()
            {
                new Platz(0,0){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(0,1){Spielstein=new Spielstein(new Farbe(0,128,0), "Bar")},
                new Platz(0,2){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(0,3){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(0,4){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(0,5){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")}
            };

            var testTarget = new LinienDummy(plätze);

            var spielername = testTarget.ÜberprüfeObEinSpielerVierInEinerReiheHat();

            Assert.AreEqual("Foo", spielername);
        }

        [TestMethod]
        public void KeinGewinnerWirdKorrektErkannt()
        {
            var plätze = new List<Platz>()
            {
                new Platz(0,0){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(0,1){Spielstein=new Spielstein(new Farbe(0,128,0), "Bar")},
                new Platz(0,2){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(0,3){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(0,4),
                new Platz(0,5)
            };

            var testTarget = new LinienDummy(plätze);

            var spielername = testTarget.ÜberprüfeObEinSpielerVierInEinerReiheHat();

            Assert.IsNull(spielername);
        }
    }
}
