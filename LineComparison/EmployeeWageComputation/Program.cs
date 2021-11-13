using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmployeeWageProblem employee = new EmployeeWageProblem();
            employee.MonthlyEmployeeWage();
        }
    }
}