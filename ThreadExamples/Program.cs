using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.InitialiseThread();

            //another process to do
            for(int i = 0; i<1000; i++)
            {
                Console.WriteLine("Thread in main");
                //Thread.Sleep(5000);


            }

            Console.ReadLine();
        }
    }

    class MyClass
    {
        public void InitialiseThread()
        {
            Thread td = new Thread(Print);
            td.Start();
            //td.Join();

        }

        public void Print()
        {
            for(int i = 0; i<1000; i++)
            {
                Console.WriteLine(i);
                //Thread.Sleep(5000);
            }
        }
    }
}
