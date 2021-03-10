using System;

namespace ConsoleApp3
{
    class Student
    {
        int Id=11;
        string name="vamshi";
        string college="mlrit";
        string Branch="ECE";
        string BloodGroup="o+";

        public static void College()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.Id);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.college);
            Console.WriteLine(s1.Branch);
        }
        public static void Hospital()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.BloodGroup);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student.College();
            Student.Hospital();
        }
    }
}
