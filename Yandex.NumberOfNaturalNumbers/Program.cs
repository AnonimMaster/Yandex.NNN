using System;
using System.Collections.Generic;
using System.Linq;

namespace Yandex.NumberOfNaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод: натуральное число n\nВывод: количество простых чисел строго меньше n");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 4)
            {
                Console.Write("Данное число не соотвествует условиям задачи, так как кол-во натуральных чисел равен N");
                return;
            }

            List<int> numberList = new List<int>(n);
            for (int r = 0; r < n; r++)
            {
                numberList.Add(r);
            }

            numberList[1] = 0;
            int i = 2;
            int j;
            while (i<n)
            {
                if (numberList[i] != 0)
                {
                    j = i + i;
                    while (j < n)
                    {
                        numberList[j] = 0;
                        j += i;
                    }
                }
                i++;
            }

            numberList = numberList.Where(i => i != 0).ToList();
            numberList.Insert(0,0);
            numberList.Insert(1,1);

            foreach (var i1 in numberList)
            {
                Console.Write($"{i1} ");
            }

            Console.WriteLine($"\nКол-во простых чисел:{numberList.Count}");
        }
    }
}
