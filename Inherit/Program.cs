
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Encap
    {
        public class Customer
        {
            private int custAge;

            private string custName;
            public int CustomerAge { get { return custAge; } set { custAge = value; } }
            public string CustomerName { get { return custName; } set { custName = value; } }
        }
        //Hieracrchical
        class DTDealer : Customer
        {
            public int DTConvalue = 10;
            public void GetDtCustomer()
            {
                Customer cus = new DTDealer();
                cus.CustomerName = "Jeeva";
                cus.CustomerAge = 18;
                if (cus.CustomerAge > 0)
                {
                    Console.WriteLine("This is from Hierarchical 1");
                }
            }
        }
        //Hierarchical
        class RoDealer : Customer
        {
            public void GetRoCustomer()
            {
                Customer cus = new RoDealer();
                cus.CustomerName = "xx";
                cus.CustomerAge = 61;
                if (cus.CustomerAge > 60)
                {
                    Console.WriteLine("This is from Hierarchical 2");
                }
            }
        }
        //Multiple Inheritance
        class Econ : DTDealer
        {
            public void econ()
            {
                DTDealer d = new DTDealer();
                if (d.DTConvalue == 10)
                {
                    Console.WriteLine("This is from Multiple");
                }
            }
        }
        private static void Main(string[] arg)
        {
            //Hierarchical
            DTDealer dt = new DTDealer();
            dt.GetDtCustomer();
            RoDealer ro = new RoDealer();
            ro.GetRoCustomer();
            //Multiple
            Econ e = new Econ();
            e.econ();
            Console.ReadLine();
        }
    }
}
