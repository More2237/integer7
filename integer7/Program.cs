using System;

namespace integer7
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
           int b = a/10;
           int c = a%10;


           var result = b + c;
           var result1 = c * b;
           Console.WriteLine(result);
           Console.WriteLine(result1);

        }
    }
}