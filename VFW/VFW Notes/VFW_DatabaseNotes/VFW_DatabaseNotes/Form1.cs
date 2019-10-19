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


namespace VFW_DatabaseNotes
{
    public partial class Form1 : Form
    {

        MySqlConnection conn = new MySqlConnection();

        // DataTable to store the information
        DataTable theData = new DataTable();

        int currentRow = 0;

        public Form1()
        {
            InitializeComponent();
            
            // connect to the SQL server
            string connString = DBUtils.BuildConnectionString();
            conn = DBUtils.Connect(connString);

            // retrieve the data
            RetrieveData();
        }


        private bool RetrieveData()
        {
            // SQL statement
            string sql = "SELECT title, releaseDate FROM item LIMIT 10;";

            // create adapter
            MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn);

            // sset type for the select command
            adr.SelectCommand.CommandType = CommandType.Text;

            // put data into table using the connection
            // user the Fill method to add rows that match the data source
            adr.Fill(theData);

            // get the number of rows in the DataTable
            // notes that .Select() gets an array
            int numOfRows = theData.Select().Length;

            // asks for the data from the first object (first row) of the Data
            // populate the textboxes with the data
            txtTitle.Text = theData.Rows[0]["title"].ToString();
            txtReleaseDate.Text = theData.Rows[0]["releaseDate"].ToString();

            // populate the rows label with the amount of rows in the data object
            lblRows.Text = numOfRows.ToString();

            return true;

        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentRow < theData.Select().Length - 1)
            {
                currentRow++;

                // populate the textboxes with the data
                txtTitle.Text = theData.Rows[currentRow]["title"].ToString();
                txtReleaseDate.Text = theData.Rows[currentRow]["releaseDate"].ToString();
            }
        }
    }
}
