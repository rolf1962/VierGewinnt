using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core.Tests
{
    [TestClass]
    public class Spaltentests
    {
        [TestMethod]
        public void SpielsteinWirdKorrektInLeereSpalteEingefügt()
        {
            var plätze = new List<Platz>();

            for(int i=0;i<6;i++)
            {
                plätze.Add(new Platz());
            }

            var testTarget = new Spalte(plätze);
            var spielstein = new Spielstein(new Farbe(0, 0, 0), "Foo");

            testTarget.LasseSpielsteinFallen(spielstein);

            for(var i=0;i<plätze.Count;i++)
            {
                if (i == 0)
                {
                    Assert.AreEqual(spielstein, plätze[0].Spielstein);
                    continue;
                }

                Assert.IsNull(plätze[i].Spielstein);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void LasseSpielsteinFallenLöstExceptionAusWennSpalteVollIst()
        {
            var spielstein = new Spielstein(new Farbe(0, 0, 0), "Foo");
            var plätze = new List<Platz>();

            for (int i = 0; i < 6; i++)
            {
                plätze.Add(new Platz() { Spielstein = spielstein });
            }

            var testTarget = new Spalte(plätze);

            testTarget.LasseSpielsteinFallen(spielstein);
        }

        [TestMethod]
        public void IstSpalteVollGibtFalseZurückWennNichAllePlätzeVollSind()
        {
            var spielstein = new Spielstein(new Farbe(0, 0, 0), "Foo");
            var plätze = new List<Platz>();

            for (int i = 0; i < 6; i++)
            {
                plätze.Add(new Platz());
            }

            plätze[0].Spielstein = spielstein;
            plätze[1].Spielstein = spielstein;
            var testTarget = new Spalte(plätze);

            Assert.IsFalse(testTarget.IstSpalteVoll);
        }

        [TestMethod]
        public void IstSpalteVollGibtTrueZurückWennAllePlätzeVollSind()
        {
            var spielstein = new Spielstein(new Farbe(0, 0, 0), "Foo");
            var plätze = new List<Platz>();

            for (int i = 0; i < 6; i++)
            {
                plätze.Add(new Platz() { Spielstein = spielstein });
            }

            var testTarget = new Spalte(plätze);

            Assert.IsTrue(testTarget.IstSpalteVoll);
        }
    }
}
