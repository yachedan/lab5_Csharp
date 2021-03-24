using System;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new();
            school.SetTeachers();
            school.GetTeachers();
            string[] pib = {"1245","1"};
            school.PIB_Teacher = pib;
            school.GetTeachers();
            Console.WriteLine("Teachers overworking: " + school.Overwork());
            Console.WriteLine("Retiree teachers: " + school.Retiree);
        }
    }
}
