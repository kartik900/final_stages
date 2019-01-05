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
using System.IO;
using Bunifu.Framework.UI;
using System.Configuration;

namespace taxii
{
    public partial class control : Form
    {
        string constr;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=K:\finalll\final_stages\taxii\taxii\rental.mdf;Integrated Security=True");
        
        Ride[] r = new Ride[90];
        int i = 0;
        public control()
        {
            InitializeComponent();
          
        }
        #region header drag
        private bool mouseDown;
        private Point lastLocation;

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }
        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void control_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carselect_dataset.car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.carselect_dataset.car);
            // TODO: This line of code loads data into the 'drivername_dataset.driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.drivername_dataset.driver);

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            
            drivernamelabel.Text = driversel.Text;
            cnamelabel.Text = cname.TextName;
            cpnumlabel.Text = cpno.TextName;
            string datee = datepick.Value.ToString();

            con.Open();
            string cmd = "insert into ride(c_name,d_name,car,date)values('"+cname.TextName+"','"+driversel.Text+"','"+carsel.Text+"','"+datee+"')";
            SqlCommand c1 = new SqlCommand(cmd, con);
            c1.ExecuteNonQuery();
            con.Close();




          

        }

    }
    class Ride
    {
        int carnum, hours, driverid, drivers_cut, owner_cut, count_before, count_after;
        public Ride(int a, int count_b,)
        {
            carnum = a;
            count_before = count_b;
        }
        public int Farecal(int a)
        {
            int f = count_after - count_before;
            return f * 50;
        }

    }
}
