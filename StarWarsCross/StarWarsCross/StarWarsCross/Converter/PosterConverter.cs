using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StarWarsUWP.Converters
{
    class PosterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Image img = new Image();
            var fname = (String)value;
            fname = fname.Replace(' ', '_').ToLower() + ".jpg";
            img.Source = FileImageSource.FromFile(fname);

            return img;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
