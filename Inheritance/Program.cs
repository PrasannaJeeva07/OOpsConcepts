
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

            private string? custName;
            public int CustomerAge { get { return custAge; } set { custAge = value; } }
            public string CustomerName { get { return custName; } set { custName = value; } }
        }

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
                    Console.WriteLine("This Customer is saticfied for this DT");
                }                
            }
        }
        class RoDealer : Customer
        {
            public void GetRoCustomer()
            {
                Customer cus = new RoDealer();
                cus.CustomerName = "xx";
                cus.CustomerAge = 61;
                if (cus.CustomerAge > 60)
                {
                    Console.WriteLine("This Customer is saticfied under RO");
                }                
            }
        }
        class Econ : DTDealer
        {
            public void econ()
            {
                DTDealer d = new DTDealer();
               if(d.DTConvalue == 10)
                {
                    Console.WriteLine("Deal needs to approve");
                }
            }
        }
        private static void Main(string[] arg)
        {
            DTDealer dt = new DTDealer();
            dt.GetDtCustomer();
            RoDealer ro = new RoDealer();
            ro.GetRoCustomer(); 
            Econ e = new Econ();
            e.econ();
            Console.ReadLine();
        }
    }
}
