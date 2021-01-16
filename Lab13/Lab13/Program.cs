using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Run() { throw null; }

        static void Run2() {
            try
            {
                throw null;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception thrown !");
            }
        }
        static void Run3() { Console.WriteLine("Hello ! The thread pool ");}
        static void Run4(object data) { Console.WriteLine("Hello ! The thread pool "  + data); }
        static void Zad1()
        {
            try
            {
                new Thread(Run).Start();
            }
            catch(NullReferenceException e) {
                Console.WriteLine("Exception thrown !");
            }
        }

        static void Zad3()
        {
            Console.WriteLine("Zad 3");
            //TaskFactory factory = new TaskFactory();
            //factory.StartNew(Run3);
            Task.Factory.StartNew(Run3);
        }

        static void Zad4()
        {
            ThreadPool.QueueUserWorkItem(Run4, 123);
            //Zadanie jest kolejkowane
            Console.ReadLine();
            
        }

        static void Zad5()
        {
            Func<string, int> method = Do;
            //.NET Core doesn't support BeginInvoke
            IAsyncResult cookie = method.BeginInvoke("test", null, null);
            int result = method.EndInvoke(cookie);
            Console.WriteLine(result.ToString());

        }
        static int Do(string s) { return s.Length; }
        static void Main(string[] args)
        {
            //Zad1();
            //new Thread(Run2).Start();
            // Według mnie zarówno pierwsza jak i druga metoda daje taki sam efekt. 
            // Uważam jednak, że wybrałabym drugą metodę ponieważ w przypadku wystąpienia wyjątku wiadom byłby że wynika on z nieprawidłowego działania metody Run.
            //Zad3();
            // Zadanie nie jest uruchamiane. Nie jest zgłaszany wyjątek.
            //Zad4();
            Zad5();
        }
    }
}
