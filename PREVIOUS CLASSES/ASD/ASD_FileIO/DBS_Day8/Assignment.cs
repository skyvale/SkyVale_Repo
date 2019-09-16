using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DBS_Day8
{
    class Assignment
    {
        /* split name into two parts
         * path --> directory
         * destination --> file
         * 
         * dont forget the using system.IO at the top!
         * 
         */ 

        

        // You can add an @ symbol in front of a string to disable the escape backslashes
        // the amount of ..\ is how many levels it is in the code folder
        private string _directory = @"..\..\output\";
        private string _file = @"info.txt";

        public Assignment()
        {

            // check if file exists, and if not, create
            Directory.CreateDirectory(_directory);

            if (File.Exists(_directory + _file))
            {
                Console.WriteLine("File exists.\n");

            }
            else
            {
                File.Create(_directory + _file);

            }


            Load();



        }



        private void Load()
        {

            using (StreamReader streamread = new StreamReader(_directory + _file))
            {
                // .Peek() is a stream method that checks if there are characters (any value above 0 indicates there are chars)
                while (streamread.Peek() > 0)
                {


                }
             

            }


        }




        private void Save()
        {


            // write to the create text file
            // stream writer -- you are writing to a stream, and the stream is being saved to a txt file
            // anything created in the using block will be shut down/destroyed outside of the using block
            // you can do this so you don't forget to close the StreamWriter

            using (StreamWriter streamwriter = new StreamWriter(_directory + _file))
            {
                streamwriter.WriteLine("ASD is okay.");

            }



        }

    }
}
