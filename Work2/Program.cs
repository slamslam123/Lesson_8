using System;
using System.Collections.Generic;
namespace Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что бы закончить вносить данные введите пустую строку");
            Dictionary<string, string> storage = new Dictionary<string, string>();
            bool cycle = true;
            while (cycle)
            {
                Console.WriteLine("Введите номер телефона: ");
                string telephoneNumber = Console.ReadLine();
                if (telephoneNumber == " ")
                {
                    cycle = false;
                    Console.WriteLine("Вы закончили добавлять данные");
                    continue;
                }
                Console.WriteLine("Введите ф.и.о: ");
                string fullName = Console.ReadLine();
                if (fullName == " ")
                {
                    cycle = false;
                    Console.WriteLine("Вы закончили добавлять данные");
                    continue;
                }
                storage.Add(telephoneNumber, fullName);
            }
            Console.WriteLine("Поиск человека по номеру");
            while (true)
            {
                Console.WriteLine("Введите номер телефона: ");
                string number = Console.ReadLine();
                string value = "";
                storage.TryGetValue(number, out value);
                if (storage.TryGetValue(number, out value) == false)
                {
                    Console.WriteLine("Данного номера в списке нет");
                    continue;
                }
                Console.WriteLine($"Этот номер принадлежит : {value} ");
            }
        }
    }
}