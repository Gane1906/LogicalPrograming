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
            DateTime timeSpan = DateTime.Now;
            if (start.Equals(START))
            {

                int hour1 = timeSpan.Hour;
                int min1 = timeSpan.Minute;
                int sec1 = timeSpan.Second;
                int ms1 = timeSpan.Millisecond;
                Console.WriteLine("Enter 'stop' to end the stop watch");
                string stop = Console.ReadLine();
                if (stop.Equals(STOP))
                {
                    DateTime timeSpan1=DateTime.Now;
                    int hour2 = timeSpan1.Hour;
                    int min2 = timeSpan1.Minute;
                    int sec2 = timeSpan1.Second;
                    int ms2 = timeSpan1.Millisecond;
                    Console.WriteLine("Stop watch time " + (hour2 - hour1) + ":" + (min2 - min1) + ":" + (sec2 - sec1) + ":" + (ms2 - ms1));
                }
            }

        }         
    }
}
