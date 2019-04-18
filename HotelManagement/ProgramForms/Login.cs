using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
 
namespace HotelManagement
{
    public partial class Form2: Form 
    {
        static string constring = ConfigurationManager.ConnectionStrings["ConSt"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public Form2()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 8;
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 8;
            textBox2.PasswordChar = '*';
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select count (*) from login where username=@b1 and password=@b2";
                SqlCommand cmad = new SqlCommand(query, con);
                cmad.Parameters.AddWithValue("@b1", textBox1.Text);
                cmad.Parameters.AddWithValue("@b2", textBox2.Text);
                con.Open();
                int i = Convert.ToInt32(cmad.ExecuteScalar());
                con.Close();
                if (i == 1)
                {
                    MessageBox.Show("User Confirmed");
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password");
                    textBox1.ResetText();
                    textBox2.ResetText();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
