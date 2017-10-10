using System;
using System.Text;


namespace ToyProbHard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many rows:");
            int input;
            Int32.TryParse(Console.ReadLine(), out input);


            for (var i = 0; i < (input*2); i++)
                {
                    if (i % 2 != 0)
                    {

                        Console.Write(new string(' ', ((input*2)- 1 - i) / 2));
                        Console.WriteLine(new string('*', i));
                    }
                }
        }
    }
}
