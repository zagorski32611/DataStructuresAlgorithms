using System;
using System.Diagnostics;

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
        public static TimeSpan measureTime()
        {
            int[] nums = new int[100];
            BuildArray(nums);

            TimeSpan startTime;
            TimeSpan duration;

            startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;

            //DisplayNums(nums);
            //MultiplyNumbersByNumbers(nums);
            StackOverflowin(nums);

            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startTime);
            Console.WriteLine($"User Processor Time: {Process.GetCurrentProcess().UserProcessorTime}");
            Console.WriteLine($"Memory Size: {Process.GetCurrentProcess().VirtualMemorySize64}");
            Console.WriteLine($"Milliseconds: {duration.TotalMilliseconds}");
            return duration;
        }

        public static void BuildArray(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                arr[i] = i;
            }
        }

        public static void DisplayNums(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void MultiplyNumbersByNumbers(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                var ii = i * (i + 1);
                var e = ii + i;

                arr[i] = e;
            }
        }

        public static void StackOverflowin(int[] arr)
        {
            if(arr.GetUpperBound(0) <= 10000)
            {
                foreach(int i in arr)
                {
                    arr[i] = (i+1) * 2;
                    StackOverflowin(arr);
                }
            }
        }

        public Object CleanHouse()
        {
            using (Process myprocess = new Process())
            {

            }
            return true;
            
            
        }
    }
}
//GC.WaitForPendingFinalizers();
//GC.Collect();
