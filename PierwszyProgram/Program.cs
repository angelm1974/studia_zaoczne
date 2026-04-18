using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        // string imie ="Ala ma kota";
        // Console.WriteLine(imie);
        // string b = imie;
        // Console.WriteLine(b);

        // imie = "Ala ma psa";
        // Console.WriteLine(imie);
        // Console.WriteLine(b);

        Pudelko a = new Pudelko();
        a.Wartosc = 5;

        Pudelko b = a;
        Console.WriteLine(a.Wartosc);
        Console.WriteLine(b.Wartosc);
        a.Wartosc = 10;
        Console.WriteLine(a.Wartosc);   
        Console.WriteLine(b.Wartosc);
    }

    class Pudelko
    {
        public int Wartosc { get; set; }
    }

}