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
 * 10.22.19
 * CE10: Research & Development
 * VFW
 * 
 */

namespace ValerioSkylar_CE10
{
    public partial class Form1 : Form
    {
        // list to hold the created user events
        List<UserEvent> eventList = new List<UserEvent>();

        // delegate
        // repopulates the user inputs based on what date the user selected
        public event EventHandler RepopulateInputs;

        // delegate
        // displays on the opened user input form with the selected date
        public event EventHandler DisplaySelectedDate;

        // stores the current date (along with accessor for the current date)
        public string currentDate;
        public string CurrentDate
        {
            get
            {
                return currentDate;
            }
        }

        // accessor for the eventList
        public List<UserEvent> EventList
        {
            get
            {
                return eventList;
            }
        }


        // initializes the form
        public Form1()
        {
            InitializeComponent();

            // initializes the correct month picture
            DateTime date = monthCalendar.SelectionRange.Start;
            pictureBox.Image = imageList.Images[date.Month - 1];

        }


        // exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // 
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            // set the current date so the other form can see it
            currentDate = monthCalendar.SelectionRange.Start.ToShortDateString();

            // instantiate new UserInput form
            UserInput userInput = new UserInput();

            // subscription for AddEvent
            userInput.AddEvent += Form1_CreateEvent;

            // subscription for DisplaySelectedDate
            DisplaySelectedDate += userInput.UserInput_GrabDate;

            // subscription for RepopulateInputs
            RepopulateInputs += userInput.UserInput_Repopulate;

            // invoke
            DisplaySelectedDate?.Invoke(this, new EventArgs());

            // if the eventList = 0 that means that there's no way there's already an event
            // for the user to choose, so just let them open a user input
            if (eventList.Count == 0)
            {
                // show userInput as modal (user cannot interact with main form)
                userInput.ShowDialog();
            }


            // this checks if the day already has an event created for it
            // will not let the user open a userinput form
            for (int i = 0; i < eventList.Count; i++)
            {
                if (currentDate == eventList[i].SelectedDate)
                {
                    return;
                }
                else
                {
                    // show userInput as modal (user cannot interact with main form)
                    userInput.ShowDialog();
                }



            }

        }


        // executable method
        // create new event based on user inputs
        public void Form1_CreateEvent(object sender, EventArgs e)
        {
            UserInput uinput = sender as UserInput;
            UserEvent newEvent = new UserEvent();

            // this will re-write the data if it already exists
            if (eventList.Contains(uinput.DataHold))
            {
                eventList.RemoveAt(eventList.IndexOf(uinput.DataHold));

            }

            newEvent.SelectedDate = monthCalendar.SelectionRange.Start.ToShortDateString();
            newEvent.EventName = uinput.DataHold.EventName;
            newEvent.Time = uinput.DataHold.Time;
            newEvent.Duration = uinput.DataHold.Duration;

            eventList.Add(newEvent);

            // eventList.Add(uinput.DataHold);

        }

        // invoke
        // if the user selects a date from the calendar, if there is a event for that day, it will
        // open a new UserInput form that is populated with that data
        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // set the current date so the other form can see it
            currentDate = monthCalendar.SelectionRange.Start.ToShortDateString();

            UserInput userInput = new UserInput();

            // subscription for RepopulateInputs
            RepopulateInputs += userInput.UserInput_Repopulate;

            // subscription for UpdateInfo
            userInput.UpdateInfo += Form1_UpdateInfo;

            // invoke
            RepopulateInputs?.Invoke(this, new EventArgs());

            // if the date is the same as the an existing event, it will open a repopulated form for that event
            for (int i = 0; i < eventList.Count; i++)
            {
                if (currentDate == eventList[i].SelectedDate)
                {
                    // show new instance of userinput
                    userInput.ShowDialog();
                }

            }

        }

        // eventhandler
        // updates the info of selected event
        private void Form1_UpdateInfo(object sender, EventArgs e)
        {
            UserInput uinput = sender as UserInput;
            UserEvent newEvent = new UserEvent();

            // this will re-write the data if it already exists
            if (eventList.Contains(uinput.DataHold))
            {
                eventList.RemoveAt(eventList.IndexOf(uinput.DataHold));

            }

            newEvent.SelectedDate = monthCalendar.SelectionRange.Start.ToShortDateString();
            newEvent.EventName = uinput.DataHold.EventName;
            newEvent.Time = uinput.DataHold.Time;
            newEvent.Duration = uinput.DataHold.Duration;

            eventList.Add(newEvent);
        }


        // controls the images in the picturebox
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar.SelectionRange.Start;

            // gets month - 1 so that it will = the specified image index
            pictureBox.Image = imageList.Images[date.Month - 1];
        }
    }
}
