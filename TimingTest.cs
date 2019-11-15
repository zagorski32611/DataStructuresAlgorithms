using System;

namespace DatastructuresandAlgorithms
{
    /*
    This class will create a method to Benchmark code we create.
    Our benchmarks will be timing tests that measure the amount of time it
    takes an algorithm to run to completion.
    */
    public class TimingTest
    {
        // First we'll need some really simple code to test:

        public static void DisplayNums(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{i}");
            }
        }
        public static TimeSpan measureTime()
        {
            DateTime startTime;
            TimeSpan endTime;

            startTime = DateTime.Now;
            endTime = DateTime.Now.Subtract(startTime);

            Console.WriteLine($"{endTime}");

            return endTime;
        }
    }
}