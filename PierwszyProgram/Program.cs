using System;
class Program
{
    public static void Main(string[] args)
    {
        var a= 2+3;
        Console.WriteLine("Wynik: " + a);
        a=3-6;
        Console.WriteLine("Wynik: " + a);
        a=3*6;
        Console.WriteLine("Wynik: " + a);
        a=3/6;
        Console.WriteLine("Wynik: " + a);
        var c =10;
        c++;
        Console.WriteLine("Wynik: " + c);
        c--;
        Console.WriteLine("Wynik: " + c);
        c+=5;
        c-=5;
        c*=2;
        c/=4;
        Console.WriteLine("Wynik: " + c);
        //Tutaj już metody nie operatrory
        var b =Math.Pow(3,2);
        Console.WriteLine("Wynik: " + b);
        b=Math.Sqrt(9);
        Console.WriteLine("Wynik: " + b);
    }
}   