﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExamples
{
    /// <summary>
    /// BASIC
    /// Thread.Start
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region EX 1
            MyClass myClass = new MyClass();
            //myClass.InitialiseThread();

            ////another process to do
            //for(int i = 0; i<1000; i++)
            //{
            //    Console.WriteLine("Thread in main");
            //    //Thread.Sleep(5000);


            //}
            #endregion


            ThreadExample t = new ThreadExample();

            Console.WriteLine("Nomal display");
            t.Display(); //syncronous call => no thread

            Console.WriteLine("Async display");
            t.DisplayAsync(); //=> running async with thread

            Console.ReadLine();
        }
    }
    class ThreadExample
    {
        public void Display()
        {
            Console.WriteLine("In Display method");
        }
        public void DisplayAsync()
        {
            Console.WriteLine("In Display Async");

            //method 1
            Thread t = new Thread(() => { Display(); });

            //method 2
            ThreadStart start = new ThreadStart(Display);
            Thread t1 = new Thread(start);

            Console.WriteLine("Before start thread");
            t.Start();
            t1.Start();

            Console.WriteLine("end of thread");
        }
    }

    class MyClass
    {
        public void InitialiseThread()
        {
            Thread td = new Thread(Print);
            td.Start();

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
