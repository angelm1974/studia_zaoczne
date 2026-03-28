internal class Program
{
    private static void Main(string[] args)
    {
        Podprogram1();
        Console.WriteLine(3 + 4);
        Console.WriteLine($"3 - 4");
        Console.WriteLine("3" + "4");
        Console.WriteLine(3.3 + 4);
    }

    static void Podprogram1()
    {
        string szkola = "Szkoła Programowania";
        Console.WriteLine($"Hello, World! Witaj w {szkola}!");
        Console.WriteLine("Jak masz na imię?");
        string ?imie = Console.ReadLine();
        Console.WriteLine($"Cześć buraku, {imie}!");
    }
}