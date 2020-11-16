using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Zad1
    {
        public void Fun1(in int i)
        {
            //Nie możemy zmodyfikować zmiennej in, ponieważ jest ona tylko do odczytu
            //i = 0;
            Console.WriteLine("in int i - tylko do odczytu: {0}",i);
        }

        public void Fun2(out int i)
        {
            i = 0;
        }

        public void Fun3(ref int i)
        {
            i = 0;
        }

        public void Fun4(int i)
        {
            i = 0;
        }

        //Nie można zdefiniować 2 metod różniących się jedynie modyfikatorem in/out
        public void Fun5(in int a){ }
        //public void Fun5(out int a){ }

        public void Fun6(Point p)
        {
            Point insidePoint = new Point(0, 0);
            p = insidePoint;
        }
        public void Fun7(ref Point p)
        {
            Point insidePoint = new Point(0, 0);
            p = insidePoint;
        }
    }

    class Point
    {
        public int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public void Print()
        {
            Console.WriteLine("Funkcja z parametrem przekazanym przez referencję" + $"{x,10}" + ", " + $"{y}");
        }
    }
}
