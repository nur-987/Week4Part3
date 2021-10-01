using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculation
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input in full salary");
            int TempSalary = Int32.Parse(Console.ReadLine());


        }
    }

    
    public class Salary<T>
    {

        public T TotalSalary{get; set;}

        public void first6Months(int salary)
        {
            int SixMthSalary = (salary * 6) * (80/100);

        }

    }
}




