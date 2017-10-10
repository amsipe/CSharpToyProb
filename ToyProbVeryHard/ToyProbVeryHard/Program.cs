using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyProbVeryHard
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var charList = new List<char>(){'I','G','M','P'};

            char metric;
            float input;
            const string errorMessage = "Invalid type. You can use I,G,M,or P";

            
            while (true)
            {
                Console.WriteLine("Please enter a conversion type. Ex 'I' for Inches to Centimeters.");
                metric = Convert.ToChar(Console.ReadLine().ToUpper());
                //break loop if enter a valid char
                if (charList.Contains(metric))
                {
                    Console.WriteLine("Enter the amount you want to convert.");
                    input = float.Parse(Console.ReadLine());
                    break;
                }
                //show error message if invalid char
                Console.WriteLine(new string('-',errorMessage.Length));
                Console.WriteLine(errorMessage);
                Console.WriteLine(new string('-',errorMessage.Length));
                
            }

            switch (metric)
            {

                case 'I':
                    Console.WriteLine("{0} inches is {1} in centimeters.",input,input*2.54);
                    break;

                case 'G':
                    Console.WriteLine("{0} gallons is {1} in liters.",input,input*3.78541);
                    break;
                case 'M':
                    Console.WriteLine("{0} mile(s) is {1} in kilometers.",input,input*1.60934);
                    break;
                case 'P':
                    Console.WriteLine("{0} pound(s) is {1} in kilograms",input,input*0.453592);
                    break;
                default:
                    break;
            }
            

        }
    }
}
