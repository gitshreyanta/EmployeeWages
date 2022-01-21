using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpolyeeWages
{
    public class Emp1
    {
        public static void IffElse()
        {
            Random random = new Random();

            int RandomNumber = random.Next(0, 2);


            if (RandomNumber == 0)
            {
                Console.WriteLine("Emplyee is Present");
            }
            else
            {
                Console.WriteLine("Emplyee is absent");
            }

        }
    }
}
