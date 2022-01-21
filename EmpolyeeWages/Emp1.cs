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

        //Method to Calculate the Wages of Emp
        public static void Work()
        {

            int totalWage = 0;
            int empWage;
            const int EMP_RATE_PER_HR = 20;
            const int NUM_OF_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            int totalWorkingdays = 0;
            int empWorkingHrs = 0;
            //Random obj created
            Random random = new Random();
            //iterating for Maximum working days and hours
            while (totalWorkingdays <= NUM_OF_WORKING_DAYS && empWorkingHrs <= MAX_WORKING_HRS)
            {
                int randomInput = random.Next(0, 3);

                //calling method to get  the working hours
                CalculateWorkingHrs(randomInput);
                empWage = EMP_RATE_PER_HR * empHrs;
                //Console.WriteLine(" Total Employee wage for Days {0} is {1}", totalWorkingdays, empWage);
                totalWage = totalWage + empWage;
                empWorkingHrs = empWorkingHrs + empHrs;
                totalWorkingdays++;

            }
            Console.WriteLine("total wage for {0} Days and hrs:{1} is:{2} ", NUM_OF_WORKING_DAYS, empWorkingHrs, totalWage);
        }


        //method to calculate emp hours
        public static void CalculateWorkingHrs(int randomInput)
        {
            //switch case to check emp present or not
            switch (randomInput)
            {
                case FULL_TIME:
                    empHrs = 8;
                    //Console.WriteLine("FullTime Employee is present");
                    break;
                case PART_TIME:
                    empHrs = 4;
                    //Console.WriteLine("PartTime Employee is present");
                    break;
                default:
                    empHrs = 0;
                    //Console.WriteLine("Employee is absent");
                    break;
            }
        }


    }
}