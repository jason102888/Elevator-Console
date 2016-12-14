// Trevor Vieth & Henrico Cillie
// COSC 2330 001
// 12/12/2016
// Reservation Class for Class Project

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Add sql using statments
using System.Data.SqlClient;
using System.Data.Sql;
namespace ParkALot
{
    public partial class Reservation_App_V2 : Form
    {
        
        public Reservation_App_V2()
        {
            InitializeComponent();

            // Make all use case parts of the gui invisible
            groupBox1.Visible = false;
            radRes1.Visible = false;
            radRes2.Visible = false;
            radRes3.Visible = false;
            
            label6.Visible = false;
            label5.Visible = false;
            dtpDate.Visible = false;
            label3.Visible = false;
            dtpTimeIn.Visible = false;
            label4.Visible = false;
            dtpTimeOut.Visible = false;
            chkBorrowedOrRented.Visible = false;


        }

        private void btnLookUpRes_Click(object sender, EventArgs e)
        {
            // Create int variable to parse the member id text box into, then do so
            int memIDNumber = 0;    // Convert.ToInt32(txtMemberID.Text);
            int.TryParse(txtMemberID.Text, out memIDNumber);
            // Make all relevant gui parts visible
            groupBox1.Visible = true;
            radRes1.Visible = true;
            radRes2.Visible = true;
            radRes3.Visible = true;

            // Connect to server
            SqlConnection connection = new SqlConnection();
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            // Read from server and store info in "info" string
            using (SqlCommand readAllReservationInfo = connection.CreateCommand())
            {
                readAllReservationInfo.CommandText = "select * from dbo.Reservations where MemID = '"+memIDNumber+"';";

                using (SqlDataReader reader = readAllReservationInfo.ExecuteReader())
                {
                    string info = "Reservation Date: ";
                    while (reader.Read())
                    {
                        info += "Reservation Date: " + reader.GetDateTime(5).ToString() + "\nTime in: ";
                        info += reader.GetTimeSpan(2).ToString() + "\nTime out: ";
                        info += reader.GetTimeSpan(3).ToString() + "\n";
                        MessageBox.Show(info);
                    }
                }
            }

        }

        private void btnExtendRes_Click(object sender, EventArgs e)
        {
            // If user clicks extend res, makes both groups visible and changes "New Reservation" Text to "Choose Altered Time"
            groupBox1.Visible = true;
            radRes1.Visible = true;
            radRes2.Visible = true;
            radRes3.Visible = true;

            label6.Text = "Choose Altered Time";

            //label6.Visible = true;
            //label5.Visible = true;
            //dtpDate.Visible = true;
            //label3.Visible = true;
            //dtpTimeIn.Visible = true;
            //label4.Visible = true;
            //dtpTimeOut.Visible = true;
            //chkBorrowedOrRented.Visible = true;

            // Make string and float for when the reservation ends
            string whenTimeOutString = "";
            float whenTimeOutFloat = 0;

            // Connect to server
            SqlConnection connection = new SqlConnection();
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
            //-----------------------------------------------------------------------------------------------------------------------
            // Read from server and store info in "info" and display 

            using (SqlCommand readAllReservationInfo = connection.CreateCommand())
            {
                int memIDNumber = 0;    // Convert.ToInt32(txtMemberID.Text);
                int.TryParse(txtMemberID.Text, out memIDNumber);
                readAllReservationInfo.CommandText = "select * from dbo.Reservations where MemID = '"+memIDNumber+"';";

                using (SqlDataReader reader = readAllReservationInfo.ExecuteReader())
                {
                    string info = "";
                    while (reader.Read())
                    {
                        //store time out in whenTimeOutString and parse into whenTimeOutFloat
                        whenTimeOutString = reader.GetTimeSpan(3).ToString();
                        float.TryParse(whenTimeOutString, out whenTimeOutFloat);
                        //whenTimeOutFloat = float.Parse(whenTimeOutString);
                        //if (float.TryParse(whenTimeOutString, out whenTimeOutFloat))
                        //{
                        //    MessageBox.Show(whenTimeOutString);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("failed");
                        //}


                        //MessageBox.Show(whenTimeOutString);
                        info += "Reservation Date: " +reader.GetDateTime(5).ToString() + "\nTime in: ";
                        info += reader.GetTimeSpan(2).ToString() + "\nTime out: ";
                        info += reader.GetTimeSpan(3).ToString() + "\n";
                        MessageBox.Show(info);
                    }
                }
            }


            //-----------------------------------------------------------------------------------------------------------------------
            // Make float for current time and parse datetime.now into it
            float currentTime = 0;
            float.TryParse(DateTime.Now.ToLongTimeString(), out currentTime);
            // Only let the user extend their reservation if it is more than 30 minutes away
            //MessageBox.Show(whenTimeOutFloat.ToString());
            if (whenTimeOutFloat - 30f > currentTime)
            {
                // Make all relevant gui parts visible
                label6.Visible = true;
                label5.Visible = true;
                dtpDate.Visible = true;
                label3.Visible = true;
                dtpTimeIn.Visible = true;
                label4.Visible = true;
                dtpTimeOut.Visible = true;

                // Update Sql server with new info
                using (SqlCommand updateReservations = connection.CreateCommand())
                {
                    int memIDNumber = 0;    // Convert.ToInt32(txtMemberID.Text);
                    int.TryParse(txtMemberID.Text, out memIDNumber);
                    // remember that the DateTimePicker controls return DateTime objects via their Value prooerty.

                    int customerID = memIDNumber;
                    string resDate = dtpDate.Value.ToString();
                    string theStartTime = dtpTimeIn.Value.ToString();
                    string theEndTime = dtpTimeOut.Value.ToString();
                    int theSpotID = 0;
                    int theReservationID = 0;

                    //updateReservations.CommandText = "insert dbo.Reservations values(" +
                    //    customerID +
                    //    ", NULL,'" +
                    //    theStartTime + "','" +
                    //    theEndTime +
                    //    "', '','" +
                    //    resDate + "');";
                    //updateReservations.CommandText = "insert dbo.Reservations values(" +
                    //                    customerID +
                    //                    ", NULL,'" +
                    //                    theStartTime + "','" +
                    //                    theEndTime +
                    //                    "', 92343,'" +
                    //                    resDate + "'" +
                    //                    ", 334" + ");";
                    updateReservations.CommandText = "insert dbo.Reservations values(" +
                    customerID +
                    ", NULL,'" +
                    theStartTime + "','" +
                    theEndTime +
                    theSpotID +
                    resDate + "'" +
                    theReservationID + ");";

                    updateReservations.ExecuteNonQuery();
                }
            }
            else
            {
                // Inform the user they cannot extend the appointment
                MessageBox.Show("The end of your appointment is less than 30 minutes away, you cannot extend it.");
            }
        }

        private void btnNewRes_Click(object sender, EventArgs e)
        {
            // Make all relevant gui parts visible
            label6.Visible = true;
            label5.Visible = true;
            dtpDate.Visible = true;
            label3.Visible = true;
            dtpTimeIn.Visible = true;
            label4.Visible = true;
            dtpTimeOut.Visible = true;
            chkBorrowedOrRented.Visible = true;
        }

        private void radRes1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radRes2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radRes3_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        public void dtpTimeIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpTimeOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkBorrowedOrRented_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        
        private void btnSubmitNew_Click(object sender, EventArgs e)
        {
            // Instantiate ReservationNew as newRes
            ReservationNew newRes = new ReservationNew();
            // Create int variable to parse the member id text box into, then do so
            int memIDNumber = 0;    // Convert.ToInt32(txtMemberID.Text);
            int.TryParse(txtMemberID.Text, out memIDNumber);
            // update database with new info
            newRes.UpdateReservation(memIDNumber, dtpDate.Value.ToString(), dtpTimeIn.Value.ToString(), dtpTimeOut.Value.ToString());
        }
        //ReservationNew newRes2 = new ReservationNew();
        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            //ExtendReservation(label1.text);
        }
    }
}
