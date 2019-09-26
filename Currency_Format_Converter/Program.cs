using System;
using System.Globalization;

namespace Currency_Format_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up the variables and prompting the user for their numbers
            Console.WriteLine("Please enter 3 numbers in U.S. Dollars. \nFirst Number: ");
            decimal num1 = Math.Round(decimal.Parse(Console.ReadLine()), 2);
            Console.WriteLine("Second Number: ");
            decimal num2 = Math.Round(decimal.Parse(Console.ReadLine()), 2);
            Console.WriteLine("Third Number: ");
            decimal num3 = Math.Round(decimal.Parse(Console.ReadLine()), 2);
            decimal[] numArray = new decimal[] { num1, num2, num3 };
            decimal totalInt = num1 + num2 + num3;
            decimal average = Math.Round((num1 + num2 + num3)/3, 2);
            decimal smallest = num1;
            decimal largest = num1;
            NumberFormatInfo enUS = new CultureInfo("en-US").NumberFormat;
            NumberFormatInfo svSE = new CultureInfo("sv-SE").NumberFormat;
            NumberFormatInfo jaJP = new CultureInfo("ja-JP").NumberFormat;
            NumberFormatInfo thTH = new CultureInfo("th-TH").NumberFormat;

            // Determining the largest and smallest numbers
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] < smallest)
                {
                    smallest = numArray[i];
                }

                if (numArray[i] > largest)
                {
                    largest = numArray[i];
                }
            }

            // Printing the average, smallest, and largest. Also converting the currencies
            Console.WriteLine("Average : {0}\nSmallest: {1}\nLargest : {2}", average, smallest, largest);
            decimal swedishTotalInt = Math.Round(totalInt * 9.7m, 2);
            int japaneseTotalInt = Decimal.ToInt32(Math.Round(totalInt * 108.21m));
            decimal thaiTotalInt = Math.Round(totalInt * 30.51m, 2);
            string total  = totalInt.ToString( "C", enUS);
            string swedishTotal = totalInt.ToString("C", svSE);
            string japaneseTotal = totalInt.ToString("C", jaJP);
            string thaiTotal = totalInt.ToString("C", thTH);
            // Please note that certain symbols may not show up and may print their currency code
            Console.WriteLine("Total Amount in US Dollars   : {0}\nTotal Amount in Swedish Krona: {1}\n" +
                              "Total Amount in Japanese Yen : {2}\nTotal Amount in Thai Baht    : {3}",
                              total, swedishTotal, japaneseTotal, thaiTotal);
        }
    }
}
