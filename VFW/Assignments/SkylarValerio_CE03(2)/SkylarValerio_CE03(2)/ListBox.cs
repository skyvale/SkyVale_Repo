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
    public partial class ListBox : Form
    {
        // delegate to uncheck the Display button if the form is closed in any way
        public event EventHandler UncheckDisplay;


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
            listBoxCharacters.Items.Clear();

            // clears the list
            (sender as Form1).CharacterList.Clear();
        }
    }
}
