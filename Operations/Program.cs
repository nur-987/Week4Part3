using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    /// <summary>
    /// Write a program which takes two arguments and does some operation. 
    /// If the value of the two operand is same then throw a 
    /// custom exception called MyArgumentException 
    /// which passes a message "Two operands cannot be same". 
    /// Print the message on the caller class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first item");
            object obj1 = Console.ReadLine();
            Console.WriteLine("Input second item");
            object obj2 = Console.ReadLine();

            MyClass intObj = new MyClass();
            intObj.Item1 = obj1;
            intObj.Item2 = obj2;

            try
            {
                intObj.Operation(obj1, obj2);
            }
            catch(MyArgumentException)
            {
               
            }


            Console.ReadLine();
        }
    }

    class MyClass
    {
        public object Item1 { get; set; }
        public object Item2 { get; set; }

        public void Operation(object a, object b)
        {
            if (a != b)
            {
                a = a + "hello";
                b = b + "bye";
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                throw new MyArgumentException("two operants cannto be the same");
            }

        }
    }
}
