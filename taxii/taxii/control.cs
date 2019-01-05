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
        int odo = 0;
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
            // TODO: This line of code loads data into the 'select_ride.car' table. You can move, or remove it, as needed.
            this.carTableAdapter1.Fill(this.select_ride.car);
            // TODO: This line of code loads data into the 'rideselect_control.ride' table. You can move, or remove it, as needed.
            this.rideTableAdapter.Fill(this.rideselect_control.ride);
            // TODO: This line of code loads data into the 'carselect_dataset.car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.carselect_dataset.car);
            // TODO: This line of code loads data into the 'drivername_dataset.driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.drivername_dataset.driver);

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {
            
            rideselect.Text = "1";
            this.Close();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            #region data entry
            int ID = i + 1;
            drivernamelabel.Text = driversel.Text;
            cnamelabel.Text = cname.TextName;
            cpnumlabel.Text = cpno.TextName;
            string datee = datepick.Value.ToString();

            con.Open();
            string cmd = "insert into ride(id,c_name,d_name,car,date)values('"+ID+"','"+cname.TextName+"','"+driversel.Text+"','"+carsel.Text+"','"+datee+"')";
            SqlCommand c1 = new SqlCommand(cmd, con);
            c1.ExecuteNonQuery();
            con.Close();
            #endregion

             r[i] = new Ride(ID, odo, driversel.Text, datee);

            idlabel.Text = "THE TRIP ID IS "+ID;
            i = i + 1;
        }

        private void updaterideb_Click(object sender, EventArgs e)
        {
            newridepanel.Hide();
            updateridepanel.Show();
        }

        private void rideselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(rideselect.Text);
            con.Open();


            string cmd = "select c_name from ride where id='" + y + "'";
            SqlCommand c = new SqlCommand(cmd, con);
            string h = Convert.ToString(c.ExecuteScalar());
            cname_on_update.Text = h;
            con.Close();
        }
        #region UPDATE LABELS IN NEW RIDE PANEL
        private void newrideb_Click(object sender, EventArgs e)
        {
            updateridepanel.Hide();
            newridepanel.Show();
        }

        private void cname_Load(object sender, EventArgs e)
        {
            drivernamelabel.Text = driversel.Text;
            cnamelabel.Text = cname.TextName;
            cpnumlabel.Text = cpno.TextName;
        }

        private void cpno_Load(object sender, EventArgs e)
        {
            drivernamelabel.Text = driversel.Text;
            cnamelabel.Text = cname.TextName;
            cpnumlabel.Text = cpno.TextName;
        }

        private void caddress_Load(object sender, EventArgs e)
        {
            drivernamelabel.Text = driversel.Text;
            cnamelabel.Text = cname.TextName;
            cpnumlabel.Text = cpno.TextName;
        }

        private void datepick_onValueChanged(object sender, EventArgs e)
        {
            drivernamelabel.Text = driversel.Text;
            cnamelabel.Text = cname.TextName;
            cpnumlabel.Text = cpno.TextName;
        }

        private void driversel_SelectedIndexChanged(object sender, EventArgs e)
        {
            drivernamelabel.Text = driversel.Text;
            cnamelabel.Text = cname.TextName;
            cpnumlabel.Text = cpno.TextName;
        }

        private void carsel_SelectedIndexChanged(object sender, EventArgs e)
        {
            drivernamelabel.Text = driversel.Text;
            cnamelabel.Text = cname.TextName;
            cpnumlabel.Text = cpno.TextName;
        }
        #endregion

        private void clear_Click(object sender, EventArgs e)
        {
            cname.TextName = "";
            caddress.TextName = "";
            cpno.TextName = "";
            drivernamelabel.Text = "";
            cnamelabel.Text = "";
            cpnumlabel.Text = "";
        }
    }
    class Ride
    {
        int rno, km_b;
        string dname, date;
        public Ride(int a, int km_bef,string drname,string datee)
        {
            rno = a;
            km_b = km_bef;
            dname = drname;
            date = datee;
        }
        public float Farecal(int a)
        {
            int f = a - km_b;
            return f * 50;
        }
        public string ownfare(float a)
        {
            return (a - (a * 80 / 100)).ToString();
        }
        public string driverfare(float a)
        {
            return (a - (a * 20 / 100)).ToString();
        }

    }
}
