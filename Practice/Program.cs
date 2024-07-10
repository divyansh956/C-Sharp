using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("{0:0.000}", 1.2345);

            var dec = 12.45465M;
            Console.WriteLine(string.Format("{0:0.00}", dec));

            double money = -3.3456D;
            Console.WriteLine("$" + money);
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C1"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", new CultureInfo("en-AU")));
        }
    }
}
