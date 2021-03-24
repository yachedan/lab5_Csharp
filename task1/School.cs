using System;
using System.Text.RegularExpressions;
namespace task1
{
    public class School
    {
        private string[] _pibTeacher;
        private string[,] _subjects;
        private int[] _classes;
        private DateTime[] _dateBirth;

        public string[] PIB_Teacher
        {
            get { return _pibTeacher; }
            set
            {
                foreach (string elem in value)
                    if (Regex.Match(elem, "^[A-Za-z ]+$").Success)
                        _pibTeacher = value;
                    else
                        throw new ArgumentException("Wrong input");
            }
        }

        public string[,] Subjects
        {
            get { return _subjects; }
            set { _subjects = value; }
        }
        public int[] Classes { get { return _classes; } set { _classes = value; } }
        public DateTime[] DateBirth
        {
            get { return _dateBirth; }
            set { _dateBirth = value; }
        }
        public int Retiree
        {
            get
            {
                int count = 0;
                foreach (DateTime date in DateBirth)
                    if ((DateTime.Now.Year - date.Year) >= 60)
                        count++;
                return count;
            }
        }
        public School()
        {

        }
        public School(string[] pib_Teacher, string[,] subjects, int[] classes, DateTime[] dateBirth)
        {
            _pibTeacher = pib_Teacher;
            _subjects = subjects;
            _classes = classes;
            _dateBirth = dateBirth;
        }
        public void SetTeachers()
        {
            Console.WriteLine("Input number of teachers: ");
            int number = Convert.ToInt32(Console.ReadLine());
            _pibTeacher = new string[number];
            _subjects = new string[number, 10];
            _classes = new int[number];
            _dateBirth = new DateTime[number];
            for (int i = 0; i < number; i++)
            {

                Console.Write("\nEnter name: ");
                string test = Console.ReadLine();
                while (!Regex.Match(test, "^[A-Za-z ]+$").Success)
                {
                    Console.WriteLine("Wrong name! Try again: ");
                    test = Console.ReadLine();
                }
                _pibTeacher[i] = test;
                Console.Write("Enter number of subjects: ");
                test = Console.ReadLine();
                while (!Regex.Match(test, "[1-9]{1}").Success)
                {
                    Console.WriteLine("Wrong number! Try again: ");
                    test = Console.ReadLine();
                }
                int subNumber = Convert.ToInt32(test);
                for (int j = 0; j < subNumber; j++)
                {
                    Console.Write("Subject " + j + ": ");
                    _subjects[i, j] = Console.ReadLine();
                }

                Console.Write("Enter number of classes: ");
                _classes[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter date of birth: ");
                DateTime tempDate;
                while (!DateTime.TryParse(Console.ReadLine(), out tempDate))
                {
                    Console.WriteLine("Wrong date! Try again: ");
                }
                _dateBirth[i] = tempDate;
            }
        }
        public void GetTeachers()
        {
            for (int i = 0; i < _pibTeacher.Length; i++)
            {
                Console.Write("\nName: " + _pibTeacher[i] + "\n" + "Subjects: ");
                Console.Write("[");
                for (int j = 0; j < _subjects.Length; j++)
                {
                    Console.Write(_subjects[i, j]);
                    if (_subjects[i, j + 1] == null)
                        break;
                    else
                        Console.Write(", ");
                }
                Console.Write("]");
                Console.WriteLine("\n" + "Classes: " + _classes[i] + "\n" + "Date Of Birth:" + _dateBirth[i]);
            }
        }
        public int Overwork()
        {
            int count = 0;
            for (int i = 0; i < _pibTeacher.Length; i++)
                if (_classes[i] > 4)
                    count++;
            return count;
        }


    }
}
