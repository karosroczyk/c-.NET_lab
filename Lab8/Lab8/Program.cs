using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        public static Action<int, int> universalFunction;
        static void Zad3()
        { 
            void add(int a, int b) => Console.WriteLine("Add: " + (a + b));
            void sub(int a, int b) => Console.WriteLine("Sub: " + (a - b));
            void mul(int a, int b) => Console.WriteLine("Mul: " + (a * b));
            universalFunction += add;
            universalFunction += sub;
            universalFunction += mul;
            universalFunction(4,5);
        }
        static void Main(string[] args)
        {
            List<ICepikData> lista = new List<ICepikData>();
            ICepikData obj = new Auto();
            lista.Add(obj);
            foreach (var elem in lista)
            {
                Console.WriteLine(elem);
            }
            Zad3();
        }
    }
}
