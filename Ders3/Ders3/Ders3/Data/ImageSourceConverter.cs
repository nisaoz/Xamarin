using System;
using System.Globalization;
using Xamarin.Forms;

namespace Ders3.Data
{
    class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Value'dan image path yani Mfactory class'ının imageurl property'si
            //classta yapılan degisiklikleri xaml'ın bilmesi icin xaml'da xmlns:local diyerek path verdik
            return ImageSource.FromResource("Ders3.Images." + (value ?? ""));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
