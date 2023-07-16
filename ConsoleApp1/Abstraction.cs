using System;
using System.Security.Cryptography.X509Certificates;

public abstract class customer
{
    public abstract bool isvalidcustomer(int age);
}
public class Dealers : customer
{
    public override bool isvalidcustomer(int age)
    {
        if (age > 18) 
            return true;
        else
           return false;
    }
    static void Main(string[] args)
    {
        customer objcus = new Dealers();
        Console.WriteLine(objcus.isvalidcustomer(19));
        Console.ReadLine();
    }

}