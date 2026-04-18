using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        Zmienne();
    }

    private static void Zmienne()
    {
        bool? czyPada=false;
        Console.WriteLine($"Czy pada? (true/false){czyPada}");

        byte wiek = 25;
        sbyte temperatura = -5;
        Console.WriteLine($"Wiek: {wiek}");
        Console.WriteLine($"Temperatura: {temperatura}");
        int liczba = -1000;
        uint dodatniaLiczba = 1000;
        Console.WriteLine($"Liczba: {dodatniaLiczba}");
        Console.WriteLine($"Liczba: {liczba}"); 
        long duzaLiczba = 10000000000;
        Console.WriteLine($"Duża liczba: {duzaLiczba}");     
        // 	-9,223,372,036,854,775,808 do 9,223,372,036,854,775,807 
        ulong bardzoDuzaLiczba = 18446744073709551615;
        Console.WriteLine($"Bardzo duża liczba: {bardzoDuzaLiczba}");
        var liczba2 = 450000L;
        Console.WriteLine($"Zmienna var: {liczba2}");
        decimal cena = 19.99m;
        Console.WriteLine($"Cena: {cena}");
        double pi = 3.14159;
        Console.WriteLine($"Pi: {pi}");
        float e = 2.71828f;
        Console.WriteLine($"E: {e}");

        ushort krotkaLiczba = 100;
        Console.WriteLine($"Krotka liczba: {krotkaLiczba}");
        short malaLiczba = -100;
        Console.WriteLine($"Mała liczba: {malaLiczba}");

        char znak = 'A';
        Console.WriteLine($"Znak: {znak}");
    }

}