using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace taxii
{
    public partial class add_driver : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=K:\finalll\final_stages\taxii\taxii\rental.mdf;Integrated Security = True");
        string imgloc;
        public add_driver()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            FileStream stream = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            img = br.ReadBytes((int)stream.Length);
            string cmd = "insert into driver(d_name,d_pno,d_address,image)values('" + name.Text + "','" + phno.Text + "','" + address.Text + "',@img)";
            con.Open();

            SqlCommand c1 = new SqlCommand(cmd, con);
            c1.Parameters.Add(new SqlParameter("@img", img));
            int t = c1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(t.ToString() + "saved");
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|all files(*.*)|*.*";
            if (od.ShowDialog() == DialogResult.OK)
            {
                imgloc = od.FileName.ToString();
                pictureBox1.ImageLocation = imgloc;
            }
        }
    }
}
