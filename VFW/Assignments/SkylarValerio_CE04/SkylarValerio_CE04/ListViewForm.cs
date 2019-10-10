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

        public ListViewForm()
        {
            InitializeComponent();
            AddDefaultCharacters();
        }


        // adds a few default characters for testing sake
        private void AddDefaultCharacters()
        {
            for (int i = 1; i < 3; i++)
            {
                ListViewItem lvi = new ListViewItem();
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
            foreach (Trainer trainer in ((sender as Form1).TrainerList))
            {
                listViewCharacters.Items.Add(trainer.Name);
            }
        }


        // invoke
        // when clicked this will clear both the listview and the Form1 list
        private void btnListViewClear_Click(object sender, EventArgs e)
        {
            ClearListView?.Invoke(this, new EventArgs());
        }
    }
}
