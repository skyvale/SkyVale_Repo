using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkylarValerio_CE03_2_
{
    public partial class Form1 : Form
    {
        // delegate for event that determines if the ListBox form is open or closed
        public event EventHandler IsClosed;

        // delegate for event that sends created character object to the listbox on the 
        // ListBox form when the 'add' button is clicked on Form1
        public event EventHandler AddToListBox;

        // delegate for event that populates the ListBox when the user hits 'display'
        public event EventHandler PopulateListBox;

        // delegate for event that clears the List and the ListBox when
        // 'Form1 - Clear All' is clicked
        public event EventHandler Form1ClearAll;

        // list that will hold all the created characters
        List<Character> characterList = new List<Character>();

        // accessor for the characterList so thingss are kept private
        public List<Character> CharacterList
        {
            get
            {
                return characterList;
            }

        }

        // accessor for all the character data
        public Character CharacterInfo
        {
            get
            {
                Character c = new Character();
                c.Name = txtName.Text;
                c.Gender = rdMale.Checked;
                c.Starter = comBoxStarter.Text;
                c.Region = comBoxRegion.Text;
                c.NewPlayer = chkNewPlayer.Checked;
                return c;
            }
            set
            {
                txtName.Text = value.Name;
                rdMale.Checked = value.Gender;
                comBoxStarter.Text = value.Starter;
                comBoxRegion.Text = value.Region;
                chkNewPlayer.Checked = value.NewPlayer;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        // exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // instantiate and show the ListBox form
        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate the ListBox Form
            ListBox listBox = new ListBox();

            // subscription for IsClosed eventhandler
            IsClosed += listBox.ListForm_CloseAndUncheck;

            // subscription for UncheckDisplay eventhnandler
            listBox.UncheckDisplay += ListBox_UncheckDisplay;

            // subscription for the PopulateListBox eventhandler
            PopulateListBox += listBox.ListForm_PopulateListBox;

            // subscription for AddToListBox eventhandler
            AddToListBox += listBox.ListForm_AddCharacter;

            // subscription to Form1ClearAll eventhandler
            Form1ClearAll += listBox.ListForm_ClearAll;

            // check if the Display button is checked
            // if it is, then open the form, but if it isnt, close the form and uncheck it
            if(btnDisplay.Checked == false)
            {
                // check the button, since youre opening the form
                btnDisplay.Checked = true;

                // repopulate the listbox with the list
                PopulateListBox?.Invoke(this, new EventArgs());

                // show the ListBox form (modeless)
                listBox.Show();
            }
            else if(btnDisplay.Checked == true)
            {     
                // call the custom event to close the other form
                IsClosed?.Invoke(this, new EventArgs());
            }

        }

        // eventhandler method that will uncheck the display button when 
        // the listbox form is closed
        private void ListBox_UncheckDisplay(object sender, EventArgs e)
        {
            btnDisplay.Checked = false;
        }


        // when the 'add' button is clicked, this method will
        // add the created character to the characterList AND it will add to the ListBox
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // add the created character to the characterList
            characterList.Add(CharacterInfo);

            // invoke the AddToListBox eventhandler
            AddToListBox?.Invoke(this, new EventArgs());

            // clears the user inputs after they click 'add'
            ClearInputs();

        }


        // when the user hits 'clear', this will clear the user inputs
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();

        }


        // clears the user inputs
        private void ClearInputs()
        {
            txtName.Clear();
            rdMale.Checked = true;
            comBoxStarter.SelectedIndex = -1;
            comBoxRegion.SelectedIndex = -1;
            chkNewPlayer.Checked = false;
        }


        // when the user clicks 'Clear All', this will clear the list and ergo, the listbox
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clears the list and ergo, clears the listbox
            Form1ClearAll?.Invoke(this, new EventArgs());

            // clears the inputs
            ClearInputs();

        }
    }
}
