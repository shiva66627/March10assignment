namespace Constructorchaining
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("Default Constructor");
        }

        public Student(string name):this()
        {
            Console.WriteLine("Name: " + name);
        }

        public Student(string name, int age):this(name) 
        {
            Console.WriteLine("Name: " + name + " Age: " + age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Student c=new Student("shiva",22);

        }
    }
}
