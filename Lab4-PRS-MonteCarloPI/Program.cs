using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PRS_MonteCarloPI
{
    class Program
    {
        static void Main(string[] args)
        {
            MonteCarlo monte = new MonteCarlo();
            int input=0;
            int precision=0;
            int numOfIterations = 0;
            try
            {
                Console.WriteLine("1. Number of iterations");
                Console.WriteLine("2. Precision");
                Console.WriteLine("0. End of program");
                input = int.Parse(Console.ReadLine());
                switch(input)
                {
                    case 1:
                        {
                            Console.WriteLine("Insert the number of iterations:");
                            numOfIterations = int.Parse(Console.ReadLine());
                            monte.PIIterations(numOfIterations);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Insert the desired precision:");
                            precision = int.Parse(Console.ReadLine());
                            monte.PIPrecision(precision);
                            break;
                        }
                    case 0:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }
    }
}
