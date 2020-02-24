using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[101];
            for(int i=2; i < 101; i++)
            {
                array[i] = i;
            }
            for(int i = 2; i < 101; i++)
            {
                if (array[i] == 0)
                    continue;
                Console.Write($"{array[i]},");
                for(int j = i + 1; j < 101; j++)
                {
                    if (array[j] % array[i] == 0)
                        array[j] = 0;
                }
            }
        }
    }
}
