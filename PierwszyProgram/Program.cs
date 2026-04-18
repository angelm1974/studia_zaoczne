using System.Text;
unsafe internal class Program
{
    private static void Main(string[] args)
    {
        int a = 5;
        int* b = &a;

        Console.WriteLine(*b);
    }

}