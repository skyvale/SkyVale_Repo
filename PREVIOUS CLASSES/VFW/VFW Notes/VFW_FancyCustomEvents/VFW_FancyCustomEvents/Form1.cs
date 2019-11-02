using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFW_FancyCustomEvents
{
    public partial class Form1 : Form
    {
        // delegate
        // this will send the data from Form1 to the SelectionForm so that
        // the fields will already be populated when the user selects a character
        public event EventHandler<SelectionForm.ChangeClassArgs> SendDataForward;


        public Form1()
        {
            InitializeComponent();
            PrePopulateView();
        }


        // pre-populates the listViewParty with information
        private void PrePopulateView()
        {
            // this will automatically add 4 default party members to the listview
            // when the form opens
            for (int i = 1; i <= 5; i++)
            {
                // make a listview item because you are adding the object
                // to the listview
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "Party Member" + i;
                lvi.ImageIndex = 0;
                listViewParty.Items.Add(lvi);

            }
        }


        // exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // when the user double-clicks on an  item in the listview
        // open the Selection Form
        private void listViewParty_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // initialize selection form
            SelectionForm selectionForm = new SelectionForm();

            // subscription for Change event
            selectionForm.Change += SelectionForm_Change;

            // subscription for sending data from SelectionForm to Form1
            SendDataForward += selectionForm.CatchData;

            // invoke SendDataForward before the form opens
            SendDataForward?.Invoke(this, new SelectionForm.ChangeClassArgs(listViewParty.SelectedItems[0].ImageIndex, listViewParty.SelectedItems[0].Text));

            // show the selectionForm as modal so the user can't open multiple instances at once
            selectionForm.ShowDialog();
        }


        // eventhandler
        // allows the user to select an item for the listbox and change their class
        private void SelectionForm_Change(object sender, SelectionForm.ChangeClassArgs e)
        {
            // note that the 'e' is the custom event, ChangeClassArgs
            // ChangeClassArgs includes an image index variable so you can access it here
            // changees the character's class
            listViewParty.SelectedItems[0].ImageIndex = e.imageIndex;

            // changes the character's name as well
            listViewParty.SelectedItems[0].Text = e.newName;
        }
    }
}
