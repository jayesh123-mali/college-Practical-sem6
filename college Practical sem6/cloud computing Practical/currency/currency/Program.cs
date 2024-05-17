using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency
{
    class Program
    {
        static void Main(string[] args)
        {
            currencyConverter client = new currencyConverterClient();
            Console.WriteLine("Enter the currency in Indian rupees: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine(client.InrtoDollar(d));
            Console.ReadLine();
       }
    }
}
