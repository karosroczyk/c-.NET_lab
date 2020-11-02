using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    struct Point2D
    {
        public int dx, dy;
        public Point2D(int dx, int dy)
        {
            this.dx = dx;
            this.dy = dy;
        }
        public void Reset()
        {
            dx = 0;
            dy = 0;
        }
        public void IncrX(int x)
        {
            dx += x;
        }
        public void IncrY(int y)
        {
            dy += y;
        }
        public void Print2DPoint()
        {
            Console.WriteLine("dx: " + dx + "dy: " + dy);
        }

        public double Dist(Point2D point)
        {
            return Math.Sqrt(Math.Pow(point.dx - this.dx, 2) + Math.Pow(point.dy - this.dy, 2));
        }
    }
    struct Point2DVersion2
    {
        int dx, dy; //Nie można zainicjować zmiennych wewnątrz struktury

        //Point2DVersion2(){ } //Struktury nie mogą zawierać konstruktorów bez parametrów
        public void Reset()
        {
            dx = 0;
            dy = 0;
        }
        public void IncrX(int x)
        {
            dx += x;
        }
        public void IncrY(int y)
        {
            dy += y;
        }
        public void Print2DPoint()
        {
            Console.WriteLine("dx: " + dx + "dy: " + dy);
        }

        public double Dist(Point2D point)
        {
            return Math.Sqrt(Math.Pow(point.dx - this.dx, 2) + Math.Pow(point.dy - this.dy, 2));
        }
    }
}
