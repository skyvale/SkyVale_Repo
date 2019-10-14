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
 * 10.13.19
 * CE06: Treeview & Tab Control
 * VFW
 */
 
// TODO!! clicking add will add double items to the treeview

namespace SkylarValerio_CE06
{
    public partial class Form1 : Form
    {
        // instantiate a list to hold the hikes
        List<Hikes> hikeList = new List<Hikes>();

        // these are variables to hold the values of the Totals
        decimal totalMiles;
        decimal totalHours;
        int totalHikes;


        // gettersetter for Hike data
        public Hikes DataHold
        {
            get
            {
                Hikes h = new Hikes();
                h.Direction = comDirection.Text;
                h.Miles = numMiles.Value;
                h.Hours = numHours.Value;
                h.Mode = txtMode.Text;
                return h;
            }
            set
            {
                comDirection.Text = value.Direction;
                numMiles.Value = value.Miles;
                numHours.Value = value.Hours;
                txtMode.Text = value.Mode;
            }
        }



        // initializes the form
        public Form1()
        {
            InitializeComponent();

            // sets the direction box to default
            comDirection.SelectedIndex = 0;

            // sets the totals to default
            txtMiles.Text = "0";
            txtHours.Text = "0";
            txtLegs.Text = "0";
        }


        // exits the application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // when the user clicks 'add'
        // this will add the user inputs to a new Hikes object to the list
        // and then adds the ListView
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // if the direction is set to "--" then it will not add a new hike
            if(comDirection.Text != "--")
            {
                // adds the new hike object to list
                hikeList.Add(DataHold);

                // adds the new values to the totals
                totalHours += decimal.Parse(numHours.Text);
                totalMiles += decimal.Parse(numMiles.Text);
                totalHikes++;

                // setting the total textboxes to display updated values
                txtHours.Text = totalHours.ToString();
                txtMiles.Text = totalMiles.ToString();
                txtLegs.Text = totalHikes.ToString();

                // creates tree
                CreateTree();

                // clears the inputs
                ClearInputs();
            }

        }


        // clears the inputs
        private void ClearInputs()
        {
            comDirection.SelectedIndex = 0;
            numHours.Value = 0;
            numMiles.Value = 0;
            txtMode.Clear();
        }


        // creates tree
        private void CreateTree()
        {
            if(hikeList.Count > 0)
            {
                foreach (Hikes obj in hikeList)
                {
                    Hikes startingObject = hikeList[hikeList.Count - 1];

                    // create a tree node
                    TreeNode n = new TreeNode();
                    n.Text = startingObject.ToString();
                    n.SelectedImageIndex = 0;

                    if (comDirection.SelectedIndex == 1)
                    {
                        // north
                        n.ImageIndex = 1;
                    }
                    else if (comDirection.SelectedIndex == 2)
                    {
                        // east
                        n.ImageIndex = 2;
                    }
                    else if (comDirection.SelectedIndex == 3)
                    {
                        // south
                        n.ImageIndex = 3;
                    }
                    else if (comDirection.SelectedIndex == 4)
                    {
                        // west
                        n.ImageIndex = 4;

                    }

                    // add the nodes to display
                    n.Nodes.Add("miles", "Miles " + startingObject.Miles);                   
                    n.Nodes.Add("hours", "Hours " + startingObject.Hours);
                    n.Nodes.Add("mode", "Mode " + startingObject.Mode);

                    treeView.Nodes.Add(n);

                }

            }

        }


        // clears both the inputs and the treeview
        private void BtnNew_Click(object sender, EventArgs e)
        {
            // clears the inputs
            ClearInputs();

            // clears the treeview
            treeView.Nodes.Clear();

            // clears the total values
            totalMiles = 0;
            totalHours = 0;
            totalHikes = 0;

            // clears the total textboxes
            txtMiles.Text = "0";
            txtHours.Text = "0";
            txtLegs.Text = "0";
        }
    }
}
