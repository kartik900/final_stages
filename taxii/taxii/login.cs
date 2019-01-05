using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxii
{
    
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            /* if(usernamebox.Text=="admin"&& passwordbox.Text == "0000")
             {
                 this.Close();
                 controlpage c1 = new controlpage();
                 c1.Show();
             }
             else
             {
                 usernamebox.Text = "";
                 passwordbox.Text = "";
                 usernamebox.HintText = "only 4 attempls left ";
                 MessageBox.Show("incorrect username or password");
             }/*/
            control c = new control();
            c.Show();
            this.Hide();
            
        }

    }
   
}
