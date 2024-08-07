using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__task
{
    internal class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private Dictionary<Product, int> productInventory = new Dictionary<Product, int>();

        public event Action<Product, int> NotifySupplier;

        public void AddProduct(Product product, int quantity)
        {
            if (productInventory.ContainsKey(product))
            {
                productInventory[product] += quantity;
            }
            else
            {
                productInventory[product] = quantity;
            }

            if (productInventory[product] < 5)
            {
                NotifySupplier?.Invoke(product, quantity);
            }
        }

        public void SellProduct(Product product, int quantity)
        {
            if (productInventory.ContainsKey(product) && productInventory[product] >= quantity)
            {
                productInventory[product] -= quantity;
                if (productInventory[product] < 5)
                {
                    NotifySupplier?.Invoke(product, quantity);
                }
            }
            else
            {
                Console.WriteLine("Insufficient quantity to sell.");
            }
        }
    }
}
