using System;
using System.Runtime.InteropServices;

namespace Lab5
{
    class Program
    {
        static void Zad1(int size)
        {
            Console.WriteLine("for: ");

            for (int i = 1; i < size+1; i++)
            {  
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nwhile: ");
            int i1 = 1;
            while(i1 < size + 1)
            {
                int j = 1;
                while( j < i1 + 1)
                {
                    Console.Write(j);
                    j++;
                }
                Console.WriteLine();
                i1++;
            }

            Console.WriteLine("\ndo while: ");
            int i2 = 1;
            do
            {
                int j = 1;
                while (j < i2 + 1)
                {
                    Console.Write(j);
                    j++;
                }
                Console.WriteLine();
                i2++;
            }
            while (i2 < size + 1);

        }
        static void Zad2()
        {
            Int32 i = 23;
            object o = i;
            i = 123;
            Console.WriteLine(i + ", " + (Int32)o); // Int32 is a value type

            //long j = (long)o;
            //Console.WriteLine(i + ", " + j); // Unable to cast object of type 'System.Int32' to type 'System.Int64'.
        }

        static void Zad3()
        {
            //Nie można wypisać nieprzypisanej wartości, ani zastosować metod HasValue, ani GetValueOrDefault

            Nullable<int> val = new Nullable<int>(10);
            if (val.HasValue)
                Console.WriteLine("Value: {0}", val);

            Nullable<int> val2 = null;
            Console.WriteLine("Default Value: {0}", val2.GetValueOrDefault());
        }

        static void Zad4()
        {
            //Można porownywać ze sobą zmienne zwykłe i typu nullable
            int? i = null;
            int j = 10;
            Console.WriteLine("<: {0}", i <j);
            Console.WriteLine("=: {0}", i = j);
            Console.WriteLine(">: {0}", i > j);
        }
        static void Zad5()
        {
            
        }

        static void Zad6()
        {
            Stack stack1 = new Stack();
            Stack stack2 = new Stack();
            Stack stack3 = new Stack();

            Random rnd = new Random();
            int i = 0, j = 0;
            while(i != 100)
            {
                stack1.AddItem(rnd.Next(0,1000));
                i++;
            }

            while (j != 100)
            {
                stack2.AddItem(rnd.Next(0,1000));
                j++;
            }

            for(int elem = 0; elem < stack1.ShowTheNumberOfItems(); elem++)
            {
                if(stack1[elem] % 2 == 0 && !stack3.FindAnItem(elem))
                    stack3.AddItem(stack1[elem]);
                if (stack2[elem] % 2 == 0 && !stack3.FindAnItem(elem))
                    stack3.AddItem(stack2[elem]);
            }

            stack3.PrintAllItems();
        }
        static void Zad7AndZad8()
        {
            int[,] sameSize2Rows = new int[,]{ {1,2,3},{1,4,7} };
            Matrix matrix = new Matrix(3, 4, sameSize2Rows);
            int[,] sameSize3Rows = new int[,] { { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };
            matrix.AddMatrix(sameSize3Rows);

            int[][] differentSize2Rows = new int[][] { new int[]{ 1, 2, 3 }, new int[]{ 1, 4} };
            int[][] differentSize3Rows = new int[][] { new int[] { 1, 1, 1, 1 }, new int[] { 1 }, new int[] { 1, 1 } };
            MatrixIrregular matrix2 = new MatrixIrregular(5, 4, differentSize2Rows);
            int[][] returnAddIrregular = matrix2.AddMatrix(differentSize3Rows);
            int[][] returnOddIrregular = matrix2.OddMatrix(differentSize3Rows);

            matrix2.Print(returnAddIrregular);
            matrix2.Print(returnOddIrregular);
        }
        static void Zad9()
        {
            Book bookInstance = new Book("Chocolate", "Joanne Harris", 40);
            Book bookInstance1 = new Book("Kosmiczne zachwyty", "Neil DeGrasse Tyson", 30.90);
            Book bookInstance2 = new Book("Jak mniej myśleć", "Christel Petitcollin", 50.20);
            Book bookInstance3 = new Book("Planer AGH", "URSS AGH", 0);

            BookLibrary bookLibrary = BookLibrary.GetInstance();
            BookLibrary bookLibrary2 = BookLibrary.GetInstance(); //Jest to to samo co bookLibrary, referencja do tego samego obiektu, ponieważ BookLibrary to Singleton, a więc może istniec tylko jedna istancja tej klasy

            bookLibrary.Add(bookInstance);
            bookLibrary.Add(bookInstance1);
            bookLibrary.Add(bookInstance2);
            bookLibrary.Add(bookInstance2); //Próba dodania 2 raz tego samego, operacja nie powoduje faktycznego dodania drugi raz tego samego obiektu
            bookLibrary.Add(bookInstance3);
            bookLibrary2.Remove(bookInstance);
            bookLibrary.Print();

            Console.WriteLine("\nPodaj autora by sprawdzić czy istnieje taka książka");
            string authorToFind = Console.ReadLine();
            Book bookFound = bookLibrary.FindByAuthor(authorToFind);
            if (bookFound != null)
                Console.WriteLine(bookFound.ToString());

            Console.WriteLine("\nPodaj tytuł by sprawdzić czy istnieje taka książka");
            string titleToFind = Console.ReadLine();
            bookFound = bookLibrary.FindByTitle(titleToFind);
            if (bookFound != null)
                Console.WriteLine(bookFound.ToString());
        }

        static void Main(string[] args)
        {
            //Zad1(5);
            //Zad2();
            //Zad3();
            //Zad4();

            //Zad6();
            //Zad7AndZad8();
            Zad9();
        }
    }
}
