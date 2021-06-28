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
            int employeePresent = 1;
            Random random = new Random();
            int empInput = random.Next(0,2);
            if(empInput==employeePresent)
            {
                Console.WriteLine("Employee is present");
                emp_Hour = 8;

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
