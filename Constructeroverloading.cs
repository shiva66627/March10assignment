namespace Constructoroverloading
{
    class Student
    {
        public Student(int id)
        {
            Console.WriteLine("your id is:" + id);
        }
        public Student(string name, int id)
        {
            Console.WriteLine("Student name is:" + name +" "+"and your id is :"+id);
            
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student s1 = new Student(1);
                Student s2 = new Student("shiva", 2);
            }
        }
    }
}
