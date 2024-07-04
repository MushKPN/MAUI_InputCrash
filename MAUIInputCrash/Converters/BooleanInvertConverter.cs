using System.Globalization;

namespace MauiTheme.Converters;

public class BooleanInvertConverter : IValueConverter
{
    #region Methods
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return !(bool)value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
    #endregion
}
