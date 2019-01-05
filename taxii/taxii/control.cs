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
    public partial class control : Form
    {
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
    }
}
