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
    public partial class ListViewForm : Form
    {

        // delegate
        // clears from listview and the list in Form1
        public event EventHandler ClearListView;

        // delegate
        // opens + repopulates the UserInput form when object in ListView is double-clicked
        public event EventHandler RepopulateInputs;


        public ListViewForm()
        {
            InitializeComponent();
            AddDefaultCharacters();
        }


        // adds a few default characters for testing sake
        private void AddDefaultCharacters()
        {
            for (int i = 1; i < 2; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "Default Character" + i;
                lvi.Name = "Default Character" + i;                
                lvi.ImageIndex = 0;
                listViewCharacters.Items.Add(lvi);

            }

        }


        // clears the listview
        public void ClearView()
        {
            listViewCharacters.Items.Clear();
        }


        // eventhandler
        // populates listview using the list from Form1
        public void ListView_Populate(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            if ((sender as Form1).TrainerList.Count > 0)
            {
                Trainer info = (sender as Form1).TrainerList[0];

                lvi.Text = info.Name;
                lvi.ImageIndex = info.ImageIndex;
                lvi.Tag = info;

                listViewCharacters.Items.Add(lvi);

            }
            
            //Trainer info = (sender as Form1).TrainerList[(sender as Form1).TrainerList.Count-1];

        }


        // invoke ClearListView
        // when clicked this will clear both the listview and the Form1 list
        private void btnListViewClear_Click(object sender, EventArgs e)
        {
            ClearListView?.Invoke(this, new EventArgs());
        }


        // invoke RepopulateInputs
        // user selects an item in the listview, which opens another form with information
        private void ListViewCharacters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UserInput userInput = new UserInput();

            RepopulateInputs?.Invoke(this, new EventArgs());

            userInput.Show();
        }
    }
}
