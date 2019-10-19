using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace VFW_DatabaseNotes
{

    // static means you can use the methods in this class without instantiating
    // in a static class, you can't have member variables though
    public static class DBUtils
    {
        public static string BuildConnectionString()
        {
            string serverIP = "";
            string port = "";

            try
            {
                // this will read the ip and port from the txt file we created
                // give the streamreader the direct path to the txt file
                using (StreamReader sr = new StreamReader(@"C:Desktop\SkyVale_Repo\VFW\VFW Notes\VFW_DatabaseNotes\connection.txt"))
                {
                    serverIP = sr.ReadLine();
                    port = sr.ReadLine();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            // make sure the userID and password are the ones used in your SQL server
            return "server=" + serverIP + ";uid=dbsAdmin;password=password;database=ExampleDatabase;SslMode=none;port=" + port;


        }



        public static MySqlConnection Connect(string myConnectionString)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                // open up the connection with the database
                conn.ConnectionString = myConnectionString;
                conn.Open();

                MessageBox.Show("Connected!");

            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 1042:
                        {
                            MessageBox.Show("Can't resolve host address.\n\n" + myConnectionString);
                        }
                        break;
                    case 1045:
                        {
                            MessageBox.Show("Invalid username or password.\n\n");
                        }
                        break;
                    default:
                        {
                            MessageBox.Show(e.ToString() + "\n\n" + myConnectionString);
                        }
                        break;

                }

            }

            return conn;

        }

    }

}
