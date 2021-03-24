using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new();
            book.SetBook();
            Console.WriteLine(book.GetBook());
        }
    }
}
