using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkylarValerio_CE03
{
    public partial class Form1 : Form
    {

        // delegate to allow the student object to be added to the ListBox on the Display Form
        public event EventHandler AddToListBox;

        // list to hold the Student objects (private)
        List<Student> studentList = new List<Student>();

        // accessor for the studentList (public)
        public List<Student> StudentList
        {
            get
            {
                return studentList;
            }
        }

        // property to hold all the variables
        public Student DataHold
        {
            get
            {
                Student createdStudent = new Student();
                createdStudent.FirstName = txtFirstName.Text;
                createdStudent.LastName = txtLastName.Text;
                createdStudent.Gender = rdMale.Checked;
                createdStudent.Program = comBoxProgram.Text;
                createdStudent.Above21 = chkAbove21.Checked;
                return createdStudent;
            }
            set
            {
                txtFirstName.Text = value.FirstName;
                txtLastName.Text = value.LastName;
                rdMale.Checked = value.Gender;
                comBoxProgram.Text = value.Program;
                chkAbove21.Checked = value.Above21;
            }
        }


        // initialize the Form
        public Form1()
        {
            InitializeComponent();
            rdMale.Checked = true;
        }


        // exits the entire program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // clears the form (just this form though)
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }


        // method to clear the inputs
        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            rdMale.Checked = true;
            comBoxProgram.SelectedIndex = -1;
            chkAbove21.Checked = false;
        }

        // executable method for RepopulateInputs eventhandler
        public void DisplayForm_Repopulate(object sender, StudentEventArgs e)
        {
            // 'e' is the student
            txtFirstName.Text = e.FirstName;
            txtLastName.Text = e.LastName;
            rdMale.Checked = e.Gender;
            comBoxProgram.Text = e.Program;
            chkAbove21.Checked = e.Above21;
        }

        // adds new student to the List when the user clicks the add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // adds the created object to the list
            studentList.Add(DataHold);
         
        }

        // unchecks the display menustrip button when the user closes the display form
        private void Display_UncheckDisplayButton(object sender, EventArgs e)
        {
            menuBtnCreate.Checked = false;
        }


        private void menuBtnCreate_Click(object sender, EventArgs e)
        {
            // make sure the DisplayForm isn't open (default is closed)
            // if it is, do not open another one
            if (menuBtnCreate.Checked == false)
            {
                // add checkmark next to the Created option in the MenuStrip when the form is opened
                menuBtnCreate.Checked = true;

                // create the Display form
                Display displayForm = new Display();

                // subscribe to the AddStudent method in the Display Form
                // so that you can add student to the ListBox there
                AddToListBox += displayForm.DisplayForm_AddStudent;

                // subscribe to the Repopulate method in the Display Form
                // so that you can repopulate the inputs on the Main Form when the user
                // chooses a student from the ListBox
                displayForm.RepopulateInputs += DisplayForm_Repopulate;

                // subscribe to the FormClosed method on the Display Form
                // so that the display menustrip button on the Main Form will become unchecked
                // when the user closes the Display Form
                displayForm.UncheckDisplayButton += Display_UncheckDisplayButton;

                // raise the eventhandler
                AddToListBox?.Invoke(this, new EventArgs());

                // invoke the UncheckDisplayButton eventhandler
                UncheckDisplayButton?.Invoke(this, new EventArgs());

                // show the form (modeless)
                displayForm.Show();

            }
            else if (menuBtnCreate.Checked == true)
            {
                // do nothing, the window is already opened              

            }

        }
    }
}
