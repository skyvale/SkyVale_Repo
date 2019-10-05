using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFW_Day4Notes
{
    public partial class ListViewForm : Form
    {
        public ListViewForm()
        {
            InitializeComponent();
        }

        // event handler to copy data to the ListBoxForm
        public event EventHandler AddToParty;

        // property to hold the data of the selected item in the ListView
        public ListViewItem SelectedCharacter
        {
            get
            {
                // verify that an item is selected
                if (lvwCharacters.SelectedItems.Count > 0)
                {
                    return lvwCharacters.SelectedItems[0];
                }
                return null;
            }
        }


        // the event handler method to add the character to the ListView
        // make it public so it can be seen from the other class
        public void listViewForm_AddCharacter(object sender, EventArgs e)
        {
            // ListViews store their displayed items as ListViewItems
            ListViewItem lvi = new ListViewItem();

            // grab the data object from the sender
            DataClass data = (sender as DataEntryForm).Data;

            // the ListViewItem is an object with several properties we can set
            lvi.Text = data.ToString();
            lvi.ImageIndex = data.ImageIndex;

            // the Tag property can hold a reference to the object
            // so we can access everything as needed
            lvi.Tag = data;

            // add the ListViewItem to the ListView
            lvwCharacters.Items.Add(lvi);

        }


        // exits the application
        private void ListViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        // invoke the AddToParty method
        private void LvwCharacters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddToParty?.Invoke(this, new EventArgs());
        }
    }
}
