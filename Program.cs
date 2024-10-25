using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace lab_4_A_та_P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[9];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 51);
            }

            Console.WriteLine("Вихідний масив: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }



            int product = 1;
            bool hasMultipleOf5 = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 5 == 0 && array[i] != 0)
                {
                    product *= array[i];
                    hasMultipleOf5 = true;
                }
            }


            if (hasMultipleOf5 == true)
            {
                Console.WriteLine($"Добуток елементів, кратних до 5: {product}");
            }
            else
            {
                Console.WriteLine("У масиві немає елементів, кратних до 5.");
            }
            Console.ReadKey();

        }
    }
}
