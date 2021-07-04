using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Employee Wage Computation \n");
            EmployeeWage dell=new EmployeeWage ("DELL",20,20,100);
            EmployeeWage hp=new EmployeeWage ("HP", 20, 20, 100);
            dell.computeEmpWage();
            hp.computeEmpWage();
        }
    }
}
