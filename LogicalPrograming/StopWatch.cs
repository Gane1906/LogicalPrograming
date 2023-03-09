using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    public class StopWatch
    {
        const string START = "start", STOP = "stop";
        public void calculateTime()
        {
            Console.WriteLine("Enter' strat' to start the stop watch");
            String start = Console.ReadLine();
            TimeSpan timeSpan = TimeSpan.Zero;
            if (start.Equals(START))
            {

                int hour1 = timeSpan.Hours;
                int min1 = timeSpan.Minutes;
                int sec1 = timeSpan.Seconds;
                int ms1 = timeSpan.Milliseconds;
                Console.WriteLine("Enter 'stop' to end the stop watch");
                string stop = Console.ReadLine();
                if (stop.Equals(STOP))
                {
                    int hour2 = timeSpan.Hours;
                    int min2 = timeSpan.Minutes;
                    int sec2 = timeSpan.Seconds;
                    int ms2 = timeSpan.Milliseconds;
                    Console.WriteLine("Stop watch time " + (hour2 - hour1) + ":" + (min2 - min1) + ":" + (sec2 - sec1) + ":" + (ms2 - ms1));
                }
            }

        }         
    }
}
