using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Employee Wage Computation \n");
            EmployeeWage.computeEmpWage("DELL",20,20,100);
            EmployeeWage.computeEmpWage("HP", 20, 20, 100);
        }
    }
}
