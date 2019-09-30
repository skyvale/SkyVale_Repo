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
    public partial class UserInputForm : Form
    {
        // event handlers to subscribe to the ListView's method
        public event EventHandler <CharacterArgs> AddToList;


        // stores the character data
        public Character CharacterData
        {
            get
            {
                Character c = new Character();
                c.Name = txtName.Text;
                c.Gender = cmbGender.Text;
                c.Region = cmbRegion.Text;
                c.StarterPokemon = cmbStarterPokemon.Text;
                c.ImageIndex = cmbStarterPokemon.SelectedIndex;
                return c;
            }
            set
            {
                txtName.Text = value.Name;
                cmbGender.Text = value.Gender;
                cmbRegion.Text = value.Region;
                cmbStarterPokemon.Text = value.StarterPokemon;
            }
        }


        public UserInputForm()
        {
            InitializeComponent();

        }



        // clears the form
        private void ClearForm()
        {
            txtName.Clear();
            cmbGender.SelectedIndex = -1;
            cmbRegion.SelectedIndex = -1;
            cmbStarterPokemon.SelectedIndex = -1;

        }


        // clears the UserInputForm when clicked
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


        // event handler method to populate the form
        public void PopulateForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterData = (sender as Character);
        }


        // event to add objects to list
        private void BtnAddToList_Click(object sender, EventArgs e)
        {
            // create the character object
            CharacterArgs c = new CharacterArgs();
            c.Name = txtName.Text;
            c.Gender = cmbGender.Text;
            c.Region = cmbRegion.Text;
            c.StarterPokemon = cmbStarterPokemon.Text;           

            // get the index num of the selected starter pokemon in the combo box
            c.ImageIndex = cmbStarterPokemon.SelectedIndex;

            // invoke
            AddToList?.Invoke(this, c);

            // clear the form
            ClearForm();
        }


        // method that 
        public void SelectionChanged_EventHandler(object sender, EventArgs e)
        {
            // make sure the program knows the sender is a ListViewForm
            ListViewForm lvf = sender as ListViewForm;

            CharacterData = lvf.SelectedObject;

        }
    }
}
