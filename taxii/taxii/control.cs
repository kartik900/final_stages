﻿using System;
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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=K:\finalll\final_stages\taxii\taxii\rental.mdf;Integrated Security=True");
        int i;
        int odo = 0;
        string constr;

        double[] totals = new double[90];
        string[] owners = new string[90];
        string[] drivers = new string[90];
        
        Ride[] r = new Ride[90];
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


        //data stufff
        private void control_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalDataSet.ride' table. You can move, or remove it, as needed.
            this.rideTableAdapter1.Fill(this.rentalDataSet.ride);
            // TODO: This line of code loads data into the 'fulldriver.driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter1.Fill(this.fulldriver.driver);
           
            // TODO: This line of code loads data into the 'ride_id.ride' table. You can move, or remove it, as needed.
            this.rideTableAdapter.Fill(this.ride_id.ride);
            
            // TODO: This line of code loads data into the 'car_name.car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.car_name.car);
            // TODO: This line of code loads data into the 'driver_name.driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.driver_name.driver);
            
            con.Open();
            string maincmd = "select max(Id) from ride";
            SqlCommand maincmd1 = new SqlCommand(maincmd, con);
            i = Convert.ToInt32(maincmd1.ExecuteScalar());
            i++;
            con.Close();
            

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

            try
            {
                this.Close();

            }
            catch (IndexOutOfRangeException) { }
            catch (FormatException) { }
            
        }

        #region LEFT PANEL BUTTON CLICKSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
        private void updaterideb_Click(object sender, EventArgs e)
        {
            driverpanel.Hide();
            infopanel.Hide();

            newridepanel.Hide();
            updateridepanel.Show();
            this.rideTableAdapter.Fill(this.ride_id.ride);

        }
        private void newrideb_Click(object sender, EventArgs e)
        {
            driverpanel.Hide();
            infopanel.Hide();

            updateridepanel.Hide();
            newridepanel.Show();
            this.driverTableAdapter.Fill(this.driver_name.driver);
            this.carTableAdapter.Fill(this.car_name.car);

        }
        private void driversb_Click(object sender, EventArgs e)
        {
            
            infopanel.Hide();

            updateridepanel.Hide();
            newridepanel.Hide();
            driverpanel.Show();
            cleardriverpanel.Hide();

        }

        private void homeb_Click(object sender, EventArgs e)
        {
            updateridepanel.Hide();
            newridepanel.Hide();
            driverpanel.Hide();
            infopanel.Hide();

        }

        private void infob_Click(object sender, EventArgs e)
        {
            updateridepanel.Hide();
            newridepanel.Hide();
            driverpanel.Hide();
            infopanel.Show();

        }
        #endregion


        #region updateride
        int y;
        int km;
        private void updateb_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                y = Convert.ToInt32(rideselect.Text);
                km = Convert.ToInt32(km_after.TextName);
                totals[y] = Convert.ToDouble(r[i].Farecal(km));
                owners[y] = r[i].ownfare(totals[y]);
                drivers[y] = r[i].driverfare(totals[y]);
            }
            catch (Exception) { }
            int d = km - kma;
            int d1 = km + kma;
            string cc="";
            ridekm.Text = Convert.ToString(d);
            totalincome.Text = Convert.ToString(d * 50);
            ownercut.Text = Convert.ToString((d*50) - ((d*50) * 80 / 100));
            drivercut.Text = Convert.ToString((d * 50) - ((d * 50) * 20 / 100));
            con.Open();
            
            string up="update car set km_bef='"+d1+"' where c_name='"+cc+"'";
            string h0 = "select c_name from ride where Id='" + y + "'";
            string kewkmfromdb = "select km_bef from car where c_name='" + cc + "'";
            SqlCommand upc = new SqlCommand(up, con);
            SqlCommand h0c = new SqlCommand(h0, con);
            SqlCommand km_bfromdb = new SqlCommand(kewkmfromdb, con);

            cc = Convert.ToString(h0c.ExecuteScalar());

            upc.ExecuteScalar();

            string newkm = Convert.ToString(km_bfromdb.ExecuteScalar());
            newkmshow.Text = "the new kms for the car " + cc + " is "+newkm ;
            con.Close();
        }

        private void rideselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            try
            {
                int y = Convert.ToInt32(rideselect.Text);
                con.Open();


                string cmd1 = "select c_name from ride where id='" + y + "'";
                SqlCommand c1 = new SqlCommand(cmd1, con);
                string h1 = Convert.ToString(c1.ExecuteScalar());
                c_nameshow.Text = h1;

                string cmd2 = "select d_name from ride where id='" + y + "'";
                SqlCommand c2 = new SqlCommand(cmd2, con);
                string h2 = Convert.ToString(c2.ExecuteScalar());
                dnameshow.Text = h2;

                string cmd3 = "select car from ride where id='" + y + "'";
                SqlCommand c3 = new SqlCommand(cmd3, con);
                string h3 = Convert.ToString(c3.ExecuteScalar());
                carnameshow.Text = h3;

                string cmd4 = "select date from ride where id='" + y + "'";
                SqlCommand c4 = new SqlCommand(cmd4, con);
                string h4 = Convert.ToString(c4.ExecuteScalar());
                dateshow.Text = h4;

                con.Close();
            }
            catch (FormatException) { }
        }
       



        #endregion






        #region create ride panel stuff
        private void okay_Click_1(object sender, EventArgs e)
        {
            int ID = i;
            
            string datee = datepick.Value.ToString();

            con.Open();

            string cmd = "insert into ride(id,c_name,d_name,car,date)values('" + ID + "','" + cname.TextName + "','" + driversel.Text + "','" + carsel.Text + "','" + datee + "')";
            SqlCommand c1 = new SqlCommand(cmd, con);
            c1.ExecuteNonQuery();
            con.Close();

            r[i] = new Ride(ID, odo, driversel.Text, datee);

            idlabel.Text = "THE TRIP ID IS " + ID;
            i = i + 1;
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            cname.TextName = "";
            caddress.TextName = "";
            cpno.TextName = "";
            drivernamelabel.Text = "";
            cnamelabel.Text = "";
            cpnumlabel.Text = "";
        }

        private void driversel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                //SqlDataReader r;
                string n = driversel.Text;
                string cmd2 = "select image from driver where d_name ='" + n + "'";
                SqlCommand c10 = new SqlCommand(cmd2, con);
                SqlDataAdapter da1 = new SqlDataAdapter(c10);
                SqlCommandBuilder cb = new SqlCommandBuilder(da1);
                DataSet ds = new DataSet();
                da1.Fill(ds);
                byte[] ap = (byte[])(ds.Tables[0].Rows[0]["image"]);
                MemoryStream ms = new MemoryStream(ap);
                pictureBox11.Image = Image.FromStream(ms);
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }
            catch (IndexOutOfRangeException) { }
            catch (InvalidCastException) { }
        }
        private void Refresh(object sender, EventArgs e)
        {
            string cmd41 = "select d_pno from driver where d_name='" +driversel.Text+ "'";
            drivernamelabel.Text = driversel.Text;
            cnamelabel.Text = cname.TextName;
            cpnumlabel.Text = cpno.TextName;
            con.Open();
            SqlCommand c41 = new SqlCommand(cmd41, con);
            driverpnolabel.Text = Convert.ToString(c41.ExecuteScalar());
            con.Close();
        }





        #endregion


        string imgloc;
        #region driver panel
        

        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dnamelabel.Text = name.TextName;
            dpnolabel.Text = phno.TextName;
            daddresslabel.Text = address.TextName;

            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|all files(*.*)|*.*";
            if (od.ShowDialog() == DialogResult.OK)
            {
                imgloc = od.FileName.ToString();
                pictureBox1.ImageLocation = imgloc;
            }
        }

        private void adddriver_Click(object sender, EventArgs e)
        {
            
            byte[] img = null;
            FileStream stream = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            img = br.ReadBytes((int)stream.Length);
            string cmd0 = "insert into driver(d_name,d_pno,d_address,image)values('" + name.TextName + "','" + phno.TextName + "','" + address.TextName + "',@img)";
            con.Open();

            SqlCommand c10 = new SqlCommand(cmd0, con);
            c10.Parameters.Add(new SqlParameter("@img", img));
            c10.ExecuteNonQuery();
            con.Close();
            lbl.Text = "Driver Added Successfully";
            cleardriverpanel.Show();





        }



        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cleardriverpanel_Click(object sender, EventArgs e)
        {
            dnamelabel.Text = daddresslabel.Text = dpnolabel.Text = "";
            name.TextName = phno.TextName = address.TextName = "";
            lbl.Text = "--";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control c1 = new control();
            c1.Show();
            this.Close();
            
        }
        int kma;
        private void carsel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ca = "select km_bef from car where c_name='" + carsel.Text + "'";
            con.Open();
            if (carsel.Text != null)
            {
                try
                {
                    SqlCommand ca1 = new SqlCommand(ca, con);
                    kmblabel.Text = Convert.ToString(ca1.ExecuteScalar());
                    kma = Convert.ToInt32(kmblabel.Text);
                }
                catch (Exception) { }
            }
            con.Close();
        }
    }
    #region CLASS RIDE
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
            
            return a * 50;
        }
        public string ownfare(double a)
        {
            return (a - (a * 80 / 100)).ToString();
        }
        public string driverfare(double a)
        {
            return (a - (a * 20 / 100)).ToString();
        }

    }
    #endregion
}
