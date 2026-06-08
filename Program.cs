namespace class0608_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IName p1;
            p1 = new Student();
            Console.WriteLine(p1.GetName());
            p1 = new Teacher();
            Console.WriteLine(p1.GetName());
        }
    }
}
