using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.ProgramForms
{
    public partial class HotelInformation : Form
    {
        public HotelInformation()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
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
