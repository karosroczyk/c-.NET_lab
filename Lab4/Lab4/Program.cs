using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Zad1a()
        {
            Zad1 ob1 = new Zad1();

            //b)
            int i = 5;
            ob1.Fun1(i);
            Console.WriteLine("Funkcja z parametrem przekazanym przez wartość" + $"{i,10}");

            i = 5;
            ob1.Fun2(out i);
            Console.WriteLine("Funkcja z parametrem przekazanym przez wartość" + $"{i,10}");

            i = 5;
            ob1.Fun3(ref i);
            Console.WriteLine("Funkcja z parametrem przekazanym przez wartość" + $"{i,10}");

            i = 5;
            ob1.Fun4(i);
            Console.WriteLine("Funkcja z parametrem przekazanym przez wartość" + $"{i,10}");

            //c)
            short j = 5;
            ob1.Fun1(j);

            //Nie jest możliwe przekonwertowanie typu 'out short/ref short' na 'out int/ref int'
            //ob1.Fun2(out j);
            //ob1.Fun3(ref j);

            j = 5;
            ob1.Fun4(j);
        }

        static void Zad1b()
        {
            Zad1 zadanie = new Zad1();
            Point point = new Point(1, 2);
            zadanie.Fun6(point);
            point.Print();
            zadanie.Fun7(ref point);
            point.Print();

            point = null;
            zadanie.Fun6(point);
            //point.Print();
            zadanie.Fun7(ref point);
            point.Print();
        }

        static void Zad3()
        {
            int[] tab = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int readed;
            if (Int32.TryParse(Console.ReadLine(), out readed))
            {
                int[] tab2 = new int[10];
                for (int i = 0; i < tab.Length; i++)
                {
                    tab2[i] = tab[i];
                }
                tab[0] = readed;
                for (int i = 1; i < tab.Length; i++)
                {
                    tab[i] = tab2[i - 1];
                }
            }

            foreach (var elem in tab) { Console.WriteLine(elem); }
        }
        static void Zad4()
        {
            int[] tab = new int[5];
            int readed, iter = 5;
            while (iter != 0)
            {
                if (Int32.TryParse(Console.ReadLine(), out readed))
                {
                    tab[5-iter] = readed;
                }
                iter--;
            }

            for (int i = tab.Length-1; i >= 0 ; i--)
            {
                Console.WriteLine(tab[i]);
            }
        }
        static void Zad5(params int[] tab)
        {
            Array.Sort(tab);           
            List<Tuple<int,int>> listCounted = new List<Tuple<int, int>>();
            int starter, counter;
            for (int i = 0; i < tab.Length; i++)
            {
                counter = 1;
                starter = tab[i];
                if (i != tab.Length-1)
                {
                    while (starter == tab[i + 1])
                    {
                        counter++;
                        i++;
                        if (i == tab.Length-1)
                            break;
                    }
                }
                listCounted.Add(Tuple.Create(starter, counter));

            }
            foreach (var elem in listCounted) { Console.WriteLine(elem); }
        }

        static void Zad6(int[,] tabA, int[,] tabB)
        {
            int[,] wynik = new int[5,5];

            for (int i = 0; i < tabA.GetLength(0); i++)
            {
                for (int j = 0; j < tabA.GetLength(1); j++)
                {
                    wynik[i, j] = tabA[i, j] + tabB[i, j];
                }
            }

            Console.WriteLine("Length: {0}",wynik.Length);
            Console.WriteLine("LongLength: {0}",wynik.LongLength);
            Console.WriteLine("Rank: {0}",wynik.Rank);
        }

        static int Zad7(int[,] matrix)
        {
            int a = matrix[0, 0] * matrix[1, 1] * matrix[2, 2];
            int b = matrix[1, 0] * matrix[2, 1] * matrix[0, 2];
            int c = matrix[2, 0] * matrix[0, 1] * matrix[1, 2];

            int a1 = matrix[2, 0] * matrix[1, 1] * matrix[0, 2];
            int b1 = matrix[1, 0] * matrix[0, 1] * matrix[2, 2];
            int c1 = matrix[0, 0] * matrix[2, 1] * matrix[1, 2];

            return (a*b*c) - (a1*b1*c1);
        }

        static void Zad8()
        {
            List<List<int>> tab1 = new List<List<int>>() {
                new List<int>(){ 1, 2, 3 },
                new List<int>(){ 4,5,6,7,8,9 },
                new List<int>(){ 10,11,12,13},
                new List<int>(){ 14, 15, 16, 17, 18 },
                new List<int>(){ 19, 20, 21 } };

            List<List<int>> tab2 = new List<List<int>>();
            tab2.Add(new List<int>() { 1, 2, 3 });
            tab2.Add(new List<int>() { 4, 5, 6, 7, 8, 9 });
            tab2.Add(new List<int>() { 10, 11, 12, 13 });
            tab2.Add(new List<int>() { 14, 15, 16, 17, 18 });
            tab2.Add(new List<int>() { 19, 20, 21 });

            Action<List<List<int>>> fun = (List<List<int>> tab1) =>
            {
                foreach (var vec in tab1)
                {
                    foreach (var elem in vec)
                    {
                        Console.Write(elem);
                    }
                    Console.WriteLine();
                }
            };
            fun(tab1);
            Console.WriteLine();
            fun(tab2);
        }
        static void Main(string[] args)
        {
            //Zad1a();
            //Zad1b();

            //TestPointer zad2 = new TestPointer();
            //zad2.Punkt1();
            //zad2.Punkt2();
            //zad2.Punkt3();

            //Zad3();
            //Zad4();
            //Zad5(8, 4, 5, 4, 5);
            //int[,] tabA = new int[5, 5] {{1,2,3,4,5},{2,3,4,5,6},{3,4,5,6,7},{4,5,6,7,8},{5,6,7,8,9}};
            //int[,] tabB = new int[5, 5] {{1,2,3,4,5},{2,3,4,5,6},{3,4,5,6,7},{4,5,6,7,8},{5,6,7,8,9}};
            //Zad6(tabA, tabB);
            //int[,] matrix = new int[3, 3] {{1,0,-1},{0,0,1},{-1,-1,0}};
            //Console.WriteLine(Zad7(matrix));
            Zad8();
        }
    }
}
