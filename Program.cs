using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

           
           
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

           
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

           
            Console.WriteLine("\nArray elements:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nSum of the elements: {sum}");
            Console.WriteLine($"Average of the elements: {average:F2}");
            Console.ReadKey();
        }
    }
}
