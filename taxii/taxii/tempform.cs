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

namespace taxii
{
    public partial class tempform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=K:\finalll\final_stages\taxii\taxii\rental.mdf;Integrated Security=True");

        public tempform()
        {
            InitializeComponent();
        }

        private void tempform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rideselect1.ride' table. You can move, or remove it, as needed.
            this.rideTableAdapter.Fill(this.rideselect1.ride);

        }

        private void okay_Click(object sender, EventArgs e)
        {
            
        }

        private void rideselect_SelectedIndexChanged(object sender, EventArgs e)
        {

            int y = Convert.ToInt32(rideselect.Text);
            con.Open();


            string cmd = "select c_name from ride where id='" + y + "'";
            SqlCommand c = new SqlCommand(cmd, con);
            string h = Convert.ToString(c.ExecuteScalar());

        }
    }
}
