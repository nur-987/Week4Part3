using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("Func Examples");
            Func<int, int, int> func = Sum;
            Console.WriteLine(func(19, 1));

            Func<int> funcReturnConst = ReturnConst;
            Console.WriteLine(funcReturnConst());
            #endregion

            #region
            Console.WriteLine("Action Examples");

            Action action = () => { Console.WriteLine("Empty action"); };
            Action<double, double> action2 = (a, b) => { Console.WriteLine("Product is:" + a * b); };
            Action<int> action3 = actionMethod;

            action();
            action2(2.3,4.1);
            action3(10);
            #endregion


            Console.ReadLine();



        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int ReturnConst()
        {
            return 100;
        }

        public static void actionMethod(int k)
        {
            for(int i = 0; i<k; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
