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

            static void Main(string[] args)
            {
                SqlConnection connection = new SqlConnection();
                //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
                connection.Open();
                Console.WriteLine(connection.ServerVersion);
                Console.ReadKey();

                using (SqlCommand searchForAppointment = connection.CreateCommand())
                {
                    searchForAppointment.CommandText = "select from db_owner.appointment where liscensePlate = lp;";

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

                if (appointment == true)
                {
                    using (SqlCommand searchForAppointment = connection.CreateCommand())
                    {
                        searchForAppointment.CommandText = "select from db_owner.appointment where liscensePlate = lp;";

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

                else if (appointment == false)
                {
                    Console.WriteLine("You do not have a reservation, enter a duration to make a reservation, or an appointment confirmation number");

                    using (SqlCommand searchForAppConNum = connection.CreateCommand())
                    {
                        searchForAppConNum.CommandText = "select from db_owner.appointment where appointmentConfirmationNumber = appConNum;";

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

            else if (SELECT FROM db_owner.members where membershipID = memID)
            {
                using (SqlCommand searchForSpot = connection.CreateCommand())
                {
                    searchForSpot.CommandText = "select from db_owner.spaces where reservation = false;";

                    using (SqlDataReader reader = searchForSpot.ExecuteReader())
                    {
                        int openSpot = 0;
                        while (reader.Read())
                        {
                            openSpot = reader.GetInt32(3);
                            Console.WriteLine(openSpot);
                        }
                    }
                }

                using (SqlCommand updateAppointment = connection.CreateCommand())
                {
                    updateAppointment.CommandText = "update db_owner.appointment set appointment = 'true', spotID = spot, duration = duration where liscensePlate = lp;";
                    updateAppointment.StatementCompleted += updateAppointment_StatementCompleted;
                    updateAppointment.ExecuteNonQuery();
                }
            }
            Console.ReadKey();
        }
    }
}