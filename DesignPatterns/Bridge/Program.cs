using Bridge.ConcreteImplementor;
using Bridge.RefinedAbstraction;
using System;

namespace Bridge
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create RefinedAbstraction
            var customers = new Customers();
            // Set ConcreteImplementor
            customers.Data = new CustomersData("Chicago");
            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");
            customers.ShowAll();
            // Wait for user
            Console.ReadKey();
        }
    }
}