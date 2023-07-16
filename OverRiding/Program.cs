using System;

namespace OverRiding
{
    class Customer
    {
        public virtual void GetCustomer()
        {
            Console.WriteLine("This is from base");
        }
    }
    class Ro : Customer
    {
        public override void GetCustomer()
        {
            Console.WriteLine("This is form child Ro");
        }
    }
    class DT : Customer
    {
        public override void GetCustomer()
        {
            Console.WriteLine("This is form child 2 DT");
        }
    }
    class Program : Customer
    {
        static void Main(string[] args)
        {
            Customer cus = new Customer();
            DT d = new DT();
            Ro r = new Ro();
            cus.GetCustomer();
            d.GetCustomer();
            r.GetCustomer();
            Console.ReadLine();                
        }
    }
}
