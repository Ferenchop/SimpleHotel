using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelManagement.ProgramForms;

namespace HotelManagement
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //new reservation
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewReservation nr = new NewReservation();
            nr.ShowDialog();
            this.Close();
        }
        //arrivals
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Arrivals ar = new Arrivals();
            ar.ShowDialog();
            this.Close();
        }
        //guests in house
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestInHouse gst = new GuestInHouse();
            gst.ShowDialog();
            this.Close();
        }
        //departures
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Departures dp = new Departures();
            dp.ShowDialog();
            this.Close();
        }
        //Accommodation Status
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccommodationStatus acs = new AccommodationStatus();
            acs.ShowDialog();
            this.Close();
        }
        //hotel information
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelInformation hi = new HotelInformation();
            hi.ShowDialog();
            this.Close();
        }
    }
}
