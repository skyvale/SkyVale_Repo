using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

/*
 * Skylar Valerio
 * 10.15.19
 * CE07: JSON and Web Connectivity
 * VFW
 * 
 */

// TODO
/*
 * > btnSaveList saves original selected item multiple times
 * > NEXT button functionality
 * > BACK button functionality
 * 
 */

namespace SkylarValerio_CE07
{
    public partial class Form1 : Form
    {

        // allows access to api
        WebClient apiConnection = new WebClient();
        string startAPI = "https://marketdata.websol.barchart.com/getQuote.json?apikey=813124bf9d173b9b0337bc55cf5a2f48&symbols=";
        string apiEndPoint;

        // list to hold selected stock objects
        List<Stocks> stockList = new List<Stocks>();

        // dictionary to hold stock symbols
        Dictionary<string, string> stockSymbols = new Dictionary<string, string>();

        // dictionary to hold stock objects (with unique identifiers)
        Dictionary<string, Stocks> stockDict = new Dictionary<string, Stocks>();


        // intializes the form
        public Form1()
        {
            InitializeComponent();
            CreateDictionary();

        }


        // exits the application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void CreateDictionary()
        {
            // add the symbols to dictionary
            stockSymbols.Add("Facebook", "FB");
            stockSymbols.Add("Amazon", "AMZN");
            stockSymbols.Add("Apple", "AAPL");
            stockSymbols.Add("Netflix", "NFLX");
            stockSymbols.Add("Google", "GOOG");
        }

        // this will concatenate the url to grab the stock data using the api
        private void BuildAPI()
        {

            foreach (string s in listBoxStocks.SelectedItems)
            {
                Stocks stock = new Stocks();
                stock.Symbol = stockSymbols[stock.ToString()];

                // this will concatenate the url depending on how many
                // items the user has chosen
                if (listBoxStocks.SelectedItems.Count > 1)
                {
                    apiEndPoint = startAPI + stock.Symbol + ",";
                    MessageBox.Show(apiEndPoint);
                }
                else if (listBoxStocks.SelectedItems.Count == 1)
                {
                    apiEndPoint = startAPI + stock.Symbol;
                }
                else if (listBoxStocks.SelectedItems.Count == listBoxStocks.SelectedItems.Count - 1)
                {
                    apiEndPoint = startAPI + stock.Symbol;
                    MessageBox.Show(apiEndPoint);

                }
            }
            
        }


        // this will store the stock objects into the dictionary
        private void StoreData()
        {
            try
            {
                // retrieve the data
                string apiData = apiConnection.DownloadString(apiEndPoint);

                JObject jsonData = JObject.Parse(apiData);
                Stocks stock = new Stocks();

                // add revelant json data to stock object
                // parse to appropriate datatype
                stock.Name = jsonData["results"][0]["name"].ToString();
                stock.LastPrice = decimal.Parse(jsonData["results"][0]["lastPrice"].ToString());
                stock.OpeningPrice = decimal.Parse(jsonData["results"][0]["open"].ToString());
                stock.HighPrice = decimal.Parse(jsonData["results"][0]["high"].ToString());
                stock.LowPrice = decimal.Parse(jsonData["results"][0]["low"].ToString());

                // adds stock to stocks dictionary, identified by the stock symbol
                // this is kind of unnecessary
                switch (jsonData["results"][0]["symbol"].ToString())
                {
                    case "FB":
                        {
                            stockDict.Add("FB", stock);
                        }
                        break;
                    case "AMZN":
                        {
                            stockDict.Add("AMZN", stock);
                        }
                        break;
                    case "AAPL":
                        {
                            stockDict.Add("AAPL", stock);
                        }
                        break;
                    case "NFLX":
                        {
                            stockDict.Add("NFLX", stock);
                        }
                        break;
                    case "GOOG":
                        {
                            stockDict.Add("GOOG", stock);
                        }
                        break;

                    default:
                        {
                            MessageBox.Show("Error: dictionary is broken");
                        }
                        break;
                }

            }
            catch(Exception exc)
            {
                MessageBox.Show("Error: StoreData");
            }
           

        }


        // when the user selects from the listBox, this will fill in the inputs using the list
        private void ListBoxStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // debugging
            txtDebug.Clear();
            txtDebug.Text = apiEndPoint;


        }


        // this will save items from the list to a txt file (File IO)
        private void BtnSave_Click(object sender, EventArgs e)
        {

        }


        // this will load a txt file to populate the form inputs
        private void BtnLoad_Click(object sender, EventArgs e)
        {

        }


        // this will clear out the form inputs as well as the stockList
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
            stockList.Clear();

        }


        // method to clear inputs
        private void ClearInputs()
        {
            txtName.Clear();
            numLastPrice.Value = 0;
            numOpeningPrice.Value = 0;
            numHighPrice.Value = 0;
            numLowPrice.Value = 0;

            txtDebug.Clear();
        }


        // this will save the selected listbox items to a list
        // it will then automatically display the first value
        private void BtnSaveList_Click(object sender, EventArgs e)
        {
            // clears previous dictionary
            stockDict.Clear();

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
                        Stocks stock = new Stocks();

                        // add revelant json data to stock object
                        // parse to appropriate datatype
                        stock.Name = jsonData["results"][i]["name"].ToString();
                        stock.LastPrice = decimal.Parse(jsonData["results"][i]["lastPrice"].ToString());
                        stock.OpeningPrice = decimal.Parse(jsonData["results"][i]["open"].ToString());
                        stock.HighPrice = decimal.Parse(jsonData["results"][i]["high"].ToString());
                        stock.LowPrice = decimal.Parse(jsonData["results"][i]["low"].ToString());

                        // adds stock to list
                        stockList.Add(stock);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: BtnSaveList");
                }

                // clears the selection
                listBoxStocks.ClearSelected();

                // displays the first value of the list
                txtName.Text = stockList[0].Name;
                numLastPrice.Value = stockList[0].LastPrice;
                numOpeningPrice.Value = stockList[0].OpeningPrice;
                numLowPrice.Value = stockList[0].LowPrice;
                numHighPrice.Value = stockList[0].HighPrice;

                // adds selection to dictionary
                StoreData();


            }
            else
            {
                MessageBox.Show("Error: no selected items");
            }

        }


        // displays the next object in the list
        // will not do anything if there is no more objects
        private void BtnNext_Click(object sender, EventArgs e)
        {

            MessageBox.Show(stockList[0].ToString()+ " and " + stockList[1].ToString());
            //if (stockList.Count > 0)
            //{
            //    for (int i = 0; i < stockList.Count; i++)
            //    {
            //        txtName.Text = stockList[i + 1].Name;
            //        numLastPrice.Value = stockList[i + 1].LastPrice;
            //        numOpeningPrice.Value = stockList[i + 1].OpeningPrice;
            //        numLowPrice.Value = stockList[i + 1].LowPrice;
            //        numHighPrice.Value = stockList[i + 1].HighPrice;
            //    }

            //}
        }
    }
}
