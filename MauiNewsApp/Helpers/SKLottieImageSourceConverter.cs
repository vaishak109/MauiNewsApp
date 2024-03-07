using SkiaSharp.Extended.UI.Controls;
using System.Globalization;

namespace MauiNewsApp.Helpers
{
    public class SKLottieImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;
            Uri uri = new Uri(value.ToString());
            return SKLottieImageSource.FromUri(uri) as SKLottieImageSource;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
