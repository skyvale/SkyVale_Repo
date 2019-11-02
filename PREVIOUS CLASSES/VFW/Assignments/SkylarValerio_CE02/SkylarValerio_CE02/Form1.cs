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
 * 10.02.19
 * CE: Passing Data & Multiple Forms
 * VFW
 */

namespace SkylarValerio_CE02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdButtMale.Checked = true;
            this.Size = new Size(905, 435);
        }

        // getter
        Character fieldData
        {
            get
            {
                Character returnObject = new Character();               
                returnObject.Name = txtName.Text;
                returnObject.Gender = rdButtMale.Checked;
                returnObject.Clan = cmBoxClan.Text;
                returnObject.Role = cmBoxRole.Text;
                returnObject.Former = chkFormer.Checked;
                return returnObject;
            }
        }


        // exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // saves object to the Good Listbox
        private void btnGood_Click(object sender, EventArgs e)
        {
            listBoxGood.Items.Add(fieldData);
            ClearForm();
        }

        // saves object to the Evil Listbox
        private void btnEvil_Click(object sender, EventArgs e)
        {
            listBoxEvil.Items.Add(fieldData);
            ClearForm();
        }

        // clears the form inputs
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();

        }

        // method to clear form inputs
        private void ClearForm()
        {
            txtName.Clear();
            rdButtMale.Checked = true;
            cmBoxClan.SelectedIndex = -1;
            cmBoxRole.SelectedIndex = -1;
            chkFormer.Checked = false;
        }


        // deletes selection from listbox
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxGood.SelectedIndex >= 0)
            {
                listBoxGood.Items.RemoveAt(listBoxGood.SelectedIndex);
            }
            else if (listBoxEvil.SelectedIndex >= 0)
            {
                listBoxEvil.Items.RemoveAt(listBoxEvil.SelectedIndex);
            }
        }


        // this prevents the user from selecting from the evil listbox if
        // good listbox has something selected
        private void listBoxGood_Click(object sender, EventArgs e)
        {
            listBoxEvil.SelectedIndex = -1;
        }


        // this prevents the user from selecting from the good listbox if
        // good listbox has something selected
        private void listBoxEvil_Click(object sender, EventArgs e)
        {
            listBoxGood.SelectedIndex = -1;
        }


        // this swaps whatever the user has selected to the opposite list
        private void btnEviltoGood_Click(object sender, EventArgs e)
        {
            if (listBoxEvil.SelectedIndex >= 0)
            {
                // this adds the object to the other box
                listBoxGood.Items.Add(listBoxEvil.SelectedItem);
                // this deletes the object from the current box
                listBoxEvil.Items.RemoveAt(listBoxEvil.SelectedIndex);
            }
            else if (listBoxGood.SelectedIndex >= 0)
            {

                listBoxEvil.Items.Add(listBoxGood.SelectedItem);
                listBoxGood.Items.RemoveAt(listBoxGood.SelectedIndex);
            }
        }


        // this saves the current state of both list, including the objects contained
        // within the lists
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt file | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // open the streamwriter
                Stream stream = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(stream);

                // write each item in good listbox to writer
                foreach (Character item in listBoxGood.Items)
                {
                    sw.WriteLine("good" + "," + item.Name + "," + item.Gender + "," + item.Clan +
                                 "," + item.Role + "," + item.Former);
                }

                // write each item in evil listbox to writer
                foreach (Character item in listBoxEvil.Items)
                {
                    sw.WriteLine("evil" + "," + item.Name + "," + item.Gender + "," + item.Clan +
                                 "," + item.Role + "," + item.Former);

                }

                // close streamwriter
                sw.Close();
                stream.Close();
            }
        }


        // loads the character objects from the txt file and repopulates the listboxes
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // filter the file type
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

                        // puts the properties that make up each object into an array
                        // and then sorts it into its correct listbox
                        while ((readString = reader.ReadLine()) != null)
                        {
                            string[] readArray = readString.Split(',');
                            Character addCharacter = new Character();

                            // add items to array
                            addCharacter.Affiliation = readArray[0];
                            addCharacter.Name = readArray[1];
                            addCharacter.Gender = bool.Parse(readArray[2]);
                            addCharacter.Clan = readArray[3];
                            addCharacter.Role = readArray[4];
                            addCharacter.Former = bool.Parse(readArray[5]);

                            // determine which listbox to sort the character into
                            if (addCharacter.Affiliation == "good")
                            {
                                listBoxGood.Items.Add(addCharacter);
                            }
                            else if (addCharacter.Affiliation == "evil")
                            {
                                listBoxEvil.Items.Add(addCharacter);
                            }
                        }
                    }
                }
            }//ofd using loop
        }


        // this will open a new modal window to display the stats
        private void DisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // initialize new display form
            Display counter = new Display();

            // sends the listbox counts to the display form
            counter.GoodCount = listBoxGood.Items.Count.ToString();
            counter.EvilCount = listBoxEvil.Items.Count.ToString();

            // show the form
            counter.ShowDialog();

        }

        
        // if the user chooses an item from the good listbox, this will repopulate the form
        private void ListBoxGood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGood.SelectedItem != null)
            {
                txtName.Text = ((Character)listBoxGood.SelectedItem).Name;
                rdButtMale.Checked = ((Character)listBoxGood.SelectedItem).Gender;
                cmBoxClan.Text = ((Character)listBoxGood.SelectedItem).Clan;
                cmBoxRole.Text = ((Character)listBoxGood.SelectedItem).Role;
                chkFormer.Checked = ((Character)listBoxGood.SelectedItem).Former;

            }
        }


        // if the user chooses an item from the evil listbox, this will repopulate the form
        private void ListBoxEvil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvil.SelectedItem != null)
            {
                txtName.Text = ((Character)listBoxEvil.SelectedItem).Name;
                rdButtMale.Checked = ((Character)listBoxEvil.SelectedItem).Gender;
                cmBoxClan.Text = ((Character)listBoxEvil.SelectedItem).Clan;
                cmBoxRole.Text = ((Character)listBoxEvil.SelectedItem).Role;
                chkFormer.Checked = ((Character)listBoxEvil.SelectedItem).Former;

            }
        }



    }
}
