using System;
using System.Diagnostics;

namespace DatastructuresandAlgorithms
{
    public class ActualTimeTest
    {
        public object TestThis()
        {
            int[] nums = new int[10000];

            BuildArray(nums);

            Timing timeObject = new Timing();

            timeObject.StartTime();

            DisplayNums(nums);

            timeObject.StopTime();

            var results = timeObject.Result();

            Console.WriteLine($"Total Time, .NET: {results.TotalMilliseconds} milliseconds");
            Console.WriteLine($"Total Time, .NET: {results.TotalSeconds} seconds");
            Console.WriteLine($"Total Time, .NET: {results.Ticks} ticks lol");
            return true;
        }

        public static void DisplayNums(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void BuildArray(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                arr[i] = i;
            }
        }

    }
}