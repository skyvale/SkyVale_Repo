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
        }


        // accessor for the items in the listview
        public ListView GetListView
        {
            get
            {
                return listViewCharacters;
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
            if ((sender as Form1).TrainerList.Count > 0)
            {
                for (int i = 0; i < (sender as Form1).TrainerList.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();

                    Trainer info = (sender as Form1).TrainerList[i];

                    lvi.Text = info.Name;
                    lvi.ImageIndex = info.ImageIndex;
                    lvi.Tag = info;

                    listViewCharacters.Items.Add(lvi);

                }

            }
            
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
            // instantiate new userinput form
            UserInput userInput = new UserInput();

            // subscription for RepopulateInputs delegate in ListViewForm
            RepopulateInputs += userInput.UserInput_Repopulate;

            // invoke the repopulation event to fill the form
            RepopulateInputs?.Invoke(this, new EventArgs());

            // open the userinput form
            userInput.Show();
        }
    }
}
