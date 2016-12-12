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
    public partial class Reservation_App_V2 : Form
    {
        
        public Reservation_App_V2()
        {
            InitializeComponent();

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
            int memIDNumber = 0;    // Convert.ToInt32(txtMemberID.Text);
            int.TryParse(txtMemberID.Text, out memIDNumber);
            groupBox1.Visible = true;
            radRes1.Visible = true;
            radRes2.Visible = true;
            radRes3.Visible = true;

            SqlConnection connection = new SqlConnection();
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

        
            using (SqlCommand readAllReservationInfo = connection.CreateCommand())
            {
                readAllReservationInfo.CommandText = "select * from dbo.Reservations where MemID = '+memIDNumber+';";

                using (SqlDataReader reader = readAllReservationInfo.ExecuteReader())
                {
                    string info = "Reservation Date: ";
                    while (reader.Read())
                    {
                        info = reader.GetString(6) + ", Time in: ";
                        info += reader.GetString(3) + ", Time out: ";
                        info += reader.GetString(4);
                        MessageBox.Show(info);
                    }
                }
            }

        }

        private void btnExtendRes_Click(object sender, EventArgs e)
        {
            // If user clicks change res, makes both groups visible and changes "New Reservation" Text to "Choose Altered Time"
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

            string whenTimeOutString = "";
            float whenTimeOutInt = 0;

            SqlConnection connection = new SqlConnection();
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
            //-----------------------------------------------------------------------------------------------------------------------
            using (SqlCommand readAllReservationInfo = connection.CreateCommand())
            {
                readAllReservationInfo.CommandText = "select * from dbo.Reservations where MemID = '+memIDNumber+';";

                using (SqlDataReader reader = readAllReservationInfo.ExecuteReader())
                {
                    string info = "Reservation Date: ";
                    while (reader.Read())
                    {
                        whenTimeOutString = reader.GetString(4);
                        float.TryParse(whenTimeOutString, out whenTimeOutInt);

                        info = reader.GetString(6) + ", Time in: ";
                        info += reader.GetString(3) + ", Time out: ";
                        info += reader.GetString(4);
                        MessageBox.Show(info);
                    }
                }
            }


            //-----------------------------------------------------------------------------------------------------------------------
            float currentTime = 0;
            float.TryParse(DateTime.Now.ToLongTimeString(), out currentTime);
            if (whenTimeOutInt - 30f > currentTime)
            {
                label6.Visible = true;
                label5.Visible = true;
                dtpDate.Visible = true;
                label3.Visible = true;
                dtpTimeIn.Visible = true;
                label4.Visible = true;
                dtpTimeOut.Visible = true;

                using (SqlCommand updateReservations = connection.CreateCommand())
                {
                    int memIDNumber = 0;    // Convert.ToInt32(txtMemberID.Text);
                    int.TryParse(txtMemberID.Text, out memIDNumber);
                    // remember that the DateTimePicker controls return DateTime objects via their Value prooerty.

                    int customerID = memIDNumber;
                    string resDate = dtpDate.Value.ToString();
                    string theStartTime = dtpTimeIn.Value.ToString();
                    string theEndTime = dtpTimeOut.Value.ToString();


                    updateReservations.CommandText = "insert dbo.Reservations values(" +
                        customerID +
                        ", NULL,'" +
                        theStartTime + "','" +
                        theEndTime +
                        "', '','" +
                        resDate + "');";

                    updateReservations.ExecuteNonQuery();
                }
            }
        }

        private void btnNewRes_Click(object sender, EventArgs e)
        {
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
            ReservationNew newRes = new ReservationNew();

            int memIDNumber = 0;    // Convert.ToInt32(txtMemberID.Text);
            int.TryParse(txtMemberID.Text, out memIDNumber);

            newRes.UpdateReservation(memIDNumber, dtpDate.Value.ToString(), dtpTimeIn.Value.ToString(), dtpTimeOut.Value.ToString());
        }
        ReservationNew newRes2 = new ReservationNew();
        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            //ExtendReservation(label1.text);
        }
    }
}
