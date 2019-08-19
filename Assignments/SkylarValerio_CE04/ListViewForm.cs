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
 * 08.18.2019
 * CE04: ListViews
 * MDV1830-O
 */

namespace SkylarValerio_CE04
{
    public partial class ListViewForm : Form
    {

        // event handler to remove all from list
        public event EventHandler RemoveAll;

        // event handler to change which object is selected in the ListView
        public event EventHandler SelectionChanged;

        // return the character for SelectionChanged
        public Character SelectedObject
        {
            get
            {

                //the tag is seen as a random object, so cast it so the program sees the info as a character
                if (lvwCharacters.SelectedItems.Count > 0)
                {
                    return lvwCharacters.SelectedItems[0].Tag as Character;
                }
                else
                {
                    // if nothing is selected, show an empty character
                    return new Character();
                }
            }
        }

        public ListViewForm()
        {
            InitializeComponent();
        }


        // event handler to add character to ListViewForm
        public void AddToListForm_EventHandler(object sender, CharacterArgs e)
        {
            Character c = new Character();
            c.Name = e.Name;
            c.Gender = e.Gender;
            c.Region = e.Region;
            c.StarterPokemon = e.StarterPokemon;
            c.ImageIndex = e.ImageIndex;

            // add the character as a ListViewItem
            ListViewItem lvi = new ListViewItem();
            lvi.Text = c.ToString();
            lvwCharacters.Items.Add(lvi);
            lvi.Tag = c;

            // get the index of the created character and set it to the ImageIndex so the images will show in ListView
            int index = lvwCharacters.Items.IndexOf(lvi);
            lvwCharacters.Items[index].ImageIndex = c.ImageIndex;

        }

        // deletes all characters from the ListViewForm and the characterList
        public void BtnClearAll_Click(object sender, EventArgs e)
        {
            // clears all items in the ListView
            lvwCharacters.Items.Clear();

            // deletes the items from the characterList
            RemoveAll?.Invoke(this, new EventArgs());

        }

        private void LvwCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // raise the SelectionChanged method
            if (SelectionChanged != null)
            {
                SelectionChanged?.Invoke(this, new EventArgs());
            }

        }
    }
}
