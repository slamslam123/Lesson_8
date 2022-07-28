using System;
using System.Collections.Generic;
namespace Lesson_8
{
    class Program
    {
        static List<int> RemoveElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 25 & numbers[i] <= 50)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine($"Удалены числа от 25 до 50\nОсталось {numbers.Count} чисел");
            return numbers;
        }
        static List<int> OutputToScreen(List<int> numbers)
        {
            foreach (var e in numbers)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine($"Всего выведено {numbers.Count} чисел");
            Console.ReadKey();
            return numbers;
        }
        static List<int> GenerateNumbers(List<int> numbers)
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(r.Next(0, 101));
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            GenerateNumbers(numbers);
            OutputToScreen(numbers);
            RemoveElements(numbers);
            OutputToScreen(numbers);
            Console.ReadKey();
        }
    }
}
