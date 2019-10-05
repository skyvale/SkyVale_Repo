using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VFW_Day4Notes
{
    public class DataClass

        // highlighting the properties and right-clicking, then clicking on 'quick actions and refactoring' is a
        // short-cut to create getter/setters for them
    {
        // numeric updown always stores in decimal datatype, so 'age' will need to be decimal datatype too
        decimal age;
        string name;
        string gender;
        bool immortal;
        string className;
        int imageIndex;

        // getter/setters for the properties
        public decimal Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public bool Immortal { get => immortal; set => immortal = value; }
        public string ClassName { get => className; set => className = value; }
        public int ImageIndex { get => imageIndex; set => imageIndex = value; }
    }

    public override string ToString()
    {
        return className;

        64,64

    }
}
