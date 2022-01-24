using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpolyeeWages
{
    public class Emp1
    {
        public const int FULL_TIME = 2;
        public const int PART_TIME = 1;

        //Defining variables
        private string company = "";
        private int EmpRatePerHr;
        private int MaxWorkingDays;
        private int MaxWorkingHrsMonth;
        private int totalEmpWage;

        //Method to import variable value for given company
        public void Work(string company, int EmpRatePerHr, int MaxWorkingDays, int MaxWorkingHrsMonth)
        {
            this.company = company;
            this.EmpRatePerHr = EmpRatePerHr;
            this.MaxWorkingDays = MaxWorkingDays;
            this.MaxWorkingHrsMonth = MaxWorkingHrsMonth;
        }
        //Method to compute Emp wage 
        public void computeEmpWage()
        {
            //int totalEmpWage = 0;
            int totalWorkingdays = 0;
            int empWorkingHrs = 0;
            int empHrs = 0;

            while (empWorkingHrs < this.MaxWorkingHrsMonth && totalWorkingdays < this.MaxWorkingDays)
            {
                totalWorkingdays++;
                Random random = new Random();
                int randomInput = random.Next(0, 3);
                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        //Console.WriteLine("FullTime Employee is present "+empHrs);
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        //Console.WriteLine("PartTime Employee is present " +empHrs);
                        break;
                    default:
                        empHrs = 0;
                        //Console.WriteLine("Employee is absent " +empHrs);
                        break;
                }
                empWorkingHrs = empWorkingHrs + empHrs;
               // Console.WriteLine("Day : " + totalWorkingdays + " Emp Hrs : " + totalWorkingdays);
            }
            totalEmpWage = empWorkingHrs * this.EmpRatePerHr;
            Console.WriteLine("Total Working hrs  " + empWorkingHrs);
            //Console.WriteLine("total Emp Wage for company : " + company + " is " + totalEmpWage);
        }

        //Method to print the wages
        public override string ToString()
        {
            return "Total Emp wage for company : " + this.company + " is : " + this.totalEmpWage;
        }

    }
}      

           