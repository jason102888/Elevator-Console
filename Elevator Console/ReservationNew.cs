// Trevor Vieth & Henrico Cillie
// COSC 2330 001
// 12/12/2016
// Reservation Class for Class Project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add sql using statments
using System.Data.SqlClient;
using System.Data.Sql;
namespace ParkALot
{
    class ReservationNew
    {
        // Connect to sql server
        SqlConnection connection = new SqlConnection();
        //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
        public ReservationNew()
        {
            // Sign in
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
        }
            
        //public string resDate = Reservation_App_V2.dtpTimeIn.Value.Date;
        //public string theStartTime = Reservation_App_V2.dateTimePicker1.Value.Time;
        //public string theEndTime = Reservation_App.dateTimePicker2.Value.Time;

        // Make method for updating reservation info
        public void UpdateReservation(int customerID, string resDate, string theStartTime, string theEndTime)
        { 
        using (SqlCommand updateReservations = connection.CreateCommand())
            {
                // remember that the DateTimePicker controls return DateTime objects via their Value prooerty.

                //updateReservations.CommandText = "insert dbo.Reservations values(" + 
                //    customerID + 
                //    ", NULL,'" + 
                //    theStartTime + "','" + 
                //    theEndTime + 
                //    "', '','" + 
                //    resDate + "');";
                //Random random = new Random();
                //int randomNumber = random.Next(0, 1000);
                updateReservations.CommandText = "insert dbo.Reservations values(" +
                    customerID +
                    ", NULL,'" +
                    theStartTime + "','" +
                    theEndTime +
                    "', 65423,'" +
                    resDate + "'" +
                    ", 333" + ");";  // Needs to select fist avalable parking spot----------------------------------------------------------------------------------------------------------------------------------

                //updateReservations.CommandText = "update db_owner.Reservation set Date = '+resDate+' where ID = + Reservation_App_V2.textBox3.Value;";
                //updateReservations.StatementCompleted += updateReservations_StatementCompleted;
                updateReservations.ExecuteNonQuery();
            }
        }



        //using (SqlCommand updateReservations = connection.CreateCommand())
        //    {
        //        updateReservations.CommandText = "update db_owner.Reservation set StartTime = '+theStartTime+' where ID = + Reservation_App_V2.textBox3.Value;";
        //        updateReservations.StatementCompleted += updateReservations_StatementCompleted;
        //        updateReservations.ExecuteNonQuery();
        //    }

        //using (SqlCommand updateReservations = connection.CreateCommand())
        //    {
        //        updateReservations.CommandText = "update db_owner.Reservation set EndTime = '+theEndTime+' where ID = + Reservation_App_V2.textBox3.Value;";
        //        updateReservations.StatementCompleted += updateReservations_StatementCompleted;
        //        updateReservations.ExecuteNonQuery();
        //    }


    }
}
