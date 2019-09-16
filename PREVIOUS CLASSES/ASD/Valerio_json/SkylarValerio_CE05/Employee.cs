using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valerio_JSON2
{
    abstract class Employee : IComparable<Employee>
    {

        protected string Name { get; set; }
        protected string Address { get; set; }


        public Employee(string n, string add)
        {
            Name = n;
            Address = add;
            

        }


        public string GetName
        {
            get{ return Name; }
            set { Name = value; }
        }


        public string GetAddress
        {

            get { return Address; }
            set { Address = value; }

        }

        public virtual decimal CalculatePay()
        {
            return 0;

        }


        public abstract string Terminate();


        public int CompareTo (Employee other)
        {
            return Name.CompareTo(other.Name);

        }


        public abstract string StringtoSave();




    }
}
