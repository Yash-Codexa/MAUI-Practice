using System;
using System.Globalization;

namespace PagesDemo.Convertors;

public class BoolConvertors : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var answer = value?.ToString();
        if (answer == "Yes")
        {
            return true;
        }
        return false;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var boolean = (bool)value;
        if (boolean)
        {
            return "Yes";
        }
        return "No";
    }
}
