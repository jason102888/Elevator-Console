// William Bates
// COSC 2330-001
// Final Project

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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //var FirstName = new Reservation_App();
            //FirstName.Show();
            //SqlCommand cmd = new SqlCommand("INSERT INTO Membership (FirstName)", connection);
            //cmd.Parameters.AddWithValue("@FirstName", FirstName);

            //connection.Open();
        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //var LastName = new Reservation_App();
            //LastName.Show();
            //SqlCommand cmd = new SqlCommand("INSERT INTO Membership (LastName)", connection);
            //cmd.Parameters.AddWithValue("@LastName", LastName);
            //connection.Open();
        }

        private void plateBox_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //var LicensePlate = new Reservation_App();
            //LicensePlate.Show();
            //SqlCommand cmd = new SqlCommand("INSERT INTO Membership (LicensePlate)", connection);
            //cmd.Parameters.AddWithValue("@LicensePlate", LicensePlate);
            //connection.Open();
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //var Email = new Reservation_App();
            //Email.Show();
            //SqlCommand cmd = new SqlCommand("INSERT INTO Membership (Email)", connection);
            //cmd.Parameters.AddWithValue("@Email", Email);
            //connection.Open();
        }

        private void phoneNumBox_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //var PhoneNum = new Reservation_App();
            //PhoneNum.Show();
            //SqlCommand cmd = new SqlCommand("INSERT INTO Membership (PhoneNum)", connection);
            //cmd.Parameters.AddWithValue("@PhoneNum", PhoneNum);
            //connection.Open();
        }

        private void cardBox_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //var CreditCard = new Reservation_App();
            //CreditCard.Show();
            //SqlCommand cmd = new SqlCommand("INSERT INTO Membership (CreditCard)", connection);
            //cmd.Parameters.AddWithValue("@CreditCard", CreditCard);
            //connection.Open();
        }

        private void dbInput_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@FirstName", nameBox.Text);
                cmd.Parameters.AddWithValue("@LastName", lastNameBox.Text);
                cmd.Parameters.AddWithValue("@LicensePlate", plateBox.Text);
                cmd.Parameters.AddWithValue("@Email", emailBox.Text);
                cmd.Parameters.AddWithValue("@PhoneNum", phoneNumBox.Text);
                cmd.Parameters.AddWithValue("@CreditCard", cardBox.Text);
                cmd.CommandType = CommandType.Text;
                //cmd.ExecuteNonQuery();

               
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string message = "Writing to the database was unsuccessful: \n";
                message += ex.Message;
                throw new Exception(message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reservation_App_V2 res = new Reservation_App_V2();
            res.Show();
        }
    }
}
