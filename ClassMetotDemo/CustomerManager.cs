using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name +" added!");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " deleted!");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Name +" updated!");
        }
    }
}
