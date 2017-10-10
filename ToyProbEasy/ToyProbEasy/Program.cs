using System;


namespace ToyProbEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int input;
            Int32.TryParse(Console.ReadLine(),out input);

            if(input <= 10)
                Console.WriteLine("This number is too small");
            else if(input > 10)
                Console.WriteLine("This number is big enough");
        }
    }
}
