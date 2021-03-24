using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new(3,2);
            Complex complex2 = new(1,3,2);
            Console.WriteLine((complex/complex2).ToString());
        }
    }
}
