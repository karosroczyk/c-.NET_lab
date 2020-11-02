using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public enum Week
    { Poniedziałek, Wtorek, Środa, Czwartek, Piątek, Sobota, Niedziela }
    public enum Ranges
    { Małe = 10, Średnie = 100 }
    static class Extensions
    {
        public static void WriteDay(this Week day)
        {
            Console.WriteLine("Ten dzień to {0}", day);
        }
        public static Ranges minPassing = Ranges.Małe;
        public static Ranges midPassing = Ranges.Średnie;
        public static void WhichSize(this Ranges range)
        {
            if (range <= Ranges.Małe)
                Console.WriteLine("Mały rozmiar");
            else if (range > Ranges.Małe && range <= Ranges.Średnie)
                Console.WriteLine("Średni rozmiar");
            else
                Console.WriteLine("Duży rozmiar");
        }
    }
}
