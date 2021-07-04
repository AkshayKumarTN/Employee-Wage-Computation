using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Employee Wage Computation \n");
         
            CompanyEmpWage companyEmpWage = new CompanyEmpWage();
            companyEmpWage.addCompanyEmpWage("DELL", 20, 20, 100);
            companyEmpWage.addCompanyEmpWage("HP", 20, 20, 100);
            companyEmpWage.computeEmpWage();
            Console.WriteLine("Total Wage of DELL Company : "+companyEmpWage.GetTotalWage("DELL"));
            Console.WriteLine("Total Wage of HP Company : " + companyEmpWage.GetTotalWage("HP"));
        }
    }
}
