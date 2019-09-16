using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_JSON_redo_
{
    class PartTime : Hourly
    {

        public PartTime(decimal payh, decimal hweek, string n, string add) : base(payh, hweek, n, add)
        {


        }


        public override decimal CalculatePay()
        {

            decimal paycheck = PayPerHour * HoursPerWeek;

            return paycheck;

        }

        public override string StringtoSave()
        {
            return $"p,{Name},{Address},{PayPerHour},{HoursPerWeek}";

        }

    }

}
