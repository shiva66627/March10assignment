namespace Autoboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            object b = a;//autoboxing
            Console.WriteLine(b);
            int c=(int)b;
            Console.WriteLine(c);//unboxing
        }
    }
}
