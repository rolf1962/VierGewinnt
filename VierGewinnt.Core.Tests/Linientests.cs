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
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")}
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
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(){Spielstein=new Spielstein(new Farbe(0,128,0), "Bar")},
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")}
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
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(){Spielstein=new Spielstein(new Farbe(0,128,0), "Bar")},
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(){Spielstein=new Spielstein(new Farbe(128,0,0), "Foo")},
                new Platz(),
                new Platz()
            };

            var testTarget = new LinienDummy(plätze);

            var spielername = testTarget.ÜberprüfeObEinSpielerVierInEinerReiheHat();

            Assert.IsNull(spielername);
        }
    }
}
