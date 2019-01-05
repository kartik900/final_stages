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

        private void button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            
            byte[] mypic = File.ReadAllBytes(openFileDialog2.FileName);
            cmd1.CommandText = "update driver set image=@pic where id='"+Convert.ToInt32(textBox1.Text)+"'";
            SqlParameter sq = new SqlParameter("@pic", SqlDbType.VarBinary, mypic.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mypic);
            cmd1.Parameters.Add(sq);
            cmd1.ExecuteNonQuery();
            con.Close();
        }
    }
}
