// Written by Andy Perrett (18684092)
// 30th Sept 2018
// Problem Solving: How many weights needed to weigh all whole kg
// from 1 to (x)kg - 40 being the question asked - using balance scales

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weights
{
    class Program
    {
        // Main
        static void Main(string[] args)
        {
            Console.WriteLine("This program will tell you how many balance weights you need.");
            Console.WriteLine("-------------------------------------------------------------\n");
            Console.Write("Enter max weight: ");
            // Get maximum weight needed
            int weights = numberWeights(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Number of weights: {0}", weights);
            // Display the weights
            Console.WriteLine("The weights are: [{0}]", string.Join(", ", determineWeights(weights)));
            Console.ReadLine();
            // FUNCTIONS

            // Determine the values of each weight
            int[] determineWeights(int nWeights)
            {
                // init weights array
                int[] weightArray = new int[nWeights];
                weightArray[0] = 1;
                for (int n = 1; n < nWeights; n ++)
                {
                    int total = 0;
                    for (int m = 0; m <= n; m++)
                    {
                        total += weightArray[m];
                    }
                    weightArray[n] = 2 * total + 1;
                }
                return (weightArray);
            }

            // Determine how many weights needed
            int numberWeights(int maxWeight)
            {
                for (int n = 1; n < maxWeight; n++)
                {
                    // cubed root could be used with no loop?
                    if (((Math.Pow(3, n) - 1) / 2) >= maxWeight)
                    {
                        // Number of weights found
                        return(n);
                    }
                }
                // default return
                return (0);
            }

        }

    }
}
