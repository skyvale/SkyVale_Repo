using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_JSON2
{
    class Salaried : Employee
    {

        protected decimal Salary;

        public Salaried(decimal s, string n, string add) : base(n, add)
        {
            Salary = s;

        }

        public override decimal CalculatePay()
        {

            decimal paycheck = Salary;

            return paycheck;

        }


        public override string Terminate()
        {
            return "\r\nWhyyyyy";

        }


        public override string StringtoSave()
        {
            return $"s,{Name},{Address},{Salary}";

        }


    }
}
