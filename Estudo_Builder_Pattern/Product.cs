using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Builder_Pattern
{
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts --------");
            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
