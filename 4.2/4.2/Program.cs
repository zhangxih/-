using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _4._2
{
    public delegate void UseClock();

    public class Clock
    {
        public event UseClock Tick;
        public event UseClock Alarm;
        public void Goon()
        {
            int times = 0 ;
            while (true)
            {
                Thread.Sleep(1000);
                Tick();
                times += 1;
                if (times % 10 == 0)
                {
                    times = 0;
                    Alarm();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            void Ticks()
            {
                Console.WriteLine(DateTime.Now.ToString());
                Console.WriteLine("Tick");
            }

            void Alarms()
            {
                Console.WriteLine(DateTime.Now.ToString());
                Console.WriteLine("Alarm");
            }

            Clock clock = new Clock();
            clock.Tick += Ticks;
            clock.Alarm += Alarms;
            clock.Goon();
        }
    }
}
