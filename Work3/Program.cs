using System;
using System.Collections.Generic;
namespace Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> collection = new HashSet<string>();
            while (true)
            {
                Console.WriteLine("\nВведите число: ");
                string numbers = Console.ReadLine();
                if (collection.Contains(numbers) == true)
                {
                    Console.WriteLine("Число уже вводилось ранее\n");
                    continue;
                }
                collection.Add(numbers);
            }
        }
    }
}