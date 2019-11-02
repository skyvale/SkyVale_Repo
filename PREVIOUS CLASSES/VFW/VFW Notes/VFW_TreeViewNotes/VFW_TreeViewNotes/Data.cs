using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VFW_TreeViewNotes
{
    class Data
    {
        int dataNumber;
        int height;
        int weight;
        List<Data> containsData = new List<Data>();

        public int DataNumber { get => dataNumber; set => dataNumber = value; }
        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }
        internal List<Data> ContainedData { get => containsData; set => containsData = value; }

        public override string ToString()
        {
            return "Data Number " + DataNumber;
        }

    }
}
