using System;
namespace Delegate_program
{
    

public delegate void Math(int x,int y);
class Multiclass
{
   public void add (int x,int y)
    {
        Console.WriteLine("add:"+(x+y));
    } 
    
   public void sub (int x,int y)
    {
        Console.WriteLine("sub:"+(x-y));
    }

     public void mul (int x,int y)
    {
        Console.WriteLine("mul:"+(x*y));
    }  

     public void div (int x,int y)
    {
        Console.WriteLine("div:"+(x/y));
    } 
}
class Solution
{
    public static void Main(String[] args)
        {
            Multiclass obj=new Multiclass();
            Math m=new Math(obj.add);
            m+=obj.sub;m+=obj.mul;
            m+=obj.div;
            m(100,60);
            Console.WriteLine();
            m(450,70);
            Console.WriteLine();
            m-=obj.div;
            m(625,25);
            Console.ReadLine();
        }
}
}