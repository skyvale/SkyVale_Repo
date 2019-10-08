using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFW_ListViewNotes
{
    public partial class ListView : Form
    {
        // this delegate is for the event where the user adds
        // the character to the ListBox party 
        public event EventHandler AddToParty;

        // make a new listviewitem so that you can pass objects from the ListView class
        // to the ListBox class
        public ListViewItem SelectedCharacter
        {
            get
            {
                // check to make sure a listviewitem is actually selected
                if (listViewParty.SelectedItems.Count > 0)
                {
                    // grab the first thing in the listViewParty array
                    return listViewParty.SelectedItems[0];
                }
                
                // if the check fails, then here is a return so that the get still works
                return null;
            }
        }

        public ListView()
        {
            InitializeComponent();
        }


        // when the user closes the form, the entire application will end
        private void ListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        // this is the method tied to the EventHandler AddCharacter in Form1
        public void ListViewForm_AddCharacter(object sender, EventArgs e)
        {
            // remember that the listview ONLY takes in listview items 
            ListViewItem lvi = new ListViewItem();

            // create a new DataClass object
            // cast as Form1 because the info for the data object is in Form1
            DataClass data = (sender as Form1).Data;

            // set the text that shows up for east listview item to the name of their
            // respective objects
            lvi.Text = data.Name;

            // set the image index
            lvi.ImageIndex = data.ImageIndex;

            // remember that tags are part of any object
            // put all the data into the tag so that way you can later repopulate
            // the data on Form1 since you can just call the Tag property
            lvi.Tag = data;

            // add the new listview item to the ListView
            listViewParty.Items.Add(lvi);
        }

        // this is where the AddToParty delegate in the ListView is invoked!
        // when a character is double-clicked from the ListView, it is added to the ListBox
        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddToParty?.Invoke(this, new EventArgs());
        }
    }
}
