using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl8.Practice
{
    class ShoppingCart
    {
        private Dictionary<string, decimal> products;
        private Dictionary<string, int> shoppingCart;
        public ShoppingCart()
        {
            // Определение списка продуктов и их цен
            products = new Dictionary<string, decimal>
                {
                    { "Хлеб", 2.0M },
                    { "Молоко", 1.5M },
                    { "Яйца", 1.2M },
                    { "Фрукты", 3.0M },
                };
            shoppingCart = new Dictionary<string, int>();
        }

        public void AddToCart(string productName, int quantity)
        {
            // Добавление продукта в корзину
            if (products.ContainsKey(productName))
            {
                shoppingCart[productName] = quantity;
            }
            else
            {
                Console.WriteLine("Продукт не найден.");
            }
        }

        public void CalculateTotal()
        {
            // Рассчет суммы покупки
            decimal totalAmount = 0.0M;

            foreach (var item in shoppingCart)
            {
                if (products.ContainsKey(item.Key))
                {
                    totalAmount += products[item.Key] * item.Value;
                }
            }

                decimal discount = 0.0M;
                DateTime currentTime = DateTime.Now;
                if (currentTime.Hour >= 8 && currentTime.Hour < 12)
                {
                    discount = 0.05M; // 5% скидка
                }

                totalAmount -= totalAmount * discount;

            DisplayCartContents();
            Console.WriteLine($"Итого: {totalAmount}");
        }

        public void DisplayCartContents()
        {
            // Вывод содержимого корзины
            Console.WriteLine("Продукты в корзине:");
            foreach (var item in shoppingCart)
            {
                Console.WriteLine($"{item.Key}: {item.Value} x {products[item.Key]} = {item.Value * products[item.Key]}");
            }
        }
    }

}
