using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PRS_MonteCarloPI
{
         class MonteCarlo
        {
        Random random = new Random();
        public void PIIterations(int numOfIterations)
        {
            double pointX = 0;
            double pointY = 0;
            double radius = 0;
            int circleCounter = 0;
            int squareCounter = 0;
            if(numOfIterations>0)
            {
                for(int i=0;i<numOfIterations;i++)
                {
                    pointX = random.NextDouble();
                    pointY = random.NextDouble();
                    radius = Math.Sqrt(pointX * pointX + pointY * pointY);
                    if(radius<1)
                    {
                        circleCounter++;
                        squareCounter++;
                    }
                    else
                    {
                        squareCounter++;
                    }
                }
                double PI = (double)(4*(circleCounter/(double)squareCounter));
                Console.WriteLine($"The estimated value of pi is {PI}. The real value of pi is {Math.PI}");
                Console.WriteLine($"The difference between the programs calculation and the real value is {Math.PI - PI}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public void PIPrecision(int precision)
        {
            double pointX = 0;
            double pointY = 0;
            double radius = 0;
            int circleCounter = 0;
            int squareCounter = 0;
            int numOfIterations = 0;
            double difference=1/(Math.Pow(10,precision));
            double PI = 0;
            do
            {
                pointX = random.NextDouble();
                pointY = random.NextDouble();
                radius = Math.Sqrt(pointX * pointX + pointY * pointY);
                if (radius < 1)
                {
                    circleCounter++;
                    squareCounter++;
                }
                else
                {
                    squareCounter++;
                }
                PI = (double)(4*(circleCounter/(double)squareCounter));
                numOfIterations++;
            }
            while (Math.Abs(PI - Math.PI) > difference);
            Console.WriteLine($"The estimated value of pi is {PI}");

        }
    }
}
