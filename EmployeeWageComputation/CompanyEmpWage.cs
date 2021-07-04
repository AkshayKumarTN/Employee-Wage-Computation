using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    {
        // Implemented Interface........
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpWage();

    }
    class CompanyEmpWage : IComputeEmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        // No. of Company is given.....
        public int numberOfCompany = 0;
        public LinkedList<EmployeeWage> companyEmpWageList;
        public Dictionary<string, EmployeeWage> companyEmpWageMap;
        // Object Array is Created......
        public CompanyEmpWage()
        {
            this.companyEmpWageList = new LinkedList<EmployeeWage>();
            this.companyEmpWageMap = new Dictionary<string, EmployeeWage>();
        }
        // Adding Company....
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            EmployeeWage employeeWage = new EmployeeWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(employeeWage);
            this.companyEmpWageMap.Add(company, employeeWage);
        }
        public void computeEmpWage()
        {
            // Employee Wage Computation is done for each Company in the Array.......
            foreach(EmployeeWage companyWage in this.companyEmpWageList)
            {
                this.computeEmpWage(companyWage);
            }
        }
        public void computeEmpWage(EmployeeWage employeeWageObject)
        {
            // Employee Wage Computation is done for given Company.........
            int empWage = 0;
            int empHour = 0;
            int totalWage = 0;
            int day = 0;
            int empWorkingHour = 0;

            Random random = new Random();
            Console.WriteLine(" "+ employeeWageObject.companyName + " Company");

            while (day < employeeWageObject.maxWorkingDays && empWorkingHour < employeeWageObject.maxWorkingHours)
            {
                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case FULL_TIME:
                        empHour = 8;
                        break;

                    case PART_TIME:
                        empHour = 4;
                        break;

                    default:
                        break;

                }
                empWage = empHour * employeeWageObject.empWagePerHour;
                empWorkingHour += empHour;
                totalWage += empWage;
                if (empInput != 0)
                {
                    day++;
                    Console.WriteLine(" Day-" + day + " : Employee Working hours --> " + empHour + " || Employee Wage for the Day --> " + empWage);
                }
            }
            employeeWageObject.totalEmpWage = totalWage;
            //Displaying Total Employee Wage for given Company ......
            Console.WriteLine(" " + employeeWageObject.companyName + "'s Employee Wage for " + day + " days = " + employeeWageObject.totalEmpWage);
            Console.WriteLine();
        }
        public int GetTotalWage(String Company)
        {
            return this.companyEmpWageMap[Company].totalEmpWage;
        }
    }
}
