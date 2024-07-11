using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class TypeConversion
    {
        void Main(string[] args)
        {
            // Implict type conversion
            byte b = 10;
            int i = b; // size of int is 4 bytes and size of byte is 1 byte, so no data loss

            // Explicit type conversion
            int a = 2;
            byte c = (byte)a; // explicit type conversion, data loss

            string s = "1";
            int j = Convert.ToInt32(s); // convert string to int
            j = int.Parse(s); // another way to convert string to int

            try
            {
                var number = "1234";
                byte k = Convert.ToByte(number); // convert string to byte
                Console.WriteLine(k);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number could not be converted to a byte.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
