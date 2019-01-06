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
    public partial class holdform : Form
    {
        public holdform()
        {
            InitializeComponent();
        }

        private void rideBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rideBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rideselect);

        }

        private void holdform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullcar.car' table. You can move, or remove it, as needed.
            this.carTableAdapter1.Fill(this.fullcar.car);
            // TODO: This line of code loads data into the 'car_name.car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.car_name.car);
            // TODO: This line of code loads data into the 'rideselect.ride' table. You can move, or remove it, as needed.
            this.rideTableAdapter.Fill(this.rideselect.ride);

        }

        private void carDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
