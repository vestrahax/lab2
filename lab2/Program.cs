using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RomanNumber n1 = new RomanNumber(15); RomanNumber n2 = new RomanNumber(4); RomanNumber n3 = new RomanNumber(10);
                RomanNumber n4 = new RomanNumber(50); RomanNumber n5 = new RomanNumber(89);
                Console.WriteLine($"Сложение: {n1.ToString()} + {n5.ToString()} = {(n1 + n5).ToString()}");
                Console.WriteLine($"Деление: {n1.ToString()} / {n2.ToString()} = {(n1 / n2).ToString()}");
                Console.WriteLine($"Вычитание: {n5.ToString()} - {n4.ToString()} = {(n5 - n4).ToString()}");
                Console.WriteLine($"Умножение: {n2.ToString()} * {n3.ToString()} = {(n2 * n3).ToString()}");

                RomanNumber[] numbers = { n1, n2, n3, n4, n5 };
                Array.Sort(numbers);
                Console.WriteLine("Результат сортировки \n");
                foreach (var el in numbers)
                {
                    Console.WriteLine($"{el.ToString()} \n");
                }

            }
            catch (RomanNumberException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

        }
    }
}