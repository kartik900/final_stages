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

namespace taxii
{
    public partial class tempform : Form
    {
        string imgloc;
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
            dnamelabel.Text = drivernametex.TextName;
            dpnolabel.Text = driverpno.TextName;
            daddresslabel.Text = daddress.TextName;

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
            string cmd1 = "select id from driver where d_name='" + drivernametex.TextName + "'";
            string cmd = "insert into driver(d_name,d_pno,d_address,image)values('" + drivernametex.TextName + "','" + driverpno.TextName + "','" + daddress.TextName + "',@img)";
            con.Open();
            SqlCommand c2 = new SqlCommand(cmd1, con);
            SqlCommand c1 = new SqlCommand(cmd, con);
            c1.Parameters.Add(new SqlParameter("@img", img));
            int t = c1.ExecuteNonQuery();

            int id = Convert.ToInt32(c2.ExecuteNonQuery());
            string idd=Convert.ToString(id);
            con.Close();
            didlabel.Text = "the drivers id is " +idd;
            MessageBox.Show(t.ToString() + "saved");
        }

        private void daddress_Load(object sender, EventArgs e)
        {

        }
    }
}
