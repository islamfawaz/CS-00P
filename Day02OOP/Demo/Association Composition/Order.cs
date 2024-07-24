using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association
{
    internal class Order
    {
        public int Id { get; set; }
        public string BuyerEmail { get; set; }
        public decimal subTotal { get; set; }
        public OrderItem[] items { get; set; }

        public Order(string userEmail ,OrderItem[] items) { 
            BuyerEmail = userEmail;
            items=items;


        }
    }
}
