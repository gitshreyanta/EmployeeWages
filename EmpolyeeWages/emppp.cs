namespace EmployeWage
{
    internal class emppp
    {
        private string company;
        private int empRatePerHr;
        private int maxWorkingDays;
        private int maxWorkingHrs;

        public emppp(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
    }
}