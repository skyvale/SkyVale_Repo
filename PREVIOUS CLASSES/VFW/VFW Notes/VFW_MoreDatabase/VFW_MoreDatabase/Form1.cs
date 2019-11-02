using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace VFW_MoreDatabase
{  
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection();


        // initializes when the form opens
        public Form1()
        {
            InitializeComponent();

            string connString = DBUtils.BuildConnectionString();
            conn = DBUtils.Connect(connString);

            // fill the combobox with database options
            GetDatabases();

            // this makes it so there is always a database selected on default
            comDatabases.SelectedIndex = 0;

        }


        private void GetDatabases()
        {
            // create Sql statement to show all available databases
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SHOW DATABASES";

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // this puts the row(s) read from the reader into the combobox
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        comDatabases.Items.Add(reader.GetValue(i).ToString());
                    }

                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Number + ": " + e.Message);
               
            }

        }


        // exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // connect to the chosen database
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // make sure there is only one connection at the same time
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            // grabs the selected database from the combobox
            string dbase = comDatabases.SelectedItem.ToString();

            // grabs text from the user input fields
            string uid = txtUser.Text;
            string pwd = txtPass.Text;

            // pass in user data to the BuildConnectionString()
            string connString = DBUtils.BuildConnectionString(dbase, uid, pwd);

            // make the connection using the now-built connection string
            conn = DBUtils.Connect(connString);

            // after the connection is made, change the status bar
            // to let the user know if they are connected or not
            if (conn.State == ConnectionState.Open)
            {
                connectedStatus.Text = "Connected To: " + dbase;
            }
            else
            {
                connectedStatus.Text = "Connect To: None";
            }

            // clear the user inputs
            txtUser.Clear();
            txtPass.Clear();
            
        }
    

        // when the user presses 'enter' it will activate the connect button
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            // checks what key the user clicked
            // if it equals 'return' aka 'enter' than activate Connect button
            if(e.KeyCode == Keys.Return)
            {
                btnConnect_Click(this, new EventArgs());
            }
        }


        // once the user chooses something from the combobox, this will change the focus
        // automatically to the username input
        private void comDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {          
            txtUser.Focus();
        }


        // this happens after form initialization, but right before the user
        // can interact with the form
        private void Form1_Shown(object sender, EventArgs e)
        {
            txtUser.Focus();
        }


        // shows or hides the password
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
