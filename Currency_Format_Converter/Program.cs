using System;

namespace Currency_Format_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 numbers in U.S. Dollars. \nFirst Number: ");
            decimal num1 = Math.Round(decimal.Parse(Console.ReadLine()), 2);
            Console.WriteLine("Second Number: ");
            decimal num2 = Math.Round(decimal.Parse(Console.ReadLine()), 2);
            Console.WriteLine("Third Number: ");
            decimal num3 = Math.Round(decimal.Parse(Console.ReadLine()), 2);
            decimal total = num1 + num2 + num3;
            decimal average = Math.Round((num1 + num2 + num3)/3, 2);
            decimal smallest = num1;
            decimal largest = num1;
            if (num2 < num1) 
            {
                smallest = num2;
            } else if (num3 < num1)
            {
                smallest = num3;
            }
            if (num2 > num1) 
            {
                largest = num2;
            } else if (num3 > num1)
            {
                largest = num3;
            }
            Console.WriteLine("Average : {0}\nSmallest: {1}\nLargest : {2}", average, smallest, largest);
            decimal swedishTotal = Math.Round(total * 9.7m, 2);
            int japaneseTotal = Decimal.ToInt32(Math.Round(total * 108.21m));
            decimal thaiTotal = Math.Round(total * 30.51m, 2);
            Console.WriteLine("Total Amount in US Dollars   : ${0}\nTotal Amount in Swedish Krona: {1}kr\n" +
                              "Total Amount in Japanese Yen : ¥{2}\nTotal Amount in Thai Baht    : ฿{3}",
                              total, swedishTotal, japaneseTotal, thaiTotal);
        }
    }
}
