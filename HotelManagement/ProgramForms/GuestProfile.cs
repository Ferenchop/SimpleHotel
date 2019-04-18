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
using System.Configuration;

namespace HotelManagement.ProgramForms
{
    public partial class GuestProfile : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["ConSt"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public GuestProfile()
        {
            InitializeComponent();
        }
        public GuestProfile(string resID)
        {
            InitializeComponent();
            proResNumber.Text = resID;
            con.Open();
            string fille = "update GuestProfile set Status='Departing' Where CheckOutDate <= GETDATE() AND Status='Checked In'";
            SqlCommand cmda = new SqlCommand(fille, con);
            cmda.ExecuteReader();
            con.Close();
            con.Open();
            string fill = "SELECT * from GuestProfile Where ResNumber='"+proResNumber.Text+"'";
            SqlCommand cmd = new SqlCommand(fill, con);
            SqlDataReader de = cmd.ExecuteReader();
            while (de.Read())
            {
                proTitle.Text = (string) de["Title"].ToString();
                proFirstName.Text = (string)de["FirstName"].ToString();
                proLastName.Text = (string)de["LastName"].ToString();
                proCheckInDateBox.Text = (string)de["CheckInDate"].ToString();
                proCheckOutDateBox.Text = (string)de["CheckOutDate"].ToString();
                proNoOfNights.Text = (string)de["TotalNights"].ToString();
                proDinningPlan.Text = (string)de["DinningPlan"].ToString();
                proRoomPlan.Text = (string)de["RoomType"].ToString();
                proRoomNumber.Text = (string)de["RoomNumber"].ToString();
                proTotalPrice.Text = (string)de["TotalPrice"].ToString();
                proCommentsBox.Text = (string)de["Comments"].ToString();
                proStatus.Text = (string)de["Status"].ToString();

            }
            con.Close();
            checkDeparture();
            if (proStatus.Text == "Reserved")
            {
                proCheckInButton.Show();
                proCheckOutButton.Hide();
            }
            else if(proStatus.Text == "Checked In")
            {
                proCheckInButton.Hide();
                proCheckOutButton.Hide();
            }
            else if(proStatus.Text == "Departing")
            {
                proCheckInButton.Hide();
                proCheckOutButton.Show();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mm = new Form1();
            mm.ShowDialog();
            this.Close();
        }

        private void checkDeparture()
        {
            con.Open();
            string fill = "update GuestProfile set Status='Departing' Where CheckOutDate <= GETDATE() AND Status='Checked In'";
            SqlCommand cmd = new SqlCommand(fill, con);
            cmd.ExecuteReader();
            con.Close();
        }
        private void proCheckOutButton_Click(object sender, EventArgs e)
        {

            con.Open();
            string fill = "Update  GuestProfile Set Status='Checked Out' where ResNumber='" + proResNumber.Text + "'";
            SqlCommand cmd = new SqlCommand(fill, con);
            cmd.ExecuteReader();
            con.Close();
            con.Open();
            string up = "Update  Rooms Set RoomStatus='Vacant' where ResNumber='" + proResNumber.Text + "'";
            SqlCommand cmda = new SqlCommand(up, con);
            cmda.ExecuteReader();
            con.Close();
            MessageBox.Show("Guests has checked out.");
            this.Hide();
            Form1 bMain = new Form1();
            bMain.ShowDialog();
            this.Close();
        }

        private void proCheckInButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string fill = "Update  GuestProfile Set Status='Checked In' where ResNumber='"+ proResNumber.Text + "'";
            SqlCommand cmd = new SqlCommand(fill, con);
            cmd.ExecuteReader();
            con.Close();
            updateRoomNumber();
            MessageBox.Show("Guests has checked in.");
            this.Hide();
            Form1 bMain = new Form1();
            bMain.ShowDialog();
            this.Close();

        }
        private void updateRoomNumber()
        {
            con.Open();
            string query = "update Rooms set RoomStatus='Occupied' where RoomNumber='" + proRoomNumber.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
        }

        private void billingFoliobutton_Click(object sender, EventArgs e)
        {
            string resId = proResNumber.Text;
            this.Hide();
            BillingFolio bf = new BillingFolio(resId);
            bf.ShowDialog();
            this.Close();
        }
    }
}
