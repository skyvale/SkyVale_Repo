using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 * Skylar Valerio
 * 08.18.2019
 * CE04: ListViews
 * MDV1830-O
 */

namespace SkylarValerio_CE04
{
    public partial class MainForm : Form
    {

        // properties to hold the amount of windows and objects
        public decimal Windows = 0;
        public decimal Objects = 0;

        // List to hold the created Character objects
        public List<Character> characterList = new List<Character>();

        // event handler to add to list
        public event EventHandler<CharacterArgs> AddToListForm;

        public MainForm()
        {
            InitializeComponent();

            // set initial value of text boxes
            txtWindows.Text = (Windows).ToString();
            txtObjects.Text = (Windows).ToString();
        }


        // sends the created Characters to the custom CharacterArgs class
        public void AddToList(object sender, CharacterArgs e)
        {
            Character cha = new Character();
            cha.Name = e.Name;
            cha.Gender = e.Gender;
            cha.Region = e.Region;
            cha.StarterPokemon = e.StarterPokemon;
            cha.ImageIndex = e.ImageIndex;

            // add Character to the characterList
            characterList.Add(cha);

            // update the Objects counter
            Objects = characterList.Count;
            txtObjects.Text = Objects.ToString();
        }


        // exits the application
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        // opens the UserInputForm
        private void BtnOpenInputForm_Click(object sender, EventArgs e)
        {
            // instantiate the global userInputForm
            UserInputForm userInputForm = new UserInputForm();

            // subscribe the closing event handler
            userInputForm.FormClosed += new FormClosedEventHandler(FormClosed_UserInput);

            // subscribe to addToList
            userInputForm.AddToList += AddToList;

            // show the form as modeless so the user can move between forms
            userInputForm.Show();

            // adds to the Main Form windows count
            Windows++;
            txtWindows.Text = (Windows).ToString();

        }


        // event handler that senses when UserInput window has been closed
        private void FormClosed_UserInput(object sender, FormClosedEventArgs e)
        {
            UserInputForm userInputForm = (UserInputForm)sender;
            Windows--;
            txtWindows.Text = (Windows).ToString();
        }


        // event handler that senses when ListViewForm window has been closed
        private void FormClosed_ListView(object sender, FormClosedEventArgs e)
        {
            ListViewForm listViewForm = (ListViewForm)sender;
            Windows--;
            txtWindows.Text = (Windows).ToString();
        }


        // opens the ListViewForm
        private void DisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate the global ListViewForm
            ListViewForm listViewForm = new ListViewForm();

            // subscribe the closing event handler
            listViewForm.FormClosed += new FormClosedEventHandler(FormClosed_ListView);

            // subscribe to the listviewform
            AddToListForm += listViewForm.AddToListForm_EventHandler;

            // subscribe to the method to remove all from the list
            listViewForm.RemoveAll += RemoveAllFromList;

            // adds Characters in characterList to CharacterArgs
            if (characterList != null)
            {
                foreach (Character item in characterList)
                {
                    CharacterArgs ca = new CharacterArgs();
                    ca.Name = item.Name;
                    ca.Gender = item.Gender;
                    ca.Region = item.Region;
                    ca.StarterPokemon = item.StarterPokemon;
                    ca.ImageIndex = item.ImageIndex;

                    // raise the event handler to add the character to the ListViewForm
                    AddToListForm?.Invoke(this, ca);
                }
            }

            // show the form as modeless so the user can move between forms
            listViewForm.Show();

            // adds to the Main Form windows count
            Windows++;
            txtWindows.Text = (Windows).ToString();

        }


        // deletes all from list
        public void RemoveAllFromList(object sender, EventArgs e)
        {
            List<Character> c = new List<Character>();
            characterList = c;

            Objects = characterList.Count;
            txtObjects.Text = Objects.ToString();
        }


    }
}
