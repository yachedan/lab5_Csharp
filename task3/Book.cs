using System;
using System.Text.RegularExpressions;
namespace task3
{
    class Book
    {
        private string _name;
        private string _author;
        private string _publisher;
        private string _language;
        private int _year;
        private int _pages;
        private string _isbn;
        private double _weight;
        private int[] _size = new int[3];
        private string _translator;

        public Book()
        {

        }
        public Book(string name, string author, string isbn, string language, int year, int pages,
                    string publisher, string translator, double weight, int size_x, int size_y, int size_z)
        {
            _name = name;
            _author = author;
            _isbn = isbn;
            _language = language;
            _year = year;
            _pages = pages;
            _publisher = publisher;
            _translator = translator;
            _weight = weight;
            _size[0] = size_x;
            _size[1] = size_y;
            _size[2] = size_z;
        }
        public void SetBook()
        {
            Console.Write("\nEnter name of the book: ");
            _name = Console.ReadLine();
            Console.Write("Enter author's name: ");
            string test = Console.ReadLine();
            while (!Regex.Match(test, "^[A-Za-z ]+$").Success)
            {
                Console.WriteLine("Wrong name! Try again: ");
                test = Console.ReadLine();
            }
            _author = test;
            Console.Write("Enter ISBN code: ");
            test = Console.ReadLine();
            while (!Regex.Match(test, "[0-9]{13}").Success)
            {
                Console.WriteLine("Wrong code! Try again: ");
                test = Console.ReadLine();
            }
            _isbn = test;
            Console.Write("Enter language: ");
            _language = Console.ReadLine();
            Console.Write("Enter year of publishment: ");
            test = Console.ReadLine();
            while (!Regex.Match(test, "^[1][0-9]{3}").Success)
            {
                Console.WriteLine("Wrong year! Try again: ");
                test = Console.ReadLine();
            }
            _year = Convert.ToInt32(test);
            Console.Write("Enter page count: ");
            test = Console.ReadLine();
            while (!Regex.Match(test, "[1-9][0-9]*").Success)
            {
                Console.WriteLine("Wrong page count! Try again: ");
                test = Console.ReadLine();
            }
            _pages = Convert.ToInt32(test);
            Console.Write("Enter publisher: ");
            _publisher = Console.ReadLine();
            Console.Write("Enter translator's name: ");
            test = Console.ReadLine();
            while (!Regex.Match(test, "^[A-Za-z ]+$").Success)
            {
                Console.WriteLine("Wrong name! Try again: ");
                test = Console.ReadLine();
            }
            _publisher = test;
            Console.Write("Enter weight: ");
            test = Console.ReadLine();
            while (!Regex.Match(test, @"-?\d+(?:\.\d+)?").Success)
            {
                Console.WriteLine("Wrong weight! Try again: ");
                test = Console.ReadLine();
            }
            _weight = Convert.ToDouble(test);
            Console.Write("Enter length(mm): ");
            test = Console.ReadLine();
            while (!Regex.Match(test, "[1-9][0-9]*").Success)
            {
                Console.WriteLine("Wrong length! Try again: ");
                test = Console.ReadLine();
            }
            _size[0] = Convert.ToInt32(test);
            Console.Write("Enter width(mm): ");
            test = Console.ReadLine();
            while (!Regex.Match(test, "[1-9][0-9]*").Success)
            {
                Console.WriteLine("Wrong width! Try again: ");
                test = Console.ReadLine();
            }
            _size[1] = Convert.ToInt32(test);
            Console.Write("Enter height(mm): ");
            test = Console.ReadLine();
            while (!Regex.Match(test, "[1-9][0-9]*").Success)
            {
                Console.WriteLine("Wrong height! Try again: ");
                test = Console.ReadLine();
            }
            _size[2] = Convert.ToInt32(test);

        }
        public string GetBook()
        {
            return $"Name: {_name}\nAuthor: {_author}\nISBN: {_isbn}";
        }
        public double ReadTime()
        {
            return(_pages*2/60);
        }
    }
}
