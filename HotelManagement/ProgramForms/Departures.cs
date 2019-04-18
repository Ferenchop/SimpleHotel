using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HotelManagement.ProgramForms
{
    public partial class Departures : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["ConSt"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public Departures()
        {
            InitializeComponent();
            getDepartures();
        }
        private void getDepartures()
        {
            DateTime today = DateTime.Today;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Title, FirstName, LastName,RoomNumber, CheckInDate,CheckOutDate,TotalNights,ResNumber from GuestProfile Where CheckOutDate <= GETDATE() AND Status='Departing'", con);
            adapter.Fill(dt);
            deprturesGrid.DataSource = dt;
        }

        private void bbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bMain = new Form1();
            bMain.ShowDialog();
            this.Close();
        }

        private void deprturesGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string dataValue = deprturesGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            this.Hide();
            GuestProfile gp = new GuestProfile(dataValue);
            gp.ShowDialog();
            this.Close();
        }
    }
}
