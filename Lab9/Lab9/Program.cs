using System;
using System.IO;

namespace Lab9
{
    class Program
    {
        static void Zad1()
        {
            string[] slowa = new string[]
                    {"Już północ",
                    "cień",
                    "ponury",
                    "pół",
                    "świata",
                    "okrywa",
                    "A jeszcze",
                    "serce",
                    "zmysłom",
                    "spoczynku nie daje"};

            Console.WriteLine($"{slowa[^1]}"); //wypisze ostatni element tablicy

            string[] sonet1 = slowa[2..6]; //definiuje range
            foreach (var word in sonet1)
                Console.Write($"<{word}>"); //wyświetla word w określonym stylu
            Console.WriteLine();

            string[] sonet2 = slowa[^3..^0]; //definiuje range od ostatniego elementu do 3 od końca
            foreach (var word in sonet2)
                Console.Write($" {word} "); //wyświetla word w określonym stylu
            Console.WriteLine();

            string[] sonet3 = slowa[..]; //definiuje range, całą tablice
            foreach (var word in sonet3)
                Console.Write($" {word} "); //wyświetla word w określonym stylu
            Console.WriteLine();

            string[] sonet4 = slowa[..5]; //definiuje range, od poczatku do 5 elementu
            foreach (var word in sonet4)
                Console.Write($" {word} "); //wyświetla word w określonym stylu
            Console.WriteLine();

            string[] sonet5 = slowa[7..]; //definiuje range od 7 elementu do końca
            foreach (var word in sonet5)
                Console.Write($" {word} "); //wyświetla word w określonym stylu
            Console.WriteLine();

            Index stri = ^5;
            Console.WriteLine(slowa[stri]); // wyświetla 5 element od końca

            Range fraza = 2..7;
            string[] tekst = slowa[fraza];
            foreach (var slowo in tekst)
                Console.Write($" {slowo} ");
            Console.WriteLine(); 
        }
        static void Main(string[] args)
        {
            //Zad1();

            //Zad2 zad2 = new Zad2();
            //zad2.Perform();


        }
    }
}
