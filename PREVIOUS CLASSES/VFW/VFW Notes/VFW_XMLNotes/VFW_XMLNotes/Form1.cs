using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace VFW_XMLNotes
{
    public partial class Form1 : Form
    {

        WebClient apiConnection = new WebClient();
        string startAPI = "https://marketdata.websol.barchart.com/getQuote.json?apikey=813124bf9d173b9b0337bc55cf5a2f48&symbols=";
        string startingAPIPart1 = "https://marketdata.websol.barchart.com/getQuote.";
        string startingAPIPart2 = "?apikey=813124bf9d173b9b0337bc55cf5a2f48&symbols=";
        string apiEndPoint;


        public Form1()
        {
            InitializeComponent();
        }


        private string ReturnStockSymbol()
        {
            string symbol = "";
            string[] stockSymbols = new string[] { "FB", "AMZN", "AAPL", "NFLX", "GOOG" };
            symbol = stockSymbols[comStock.SelectedIndex];
            return symbol;

        }


        private void BuildAPI()
        {
            string symbol = ReturnStockSymbol();

            // this is for concatenating the API string
            string jsonOrXML = "xml";
            if (radJSON.Checked)
            {
                jsonOrXML = "json";
            }

            apiEndPoint = startingAPIPart1 + jsonOrXML + startingAPIPart2 + symbol;

            txtDebug.Text = apiEndPoint;
           
        }


        private void ReadTheJSONData()
        {
            string apiData = apiConnection.DownloadString(apiEndPoint);

            //MessageBox.Show("The String:\n" + apiData);

            JObject jsonData = JObject.Parse(apiData);

            //MessageBox.Show("The object:\n" + jsonData.ToString());
            //MessageBox.Show("The Results:\n" + jsonData["results"].ToString());

            numLastPrice.Value = decimal.Parse(jsonData["results"][0]["lastPrice"].ToString());

        }


        private void ReadTheXMLData()
        {

            // remember that 'm' denotes a number as a decimal
            decimal lastPrice = 0m;
            decimal open = 0m;

            // xml is slower than json, but it is easier to code and get data
            // also note that xml data disappears immediately after using it
            // this using and while loop will always be the same each time you create an xml
            // object (ofc, the data names will change)
            using (XmlReader apiData = XmlReader.Create(apiEndPoint))
            {
                while (apiData.Read())
                {
                    if (apiData.Name == "lastPrice")
                    {
                        lastPrice = apiData.ReadElementContentAsDecimal();

                    }
                    if (apiData.Name == "open")
                    {
                        open = apiData.ReadElementContentAsDecimal();
                    }
                }
            }

            // MessageBox.Show("Last price: " + lastPrice + "\nOpen: " + open.ToString());
            numLastPrice.Value = lastPrice;
            numOpen.Value = open;
               
        }


        private void btnGetStockData_Click(object sender, EventArgs e)
        {

            BuildAPI();

            if (radJSON.Checked)
            {
                ReadTheJSONData();

            }
            else
            {
                ReadTheXMLData();
            }
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // saving data to an .xml file
        private void saveAsXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "xml";
           
            // as long as the user doesn't exit the dialog and cancel the save,
            // this if will run
            if (DialogResult.OK == sfd.ShowDialog())
            {
                // these settings will allow you to set some defaults
                XmlWriterSettings settings = new XmlWriterSettings();
                // the conformance level will throw an error if the xml document
                // is incorrectly formatted
                settings.ConformanceLevel = ConformanceLevel.Document;
                // this indent will just make the xml look nicer and easy to read
                settings.Indent = true;

                using(XmlWriter writer = XmlWriter.Create(sfd.FileName, settings))
                {
                    // this sets the element name
                    writer.WriteStartElement("StockData");

                    // stores the data in the element
                    writer.WriteElementString("Stock", comStock.SelectedItem.ToString());
                    writer.WriteElementString("Last", numLastPrice.Text);
                    writer.WriteStartElement("Open", numOpen.Value.ToString());

                    // write the end of the element
                    writer.WriteEndElement();

                }
            }
        }


        // loads the .xml file
        private void loadXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
