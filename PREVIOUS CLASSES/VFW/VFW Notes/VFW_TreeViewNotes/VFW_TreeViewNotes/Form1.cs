using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFW_TreeViewNotes
{
    public partial class Form1 : Form
    {
        // create a new random object to use in GenerateData
        Random rand = new Random();


        // instantiates Form1
        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }


        // this will populate the ListView in the ListViewTab
        private void InitializeData()
        {
            // this will populate a new list with 5 of the randomly generated
            // lists from the GenerateData method
            List<Data> objectsToPopulate = GenerateData(5);

            foreach (Data obj in objectsToPopulate)
            {
                // creates a new listview item with a customized text label and an image index of 0
                ListViewItem lvi = new ListViewItem(obj.ToString(), 0);

                // sets the object to the listviewitem's tag, in case you need the information
                // somewhere else in the code
                lvi.Tag = obj;

                // add the created object into the listview
                listView.Items.Add(lvi);
            }
        }


        // takes in how many data objects we want to create,
        // and then generates a bunch of random data to put in each object
        private List<Data> GenerateData(int countDown)
        {
            // create a list to hold the data objects
            List<Data> dataList = new List<Data>();

            // this will create a list based on the int countDown that is brought in
            for (int i = 0; i < countDown; i++)
            {
                // create a new Data object and set the properties to random
                Data dataObject = new Data();

                dataObject.DataNumber = i + 1;
                dataObject.Height = rand.Next(50, 190);
                dataObject.Weight = rand.Next(70, 250);
                // numData will set another random number of data objects for another list
                int numData = rand.Next(1, 5);

                // this will create a list within a loop
                for (int j = 0; j < numData; i++)
                {
                    Data internalDataObject = new Data();
                    internalDataObject.DataNumber = i + 1;
                    internalDataObject.Height = rand.Next(50, 190);
                    internalDataObject.Weight = rand.Next(70, 250);

                    // now you can set the new
                    dataObject.ContainedData.Add(internalDataObject);
                }

                // adds the new dataObject to the dataList
                dataList.Add(dataObject);

            }

            return dataList;
        }


        // this will create a new tree in the treeview based on the 
        // randomly generated data
        private void CreateTree()
        {
            if(listView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in listView.SelectedItems)
                {
                    // create a new casted object
                    Data startingObject = lvi.Tag as Data;

                    // create a new TreeNode
                    TreeNode n = new TreeNode();
                    n.Text = startingObject.ToString();
                    n.ImageIndex = 1;
                    n.SelectedImageIndex = 0;

                    // you will have to add a node for every piece of data you want to display
                    // you can sort using a key in the tree view, that is what 'height' is
                    n.Nodes.Add("height", "Height: " + startingObject.Height);
                    n.Nodes.Add("weight", "Weight: " + startingObject.Weight);

                    foreach (Data obj in startingObject.ContainedData)
                    {
                        // create a node within the node
                        TreeNode childNode = new TreeNode();
                        childNode.Text = obj.ToString();
                        childNode.ImageIndex = 1;
                        childNode.SelectedImageIndex = 0;

                        n.Nodes.Add("height", "Height: " + obj.Height);
                        n.Nodes.Add("weight", "Weight: " + obj.Weight);

                        // adds a child node to the previously added node (n)
                        n.Nodes.Add(childNode);
                    }

                    // adds the new nodes to the treeview
                    treeView.Nodes.Add(n);
                }
            }
        }


        // exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // this will add the generated data when the 'new' button is clicked
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this will clear the listView of any current items
            listView.Items.Clear();

            // creates 5 new items in the listView
            InitializeData();
        }


        // this will populate the treeview if the user has an object in the listview selected
        private void tabPages_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // checks to make sure it is selecting from one of the two tabs
            if (e.TabPageIndex > 0)
            {
                // this will clear the listview selection each time the user goes back and forth
                // between the tabs
                treeView.Nodes.Clear();

                // creates a tree view
                CreateTree();
            }
        }
    }
}
