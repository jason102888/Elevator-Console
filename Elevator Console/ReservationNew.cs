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
        connection.ConnectionString = "Server=cis1.actx.edu;Database=project;User Id=project;Password = project1;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);
            Console.ReadKey();

            
        public string resDate = Reservation_App.dateTimePicker4.Value.Date;
        public string theStartTime = Reservation_App.dateTimePicker1.Value.Time;
        public string theEndTime = Reservation_App.dateTimePicker2.Value.Time;



        using (SqlCommand updateReservations = connection.CreateCommand())
            {
                updateReservations.CommandText = "update db_owner.Reservation set Date = '+resDate+' where ID = + Reservation_App.textBox3.Value;";
                updateReservations.StatementCompleted += updateReservations_StatementCompleted;
                updateReservations.ExecuteNonQuery();
            }

        using (SqlCommand updateReservations = connection.CreateCommand())
            {
                updateReservations.CommandText = "update db_owner.Reservation set StartTime = '+theStartTime+' where ID = + Reservation_App.textBox3.Value;";
                updateReservations.StatementCompleted += updateReservations_StatementCompleted;
                updateReservations.ExecuteNonQuery();
            }

        using (SqlCommand updateReservations = connection.CreateCommand())
            {
                updateReservations.CommandText = "update db_owner.Reservation set EndTime = '+theEndTime+' where ID = + Reservation_App.textBox3.Value;";
                updateReservations.StatementCompleted += updateReservations_StatementCompleted;
                updateReservations.ExecuteNonQuery();
            }


    }
}
