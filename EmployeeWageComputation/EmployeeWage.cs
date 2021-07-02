using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;


        public static void computeEmpWage(String company_name,int emp_wage_per_hour,int max_working_days,int max_working_hours)
        {

            int emp_Wage = 0;
            int emp_Hour = 0;
            int total_wage = 0;
            int day = 0;
            int emp_Working_Hour = 0;

            Random random = new Random();

            while (day < max_working_days && emp_Working_Hour < max_working_hours)
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
                emp_Wage = emp_Hour * emp_wage_per_hour;
                emp_Working_Hour += emp_Hour;
                total_wage += emp_Wage;
                if (empInput != 0)
                    day++;
            }
            Console.WriteLine(" "+company_name+"'s Employee Wage for " + day + " days = " + total_wage);
        }
    }
}
