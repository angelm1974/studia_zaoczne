namespace Const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14;
            Console.WriteLine("Wartość Pi: " + Pi);
            Pi *=2; // Błąd kompilacji: nie można przypisać wartości do stałej
        }
    }
}