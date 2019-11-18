using System;
using System.Diagnostics;

namespace DatastructuresandAlgorithms
{
    public class Timing
    {
        TimeSpan startingTime;
        TimeSpan duration;


        public Timing()
        {
            startingTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }

        public object StopTime()
        {
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);
            return duration;

        }

        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            startingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        }
        
        public TimeSpan Result()
        {
            return duration;
        }
    }
}