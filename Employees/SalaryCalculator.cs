namespace Employees
{
    public class SalaryCalculator
    {
        private string EmployeeId { get; }
        public string EmployeeName { get; set; }
        public string EmployeeGender { get; set; }
        public string position { get; set; }
            
        private static int EmployeeIdSeed = 0123456789;
            
        public SalaryCalculator()
        {
            this.EmployeeId = EmployeeIdSeed.ToString();
            EmployeeIdSeed++;

        }

        public double MonthlySalary(double GrossSalary)
        {
            double Salary1;
            Salary1 = GrossSalary - ((GrossSalary * 0.3) + (GrossSalary * 0.03) + (GrossSalary * 0.05));
            return Salary1;
        }

        public double HourlySalary(double rate, double Hours)
        {
            double Salary2;
            Salary2 = ((rate * Hours) - ((rate * 0.03) + (rate * 0.05)));
            return Salary2;
        }

        public double OneTimeSalary(double GrossSalary)
        {
            double Salary3;
            Salary3 = (GrossSalary - (GrossSalary * 0.3));
            return Salary3;
        }
    }
}