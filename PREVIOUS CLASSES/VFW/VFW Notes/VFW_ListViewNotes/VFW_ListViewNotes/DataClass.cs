using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VFW_ListViewNotes
{
    // dont forget to make this class public so that
    // other files can use it!
    public class DataClass
    {
        string name;
        decimal age;
        string gender;
        bool immortal;
        string className;

        // since you're using a ListView, don't forget to make a variable
        // to store the ImageIndex
        int imageIndex;

        // to get these, highlight the original properties, then right-click and choose
        // 'quick actions' to create these properties
        // they are essentially the same thing as {get; set;}
        public string Name { get => name; set => name = value; }
        public decimal Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public bool Immortal { get => immortal; set => immortal = value; }
        public string ClassName { get => className; set => className = value; }
        public int ImageIndex { get => imageIndex; set => imageIndex = value; }


        public override string ToString()
        {
            return Name + " - " + ClassName;
        }
    }
}
