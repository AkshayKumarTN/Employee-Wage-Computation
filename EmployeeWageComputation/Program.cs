using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public const int WORKING_DAYS = 20;
        

        static void Main(string[] args)
        {
            
            int emp_Wage = 0;
            int emp_Hour = 0;
            int total_wage = 0;

            Random random = new Random();
            
            for (int day = 1; day <= WORKING_DAYS; day++)
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
                total_wage += emp_Wage;
            }
            Console.WriteLine("Employee Wage per day = "+total_wage);
        }
    }
}
