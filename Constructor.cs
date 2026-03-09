using System;

namespace Practice
{
    class Student
    {
        public Student(int a)
        {
            Console.WriteLine("integer is: " + a);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(10);
        }
    }
}
