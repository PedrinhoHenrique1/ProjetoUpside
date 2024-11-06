using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUpside
{
    internal class Product
    {
        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public Product(string name, float price, int quantity) {
            NameProduct = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
