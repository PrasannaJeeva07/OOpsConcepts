
using System;

namespace Structure
{
    struct Dealers
    {
        public int Dealerid;
        public string DealerName;
        public string DealerContrct;
        public string DealerMap;
    }
    class Program
    {

        static void Main(string[] args)
        {
            Dealers d1;
            Dealers d2;

            //Declare 
            d1.Dealerid = 1;
            d1.DealerName = "Cudl";
            d1.DealerContrct = "test";
            d1.DealerMap = "TestMapping";

            d2.Dealerid = 2;
            d2.DealerName = "RO";
            d2.DealerContrct = "test2";
            d2.DealerMap = "TestMapping2";

            Console.WriteLine(d1.Dealerid + "," + d1.DealerName + "," + d1.DealerContrct + "," + d1.DealerMap);
            Console.WriteLine(d2.Dealerid + "," + d2.DealerName + "," + d2.DealerContrct + "," + d2.DealerMap);
            Console.ReadLine();

        }
    }
}
