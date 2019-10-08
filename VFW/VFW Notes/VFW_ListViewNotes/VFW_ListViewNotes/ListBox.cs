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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }


        // when the user closes the form, the entire application will end
        private void ListBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        // as soon as the ListBox loads, instantiate the other two forms and display them
        private void ListBox_Load(object sender, EventArgs e)
        {
            // instantiate the two other forms
            Form1 form1Instance = new Form1();
            ListView myListView = new ListView();

            // do your subscriptions here since this is where you have access 
            // to ALL the forms

            // delegate on the left, eventhandler method on the right
            form1Instance.AddCharacter += myListView.ListViewForm_AddCharacter;
            myListView.AddToParty += MyListView_AddToParty;

            // show the forms (modeless)
            form1Instance.Show();
            myListView.Show();
                

        }

        // adds the selected character from the ListView to the ListBox
        private void MyListView_AddToParty(object sender, EventArgs e)
        {
            // remember that the Tag holds all the data for each object in the ListView
            listBoxParty.Items.Add((sender as ListView).SelectedCharacter.Tag);
        }
    }
}
