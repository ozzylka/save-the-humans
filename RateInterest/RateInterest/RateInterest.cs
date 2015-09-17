using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateInterest
{
    class RateInterest
    {
        public const int hundred = 100;

        //public double rate = 0;
        public bool leapYear()
        {
            return true;
        }
        public double calculateRate(double annual, bool leap, double term, double credit)
        {
            double rate = 0;
            int daysYear = 365;
            if (leap) {
                daysYear += 1;
            }
            rate = (annual / hundred / daysYear * term) * credit;
            return rate;
        }
    }
}
