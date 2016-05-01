using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace argsecho
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var count = 0;
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"{i} : '{args[i]}'");
                count++;
            }

            Console.WriteLine($"{count} argument(s)");
            Console.WriteLine("Press any key to exit");

            Console.ReadKey(true);
        }
    }
}