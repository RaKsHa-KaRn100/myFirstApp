using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c = System.Console;

namespace myFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            c.WriteLine("Hello World!!!");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
              
            }
            c.ReadKey();
        }
    }
}
