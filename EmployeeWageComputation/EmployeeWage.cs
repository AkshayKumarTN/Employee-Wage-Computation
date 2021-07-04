using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        
        public String companyName;
        public int empWagePerHour;
        public int maxWorkingDays;
        public int maxWorkingHours;
        public int totalEmpWage;

        public EmployeeWage(String companyName, int empWagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.empWagePerHour = empWagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours; 
    }
        
    }
}
