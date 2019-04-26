using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace VierGewinnt.WpfClient
{
    public class IstAnDerReiheZuBrushKonverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var spielerViewModel = value as ISpielerViewModel;
            if (spielerViewModel == null)
                throw new ArgumentException($"{nameof(value)} ist kein {nameof(ISpielerViewModel)}");

            if (spielerViewModel.IstAnDerReihe)
            {
                var spielerFarbe = spielerViewModel.Spieler.SpielerFarbe;
                return new SolidColorBrush(Color.FromRgb(spielerFarbe.Rot, spielerFarbe.Grün, spielerFarbe.Blau));
            }

            return new SolidColorBrush(Colors.Transparent);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
