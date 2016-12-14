// Cameron Stover & Ryan Robison
// COSC 2330 001
// 12/14/2016
// Elevator Class for Class Project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace ParkALot
{
    public class Elevator : ParkALot
    {
        public void queryAppointment()
        {
            SqlConnection connection = new SqlConnection();
            // Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
            Console.ReadKey();

            // Scan for license plate and determine if there is an appointment associated with it
            using (SqlCommand searchForAppointment = connection.CreateCommand())
            {
                searchForAppointment.CommandText = "select * from dbo.Reservations where licensePlate = lp;";

                using (SqlDataReader reader = searchForAppointment.ExecuteReader())
                {
                    bool app = true;
                    while (reader.Read())
                    {
                        app = reader.GetBoolean(5);
                        bool Appointment = app;
                        if (Appointment == true)
                        { /*elevator goes to floor*/ }
                    }
                }
            }
        }
    }
}