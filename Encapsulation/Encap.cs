using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Encap
    {
        private static void Main(string[] arg)
        {
            Encapsulation encapsulation = new Encapsulation();
            encapsulation.DealerName = "DT";
            encapsulation.DealerAddress = "NO,20,Test";
            Console.WriteLine("DelaerName:" + encapsulation.DealerName);
            Console.WriteLine("DelaerAddress:" + encapsulation.DealerAddress);
            Console.ReadLine();
        }
    }
    public class Encapsulation
    {
        private string _dealername;
        private string _dealerAddress;

        public string DealerName { get { return _dealername; } set { _dealername = value; } }
        public string DealerAddress { get { return _dealerAddress; } set { _dealerAddress = value; } }

    }


}
