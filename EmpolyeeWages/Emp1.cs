using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpolyeeWages
{
    //Inheriting class to Employee Wage class
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

        //Declaring list and dictionary
        public IList<emppp> CompanyEmpWge;
        public IDictionary<string, emppp> employees;

        //Constructor to initialise list and dictonary
        public Emp1()
        {
            this.CompanyEmpWge = new List<emppp>();
            this.employees = new Dictionary<string, emppp>();
        }
        //method to Add a company
        public void AddCompany(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            emppp emp = new emppp(company, empRatePerHr, maxWorkingDays, maxWorkingHrs);
            CompanyEmpWge.Add(emp);
            employees.Add(company, emp);
        }

        //Method to get Wages for each company
        public void GetWage()
        {
            foreach (emppp empp in this.CompanyEmpWge)
            {
                empp.SetTotalWage(CalWage(empp));
            }

        }
        //Method to calculate total Wage of company
        public int CalWage(emppp emp)
        {
            int totalWage = 0;
            Random random = new Random();
            while (empWorkingHrs <= emp.maxWorkingHrs && days <= emp.maxWorkingDays)
            {
                int randomInput = random.Next(0, 3);
                //method calling to fetch working hours
                GetWorkingHrs(randomInput);
                empWage = emp.empRatePerHr * empHrs;
                //Console.WriteLine("Employee wage for Day {0} is {1}", days, empWage);
                totalWage += empWage;
                empWorkingHrs += empHrs;

                if (empWorkingHrs > emp.maxWorkingHrs)
                {
                    empWorkingHrs = emp.maxWorkingHrs;
                    break;
                }
                days++;

            }
            Console.WriteLine("\ncompany : {0} , Total wage is : {1} ", emp.company, totalWage);
            return totalWage;
        }
        //Method to get total Company Wage
        public int GetTotalWage(string company)
        {
            return this.employees[company].totalWage;
        }

        //method to calculate working hours
        public static void GetWorkingHrs(int randomInput)
        {

            switch (randomInput)
            {
                case FULL_TIME:
                    empHrs = 8;
                    //Console.WriteLine("FullTime Employee is present "+empHrs);
                    break;
                case PART_TIME:
                    empHrs = 4;
                    //Console.WriteLine("Parttime Employee is present  " +empHrs);
                    break;
                default:
                    empHrs = 0;
                    //Console.WriteLine("Employee is absent " +empHrs);
                    break;
            }
        }
    }
}
