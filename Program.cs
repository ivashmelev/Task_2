using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа: ");
            string[] spliteLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int count = spliteLine.Length;
            int[] Arr = new int[count];
            
            for (int i=0; i<count; i++)
            {
                Arr[i] = int.Parse(spliteLine[i]);                
            }
            for (int i=0; i<Arr.Length; i++)
            {
                //Console.Write($" {Arr[i]}");
            }
                int sum = Arr.Sum();
                int average = sum / count;
                Console.WriteLine($"\nСреднее арифметическое: {average}");
            Console.ReadKey();
        }
    }
}
