using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[int.Parse(Console.ReadLine())];
            for(int i=0;i< array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            Console.WriteLine($"最大值为{max}");
            int min = 9999999;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine($"最小值为{min}");
            int average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            Console.WriteLine($"所有数组元素的和为{average}");
            average /= array.Length;
            Console.WriteLine($"平均值为{average}");

        }
    }
}
