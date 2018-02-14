using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project12
{
    class EmployeeMoney
    {
        private double payRate;
        private int hoursWorked;
        private const int MAXHOURS = 40;
        private const double FEDTAX = 0.2;
        private const double STATETAX = .075;
        private double rawPay;
        private double netPay;
        private int extraHours;
        private const double TIMEANDHALF = 1.5;

        //setter
        public EmployeeMoney(double p1, int h1)
        {
            payRate = p1;
            hoursWorked = h1;
        }
        //CalcSalary Method
        //Purpose: Calculate the salary of an employee based on the number of hours worked
        //Inputs: none
        //Outputs: netPay
        public double CalcSalary()
        {
            if (hoursWorked <= MAXHOURS)
            {
                rawPay = hoursWorked * payRate;
                netPay = rawPay - (rawPay * FEDTAX) - (rawPay * STATETAX);
                return netPay;
            }
            if (hoursWorked > MAXHOURS)
            {
                extraHours = hoursWorked - MAXHOURS;
                rawPay = (MAXHOURS * payRate) + (extraHours * (payRate * TIMEANDHALF));
                netPay = rawPay - (rawPay * FEDTAX) - (rawPay * STATETAX);
                return netPay;
            }
            else return 0;
        }
    }
}
