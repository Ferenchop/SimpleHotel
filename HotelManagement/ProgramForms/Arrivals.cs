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
    public partial class Arrivals : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["ConSt"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public Arrivals()
        {
            InitializeComponent();
            getArrivals();
        }

        private void arrivalsGrid_Load(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void getArrivals()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Title, FirstName, LastName, RoomNumber, CheckInDate,CheckOutDate,TotalNights,ResNumber from GuestProfile Where CheckInDate <= GETDATE() AND Status ='Reserved'", con);
            adapter.Fill(dt);
            arrivalsGrid.DataSource = dt;
        }

        private void bbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bMain = new Form1();
            bMain.ShowDialog();
            this.Close();
        }

        private void arrivalsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            string dataValue = arrivalsGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            GuestProfile gp = new GuestProfile(dataValue);
            this.Hide();
            gp.ShowDialog();
            this.Close();
        }

    }
}
