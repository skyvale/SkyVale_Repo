using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> myList = new List<int>() { 10, 20, 30 };
            myList.Add(25);
            int n = myList.Count + 1;
            myList[0] = n;
            myList.RemoveAt(1);
            myList[n - 4] = 8;


            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
               
            }
        }
    }
}
