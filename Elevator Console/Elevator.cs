// Cameron Stover & Ryan Robison
// COSC 2330 001
// 12/8/2016
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
        private string duration;
        private int lp;
        private int appConNum;
        private static bool appointment;
        private static int spot;

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public int LP
        {
            get { return lp; }
            set { lp = value; }
        }

        public int AppConNum
        {
            get { return appConNum; }
            set { appConNum = value; }
        }

        public object memID { get; set; }

        // Make connection to database
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            // Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
            Console.ReadKey();

            // Scan for license plate and determine if there is an appointment associated with it
            // I don't know the names of any of the database items yet so these are only temporary
            using (SqlCommand searchForAppointment = connection.CreateCommand())
            {
                searchForAppointment.CommandText = "select * from db_owner.appointment where licensePlate = lp;";

                using (SqlDataReader reader = searchForAppointment.ExecuteReader())
                {
                    bool app = false;
                    while (reader.Read())
                    {
                        app = reader.GetBoolean(2);
                        bool appointment = app;
                    }
                }
            }

            // If an appointment is associated with the scanned license plate tell the member their
            // spotID and take them to the appropriate floor
            if (appointment == true)
            {
                using (SqlCommand searchForAppointment = connection.CreateCommand())
                {
                    searchForAppointment.CommandText = "select * from db_owner.appointment where liscensePlate = lp;";

                    using (SqlDataReader reader = searchForAppointment.ExecuteReader())
                    {
                        int spot = 0;
                        while (reader.Read())
                        {
                            spot = reader.GetInt32(3);
                            Console.WriteLine(spot);
                            // elevator goes to floor
                        }
                    }
                }
            }

            // If no appointment is associated with the scanned license plate tell the member they
            // do not have a reservation ask them to enter a duration to make a reservation or
            // to give their appointment confirmation number if the customer qives a confirmation 
            // number query the database for a matching number. If a matching number is found tell 
            // them their spotID and take them to their floor. If no matching number is found tell 
            // them to leave
            else if (appointment == false)
            {
                Console.WriteLine("You do not have a reservation, enter a duration to make a reservation, or an appointment confirmation number");

                using (SqlCommand searchForAppConNum = connection.CreateCommand())
                {
                    searchForAppConNum.CommandText = "select * from db_owner.appointment where appointmentConfirmationNumber = appConNum;";

                    using (SqlDataReader reader = searchForAppConNum.ExecuteReader())
                    {
                        string appNum = "";
                        while (reader.Read())
                        {
                            appNum = reader.GetString(4);
                            string appCNum = appNum;

                            if (appCNum != null)
                            {
                                // elevator goes to floor
                                Console.WriteLine(spot);
                            }

                            else if (appCNum == null)
                            {
                                Console.WriteLine("Leave elevator");
                            }
                        }
                    }
                }
            }

            // If a membershipID is given query the database for spaces that do not have a reservation
            // If an empty spot is found return the spotID and take them to the appropriate floor
            // Then update appointments makeing appoinment = true spotID - the spot they were assigned
            // and duration = the duration they entered in association with the mempershipID they entered
            else if (SELECT FROM db_owner.members where membershipID = memID)
            {
                using (SqlCommand searchForSpot = connection.CreateCommand())
                {
                    searchForSpot.CommandText = "select * from db_owner.spaces where reservation = false;";

                    using (SqlDataReader reader = searchForSpot.ExecuteReader())
                    {
                        int openSpot = 0;
                        while (reader.Read())
                        {
                            openSpot = reader.GetInt32(3);
                            Console.WriteLine(openSpot);
                            // elevator goes to floor
                        }
                    }
                }

                using (SqlCommand updateAppointment = connection.CreateCommand())
                {
                    updateAppointment.CommandText = "update db_owner.appointment set appointment = 'true', spotID = spot, duration = duration where membershipID = memID;";
                    updateAppointment.StatementCompleted += updateAppointment_StatementCompleted;
                    updateAppointment.ExecuteNonQuery();
                }
            }
            Console.ReadKey();
        }
    }
}