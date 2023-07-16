using System;

namespace Static_Complie_methodOverloading
{
    class Customer
    {
        public void GetCustomer(int id)
        {
            Console.WriteLine("Based on ID");
        }
        public void GetCustomer(int id, int number)
        {
            Console.WriteLine("Based on id, number");
        }
        public void GetCustomer(int id, int number, string name)
        {
            Console.WriteLine("Based on id, number , name");
        }
    }
    class Program : Customer
    {
        static void Main(string[] args)
        {
            Customer cus = new Customer();
            cus.GetCustomer(2);
            cus.GetCustomer(2, 122);
            cus.GetCustomer(2,122, "Jeeva");
            Console.ReadLine();
        }
    }
}
