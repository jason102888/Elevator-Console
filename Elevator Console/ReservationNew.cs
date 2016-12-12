using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
namespace ParkALot
{
    class ReservationNew
    {
        SqlConnection connection = new SqlConnection();
        //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
        public ReservationNew()
        {
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);
            Console.ReadKey();
        }
            
        //public string resDate = Reservation_App_V2.dtpTimeIn.Value.Date;
        //public string theStartTime = Reservation_App_V2.dateTimePicker1.Value.Time;
        //public string theEndTime = Reservation_App.dateTimePicker2.Value.Time;


        public void UpdateReservation(int customerID, string resDate, string theStartTime, string theEndTime)
        { 
        using (SqlCommand updateReservations = connection.CreateCommand())
            {
                // remember that the DateTimePicker controls return DateTime objects via their Value prooerty.

                updateReservations.CommandText = "insert dbo.Reservations values(" + 
                    customerID + 
                    ", NULL,'" + 
                    theStartTime + "','" + 
                    theEndTime + 
                    "', '','" + 
                    resDate + "');";
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
