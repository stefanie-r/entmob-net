using System;
using System.Globalization;
using Xamarin.Forms;

namespace StarWarsUWP.Converters
{
    class RomanConvert : IValueConverter
    {
        public static string To(int number)
        {
            var romanNumerals = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" }; // ones

            // split integer string into array and reverse array
            var intArr = number.ToString();
            var len = intArr.Length;
            var romanNumeral = "";
            var i = len;

            // starting with the highest place (for 3046, it would be the thousands
            // place, or 3), get the roman numeral representation for that place
            // and add it to the final roman numeral string
            while (i-- > 0)
            {
                romanNumeral = romanNumerals[Int32.Parse(intArr)];
            }

            return romanNumeral;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var episode_id = (int)value;
            return "Episode " + To(episode_id);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
