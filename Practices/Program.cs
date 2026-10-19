using System;
using System.Runtime.InteropServices;




//Customer
class Customerdetails
{
    int ID = 10;

    String customerName = "sruthi";
    int age = 24;

    void
   CreateCustomerdetails()
    {
        Console.WriteLine("customer created successfully");
        Console.WriteLine("customerName:" + customerName);
        Console.WriteLine("customer id:" + ID);
        Console.WriteLine("customerage:" + age);

    }

    static void Main1()
    {
        Customerdetails customer = new Customerdetails();
        customer.CreateCustomerdetails();
    }


    static void Main()
    {
        Customerdetails customer = new Customerdetails();
        customer.CreateCustomerdetails();
    }
}


class ClassC
{

}


class ClassA
{
    static void Main()
    {
        Console.WriteLine("Hellow ");
    }
}

class ClassB
{
    static void Main()
    {
        Console.WriteLine("hadfas");
    }
}