using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class TestPointer
    {
        public unsafe void Punkt1()
        {
            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                    Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
                }
            Console.ReadKey();
        }

        public void Punkt2()
        {
            int p = 4, q = 5;
            unsafe
            {
                swap(&p, &q);
                Console.WriteLine("p: {0}, q: {1}", p, q);
            }
        }
        static unsafe void swap(int *p, int *q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }

        public void Punkt3()
        {
            classToBuffer buffer = new classToBuffer();
            unsafe
            {
                fixed (int* buff = buffer.bufferHandler.fixedSizeBuffer)
                {
                    *buff = 3;
                    Console.WriteLine(*buff);
                    Console.WriteLine(*(buff + 1));
                }
            }
        }
        unsafe struct structToBuffer
        {
            public fixed int fixedSizeBuffer[1024]; 
        }

        unsafe class classToBuffer
        {
            public structToBuffer bufferHandler = default;
        }

        //Ze wskaźników pożemy korzystac tylko przy użyciu unsafe oraz w bloku fixed
    }
}
