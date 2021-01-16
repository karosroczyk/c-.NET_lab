using System;
using System.Threading;
using System.Collections.Generic;

namespace Lab12
{
    class ThreadExample
    {
        bool done;
        bool doneLocker;
        static bool done2;
        static bool done3;
        static readonly object locker = new object();
        void Zad1()
        {
            Thread thread1 = new Thread(new ParameterizedThreadStart(WriteNumber));
            thread1.Start(1);

            WriteNumber(0);
        }
        void Zad2()
        {
            new Thread(WriteNumber).Start(2);
            WriteNumber(3);
        }
        void Zad6()
        {
            Thread t = new Thread(WriteNumber);
            t.Start(6);
            t.Join();
            Console.WriteLine("Thread ended.");
        }

        int countSum(Object m)
        {
            int suma = 0;
            foreach (var row in (List<List<int>>)m)
            {
                foreach (var elem in row)
                {
                    suma += elem;
                }
            }
            return suma;
        }

        Thread createThread()
        {
            int sum1 = 0;
            Thread t = new Thread((m) => {
                sum1 = countSum(m);
                Console.WriteLine("Suma:{0}", sum1);
            });
            return t;
        }
        void Zad7(List<List<int>> m1, List<List<int>> m2, List<List<int>> m3, List<List<int>> m4, List<List<int>> m5)
        {
            Thread t = createThread();
            t.Start(m1);
            
            Thread t2 = createThread();
            t2.Start(m2);

            Thread t3 = createThread();
            t3.Start(m3);

            Thread t4 = createThread();
            t4.Start(m4);

            Thread t5 = createThread();
            t5.Start(m5);

        }
        static void Main(string[] args)
        {
            ThreadExample thread = new ThreadExample();

            thread.Zad1();
            thread.Zad2();
            //Zad 3   
            new Thread(thread.Run).Start();
            thread.Run();
            //'*'zostaje wypisana 5 razy ponieważ, zmienna done zostaje zmieniona na true przez jeden z wątków, zatem drugi wątek nie wchodzi do if

            //Zad 4
            new Thread(thread.Run2).Start();
            thread.Run2();
            //wątki współdzielą składową statyczną (wyświetlany x 5 razy)
            new Thread(thread.Run3).Start();
            thread.Run3();
            //w wyniku zmiany funkcji Run2 na Run3 (wyświetlany x 10 razy)
            //Spowodowane jest to tym, że jeden wątek może sprawdzać wartość wyrażenia if, podczas gdy drugi nie zdążył jeszcze zmienić done na true

            //Zad 5
            new Thread(thread.RunLocker).Start();
            thread.RunLocker();
            //Zastosowanie lock gwarantuje, że w danej chwili tylko jeden wątek może nałożyć blokade, a drugi oczekuje na zniesienie blokady

            //Zad 6
            thread.Zad6();
            //Join powoduje wstrzymanie pracy kolejnego wątku do czasu gdy ten pierwszy nie zakończy działania

            //Zad 7
            List<List<int>> m1 = new List<List<int>>() {new List<int>(){1,1}, new List<int>(){1,1}};
            List<List<int>> m2 = new List<List<int>>() { new List<int>() { 2, 2 }, new List<int>() { 2, 2 } };
            List<List<int>> m3 = new List<List<int>>() { new List<int>() { 3, 3 }, new List<int>() { 3, 3 } };
            List<List<int>> m4 = new List<List<int>>() { new List<int>() { 4, 4 }, new List<int>() { 4, 4 } };
            List<List<int>> m5 = new List<List<int>>() { new List<int>() { 5, 5 }, new List<int>() { 5, 5 } };
            thread.Zad7(m1, m2, m3, m4, m5);
        }
        void WriteNumber(object num)
        {
            for (int i=0; i<5; i++) Console.Write(num);
        }
        void Run()
        {
            if (!done) { done = true; for (int i = 0; i < 5; i++) Console.Write('*');}
        }
        void Run2()
        {
            if (!done2) { done2 = true; for (int i = 0; i < 5; i++) Console.Write('x'); }
        }
        void Run3()
        {
            if (!done3) {for (int i = 0; i < 5; i++) Console.Write('x'); done3 = true; }
        }
        void RunLocker()
        {
            lock (locker)
            {
                if (!doneLocker) { for (int i = 0; i < 5; i++) Console.Write('|'); doneLocker = true; }
            }
        }
    }
}
