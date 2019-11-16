using System;

namespace DatastructuresandAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chapter 1 Part 1
            CustomCollection.usingCollection();
            // Chapter 1 Part 2
            //PlaceholderDataType.place_and_swap();

            // Chapter 1 Part 3 Timing Test
            //int[] x = new int[6] { 1, 2, 3, 4, 5, 6 };
            //
            //TimingTest.DisplayNums(x);
            //TimingTest.measureTime();
            
            ActualTimeTest att = new ActualTimeTest();
            att.TestThis();
        }
    }
}
