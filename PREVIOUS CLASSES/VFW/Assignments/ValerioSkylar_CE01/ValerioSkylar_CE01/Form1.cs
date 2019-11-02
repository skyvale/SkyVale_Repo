using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


/*
 * Skylar Valerio
 * 09.30.19
 * CE01: Introduction to Windows Forms
 * VFW
 * 
 */ 

namespace ValerioSkylar_CE01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radButMale.Checked = true;

        }

        // exits the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // clears the inputs on the form
        private void clrButton_Click(object sender, EventArgs e)
        {
            // clears the text in the text box
            txtName.Text = "";
            // resets the combo box so no text is showing
            comBoxSpecies.SelectedIndex = -1;
            // resets all the ticked boxes so they arent ticked
            radButMale.Checked = true;
            chkBoxEvil.Checked = false;

        }

        // saves the current input as a txt file
        private void btnSave_Click(object sender, EventArgs e)
        {
            // create a new save file, default name user.txt, filter as txt file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "user.txt";
            sfd.Filter = "txt file | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // open the streamwriter
                Stream stream = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(stream);

                // write the info to a file
                sw.WriteLine(txtName.Text);
                sw.WriteLine(comBoxSpecies.Text);
                sw.WriteLine(radButMale.Checked);
                sw.WriteLine(chkBoxEvil.Checked);

                // close the streamwriter
                sw.Close();
                stream.Close();
            }
        }

        // loads previously saved objects
        // user chooses file from computer
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.FileName = "user.txt";
                ofd.Filter = "txt file | *.txt";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // get the file path
                    var filePath = ofd.FileName;

                    // use streamreader to read the contents of the file
                    var fileStream = ofd.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string readString = "";
                        List<string> readList = new List<string>();

                        while ((readString = reader.ReadLine()) != null)
                        {
                            readList.Add(readString);
                        }

                        txtName.Text = readList[0];
                        comBoxSpecies.Text = readList[1];

                        // checks if male or female radio btn was checked or not
                        if (readList[2] == "False")
                        {
                            radButFemale.Checked = true;
                        }
                        else if (readList[2] == "True")
                        {
                            radButMale.Checked = true;
                        }

                        // checks if evil box is checked or not
                        if (readList[3] == "False")
                        {
                            chkBoxEvil.Checked = false;
                        }
                        else if (readList[3] == "True")
                        {
                            chkBoxEvil.Checked = true;
                        }

                    }


                }
            }
        }
    }
}
