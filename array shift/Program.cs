﻿using System;

namespace array_shift
{
    class Program
    {
        static void Main(string[] args)
        {
            const int namber = 7;
            int[] array = new int[namber] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nУкажите число сдвига влево!");
            int left = int.Parse(Console.ReadLine());
            for (int i = 0; i < left; ++i)
            {
                int arrayLast = array[namber - 1];
                for (int j = namber - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                    array[0] = arrayLast;
                }
            }
            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < namber; ++i)
            {
                Console.Write(" " + array[i]);
            }
        }
    }
}
/*Дан массив чисел. 
 *Нужно его сдвинуть циклически на указанное пользователем значение позиций влево, 
 *не используя других массивов. 
 *Пример для сдвига один раз: {1, 2, 3, 4} => {2, 3, 4, 1}*/