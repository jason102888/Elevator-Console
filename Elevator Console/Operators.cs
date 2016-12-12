﻿//Jeff and Kelcey

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;

namespace ParkALot
{
    public class Operators
    {
        //create a connection and name it connection 
        SqlConnection connection;

        public Operators()
        {
            //here in the constructor we are giving it the log in credentials, and calling it everytime Operator() is called.
            connection = new SqlConnection("Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;");
        }

        //The method below will help tell us yes or no a non query executed( update,creat, delete, insert), it will also 
        //act as the "handler" for non query functions
        private bool DoNonQuery(string queryString)
        {
            int rowCount;

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = queryString;
                command.Connection.Open();
                rowCount = command.ExecuteNonQuery();
            }

            return rowCount > 0;
        }
        // This method acts as the "handler" for all queries which we know execute if we see the data
        // To pull out the data from the list, just use a foreach:


        private List<DataRow> Query(string queryString)
        {
            List<DataRow> results = new List<DataRow>();
            DataTable resultsTable = new DataTable();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = queryString;
                command.Connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    resultsTable.Load(reader);
                    foreach (DataRow row in resultsTable.Rows)
                    {
                        results.Add(row);
                    }
                }
            }
            return results;
        }
        //private void Query(string queryString)
        //{
        //    //List<string> result = new List<String>();

        //    using (SqlCommand command = connection.CreateCommand())
        //    {
        //        command.CommandText = queryString;
        //        command.Connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        string rec = "";
        //        while (reader.Read())
        //        {
        //            //IDataRecord record = (IDataRecord)reader;
        //            // result.Add(String.Format("{0}, {1}", record[0], record[1]));
        //            rec = reader.GetString(1) + " ";
        //            rec += reader.GetString(2) + " ";
        //            rec += reader.GetString(3);
        //            Console.WriteLine(rec);
        //        }

        //        // Call Close when done reading.
        //        reader.Close();                 //ask higgs if neccessary
        //    }

        //  //  return result;
        //}

        public void GetCustomerData(string memberInfo)
        {
            string queryString = String.Format("SELECT * from Membership WHERE (FirstName = '{0}' OR LastName = '{0}');", memberInfo);
            //SqlDataReader reader = Query(queryString);         //ask higgs what the frack
            //while (reader.Read())
            //{
            //    int count = 0;
            //    Console.WriteLine(reader[count]);
            //    count++;
            //}
            List<DataRow> results = Query(queryString);
            foreach (DataRow row in results)
            {
                Console.WriteLine(row.Field<int>(0).ToString());
            }

        }

        public void SetPrice(string newPrice)
        {
            bool result = DoNonQuery("UPDATE * ParkingSpace SET  = ");
            if (result)
            {
                MessageBox.Show("It fucking worked");
            }
            else
            {
                MessageBox.Show("it didnt fucking work.");
            }
        }

    }
}