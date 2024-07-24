using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public decimal  Type {  get; set; }
        public int Price { get; set; }
        public OrderItem(Product product) { 
            Product = product;
        }

    }
}
