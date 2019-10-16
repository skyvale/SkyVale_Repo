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
 * 10.09.19
 * CE04: ListViews
 * VFW
 * 
 */

namespace SkylarValerio_CE04
{
    public partial class UserInput : Form
    {
        // delegate
        // saves the created character from UserInput to the characterList in Form1
        public event EventHandler SaveToList;


        // getter setter for trainer properties
        public Trainer TrainerInfo
        {
            get
            {
                Trainer t = new Trainer();
                t.Name = txtName.Text;
                t.MaleGender = rdMale.Checked;
                t.FemaleGender = rdFemale.Checked;
                t.TrainerType = comBoxTrainerType.Text;
                t.Starter = comBoxStarter.Text;
                t.ImageIndex = comBoxStarter.SelectedIndex;
                return t;
            }
            set
            {
                txtName.Text = value.Name;
                rdMale.Checked = value.MaleGender;
                rdFemale.Checked = value.FemaleGender;
                comBoxTrainerType.Text = value.TrainerType;
                comBoxStarter.Text = value.Starter;

            }

        }



        public UserInput()
        {
            InitializeComponent();
            rdMale.Checked = true;

        }


        // clears the inputs
        private void btnClearInputs_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            rdMale.Checked = true;
            comBoxTrainerType.SelectedIndex = -1;
            comBoxStarter.SelectedIndex = -1;

        }


        // invoke SaveToList
        // saves character to list in Form1
        private void btnSaveCharacter_Click(object sender, EventArgs e)
        {
            SaveToList?.Invoke(this, new EventArgs());
            this.Close();
        }


        // eventhandler
        // repopulates the inputs based on selected item in listview
        public void UserInput_Repopulate(object sender, EventArgs e)
        {
            ListViewForm lv = sender as ListViewForm;

            Trainer trainer = lv.GetListView.SelectedItems[0].Tag as Trainer;

            txtName.Text = trainer.Name;
            rdMale.Checked = trainer.MaleGender;
            rdFemale.Checked = trainer.FemaleGender;
            comBoxTrainerType.Text = trainer.TrainerType;
            comBoxStarter.Text = trainer.Starter;

        }

    }
}
