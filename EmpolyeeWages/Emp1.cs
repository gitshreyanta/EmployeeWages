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
        public static int empHrs = 0;

        //Method to calculate wage for multiple companies
        public void Work(string company, int EmpRatePerHr, int MaxWorkingDays, int MaxWorkingHrs)
        {

            int totalWage = 0;
            int empWage;
            int totalWorkingdays = 0;
            int empWorkingHrs = 0;

            //Random obj created
            Random random = new Random();
            //iterating Working hrs of emp for max hours and days 
            while (empWorkingHrs < MaxWorkingHrs && totalWorkingdays <= MaxWorkingDays)
            {
                int randomInput = random.Next(0, 3);
                //calling method to get working hours of employee
                CalculateWorkingHrs(randomInput);
                empWage = EmpRatePerHr * empHrs;
                //Console.WriteLine("Employee wage for Day {0} is {1}", days, empWage);
                totalWage = totalWage + empWage;
                empWorkingHrs = empWorkingHrs + empHrs;

                if (empWorkingHrs > MaxWorkingHrs)
                {

                    empWorkingHrs = MaxWorkingHrs;
                    break;
                }
                totalWorkingdays++;

            }
            Console.WriteLine("{0} Employee worked for {1}days / {2}days and {3}hours / {4}hours.Total Employee wage is:{5} ", company, totalWorkingdays , MaxWorkingDays, empWorkingHrs, MaxWorkingHrs, totalWage);
        }

        //method to get working hours of employee
        public static void CalculateWorkingHrs(int randomInput)
        {

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
        }
    }
}