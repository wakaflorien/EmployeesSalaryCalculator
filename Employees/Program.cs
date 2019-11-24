using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator Cal = new SalaryCalculator();
            
            Console.WriteLine($"Enter Your Name , Gender, and Position respectively in that order");
            Cal.EmployeeName = Console.ReadLine();
            Cal.EmployeeGender = Console.ReadLine();
            Cal.position = Console.ReadLine();
            
            Console.WriteLine($"Enter Your GossSalary");
            double GrossSalary = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"Employee {Cal.EmployeeName} Your Monthly Salary on position of {Cal.position} is {Cal.MonthlySalary(GrossSalary)}");
            Console.WriteLine($"Employee {Cal.EmployeeName} Your One-Time Salary on position of {Cal.position} is {Cal.OneTimeSalary(GrossSalary)}");
            
            Console.WriteLine($"Enter Your Hourly rate and Hours Worked respectively to know your hourly Salary");

            double Rate = Convert.ToDouble(Console.ReadLine());
            double Hours = Convert.ToDouble(Console.ReadLine());
            if (Rate > 0 && Hours > 0)
            {
                Console.WriteLine($"Employee {Cal.EmployeeName} Your Hourly Salary on position of {Cal.position} is {Cal.HourlySalary(Rate,Hours)} ");
            }
            else
            {
                Console.WriteLine($"YouR RATE OR HOURS ARE LESS THAN OR EQUAL 0");
            }
        }
    }
}