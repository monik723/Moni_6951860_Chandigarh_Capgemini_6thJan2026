using System;

interface Inter1
{
    void f1();
}

interface Inter2
{
    void f1();
}

class C3 : Inter1, Inter2
{
    // Explicit implementation for Inter1
    void Inter1.f1()
    {
        Console.WriteLine("This is Inter1 f1 method");
    }

    // Explicit implementation for Inter2
    void Inter2.f1()
    {
        Console.WriteLine("This is Inter2 f1 method");
    }
}

class ClsInterface1
{
    static void Main(string[] args)
    {
        C3 obj1 = new C3();

        Inter1 obj2 = (Inter1)obj1;
        Inter2 obj3 = (Inter2)obj1;

        obj2.f1();
        obj3.f1();

        Console.Read();
    }
}
