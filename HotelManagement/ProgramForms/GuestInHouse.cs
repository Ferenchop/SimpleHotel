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
    public partial class GuestInHouse : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["ConSt"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public GuestInHouse()
        {
            InitializeComponent();
            getGuestsInHouse();
        }
        private void getGuestsInHouse()
        {
            DateTime today = DateTime.Today;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Title, FirstName, LastName,RoomNumber, CheckInDate,CheckOutDate,TotalNights,ResNumber from GuestProfile Where Status='Checked In'", con);
            adapter.Fill(dt);
            guestsInHouseGrid.DataSource = dt;
        }

        private void bbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bMain = new Form1();
            bMain.ShowDialog();
            this.Close();
        }

        private void guestsInHouseGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dataValue = guestsInHouseGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            GuestProfile gp = new GuestProfile(dataValue);
            gp.ShowDialog();
            this.Close();
        }

    }
}
