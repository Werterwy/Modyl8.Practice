using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl8.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1.	В С # индексация начинается с нуля, но в некоторых языках программирования это не так. 
             Например,в Turbo Pascal индексация массиве начинается с 1. Напишите класс RangeOfArray,
              который позволяет работать с массивом такого типа, в котором индексный диапазон устанавливается
             пользователем. Например, в диапазоне от 6 до 10, или от –9 до 15.*/

            Console.Write("Введите начальный индекс: ");
            int startIndex = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размер массива: ");
            int endIndex = Convert.ToInt32(Console.ReadLine());
            RangeOfArray arr = new RangeOfArray(startIndex, endIndex);

            for (int i = startIndex; i <= endIndex; i++)
            {
                arr[i] = i;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
            Console.WriteLine("");

            /*  2.Написать программу «Продуктовый супермаркет»: выбирается ряд продуктов, рассчитывается
                  их сумма с учетом скидки в 5 % (скидка предоставляется, если покупка сделана с 8.00 до 12.00 по текущему времени) */


            ShoppingCart cart = new ShoppingCart();

            // Ввод продуктов и их количество
            Console.WriteLine("Введите продукт и количество (например, Хлеб 2):");
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                string[] parts = input.Split(' ');
                if (parts.Length == 2)
                {
                    string productName = parts[0];
                    if (int.TryParse(parts[1], out int quantity))
                    {
                        cart.AddToCart(productName, quantity);
                    }
                }
                input = Console.ReadLine();
            }

            // Рассчет и вывод информации
            string applyDiscountInput = Console.ReadLine();
            cart.CalculateTotal();
        }
    }
}
