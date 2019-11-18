using System;
using System.Collections;
using System.Diagnostics;

namespace DatastructuresandAlgorithms
{
    public class Question3
    {
        Timing time = new Timing();
        public TimeSpan customcollectTime()
        {
            time.StartTime();
            CustomCollection collect = new CustomCollection();
            for (int i = 0; i <= 100000000; i++)
            {
                collect.Add(i);
            }
            time.StopTime();
            Console.WriteLine($"Custom Collection time: {time.Result()}");
            return time.Result();
        }

        public TimeSpan ArrayListTime()
        {
            time.StartTime();
            for (int i = 0; i <= 100000000; i++)
            {
                ArrayList array = new ArrayList();
                array.Add(i);
            }
            time.StopTime();
            Console.WriteLine($"Array List Time: {time.Result()}");
            return time.Result();
        }
    }
}



/*

            int[] nums = new int[10000];
            BuildArray(nums);
            Timing timeObject = new Timing();

            timeObject.StartTime();
            timeObject.StopTime();

            var results = timeObject.Result();

            Console.WriteLine($"Total Time, .NET: {results.TotalMilliseconds} milliseconds");
            Console.WriteLine($"Total Time, .NET: {results.TotalSeconds} seconds");
            Console.WriteLine($"Total Time, .NET: {results.Ticks} ticks lol");
            return true;
            */