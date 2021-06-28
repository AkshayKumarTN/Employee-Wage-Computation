using System;

namespace EmployeeWageComputation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int emp_Wage_Per_Hour = 20;
            int emp_Wage = 0;
            int emp_Hour = 0;
            int employee_Present = 1;
            int employee_Part_Time = 2;
            Random random = new Random();
            int empInput = random.Next(0,3);
            if(empInput==employee_Present)
            {
                Console.WriteLine("Employee Full Time");
                emp_Hour = 8;

            }
            else if(empInput==employee_Part_Time)
            {
                Console.WriteLine("Employee Part Time");
                emp_Hour = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            emp_Wage = emp_Hour * emp_Wage_Per_Hour;
            Console.WriteLine("Employee Wage per day = "+emp_Wage);
        }
    }
}
