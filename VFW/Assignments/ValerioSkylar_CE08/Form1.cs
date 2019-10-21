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

/*
 * Skylar Valerio
 * 10.19.19
 * CE08: XML and Treeviews
 * VFW
 * 
 */


namespace ValerioSkylar_CE08
{
    public partial class Form1 : Form
    {
        // stuff for building the API url
        WebClient apiConnection = new WebClient();
        string startAPI = "https://marketdata.websol.barchart.com/getQuote.json?apikey=813124bf9d173b9b0337bc55cf5a2f48&symbols=";
        //string startingAPIPart1 = "https://marketdata.websol.barchart.com/getQuote.";
        //string startingAPIPart2 = "?apikey=813124bf9d173b9b0337bc55cf5a2f48&symbols=";
        string apiEndPoint;

        // the list to hold whatever stocks the user chooses from the ListBox
        List<Stock> stockList = new List<Stock>();


        // intializes the form
        public Form1()
        {
            InitializeComponent();
        }


        // exits the application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BuildAPI()
        {
            apiEndPoint = startAPI;

            for (int i = 0; i < listBoxStocks.SelectedItems.Count; i++)
            {
                Stock stock = new Stock();

                if (listBoxStocks.SelectedItems[i].ToString() == "Facebook")
                {
                    stock.Symbol = "FB";
                }
                else if (listBoxStocks.SelectedItems[i].ToString() == "Amazon")
                {
                    stock.Symbol = "AMZN";
                }
                else if (listBoxStocks.SelectedItems[i].ToString() == "Apple")
                {
                    stock.Symbol = "AAPL";
                }
                else if (listBoxStocks.SelectedItems[i].ToString() == "Netflix")
                {
                    stock.Symbol = "NFLX";
                }
                else if (listBoxStocks.SelectedItems[i].ToString() == "Google")
                {
                    stock.Symbol = "GOOG";
                }
                else
                {
                    MessageBox.Show("Error: BuildAPI - adding stock symbol");
                }


                // this will concatenate the url depending on how many
                // items the user has chosen
                if (i >= 0 && i != listBoxStocks.SelectedItems.Count - 1)
                {
                    apiEndPoint += stock.Symbol + ",";
                }
                else if (i == listBoxStocks.SelectedItems.Count - 1)
                {
                    apiEndPoint += stock.Symbol;

                }

            }
        }


        // adds the stocks to the stockList
        private void AddToList()
        {
            // clears previous list
            stockList.Clear();

            // concatenates the api url strings
            BuildAPI();

            // adds whatever is selected to the list
            if (listBoxStocks.SelectedIndex >= 0)
            {
                try
                {
                    // retrieve the data
                    string apiData = apiConnection.DownloadString(apiEndPoint);

                    // add selected items in the listbox to the list
                    for (int i = 0; i < listBoxStocks.SelectedItems.Count; i++)
                    {
                        JObject jsonData = JObject.Parse(apiData);
                        Stock stock = new Stock();

                        // add revelant json data to stock object
                        // parse to appropriate datatype
                        stock.Name = jsonData["results"][i]["name"].ToString();
                        stock.LastPrice = jsonData["results"][i]["lastPrice"].ToString();
                        stock.OpeningPrice = jsonData["results"][i]["open"].ToString();
                        stock.HighPrice = jsonData["results"][i]["high"].ToString();
                        stock.LowPrice = jsonData["results"][i]["low"].ToString();

                        // adds stock to list
                        stockList.Add(stock);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.ToString());
                }

            }
        }


        // creates the tree in the treeview
        private void CreateTree()
        {
            if (listBoxStocks.SelectedItems.Count > 0)
            {
                foreach (Stock stock in stockList)
                {
                    // make a new stock object using the stocks in the list
                    Stock s = stock;

                    // create a new TreeNode
                    TreeNode t = new TreeNode();
                    t.Text = s.ToString();
                    t.ImageIndex = 1;
                    t.SelectedImageIndex = 0;

                    // add the nodes
                    t.Nodes.Add("lastPrice", "Last Price: " + s.LastPrice);
                    t.Nodes.Add("openingPrice", "Opening Price: " + s.OpeningPrice);
                    t.Nodes.Add("highPrice", "High Price: " + s.HighPrice);
                    t.Nodes.Add("lowPrice", "Low Price: " + s.LowPrice);

                    // adds the new nodes to the treeview
                    treeView.Nodes.Add(t);

                }

                // clears selected items
                listBoxStocks.ClearSelected();

            }
        }


        // adds the user's selection to the treeview
        private void BtnSaveTree_Click(object sender, EventArgs e)
        {
            AddToList();
            CreateTree();

        }


        // clears the selection, list, and treeview
        private void BtnNew_Click(object sender, EventArgs e)
        {
            listBoxStocks.ClearSelected();
            stockList.Clear();
            treeView.Nodes.Clear();
        }


        // saves items in treeview to xml file
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "xml";

            // as long as the user doesn't exit the dialog and cancel the save,
            // this if will run
            if (DialogResult.OK == sfd.ShowDialog())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.ConformanceLevel = ConformanceLevel.Document;
                settings.Indent = true;

                using (XmlWriter writer = XmlWriter.Create(sfd.FileName, settings))
                {

                    foreach (Stock s in stockList)
                    {
                        // this sets the element name
                        writer.WriteStartElement("StockData");

                        // stores the data in the element                   
                        writer.WriteStartElement("Name", s.Name);
                        writer.WriteElementString("LastPrice", s.LastPrice);
                        writer.WriteElementString("OpeningPrice", s.OpeningPrice);
                        writer.WriteElementString("HighPrice", s.HighPrice);
                        writer.WriteElementString("LowPrice", s.LowPrice);

                        // write the end of the element
                        writer.WriteEndElement();
                    }


                }
            }
        }



        private void BtnLoad_Click(object sender, EventArgs e)
        {
            stockList.Clear();

            OpenFileDialog dlg = new OpenFileDialog();
            if (DialogResult.OK == dlg.ShowDialog())
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ConformanceLevel = ConformanceLevel.Document;

                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;

                using (XmlReader reader = XmlReader.Create(dlg.FileName, settings))
                {
                    reader.MoveToContent();
                    if (reader.Name != "StockData")
                    {
                        MessageBox.Show("Error: Data is not formatted correctly.");
                        return;
                    }


                    while (reader.Read())
                    {
                        Stock stock = new Stock();

                        if (reader.Name == "Name" && reader.IsStartElement())
                        {
                            stock.Name = reader.ReadElementContentAsString();
                        }
                        if (reader.Name == "LastPrice")
                        {
                            stock.LastPrice = reader.ReadElementContentAsString();
                        }
                        if (reader.Name == "OpeningPrice")
                        {
                            stock.OpeningPrice = reader.ReadElementContentAsString();
                        }
                        if (reader.Name == "HighPrice")
                        {
                            stock.HighPrice = reader.ReadElementContentAsString();
                        }
                        if (reader.Name == "LowPrice")
                        {
                            stock.LowPrice = reader.ReadElementContentAsString();
                        }

                        stockList.Add(stock);

                    }

                }

            }

            // load the new tree in
            treeView.Nodes.Clear();
            CreateTree();
        }
    }
}
