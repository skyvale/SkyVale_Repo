using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValerioSkylar_CE04
{
    class Course
    {

        public string Title { get; set; }
        public Teacher AssignedTeacher { get; set; }
        public Student[] AssignedStudents { get; set; }


        public Course(string t, int num)
        {
            Title = t;
            AssignedStudents = new Student[num];
          

        }



    }
}
