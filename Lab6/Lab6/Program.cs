using System;

namespace Lab6
{
    class Program
    {
        public static void Zad1()
        {
            ChristmasTree christmasTree = new ChristmasTree("Choinka", 1);
            christmasTree.AddBauble(Color.Red, Type.Angle);
            christmasTree.AddBauble(Color.Blue, Type.Star);
            christmasTree.AddBauble(Color.Red, Type.Star);
            Console.WriteLine("Jest {0} bombek w kolorze {1}.", christmasTree[Color.Red], Color.Red);
            Console.WriteLine("Bombka o indeksie 0 w kolorze {0}.", christmasTree[0]);
            christmasTree[0, 0] = Color.Blue;
            Console.WriteLine("Bombka o indeksie 0 w kolorze {0}.", christmasTree[0]);
            christmasTree.RemoveBauble(2);
            Console.WriteLine("Jest {0} bombek w kolorze {1}.", christmasTree[Color.Red], (Color)0);
        }

        static void Zad2()
        {
            ChristmasTreeA christmasTreeA = new ChristmasTreeA("Choinka1", 1);
            christmasTreeA.AddBauble(Color.Red, Type.Angle);
            Console.WriteLine("Bombka o indeksie 0 jest w kształcie {0}.", christmasTreeA[0]);
            Console.WriteLine("Bombka o indeksie 0 jest w kształcie {0}.", ((ChristmasTree)christmasTreeA)[0]);
            Console.WriteLine("Bombka o indeksie 0 w kolorze {0}.", christmasTreeA.BaubleColor(0));
        }
        static void Zad3()
        {
            ChristmasTreeB christmasTreeB = new ChristmasTreeB("Choinka1", 1);
            christmasTreeB.AddBauble(Color.Red, Type.Angle);
            Console.WriteLine("Bombka o indeksie 0 jest w kształcie {0}.", christmasTreeB[0]);
            Console.WriteLine("Bombka o indeksie 0 jest w kształcie {0}.", ((ChristmasTreeA)christmasTreeB)[0]);
        }
        static void Main(string[] args)
        {
            //Zad1();
            Zad2();
            //Zad3();
        }
    }
}
