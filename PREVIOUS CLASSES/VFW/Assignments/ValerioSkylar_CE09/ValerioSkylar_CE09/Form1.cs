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
using System.IO;
using System.Net;
using System.Xml;

/*
 * Skylar Valerio
 * 10.20.19
 * CE09: Database Connectivity
 * VFW
 * 
 */ 


namespace ValerioSkylar_CE09
{
    public partial class Form1 : Form
    {

        MySqlConnection conn = new MySqlConnection();

        int currentRow = 0;

        // DataTable to store the information
        DataTable theData = new DataTable();

        // initializes the form
        public Form1()
        {
            InitializeComponent();

            // connect to the SQL server
            string connString = DBUtils.BuildConnectionString();
            conn = DBUtils.Connect(connString);

            // retrieve the data
            RetrieveData();

        }


        // exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // retrieves the data from the sql server and adds it to the DataTable
        private bool RetrieveData()
        {
            // SQL statement
            string sql = "SELECT DVD_title, Studio, Year, Price FROM dvd ORDER BY rand() LIMIT 15;";

            // create adapter
            MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn);

            // sset type for the select command
            adr.SelectCommand.CommandType = CommandType.Text;

            // put data into table using the connection
            // user the Fill method to add rows that match the data source
            adr.Fill(theData);

            foreach (DataRow row in theData.Rows)
            {
                // asks for the data from the first object (first row) of the Data
                // populate the textboxes with the data
                txtTitle.Text = theData.Rows[0]["DVD_title"].ToString();
                txtStudio.Text = theData.Rows[0]["Studio"].ToString();
                lbReleaseDate.Text = theData.Rows[0]["Year"].ToString();
                numRetailPrice.Value = decimal.Parse(theData.Rows[0]["Price"].ToString());
            }
          
            return true;

        }


        private void butNext_Click(object sender, EventArgs e)
        {

            if (currentRow == 14)
            {

            }
            else
            {
                currentRow++;

                if (currentRow < theData.Select().Length - 1)
                {

                    // populate the textboxes with the data
                    txtTitle.Text = theData.Rows[currentRow]["DVD_title"].ToString();
                    txtStudio.Text = theData.Rows[currentRow]["Studio"].ToString();
                    lbReleaseDate.Text = theData.Rows[currentRow]["Year"].ToString();
                    numRetailPrice.Value = decimal.Parse(theData.Rows[currentRow]["Price"].ToString());
                }
            }
 
        }


        private void butBack_Click(object sender, EventArgs e)
        {
            if (currentRow == 0)
            {

            }
            else
            {
                currentRow--;

                if (currentRow < theData.Select().Length - 1)
                {

                    // populate the textboxes with the data
                    txtTitle.Text = theData.Rows[currentRow]["DVD_title"].ToString();
                    txtStudio.Text = theData.Rows[currentRow]["Studio"].ToString();
                    lbReleaseDate.Text = theData.Rows[currentRow]["Year"].ToString();
                    numRetailPrice.Value = decimal.Parse(theData.Rows[currentRow]["Price"].ToString());
                }
            }

        }


        // goes back to the starting row in the datatable
        private void butStart_Click(object sender, EventArgs e)
        {
            currentRow = 0;

            if (currentRow < theData.Select().Length - 1)
            {

                // populate the textboxes with the data
                txtTitle.Text = theData.Rows[currentRow]["DVD_title"].ToString();
                txtStudio.Text = theData.Rows[currentRow]["Studio"].ToString();
                lbReleaseDate.Text = theData.Rows[currentRow]["Year"].ToString();
                numRetailPrice.Value = decimal.Parse(theData.Rows[currentRow]["Price"].ToString());
            }
        }


        // goes to the last row in the datatable
        private void butEnd_Click(object sender, EventArgs e)
        {
            currentRow = 13;

            if (currentRow < theData.Select().Length - 1)
            {

                // populate the textboxes with the data
                txtTitle.Text = theData.Rows[currentRow]["DVD_title"].ToString();
                txtStudio.Text = theData.Rows[currentRow]["Studio"].ToString();
                lbReleaseDate.Text = theData.Rows[currentRow]["Year"].ToString();
                numRetailPrice.Value = decimal.Parse(theData.Rows[currentRow]["Price"].ToString());
            }
        }


        // save datatable to an xml file
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "xml";

            if (DialogResult.OK == sfd.ShowDialog())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.ConformanceLevel = ConformanceLevel.Auto;
                settings.Indent = true;

                using(XmlWriter writer = XmlWriter.Create(sfd.FileName, settings))
                {

                    for (int i = 0; i < theData.Rows.Count; i++)
                    {
                        writer.WriteStartElement("Movie_Data");
                        writer.WriteStartElement("Movie");

                        writer.WriteElementString("Title", theData.Rows[i]["DVD_Title"].ToString());
                        writer.WriteElementString("Studio", theData.Rows[i]["Studio"].ToString());
                        writer.WriteElementString("Year", theData.Rows[i]["Year"].ToString());
                        writer.WriteElementString("Price", theData.Rows[i]["Price"].ToString());

                        writer.WriteEndElement();
                        writer.WriteEndElement();

                    }
                 
                }

            }
        }
    }
}
