using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            num = int.Parse(Console.ReadLine());
            int flag = (int)Math.Sqrt(num);
            int factor = 2;
            for (; factor <= flag; factor++)
            {
                while (num % factor == 0)
                {
                    Console.Write($"{factor},");
                    num /= factor;
                }
            }
            if (num >= factor)
                Console.Write(factor);
        }
    }
}
