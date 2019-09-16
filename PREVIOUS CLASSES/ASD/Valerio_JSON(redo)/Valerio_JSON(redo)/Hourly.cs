using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_JSON_redo_
{
    class Hourly : Employee
    {

        protected decimal PayPerHour { get; set; }
        protected decimal HoursPerWeek { get; set; }

        public Hourly(decimal payh, decimal hweek, string n, string add) : base(n, add)
        {
            PayPerHour = payh;
            HoursPerWeek = hweek;


        }

        public override string Terminate()
        {
            return "\r\nHow could this happen to me...";

        }


        public override string StringtoSave()
        {
            return $"h,{Name},{Address},{PayPerHour},{HoursPerWeek}";

        }

    }

}
