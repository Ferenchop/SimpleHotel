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
    public partial class BillingFolio : Form
    {

        static string constring = ConfigurationManager.ConnectionStrings["ConSt"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public BillingFolio()
        {
            InitializeComponent();
        }

        public BillingFolio(string resID)
        {
            InitializeComponent();
            saveAndProceed.Hide();
            gResNumber.Text = resID;
            if (string.IsNullOrEmpty(gTotal.Text))
                gTotal.Text = gTotalCharge.Text;
            if (string.IsNullOrEmpty(gTotalPayed.Text))
                gTotalPayed.Text = "0";
            con.Open();
            
            string fill = "SELECT * from GuestProfile Where ResNumber='" + gResNumber.Text + "'";
            SqlCommand cmd = new SqlCommand(fill, con);
            SqlDataReader de = cmd.ExecuteReader();
            while (de.Read())
            {
                gFirstName.Text = (string)de["FirstName"].ToString();
                gLastName.Text = (string)de["LastName"].ToString();
                gResNumber.Text = (string)de["ResNumber"].ToString();
                gTotalCharge.Text = (string)de["TotalPrice"].ToString();
                gTotalPayed.Text = (string)de["Payment"].ToString();
            }
            con.Close();
        }
        private void bbutton_Click(object sender, EventArgs e)
        {
            string resID = gResNumber.Text;
            this.Hide();
            GuestProfile gp = new GuestProfile(resID);
            gp.ShowDialog();
            this.Close();
        }
        public string Calculate()
        {
            int temp = Convert.ToInt32(gTotalCharge.Text) - Convert.ToInt32(gTotalPayed.Text);
            
            return temp.ToString();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            string temp = Calculate();
            gTotal.Text = temp;
            payButton.Hide();
            saveAndProceed.Show();
        }

        private void gTotalPayed_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(gTotalPayed.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only positive numbers, and press the payment button.");
                gTotalPayed.Text = gTotalPayed.Text.Remove(gTotalPayed.Text.Length - 1);
            }
        }

        private void gTotal_TextChanged(object sender, EventArgs e)
        {
            int itot = Convert.ToInt32(gTotal.Text);
            if(itot < 0)
            {
                MessageBox.Show("Please take your change");
                gTotal.Text = "0";

            }
            else if(itot == 0)
            {
                payButton.Hide();
                saveAndProceed.Show();
            }

        }

        private void saveAndProceed_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update GuestProfile set Payment='" + gTotal.Text+ "' where resNumber ='" + gResNumber.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteReader();
            MessageBox.Show("Payment Saved");
            con.Close();
            string resID = gResNumber.Text;
            this.Hide();
            GuestProfile gp = new GuestProfile(resID);
            gp.ShowDialog();
            this.Close();
        }
    }
}
