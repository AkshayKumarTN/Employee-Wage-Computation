using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HOURS = 100;


        public static void computeEmpWage()
        {

            int emp_Wage = 0;
            int emp_Hour = 0;
            int total_wage = 0;
            int day = 0;
            int emp_Working_Hour = 0;

            Random random = new Random();

            while (day < MAX_WORKING_DAYS && emp_Working_Hour < MAX_WORKING_HOURS)
            {
                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case FULL_TIME:
                        emp_Hour = 8;
                        break;

                    case PART_TIME:
                        emp_Hour = 4;
                        break;

                    default:
                        break;

                }
                emp_Wage = emp_Hour * EMP_WAGE_PER_HOUR;
                emp_Working_Hour += emp_Hour;
                total_wage += emp_Wage;
                if (empInput != 0)
                    day++;
            }
            Console.WriteLine("Employee Wage for " + day + " days = " + total_wage);
        }
    }
}
