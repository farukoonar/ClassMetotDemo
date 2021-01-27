using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, Name = "Engin", LastName = "Demiroğ", CustomerNumber = "265478" };
            Customer customer2 = new Customer { Id = 2, Name = "Faruk", LastName = "Onar", CustomerNumber = "265487" };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.Update(customer1);
        }
    }
}
