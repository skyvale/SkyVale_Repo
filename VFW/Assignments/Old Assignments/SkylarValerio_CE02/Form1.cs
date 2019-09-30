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
 * 08.11.19
 * CE02: Passing Data and Multiple Forms
 * MDV1830-O 01
 */


namespace SkylarValerio_CE02
{
    public partial class ArtFight_2019 : Form
    {

        // gathers data for Team Nightmare
        Fighter NightmareData
        {
            get
            {
                Fighter returnObj = new Fighter();
                returnObj.username = txtUserName.Text;
                returnObj.password = txtPassword.Text;
                returnObj.isProfessional = chkProfessionalArtist.Checked;
                returnObj.preferredMedium = comBoxPreferredMedium.Text;
                return returnObj;
            }
        }

        // gathers data for Team Dream
        Fighter DreamData
        {
            get
            {
                Fighter returnObj = new Fighter();
                returnObj.username = txtUserName.Text;
                returnObj.password = txtPassword.Text;
                returnObj.isProfessional = chkProfessionalArtist.Checked;
                returnObj.preferredMedium = comBoxPreferredMedium.Text;
                return returnObj;
            }
        }


        public ArtFight_2019()
        {
            InitializeComponent();
        }


        // exits the application
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // adds user to Team Dream
        private void BtnDream_Click(object sender, EventArgs e)
        {
            // creates object
            listTeamDream.Items.Add(DreamData);

            // call the event handler to clear the form
            ClearForm_Event(this, new EventArgs());

        }


        // adds user to Team Nightmare
        private void BtnNightmare_Click(object sender, EventArgs e)
        {
            // creates object
            listTeamNightmare.Items.Add(NightmareData);

            // clear the form
            ClearForm_Event(this, new EventArgs());
        }


        // lets user select from Dream ListBox and populates form with info 
        private void listTeamDream_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTeamDream.SelectedItem != null)
            {
                txtUserName.Text = ((Fighter)listTeamDream.SelectedItem).username;
                txtPassword.Text = ((Fighter)listTeamDream.SelectedItem).password;
                chkProfessionalArtist.Checked = ((Fighter)listTeamDream.SelectedItem).isProfessional;
                comBoxPreferredMedium.Text = ((Fighter)listTeamDream.SelectedItem).preferredMedium;
            }
        }


        // lets user select from Nightmare ListBox and populates form with info 
        private void listTeamNightmare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTeamNightmare.SelectedItem != null)
            {
                txtUserName.Text = ((Fighter)listTeamNightmare.SelectedItem).username;
                txtPassword.Text = ((Fighter)listTeamNightmare.SelectedItem).password;
                chkProfessionalArtist.Checked = ((Fighter)listTeamNightmare.SelectedItem).isProfessional;
                comBoxPreferredMedium.Text = ((Fighter)listTeamNightmare.SelectedItem).preferredMedium;

            }
        }


        // event handler that will clear the form
        public void ClearForm_Event(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            chkProfessionalArtist.Checked = false;

        }

        private void StatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate new form (FighterCount)
            FighterCount statsDisplay = new FighterCount();

            // send the ListBox counts to FighterCount form using the CountDisplay public property within the form code
            statsDisplay.CountDream = listTeamDream.Items.Count.ToString();
            statsDisplay.CountNightmare = listTeamNightmare.Items.Count.ToString();

            // show the form
            statsDisplay.ShowDialog();

        }


        // method that will switch selected object from one ListBox to the other
        private void SwitchListBox(ListBox movingFrom, ListBox movingTo)
        {
            // access the objects in the ListBox that's having stuff moved from it
            ListBox.SelectedObjectCollection movingFromItems = movingFrom.SelectedItems;

            // move the object to the other ListBox
            foreach (var item in movingFromItems)
            {
                movingTo.Items.Add(item);
            }

            // remove the selected object from the original ListBox
            while (movingFrom.SelectedItems.Count > 0)
            {
                movingFrom.Items.Remove(movingFrom.SelectedItems[0]);
            }
        }


        // calls the switch method to switch from Nightmare ListBox to Dream ListBox
        private void BtnSwitchToDream_Click(object sender, EventArgs e)
        {
            SwitchListBox(listTeamNightmare, listTeamDream);
 
        }


        // calls the switch method to switch from Dream ListBox to Nightmare ListBox
        private void BtnSwitchToNightmare_Click(object sender, EventArgs e)
        {
            SwitchListBox(listTeamDream, listTeamNightmare);

        }


        // removes selected object (fighter) from ListBox
        private void BtnRemoveFighter_Click(object sender, EventArgs e)
        {
            if (listTeamDream.SelectedItem != null)
            {
                listTeamDream.Items.Remove(listTeamDream.SelectedItem);
            }
            else if (listTeamNightmare.SelectedItem != null)
            {
                listTeamNightmare.Items.Remove(listTeamNightmare.SelectedItem);
            }

        }


        // clears the form
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            chkProfessionalArtist.Checked = false;
            comBoxPreferredMedium.SelectedIndex = -1;

        }
    }
}
