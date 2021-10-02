using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExample
{
    /// <summary>
    /// Write a class which has a function
    /// which can take any function as an argument. => Delegate and its types; func, action, predicate
    /// Execute the function passed as an argument and 
    /// Print the name of the function to be executed.
    /// </summary>
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            Evaluate(Display);
            //function(function)
            // => function calling a function. the 2nd function is passed as an argument
            Evaluate(Display1);
        }

        public static void Display()
        {
            Console.WriteLine("Display");
        }
        public static void Display1()
        {
            Console.WriteLine("Display1");
        }
        public static void Evaluate(Action action)
        {
            action.Invoke();
        }
    }


}
