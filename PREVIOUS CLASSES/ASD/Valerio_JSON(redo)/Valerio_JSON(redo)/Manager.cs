using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_JSON_redo_
{
    class Manager : Salaried
    {

        private decimal Bonus { get; set; }

        public Manager(decimal b, decimal s, string n, string add) : base(s, n, add)
        {
            Bonus = b;

        }



        public override decimal CalculatePay()
        {

            decimal paycheck = Salary + Bonus;

            return paycheck;

        }


        public override string Terminate()
        {
            return "\r\nYou can't fire me, I'm your boss!";

        }


        public override string StringtoSave()
        {
            return $"m,{Name},{Address},{Salary},{Bonus}";


        }


    }
}
