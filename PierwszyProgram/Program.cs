using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        // Podprogram1();
        // Console.WriteLine(3 + 4);
        // Console.WriteLine($"3 - 4");
        // Console.WriteLine("3" + "4");
        // Console.WriteLine(3.3 + 4);
        StringBuilder sb = new StringBuilder();
        sb.Append("Mam na imię Mariusz i mam ");
        sb.Append("4");
        sb.Append(" lata.");
        Console.WriteLine(sb.ToString());
        StringBuilder tb = new StringBuilder();
        tb.Append("Mam na imię Mariusz i mam ");
        tb.Append("44");
        tb.Append(" lata.");
        Console.WriteLine(tb.ToString());
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