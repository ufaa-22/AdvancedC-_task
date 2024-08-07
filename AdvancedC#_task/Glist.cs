using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__task
{
    internal class GList<T>
    {
        private List<T> elements = new List<T>();

        public void Add(T item)
        {
            elements.Add(item);
            Console.WriteLine($"Added item of type: {typeof(T).Name}");
        }

        public void Display()
        {
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
