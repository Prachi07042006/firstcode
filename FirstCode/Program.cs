using System;

namespace FirstCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter value for a");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value for b");
            b =Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Addition =" +c);
        }
    }
}
