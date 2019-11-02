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
    public partial class UserInput : Form
    {
        // delegate
        // adds user created event to the event list
        public event EventHandler AddEvent;

        // delegate
        // updates the selected event info
        public event EventHandler UpdateInfo;


        public UserEvent DataHold
        {
            get
            {
                UserEvent ue = new UserEvent();
                ue.EventName = txtEventName.Text;
                ue.Time = comEventTime.Text;
                ue.Duration = comEventDuration.Text;
                return ue;
            }
            set
            {
                lbSelectedDate.Text = value.SelectedDate;
                txtEventName.Text = value.EventName;
                comEventDuration.Text = value.Duration;
                comEventTime.Text = value.Time;
            }
        }

        // initializes the form
        public UserInput()
        {
            InitializeComponent();
        }


        // closes the input form without saving
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        // invoke
        // adds the event to the eventList
        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            AddEvent?.Invoke(this, new EventArgs());

            UpdateInfo?.Invoke(this, new EventArgs());

            // close form after saving
            this.Close();

        }

        
        // event method
        // grabs the selected date from Form1 and displays it on the freshly opened UserInput form
        public void UserInput_GrabDate(object sender, EventArgs e)
        {
            Form1 form = sender as Form1;

            lbSelectedDate.Text = form.currentDate;

        }


        // event method
        // repopulates the inputs based on what event date the user selects
        public void UserInput_Repopulate(object sender, EventArgs e)
        {
            Form1 form = sender as Form1;
            for (int i = 0; i < form.EventList.Count; i++)
            {
                if (form.currentDate == form.EventList[i].SelectedDate)
                { 
                    DataHold = form.EventList[i];

                }
            }


            // make everything read-only
            //txtEventName.ReadOnly = true;
            //comEventTime.Enabled = false;
            //comEventDuration.Enabled = false;

            // disables the save event button so they can't add another event this way
            // btnSaveEvent.Enabled = false;
        }
     
    }
}
