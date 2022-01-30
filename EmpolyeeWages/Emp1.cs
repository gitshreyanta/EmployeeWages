using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpolyeeWages
{
    public class Emp1 : IComputeEmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public static int empHrs = 0;
        int empWage;
        int days = 1;
        int empWorkingHrs = 0;
        emppp[] CompanyRecord = new emppp[5];
        public int numOfCompany = 0;

        //method to add company
        public void AddCompany(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            emppp emp = new emppp(company, empRatePerHr, maxWorkingDays, maxWorkingHrs);
            this.CompanyRecord[this.numOfCompany] = emp;       //storing details in array with respecting index.
            numOfCompany++;
        }

        //method to get wage for each company
        public void GetWage()
        {

            for (int i = 0; i < numOfCompany; i++)
            {
                int result = CalWage(this.CompanyRecord[i]);
                this.CompanyRecord[i].SetTotalWage(result);
            }
        }
        //method to calculate total wage 
        public int CalWage(emppp emp)
        {
            int totalWage = 0;
            Random random = new Random();
            while (empWorkingHrs <= emp.maxWorkingHrs && days <= emp.maxWorkingDays)
            {
                int randomInput = random.Next(0, 3);
                // calling method to fetch working hours
                GetWorkingHrs(randomInput);
                empWage = emp.empRatePerHr * empHrs;
                //Console.WriteLine("Employee wage for DAy {0} is {1}", days, empWage);
                totalWage += empWage;
                empWorkingHrs += empHrs;

                if (empWorkingHrs > emp.maxWorkingHrs)
                {
                    empWorkingHrs = emp.maxWorkingHrs;
                    break;
                }
                days++;

            }
            Console.WriteLine("\nEmployee of company : {0} , Total wage is : {1} ", emp.company, totalWage);
            return totalWage;
        }

        //method to calculate  calculate working hours
        public static void GetWorkingHrs(int randomInput)
        {

            switch (randomInput)
            {
                case FULL_TIME:
                    empHrs = 8;
                    //Console.WriteLine("Employee is present fulltime "+empHrs);
                    break;
                case PART_TIME:
                    empHrs = 4;
                    //Console.WriteLine("Employee is present parttime " +empHrs);
                    break;
                default:
                    empHrs = 0;
                    //Console.WriteLine("Employee is absent " +empHrs);
                    break;
            }
        }
    }
}
