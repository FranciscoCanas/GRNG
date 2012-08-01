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
            double ALPHA = 1.0;
            int VARIANCE = 100;
            int TEST_SIZE = 1000;
            double totalNorm=0;
            double totalExp = 0;
            double[] sampleNorm = new double[TEST_SIZE];
            double[] sampleExp = new double[TEST_SIZE];
            
            GRandom rand = new GRandom();

            for (int i = 0; i < TEST_SIZE; i++)
            {
                sampleNorm[i] = rand.GetNormalDouble(MEAN, VARIANCE);
                sampleExp[i] = rand.GetExpDouble(ALPHA);
                Console.WriteLine("Normal Sample " + i + ": " + sampleNorm[i]);
                Console.WriteLine("Expo Sample " + i + ": " + sampleExp[i]);
                totalNorm += sampleNorm[i];
                totalExp += sampleExp[i];
            }

            Console.WriteLine("Normal:");
            Console.WriteLine("Total: " + (totalNorm));
            Console.WriteLine("Mean: " + GRandom.Mean(sampleNorm, TEST_SIZE));
            Console.WriteLine("Variance: " + GRandom.variance(sampleNorm, TEST_SIZE));

            Console.WriteLine("Exponential:");
            Console.WriteLine("Total: " + (totalExp));
            Console.WriteLine("Mean: " + GRandom.Mean(sampleExp, TEST_SIZE));
            Console.WriteLine("Variance: " + GRandom.variance(sampleExp, TEST_SIZE));

            
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\workspace\GRNG\GRNG\samples.txt"))
            {
                file.WriteLine("Normal:");
                foreach (double x in sampleNorm)
                {
                    file.WriteLine(x);
                }
                file.WriteLine("Exponential:");
                foreach (double x in sampleExp)
                {
                    file.WriteLine(x);
                }
            }
        }
    }
}
