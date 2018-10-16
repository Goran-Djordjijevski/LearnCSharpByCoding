using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer()
        {
            this.Orders = new List<Order>();
        }

        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
    }
}
