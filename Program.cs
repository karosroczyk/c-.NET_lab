using System;

namespace Aplikacja1
{
    class Program
    {

        static Func<int, int, int> sum = (a, b) => a+b;
        static Func<double, double, double> divide = (a, b) => a / b;


        static void Main(string[] args)
        {
            //Zad2
            Console.WriteLine(1 + 2);
            Console.WriteLine((double)1 / 2);
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine(35 + 5 % 7);
            Console.WriteLine(14 - 4 * (double)6 / 11);
            Console.WriteLine(2 + (double)15 / 6 * 1 - 7 % 2);

            //Zad3
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();
            Console.WriteLine("Drugi numer: {0}, Pierwszy numer: {1}", number2, number1);

            //Zad4
            int num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iloczyn : {0} x {1} x {2} = {3}", num3, num2, num1, num1 * num2 * num3);

            //Zad5
            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 7; i++)
            {
                if (i == 0 || i == 6)
                {
                    Console.Write(" ");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(value);
                    }
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("{0}    {1}", value, value);
                }

            }

            //Zad6
            int ii = 75400;
            double id = 7.54;
            Console.WriteLine("Wartość int to" + ii + ", a wartość double to" + id);
            Console.WriteLine("Wartość int to {0}, a wartość double to {1}", ii, id);
            Console.WriteLine("Wartość int to {0:C2}, a wartość double to {1:c}", ii, id);

            float flo = 220.022f;
            Console.WriteLine("Float {0:0.00000}", flo);
            Console.WriteLine("Float {0:[#].(#)(##)}", flo);
            Console.WriteLine("Float {0:0.0}", flo);
            Console.WriteLine("Float {0:0,0}", flo);
            Console.WriteLine("Float {0:,.}", flo);
            Console.WriteLine("Float {0:0%}", flo);
            Console.WriteLine("Float {0:0e+0}", flo);


            double val1 = 123.4, val2 = -1234, val3 = 0;
            Console.WriteLine("Format: {0:#,##0.0;(#,##)Minus;Zero}", val1);
            Console.WriteLine("Format: {0:#,##0.0;(#,##)Minus;Zero}", val2);
            Console.WriteLine("Format: {0:#,##0.0;(#,##)Minus;Zero}", val3);

            DateTime date = System.DateTime.Now;
            Console.WriteLine("Data: {0:d}", date);
            Console.WriteLine("Data: {0:D}", date);
            Console.WriteLine("Data: {0:t}", date);
            Console.WriteLine("Data: {0:T}", date);
            Console.WriteLine("Data: {0:f}", date);
            Console.WriteLine("Data: {0:F}", date);
            Console.WriteLine("Data: {0:g}", date);
            Console.WriteLine("Data: {0:G}", date);

            //Zad7
            double celc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kelvin: {0}", celc + 273);
            Console.WriteLine("Fahrenheit: {0}", (double)celc * 18 / 10 + 32);

            //Zad8
            int vala1 = int.Parse(Console.ReadLine());
            int vala2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik: {0}", (vala1 <= 0 && vala2 > 0) || (vala2 <= 0 && vala1 > 0));

            Console.ReadKey();
        }
    }
}
