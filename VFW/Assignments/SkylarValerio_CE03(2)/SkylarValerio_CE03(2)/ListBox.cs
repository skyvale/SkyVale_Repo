using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Skylar Valerio
 * 10.07.19
 * CE03: Custom Events
 * VFW
 * 
 * This is my listbox form, which displays the characters the user creates
 * and allows them to choose from the list to repopulate Form1 with character info
 */

namespace SkylarValerio_CE03_2_
{
    public partial class ListBox : Form
    {
        // delegate to uncheck the Display button if the form is closed in any way
        public event EventHandler UncheckDisplay;

        // delegate to clear the ListBox and the List in Form1 when
        // 'ListBox - clear all' is clicked
        public event EventHandler ListBoxClearAll;

        // delegate to repopulate form when user chooses item from ListBox
        public event EventHandler RepopulateInputs;

        public List<Character> otherList = new List<Character>();

        public Character GetCharacter
        {           
            get
            {

                return ((Character)listBoxCharacters.SelectedItem);

            }
        }

        public ListBox()
        {
            InitializeComponent();
        }


        // eventhandler
        // when called this closes the ListBox form
        public void ListForm_CloseAndUncheck(object sender, EventArgs e)
        {
            this.Close();
        }


        // eventhandler
        // populates the ListBox with the items in the List
        public void ListForm_PopulateListBox(object sender, EventArgs e)
        {
            foreach (Character c in ((sender as Form1).CharacterList))
            {
                listBoxCharacters.Items.Add(c);
            }
        }


        // eventhandler
        // adds a new character to the ListBox using the List from Form1
        public void ListForm_AddCharacter(object sender, EventArgs e)
        {
            // add whatever is in the CharacterList on Form1 to the ListBox on this form
            listBoxCharacters.Items.Add((sender as Form1).CharacterList[(sender as Form1).CharacterList.Count-1]);

        }

        // eventhandler
        // when the form is closed, this will uncheck the display button on Form1
        private void ListBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            UncheckDisplay?.Invoke(this, new EventArgs());
        }


        // eventhandler
        // when 'clear all' is hit on Form1, this will clear the List/ListBox
        public void ListForm_ClearAll(object sender, EventArgs e)
        {
            // clears the listbox
            ClearListBox();

            // clears the list
            (sender as Form1).CharacterList.Clear();
        }


        // clears the listbox
        public void ClearListBox()
        {
            listBoxCharacters.Items.Clear();
        }


        // clears the list and listbox when user hits 'clear all'
        private void ToolStripClearAll_Click(object sender, EventArgs e)
        {
            // calls the method to clear the listbox and list
            ListBoxClearAll?.Invoke(this, new EventArgs());
        }


        // when the user selects an item from the list, it will repopulate the Form1 inputs with the info
        public void ListBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            RepopulateInputs?.Invoke(this, new EventArgs());
        }
    }
}
