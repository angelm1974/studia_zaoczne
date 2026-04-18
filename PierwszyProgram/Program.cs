using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        dynamic zmienna = 5;
        Console.WriteLine(zmienna);
        zmienna = "tekst";
        Console.WriteLine(zmienna);

        var zmienna2 = 5;
        Console.WriteLine(zmienna2);
        zmienna2 = "tekst";
        Console.WriteLine(zmienna2);
    }

}