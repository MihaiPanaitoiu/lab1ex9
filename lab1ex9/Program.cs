using System;

namespace lab1ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 9
            Scrieti un program care interschimba valoarea a doua variabile intregi.
             */
            Console.WriteLine("a = ");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("b = ");
            int b = int.Parse(Console.ReadLine());

            (b, a) = (a, b);

            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
