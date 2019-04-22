using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Helper
{
    public class Logics
    {
        public static string ToTitle(string input)
        {
            return System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(input);
        }
    }
}
