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
    public partial class loadimg : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=K:\finalll\final_stages\taxii\taxii\rental.mdf;Integrated Security = True");
        public loadimg()
        {

            InitializeComponent();

        }
        string imgloc = "";

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|all files(*.*)|*.*";
            if (od.ShowDialog() == DialogResult.OK)
            {
                imgloc = od.FileName.ToString();
                pictureBox1.ImageLocation = imgloc;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            int t=c1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(t.ToString()+"saved");

        }

        private void view_Click(object sender, EventArgs e)
        {
            SqlDataReader r;
            string n = name.Text;
            string cmd2="select image from driver where name ='"+n+"";
            SqlCommand c10 = new SqlCommand(cmd2, con);
            DataTable t = new DataTable();
           // byte[] imgg=(byte[])(r[i])

        }
       
    }
}
/*

            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            
            byte[] mypic = File.ReadAllBytes(openFileDialog2.FileName);
            cmd1.CommandText = "update driver set image=@pic where id='"+Convert.ToInt32(textBox1.Text)+"'";
            SqlParameter sq = new SqlParameter("@pic", SqlDbType.VarBinary, mypic.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mypic);
            cmd1.Parameters.Add(sq);
            cmd1.ExecuteNonQuery();
            con.Close();
*/