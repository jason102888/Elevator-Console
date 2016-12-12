using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;

namespace ParkALot
{
    public class Database : ParkALot
    {
        public void queryInfoByName()
        {

            // Create a connection to the Sql Database
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password=db10;";
            connection.Open();

            // Instantiate the Garage Operator 
            Garage_Operator garage = new Garage_Operator();

            // Create a variable for the customer name retrieved from the database
            string customerName = garage.textBox2.Text;

            // reading the information from the database
            using (SqlCommand readInfoByName = connection.CreateCommand())
            {
                readInfoByName.CommandText = "select * from dbo.Membership where FirstName = '" + customerName + "' ";

                using (SqlDataReader reader = readInfoByName.ExecuteReader())
                {
                    string rec = "";
                    while (reader.Read())
                    {
                        rec = "Member ID:  ";
                        rec += reader.GetInt32(0) + "\n";
                        rec += "First Name: " + reader.GetString(1) + "\n";
                        rec += "Last Name: " + reader.GetString(2) + "\n";
                        rec += "License Plate: " + reader.GetString(3) + "\n";
                        rec += "Email: " + reader.GetString(4) + "\n";
                        rec += "Phone Number: " + reader.GetInt32(5) + "\n";
                        rec += "Credit Card: " + reader.GetInt32(6);
                        Console.WriteLine(rec);
                        Console.ReadKey();
                    }
                }
            }
        }

        public void queryMembershipNumber()
        {

        }

        public void queryEmptySpaces()
        {

        }
    }
}