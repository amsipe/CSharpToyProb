using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyProbMedium
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var i = 0; i < 50; i++)
            {
                if (i % 10 == 0)
                {
                    Console.Write("\n");
                }
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}
