using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkylarValerio_CE04
{
    public partial class Form1 : Form
    {
        // delegate
        // populates the ListViewForm with the list from Form1
        public event EventHandler PopulateListView;

        public List<Trainer> trainerList = new List<Trainer>();

        // accessor for trainerList
        public List<Trainer> TrainerList
        {
            get
            {
                return trainerList;
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

       

        // when clicked, this will open the ListViewForm
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            ListViewForm listViewForm = new ListViewForm();

            UserInput userInput = new UserInput();

            // subscription to PopulateListView delegate
            PopulateListView += listViewForm.ListView_Populate;

            // subscription to ClearListView delegate in ListViewForm
            listViewForm.ClearListView += ListViewForm_ClearListView;

            // subscription for RepopulateInputs delegate in ListViewForm
            listViewForm.RepopulateInputs += userInput.UserInput_Repopulate;

            // invokes the PopulateListView event before the form opens
            PopulateListView?.Invoke(this, new EventArgs());           
            
            // opens listViewForm
            listViewForm.Show();
        }


        // instantiates a new UserInput form
        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            UserInput userInput = new UserInput();

            // subscription to SaveToList delegate in UserInput form
            userInput.SaveToList += UserInput_SaveToList;

            // opens userInput form
            userInput.Show();
            
        }


        // eventhandler
        // clears the 
        private void ListViewForm_ClearListView(object sender, EventArgs e)
        {
            // clears the list
            TrainerList.Clear(); 

            // clears the listview
            ListViewForm lv = sender as ListViewForm;
            lv.ClearView();

        }


        // eventhandler
        // this will save the created trainer to the trainerList
        private void UserInput_SaveToList(object sender, EventArgs e)
        {
            UserInput userInput = sender as UserInput;
            trainerList.Add(userInput.TrainerInfo);
        }
    }
}
