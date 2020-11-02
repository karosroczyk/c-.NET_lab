using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public struct Coords
    {
        public int x, y;
        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
        public void Fun2()
        {
            x = 0;
            y = 0;
        }
    }
    public class Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
        public void Fun1()
        {
            x = 0;
            y = 0;
        }
        public override string ToString()
        {
            return "x: " + x + ", y: " + y;
        }
    }
}
