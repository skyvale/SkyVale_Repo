using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Valerio_Sky_DBSreview
{
    class Assignment
    {

        public string City;
        public decimal Temp;
        public decimal Pressure;
        public int Humidity;

        public Assignment()
        {

            // MySQL Database Connection String
            string cs = @"server=172.20.6.206;userid=review;password=password;database=DBSreview;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;

            // Prompt the user
            string cityInput = Validation.ValidateString("\nWhat city would you like to know the weather for?");
            City = cityInput;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                string stm = "SELECT temp, humidity, pressure" +
                             "FROM weather" +
                             "WHERE city = @City";

                MySqlCommand cmd = new MySqlCommand(stm, conn);
                cmd.Parameters.AddWithValue("@city", City);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();

                    // set properties
                    City = rdr["city"].ToString();

                    decimal tempString;
                    decimal.TryParse(rdr["temp"].ToString(), out tempString);
                    Temp = tempString;

                    decimal pressureString;
                    decimal.TryParse(rdr["pressure"].ToString(), out pressureString);
                    Pressure = pressureString;

                    int humidString;
                    int.TryParse(rdr["humidity"].ToString(), out humidString);
                    Humidity = humidString;


                    // display properties
                    Console.WriteLine("\n--------------------------------\n");
                    Console.WriteLine("\nCity: " + City);
                    Console.WriteLine("Temperature: " + Temp);
                    Console.WriteLine("Pressure: " + Pressure);
                    Console.WriteLine("Humidity: " + Humidity + "%\n");



                }
                else
                {
                    Console.WriteLine("\r\nCity unknown. Please input a valid city name.");

                }

                rdr.Close();

                Console.WriteLine("\nPress any key to continue...\n");
                Console.ReadKey();
                Console.Clear();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                Console.ReadKey();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }


    }
}
