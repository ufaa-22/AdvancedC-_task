using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__task
{
    internal class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Restock(Product product, int quantity)
        {
            Console.WriteLine($"Supplier {Name} notified to restock product {product.Name} with quantity {quantity}");
        }
    }
}
