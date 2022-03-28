using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of all supported standard date and time format specifiers.
            string[] formats = {"d", "D", "f", "F", "g", "G", "m", "o", "r",
                          "s", "t", "T", "u", "U", "Y"};
            // Create an array of four cultures.
            CultureInfo[] cultures = {CultureInfo.GetCultureInfo("de-DE"),
                                CultureInfo.GetCultureInfo("en-US"),
                                CultureInfo.GetCultureInfo("es-ES"),
                                CultureInfo.GetCultureInfo("fr-FR")};
            // Define date to be displayed.
            DateTime dateToDisplay = new DateTime(2008, 10, 31, 17, 4, 32);

            // Iterate each standard format specifier.
            foreach (string formatSpecifier in formats)
            {
                foreach (CultureInfo culture in cultures)
                    Console.WriteLine("{0} Format Specifier {1, 10} Culture {2, 40}",
                                      formatSpecifier, culture.Name,
                                      dateToDisplay.ToString(formatSpecifier, culture));
                Console.WriteLine();
            }
        }
    }
}
