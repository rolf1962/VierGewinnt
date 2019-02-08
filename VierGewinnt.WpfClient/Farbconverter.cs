using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public class Farbconverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var farbe = value as Farbe;
            if (farbe == null)
                throw new ArgumentException($"{nameof(value)} ist keine {nameof(Farbe)}");

            return new SolidColorBrush(Color.FromRgb(farbe.Rot, farbe.Grün, farbe.Blau));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
