using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //RomanNumberExcaption
                //RomanNumber r1 = new RomanNumber(0);
                RomanNumber r2 = new RomanNumber(28);
                RomanNumber r3 = new RomanNumber(6);
                RomanNumber r4 = new RomanNumber(15);
                RomanNumber r5 = new RomanNumber(38);
                RomanNumber r6 = new RomanNumber(82);
                Console.WriteLine($"Add: {r2.ToString()} + {r6.ToString()} = {RomanNumber.Add(r2, r6).ToString()}");
                Console.WriteLine($"Div: {r2.ToString()} / {r3.ToString()} = {RomanNumber.Div(r2, r3).ToString()}");
                Console.WriteLine($"Sub: {r6.ToString()} - {r5.ToString()} = {RomanNumber.Sub(r6, r5).ToString()}");
                Console.WriteLine($"Mul: {r3.ToString()} * {r4.ToString()} = {RomanNumber.Mul(r3, r4).ToString()}");
                RomanNumber[] r = { r2, r3, r4, r5, r6 };
                Array.Sort(r);
                Console.WriteLine("Result");
                foreach (var el in r)
                {
                    Console.WriteLine(el.ToString());
                }

            }
            catch (RomanNumberException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

        }
    }
}