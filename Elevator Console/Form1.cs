using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;

namespace ParkALot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reservation_App res = new Reservation_App();
            res.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLPlateTrue_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            // Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand searchForAppointment = connection.CreateCommand())
            {
                searchForAppointment.CommandText = "select * from dbo.Reservations where LicensePlate = 1;";

                using (SqlDataReader reader = searchForAppointment.ExecuteReader())
                {
                    int spot = 0;
                    while (reader.Read())
                    {
                        spot = reader.GetInt32(4);
                        string spotID = spot.ToString();
                        lblOutput.Text = ("Your spot ID is " + spotID);
                        // elevator goes to floor
                    }
                }
            }
        }

        // The following code was written by Cameron Stover and Ryan Robison

        private void btnLPlateFalse_Click(object sender, EventArgs e)
        {
            // If no appointment is associated with the scanned license plate tell the member they
            // do not have a reservation ask them to enter a duration to make a reservation or
            // to give their appointment confirmation number if the customer qives a confirmation 
            // number query the database for a matching number. If a matching number is found tell 
            // them their spotID and take them to their floor. If no matching number is found tell 
            // them to leave

            SqlConnection connection = new SqlConnection();
            // Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
            {
                Console.WriteLine("You do not have a reservation, enter a duration to make a reservation, or an appointment confirmation number");

                using (SqlCommand searchForAppConNum = connection.CreateCommand())
                {
                    searchForAppConNum.CommandText = "select * from dbo.Reservations where ReservationID = 1;";

                    using (SqlDataReader reader = searchForAppConNum.ExecuteReader())
                    {
                        string appNum = "";
                        int spot = 0;
                        while (reader.Read())
                        {
                            appNum = reader.GetString(0);
                            spot = reader.GetInt32(4);
                            string appCNum = appNum;

                            if (appCNum != null)
                            {
                                string spotID = spot.ToString();
                                lblOutput.Text = ("Your spot ID is " + spotID);
                                // elevator goes to floor
                            }

                            else if (appCNum == null)
                            {
                                Console.WriteLine("Leave elevator");
                            }
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            // If a membershipID is given query the database for spaces that do not have a reservation
            // If an empty spot is found return the spotID and take them to the appropriate floor
            // Then update appointments makeing appoinment = true spotID - the spot they were assigned
            // and duration = the duration they entered in association with the mempershipID they entered

            SqlConnection connection = new SqlConnection();
            // Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
            using (SqlCommand searchForSpot = connection.CreateCommand())
            {
                searchForSpot.CommandText = "select top 1 * from dbo.ParkingSpace where Empty = 0;";

                using (SqlDataReader reader = searchForSpot.ExecuteReader())
                {
                    int spot = 0;
                    while (reader.Read())
                    {
                        spot = reader.GetInt32(0);
                        string spotID = spot.ToString();
                        lblOutput.Text = ("Your spot ID is " + spotID);
                        // elevator goes to floor
                    }
                }
            }

            using (SqlCommand updateAppointment = connection.CreateCommand())
            {
                updateAppointment.CommandText = "update dbo.appointment set appointment = 'true', spotID = spot where membershipID = memID;";
                updateAppointment.ExecuteNonQuery();
            }
        }
    }
}