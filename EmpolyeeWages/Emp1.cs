using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpolyeeWages
{
    public class EmpWage
    {
        public int empHrs;
        public int empTotalWage;

        public void IffElse()
        {
            int wagePerHrs = 20;
            Random random = new Random();

            //To check emp present or not
            int RandomNumber = random.Next(0, 2);


            if (RandomNumber == 0)
            {
                Console.WriteLine("Emplyee is Present");
                //To check full time or not
                int check = random.Next(0, 2);
                if (check == 1)
                {
                    Console.WriteLine("Employe is present for full time");
                    empHrs = 8;

                }
            }
            else
            {
                Console.WriteLine("Emplyee is absent");
            }
            //calculating total emp wage
            empTotalWage = wagePerHrs * empHrs;
            //printing total emp wage
            Console.WriteLine("EmployeWage Total Wage Is = " + empTotalWage);

        }
    }
}