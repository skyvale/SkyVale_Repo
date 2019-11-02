using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylarValerio_CE03
{
    public class StudentEventArgs : EventArgs
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string Program { get; set; }
        public bool Above21 { get; set; }



    }
}
