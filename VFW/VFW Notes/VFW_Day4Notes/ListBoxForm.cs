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
    public partial class ListBoxForm : Form
    {
        // event handler to populate the DataEntryForm
        public event EventHandler PopulateForm;

        // because these forms need to be available to the entire application,
        // we'll make them global objects (available anywhere in the application)
        DataEntryForm dataEntryForm;
        ListViewForm listViewForm;


        public ListBoxForm()
        {
            InitializeComponent();
        }

        private void ListBoxForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ListBoxForm_Load(object sender, EventArgs e)
        {
            // instantiate the globals as the other two forms
            dataEntryForm = new DataEntryForm();
            listViewForm = new ListViewForm();

            // subscribe to the event handlers
            dataEntryForm.AddCharacter += listViewForm.listViewForm_AddCharacter;
            listViewForm.AddToParty += ListViewForm_AddToParty;
            PopulateForm += dataEntryForm.listBoxForm_PopulateForm;

            // show the forms as modeless (so you can move back and forth between all of them)
            dataEntryForm.Show();
            listViewForm.Show();

        }

        private void ListViewForm_AddToParty(object sender, EventArgs e)
        {
            // get the object data from the selected ListViewItem's Tag property
            lstParty.Items.Add((sender as ListViewForm).SelectedCharacter.Tag);
        }

        private void ListBoxForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PopulateForm(lstParty.SelectedItem, new EventArgs());
        }
    }
}
