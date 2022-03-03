using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class RomanNumber : ICloneable, IComparable
    {
        
        private ushort _num;
        private static int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static string[] roman = new string[]
            { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        public RomanNumber(ushort n)
        {
            if (n <= 0) throw new RomanNumberException($"Число {n} меньше либо равно 0");
            else this._num = n;
        }
        public static RomanNumber operator + (RomanNumber? n1, RomanNumber? n2)
        {
            int num = n1._num + n2._num;
            if (num <= 0) throw new RomanNumberException("Не удалось сложить  числа!");
            else
            {
                return new RomanNumber((ushort)num);
            }
        }
        public static RomanNumber operator -(RomanNumber? n1, RomanNumber? n2)
        {
            int num = n1._num - n2._num;
            if (num <= 0) throw new RomanNumberException("Результат вычитания меньше либо равен 0!");
            else
            {
                return new RomanNumber((ushort)num);
            }
        }
        public static RomanNumber operator *(RomanNumber? n1, RomanNumber? n2)
        {
            int num = n1._num * n2._num;
            if (num <= 0) throw new RomanNumberException("Не удалось умножить 2 числа!");
            else
            {
                return new RomanNumber((ushort)num);
            }
        }

        public static RomanNumber operator /(RomanNumber? n1, RomanNumber? n2)
        {

            if (n2._num == 0) throw new RomanNumberException($"Ошибка деления чисел {n1} и {n2}!") ;
            else
            {
                int num = n1._num / n2._num;
                if (num == 0) throw new RomanNumberException($"Ошибка деления чисел {n1} и {n2}");
                else
                {
                    return new RomanNumber((ushort)num);
                }
            }
        }
        public override string ToString()
        {
            int tmp = _num;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 13; i++)
            {
                while (tmp >= values[i])
                {
                    tmp -= (ushort)values[i];
                    result.Append(roman[i]);
                }
            }
            if (result.ToString() == "")
                throw new RomanNumberException("Перевод числа в Римские цифры невозможен");
            else
                return result.ToString();

        }

        public object Clone()
        {

            return new RomanNumber(_num);
        }

        public int CompareTo(object obj)
        {
            if (obj is RomanNumber roman)
                return _num.CompareTo(roman._num);
            else
                throw new RomanNumberException("object is not a RomanNumber");
        }

    }

}