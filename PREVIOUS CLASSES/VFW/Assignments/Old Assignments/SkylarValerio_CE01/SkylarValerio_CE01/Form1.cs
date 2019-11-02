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
 * 07.13.19
 * VFW C201907
 * CE: Introduction to Windows Forms
 *
 */


namespace SkylarValerio_CE01
{
    public partial class usersForm : Form
    {

        // initialize form
        public usersForm()
        {
            InitializeComponent();

        }


        // saves the user input
        private void saveMenuButton_Click(object sender, EventArgs e)
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
                sw.WriteLine(usernameTextBox.Text);
                sw.WriteLine(passwordTextBox.Text);
                sw.WriteLine(genderComboBox.Text);
                sw.WriteLine(studentCheckbox.Checked);

                // close the streamwriter
                sw.Close();
                stream.Close();

            }

        }

        // loads previously saved objects
        // user chooses file from computer
        private void loadMenuButton_Click(object sender, EventArgs e)
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

                        usernameTextBox.Text = readList[0];
                        passwordTextBox.Text = readList[1];
                        genderComboBox.Text = readList[2];

                        if (readList[3] == "False")
                        {
                            studentCheckbox.Checked = false;
                        }
                        else if (readList[3] == "True")
                        {
                            studentCheckbox.Checked = true;
                        }
                        
                    }


                }
            }

        }

        // resets inputs to default
        private void resetButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            studentCheckbox.Checked = false;
            genderComboBox.Text = "";

        }

        // exits the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

}
