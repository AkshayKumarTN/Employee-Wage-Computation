using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        private String company_name;
        private int emp_wage_per_hour;
        private int max_working_days;
        private int max_working_hours;

        public EmployeeWage(String company_name, int emp_wage_per_hour, int max_working_days, int max_working_hours)
        {
            this.company_name= company_name;
            this.emp_wage_per_hour= emp_wage_per_hour;
            this.max_working_days= max_working_days;
            this.max_working_hours= max_working_hours; 
    }
        public void computeEmpWage()
        {

            int emp_Wage = 0;
            int emp_Hour = 0;
            int total_wage = 0;
            int day = 0;
            int emp_Working_Hour = 0;

            Random random = new Random();

            while (day < this.max_working_days && emp_Working_Hour < this.max_working_hours)
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
                emp_Wage = emp_Hour * this.emp_wage_per_hour;
                emp_Working_Hour += emp_Hour;
                total_wage += emp_Wage;
                if (empInput != 0)
                    day++;
            }
            Console.WriteLine(" "+ this.company_name +"'s Employee Wage for " + day + " days = " + total_wage);
        }
    }
}
