﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpolyeeWages
{

    internal class emppp
    {
        public string company;
        public int empRatePerHr, maxWorkingDays, maxWorkingHrs, totalWage;
        public emppp(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;

        }
        public void SetTotalWage(int totalWagee)
        {
            this.totalWage = totalWage;
        }
    }
}