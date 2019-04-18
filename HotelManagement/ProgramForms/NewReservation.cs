using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HotelManagement.ProgramForms
{
    public partial class NewReservation : Form
    {

        static string constring = ConfigurationManager.ConnectionStrings["ConSt"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public NewReservation()
        {
            InitializeComponent();
        }
        public void NewReservation_Load(object sender, EventArgs e)
        {
            TwinBedCheck.Hide();
            string queryRoo = "Select * from Billing";
            SqlCommand cmd = new SqlCommand(queryRoo, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomTypeListBox.Items.Add(reader[2]).ToString();
                    dinningListBox.Items.Add(reader[1]).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            if (string.IsNullOrEmpty(dinningPerNight.Text))
                dinningPerNight.Text = "0";
            if (string.IsNullOrEmpty(totalNis.Text))
                totalNis.Text = "0";
            if (string.IsNullOrEmpty(noOfNights.Text))
                noOfNights.Text = "0";
            if (string.IsNullOrEmpty(nisPerNight.Text))
                nisPerNight.Text = "0";
        }
        private void roomList()
        {
            roomNumber.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * from Rooms where RoomCategory='" + roomTypeListBox.Text + "'AND RoomStatus ='Vacant'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                roomNumber.Items.Add(dr[1]);
            }
            con.Close();
        }

        private void roomTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomTypeListBox.SelectedIndex == 1)
            {
                TwinBedCheck.Show();
            }
            else
            {
                TwinBedCheck.Hide(); 
            }
            roomList();
            SqlCommand cmd = new SqlCommand("SELECT * from Billing where Room='"+roomTypeListBox.Text+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                string priceSH = (string)dr["PriceShRoom"].ToString();
                nisPerNight.Text = priceSH;
            }
            con.Close();
        }
        private void checkInPicker_ValueChanged(object sender, EventArgs e)
        {
            noOfNights.Text = checkOutPicker.Value.Date.Subtract(checkInPicker.Value.Date).Days.ToString();
        }

        private void checkOutPicker_ValueChanged(object sender, EventArgs e)
        {
            noOfNights.Text = checkOutPicker.Value.Date.Subtract(checkInPicker.Value.Date).Days.ToString();
        }

        private void noOfNights_ValueChanged(object sender, EventArgs e)
        {
            int numNights = int.Parse(noOfNights.Text);
            if (numNights < 0)
            {
                MessageBox.Show("Check in date cannot be greater the check out date.");
                checkInPicker.ResetText();
                checkOutPicker.ResetText();
            }
        }

        private void dinningListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Billing where Board ='" + dinningListBox.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string priceSHB = (string)dr["PriceShBoard"].ToString();
                dinningPerNight.Text = priceSHB;
            }
            con.Close();
        }
        private void generate_Click(object sender, EventArgs e)
        {
            int numNights = int.Parse(noOfNights.Text);
            if (numNights == 0)
            {
                MessageBox.Show("Reservation Must be at least for 1 night.");
            }
            else
            {
                int tot = Convert.ToInt32(noOfNights.Text) * Convert.ToInt32(nisPerNight.Text) + Convert.ToInt32(dinningPerNight.Text);
                totalNis.Text = tot.ToString();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            DialogResult bb = MessageBox.Show("Are you sure you want to go back to the main menu? The information won't be saved.", "Back", MessageBoxButtons.YesNo);
            if (bb == DialogResult.Yes)
            {
                this.Hide();
                Form1 bMain = new Form1();
                bMain.ShowDialog();
                this.Close();
            }
        }
        private void updateRoomNumber()
        {
            con.Open();
            string query = "update Rooms set RoomStatus='Occupied' where RoomNumber='" + roomNumber.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
        }
        private void Apply_Click(object sender, EventArgs e)
        {
            
            //Save
            if (firstName.Text == "" || lastName.Text == "" || titleListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill the guests full name and title");
            }
            else if(totalNis.Text == "0")
            {
                MessageBox.Show("Full price must be generated");
            }
            else if(roomNumber.Text == "")
            {
                MessageBox.Show("You must select a room");
            }
            else
            {
                string si = "insert into GuestProfile(FirstName,LastName,Title,CheckinDate,CheckOutDate,TotalNights,DinningPlan,RoomType,RoomNumber,Totalprice,Comments,Status) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12);";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(si, con);
                    cmd.Parameters.AddWithValue("@v1", firstName.Text);
                    cmd.Parameters.AddWithValue("@v2", lastName.Text);
                    cmd.Parameters.AddWithValue("@v3", titleListBox.Text);
                    cmd.Parameters.AddWithValue("@v4", checkInPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@v5", checkOutPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@v6", Convert.ToInt32(noOfNights.Text));
                    cmd.Parameters.AddWithValue("@v7", dinningListBox.Text);
                    cmd.Parameters.AddWithValue("@v8", roomTypeListBox.Text);
                    cmd.Parameters.AddWithValue("@v9", Convert.ToInt32(roomNumber.Text));
                    cmd.Parameters.AddWithValue("@v10", Convert.ToInt32(totalNis.Text));
                    cmd.Parameters.AddWithValue("@v11", commentsBox.Text);
                    cmd.Parameters.AddWithValue("@v12", "Reserved");
                    MessageBox.Show("New guest is added.");
                    cmd.ExecuteReader();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Proceed
                updateRoomNumber();
                this.Hide();
                Form1 bMain = new Form1();
                bMain.ShowDialog();
                this.Close();
            }
        }
    } 
}
