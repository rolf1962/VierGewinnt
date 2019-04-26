using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Windows.Media;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    [TestClass]
    public class IstAnDerReiheZuBrushKonverterTests
    {
        IstAnDerReiheZuBrushKonverter _testTarget;

        [TestInitialize]
        public void TestInitialize()
        {
            _testTarget = new IstAnDerReiheZuBrushKonverter();
        }

        [TestMethod]
        public void KonverterGibtTransparentenBrushZurückWennWertFalschIst()
        {
            var brush = (SolidColorBrush)_testTarget.Convert(
                new SpielerViewModel(
                    new Spieler(name: "Foo", spielsteine: new List<Spielstein>(), spielerFarbe: new Farbe(Colors.Transparent.R, Colors.Transparent.G, Colors.Transparent.B)))
                { IstAnDerReihe = false },
                null, null, null);

            Assert.AreEqual(brush.Color, Colors.Transparent);
        }

        [TestMethod]
        public void KonverterGibtBlauenBrushZurückWennWertWahrIst()
        {
            var brush = (SolidColorBrush)_testTarget.Convert(
                new SpielerViewModel(
                    new Spieler(name: "Foo", spielsteine: new List<Spielstein>(), spielerFarbe: new Farbe(Colors.Blue.R, Colors.Blue.G, Colors.Blue.B)))
                { IstAnDerReihe = true },
                null, null, null);

            Assert.AreEqual(brush.Color, Colors.Blue);
        }
    }
}
