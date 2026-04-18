using System.Text;
int wartosc1 = 5;
byte wartosc2 = 10;

wartosc1 = wartosc2; // konwersja niejawna (implicit conversion)

Console.WriteLine("Wartość 1: " + wartosc1  );

double wartosc3 = 3.1459;
int i;
i = (int)wartosc3; // konwersja jawna (explicit conversion)
Console.WriteLine("Wartość 3: " + wartosc3 );
Console.WriteLine("Wartość i: " + i );
var zmienna = Convert.ToSingle(wartosc1);
var wynik = "Wynik moich obliczeń to " + wartosc3.ToString();
Console.WriteLine(wynik);
Console.WriteLine(wartosc1);

//LITERAŁY I ZAPIS ZMIENNYCH
// 212
// 212u
// 0xBeef
// 078 -niepoprawny
// 032UU - niepoprawny
// 0b1010 - binarny zapis liczby 10
// \\	znak \
// \'	znak '
// \"	znak "
// \?	znak ?
// \a	z głośników usłyszmy pojedyczny brzęczyk (beep)
// \b	znak backspace (cofamy kursor o jedną pozycję)
// \n	nowa linia
// \r	powrót kursora na początek obecnej linii
// \t	znak tabulacji (odstęp)
// \v	pionowy znak tabulacji
// \ooo	liczba ósemkowa o jednej lub większej liczbie cyfr
// \xhh	liczba szestastkowa o jednej lub większej liczbie cyfr