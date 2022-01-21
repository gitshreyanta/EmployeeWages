using System;
using System.Collections.Generic;
using System.Text;

namespace EmpolyeeWages
{
    public class Emp1
    {
        const int FULL_TIME = 2;
        const int PART_TIME = 1;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;

        public void Work()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //to check condition of 100 working hrs or 20 days
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int randomInput = random.Next(0, 3);
                //loop to check emp present full-time part-time or absent
                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        //Console.WriteLine("FullTime Employee is present");
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        //Console.WriteLine("Part-Time employee is present");
                        break;
                    default:
                        empHrs = 0;
                        //Console.WriteLine("Employee is absent");
                        break;
                }
                //calculating total emp wage
                totalEmpHrs += empHrs;
                //Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            // Printing totalworking days and totalworking hrs
            Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs : " + totalEmpHrs);
            //printing total emp wage
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }


    }
}
