using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class MyArgumentException : Exception
    {
        public MyArgumentException(string message) :base(message)
        {
            message = "Two operants cannot be the same";
            Console.WriteLine(message);
        }
    }
}
