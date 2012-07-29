using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GRNG
{
    class Program
    {
        /** 
         * Just a short test.
         **/
        static public void Main()
        {
            int MEAN = 50;
            int VARIANCE = 100;
            int TEST_SIZE = 1000;
            double total=0;
            double[] sample = new double[TEST_SIZE];
            
            GRandom rand = new GRandom();

            for (int i = 0; i < TEST_SIZE; i++)
            {
                sample[i] = rand.GetNormalDouble(MEAN, VARIANCE);
                Console.WriteLine(sample[i]);
                total += sample[i];
            }

            Console.WriteLine("Total: " + (total));
            Console.WriteLine("Mean: " + GRandom.Mean(sample, TEST_SIZE));
            Console.WriteLine("Variance: " + GRandom.variance(sample, TEST_SIZE));
        }
    }
}
