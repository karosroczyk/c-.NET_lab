using System.Linq;
using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        const int rad = 5;
        static int[] CountDistances(List<Point2D> points)
        {
            int[] tab = new int[4];

            for (int i = 0; i < 4; i++)
            {
                tab[i] = Convert.ToInt32(points[4].Dist(points[i]));
            }
            return tab;
        }
        static void AddPoint(List<Point2D> points)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            points.Add(new Point2D(x, y));
        }
        static void Zad1()
        {
            List<Point2D> points = new List<Point2D>();

            Console.WriteLine("Wprowadź 5 punktów:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Punkt {0}:", i);
                AddPoint(points);
            }

            int[] countedDistances = CountDistances(points);

            int iter = 0;
            bool flag = true;
            while (iter < 4 && flag)
            {
                if (countedDistances[iter] < rad)
                {
                    Console.WriteLine("Punkt znajduje się wewnątrz okręgu.");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Punkt znajduje się poza okręgiem.\nNajmniejsza odległość to: " + countedDistances.Min());

                    Console.WriteLine("Podaj kolejny punkt");
                    List<Point2D> finalPoints = new List<Point2D>();
                    AddPoint(finalPoints);

                    int j = 0;
                    while (points[4].Dist(finalPoints[j]) >= rad || finalPoints[0].dx < 0)
                    {
                        Console.WriteLine("Podaj kolejny punkt");
                        AddPoint(finalPoints);
                        j++;
                    }
                    Console.WriteLine("Punkt znajduje się wewnątrz okręgu.");
                    Console.WriteLine("Współrzędne punktów wpisanych do tej pory to:.");

                    finalPoints.InsertRange(0, points);
                    foreach (var elem in finalPoints)
                    {
                        elem.Print2DPoint();
                    }

                    flag = false;
                }
                iter++;
            }
            Console.ReadKey();
        }

        static void Zad2()
        {
            Point2DVersion2 point;
            //point.ToString(); //Nie jest możliwe wywołanie metody ToString
            Point2DVersion2 point2 = new Point2DVersion2();
            point2.ToString(); //Można wywołać metodę ToString, ale nic ona nie wypisuje
        }

        static void Zad3()
        {
            bool flag = true;
            int counterInt = 0;
            int counterFloat = 0;
            int counterString = 0;
            Console.WriteLine("Podaj dane:");
            string data = Console.ReadLine();

            while (data != "-1")
            {
                int number;
                float number1;

                bool success = Int32.TryParse(data, out number);
                bool success1 = float.TryParse(data, out number1);

                if (success)
                {
                    counterInt++;
                }
                if (success1)
                {
                    counterFloat++;
                }
                if (!success && !success1)
                {
                    counterString++;
                }
                Console.WriteLine("Podaj dane:");
                data = Console.ReadLine();
            }

            Console.WriteLine("Wpisano {0} Int", counterInt);
            Console.WriteLine("Wpisano {0} Float", counterFloat);
            Console.WriteLine("Wpisano {0} String", counterString);
        }

        static void Zad4()
        {
            Console.WriteLine("Podaj numer dnia tygodnia:");
            int day = int.Parse(Console.ReadLine()) - 1;

            Week g1 = (Week)day;
            g1.WriteDay();

            Console.WriteLine("Podaj wartość by sprawdzić jej rozmiar:");
            int num = int.Parse(Console.ReadLine()) - 1;
            Ranges r1 = (Ranges)num;
            r1.WhichSize();
        }

        public static void Zad5()
        {
            Console.WriteLine("Podaj znak:");
            char value = char.Parse(Console.ReadLine());

            List<char> vowels = new List<char>() { 'a', 'ą', 'e', 'ę', 'i', 'o', 'u', 'y' };
            if (vowels.Contains(value))
                Console.WriteLine("Jest to samogłoska.");
            else if(Char.IsDigit(value))
                Console.WriteLine("Jest to cyfra.");
            else
                Console.WriteLine("Jest to inny znak.");
        }

        static void Zad7()
        {
            //int val = int.MaxValue + 1; // Statyczna kontrola - Błąd kompilacji 

            int value = 780000000;
            checked
            {
                try
                {
                    int square = value * value;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void Zad8()
        {
            Point point1 = new Point(1, 2);
            Coords point2 = new Coords(3, 4);
            point1.Fun1();
            point2.Fun2();

            Console.WriteLine(point1.ToString()); //Point jest typem referencyjnym więc Fun1 zmieniła wartości
            Console.WriteLine("x: " + point2.x + ", y: " + point2.y); //Coords jest typem wartościowym więc Fun2 nie zmieniła wartości

            Point point1a = new Point(1, 2);
            Coords point2a = new Coords(3, 4);

            Console.WriteLine("Object.Equals(,)");
            Console.WriteLine(Object.Equals(point1, point1a));
            Console.WriteLine(Object.Equals(point2, point2a));

            Console.WriteLine("p.Equals(,)");
            Console.WriteLine(point1.Equals(point1a));
            Console.WriteLine(point2.Equals(point2a));

            Console.WriteLine("Object.ReferenceEquals(,)");
            Console.WriteLine(Object.ReferenceEquals(point1, point1a));
            Console.WriteLine(Object.ReferenceEquals(point2, point2a));
        }

        static void Zad10()
        {
            double jawna1 = 2;


            int niejawna1 = (int)3.5;
        }

        static void Main(string[] args)
        {
            //Zad1();
            //Zad2();
            //Zad3();
            //Zad4();
            //Zad5();
            //# Zad6
            //Console.WriteLine(string.Join(" ", Console.ReadLine().Select(c => c)));
            //Zad7();
            //Zad8();

            Zad10();
        }

    }
}
