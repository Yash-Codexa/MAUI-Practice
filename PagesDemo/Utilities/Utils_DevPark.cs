using System;
using System.Text.RegularExpressions;

namespace PagesDemo.Utilities;

public static class Utils_DevPark
{
    public static string GetName(this ContentPage page)
        {
            return Regex.Replace(page.GetType().Name, "([a-z])([A-Z])", "$1 $2");
        }
}
