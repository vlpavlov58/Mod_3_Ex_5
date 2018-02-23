using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_3_Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter finish number: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i%5 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
         
        }
    }
}
