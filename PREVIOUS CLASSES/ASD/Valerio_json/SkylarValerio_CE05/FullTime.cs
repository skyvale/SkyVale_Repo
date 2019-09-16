using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylarValerio_CE05
{
    class FullTime : Hourly
    {

        public FullTime(string n, string add, decimal payh, decimal hweek) : base(payh, hweek, n, add)
        {


        }


        public override decimal CalculatePay()
        {

           decimal paycheck = PayPerHour * HoursPerWeek;

            return paycheck;

        }


        public override string StringtoSave()
        {

            return $"f,{Name},{Address},{PayPerHour},{HoursPerWeek}";

        }

    }
}
