using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blueDigitalKwengo
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Please insert the kwegonian numbers to translate.";

            if (args.Length > 0)
            {
                var chars = Kwengo.ConvertKwengoToRoman(args[0]);

                if (chars == "?")
                {
                    Console.WriteLine(msg);
                    return;
                }


                var r = Roman.RomanToDecimal(chars);

                Console.WriteLine("------------------------\n");
                Console.WriteLine("Input: " + args[0]);
                Console.WriteLine("Console Kwegonian Numbers in C#\r");
                Console.WriteLine("------------------------\n");
                Console.WriteLine("Output: " + r);
            }
            else
                Console.WriteLine(msg);

        }

    }
}