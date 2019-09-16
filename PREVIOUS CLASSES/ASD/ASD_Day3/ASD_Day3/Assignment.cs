using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_Day3
{
    class Assignment
    {

        // USING DICTIONARIES WITH LISTS
        //----------------------------------------


        // declare the dictionary variable
        private Dictionary<string, List<Student>> _classes = new Dictionary<string, List<Student>>();


        // create the main method
        public Assignment()
        {

            // add lists to the list in the dictionary, list-ception
            // don't forget to instantiate the list (new)
            _classes.Add("ASD", new List<Student>());
            _classes.Add("DVP2", new List<Student>());
            _classes.Add("VFW", new List<Student>());

            // create a new student element to add to the list(s)
            Student student = new Student("Bob");
            Student student1 = new Student("Scott");
            Student student2 = new Student("George");
            Student student3 = new Student("Lee");
            Student student4 = new Student("King Arthur");


            // assign some grades
            student.Grades.Add(98);
            student.Grades.Add(87);
            student.Grades.Add(92);


            // add students to these new lists
            _classes["ASD"].Add(student);
            _classes["DVP2"].Add(student1);
            _classes["ASD"].Add(student2);
            _classes["VFW"].Add(student3);
            _classes["VFW"].Add(student4);


            // loop through the lists to display the students in each class
            foreach (KeyValuePair<string, List<Student>> item in _classes)
            {

                // first, write the title of the class (the key)
                Console.WriteLine(item.Key);

                // then, before you loop again and write the next title, list the students in said class
                foreach (Student students in item.Value)
                {
                    Console.WriteLine(students.Name + "     " + students.DisplayGrades());

                }



            }


        }

    }
}
