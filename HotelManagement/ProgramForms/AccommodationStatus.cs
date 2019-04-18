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
    public partial class AccommodationStatus : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["ConSt"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public AccommodationStatus()
        {
            InitializeComponent();
            getAccommodationStatus();
        }
        public void getAccommodationStatus()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Rooms", con);
            adapter.Fill(dt);
            accommodataionGrid.DataSource = dt;
        }

        private void bbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bMain = new Form1();
            bMain.ShowDialog();
            this.Close();
        }
    }
}
