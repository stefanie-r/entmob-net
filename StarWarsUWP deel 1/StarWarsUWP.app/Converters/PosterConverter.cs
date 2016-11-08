using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace StarWarsUWP.app.Converters
{
    public class PosterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            BitmapImage img = new BitmapImage();
            var fname = (String)value;
            fname = fname.Replace(' ', '_').ToLower();
            img.UriSource = new Uri("ms-appx:///Assets/" + fname + ".jpg");

            return img;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}

