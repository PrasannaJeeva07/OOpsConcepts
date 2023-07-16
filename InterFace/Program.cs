using System;

namespace InterFace
{
    interface Dealers
    {
        void GetDealers();
    }
    class Program : Dealers
    {
        static void Main(string[] args)
        {
            Dealers d = new Program();
            d.GetDealers();
            Console.ReadLine();
        }

        public void GetDealers()
        {
            Console.WriteLine("This is from Derived Class Dealer");
            
        }
    }
}
