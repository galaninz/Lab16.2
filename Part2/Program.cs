using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct = products[0];
            foreach (Product product in products)
            {
                if (product.Price > maxProduct.Price)
                {
                    maxProduct = product;
                }
            }
            Console.WriteLine($"{maxProduct.Id} \n{maxProduct.Name} \n{maxProduct.Price}");
            Console.ReadKey();
        }
    }
}
