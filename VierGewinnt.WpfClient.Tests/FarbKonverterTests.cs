using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Media;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    [TestClass]
    public class FarbKonverterTests
    {
        [TestMethod]
        public void FarbkonverterGibtBrsuhZurückMitEntsprechenderRgbColor()
        {
            var farbe = new Farbe(255, 128, 0);
            var testTarget = new FarbKonverter();

            var resultingBrush = (SolidColorBrush)testTarget.Convert(farbe, null, null, null);
            var expectedColor = Color.FromRgb(farbe.Rot, farbe.Grün, farbe.Blau);

            Assert.AreEqual(expectedColor, resultingBrush.Color);
        }
    }
}
