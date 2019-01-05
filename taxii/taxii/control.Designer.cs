namespace taxii
{
    partial class control
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(control));
            this.header = new System.Windows.Forms.Panel();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.homeb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.newrideb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updaterideb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.driversb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.infob = new Bunifu.Framework.UI.BunifuFlatButton();
            this.newridepanel = new System.Windows.Forms.Panel();
            this.cname = new JTextBox2.JTextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cpno = new JTextBox2.JTextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.caddress = new JTextBox2.JTextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.driversel = new System.Windows.Forms.ComboBox();
            this.carsel = new System.Windows.Forms.ComboBox();
            this.drivername_dataset = new taxii.drivername_dataset();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new taxii.drivername_datasetTableAdapters.driverTableAdapter();
            this.carselect_dataset = new taxii.carselect_dataset();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new taxii.carselect_datasetTableAdapters.carTableAdapter();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cnamelabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cpnumlabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drivernamelabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.driverpnolabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.okay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            this.leftpanel.SuspendLayout();
            this.newridepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivername_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carselect_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.header.Controls.Add(this.bunifuCustomLabel8);
            this.header.Controls.Add(this.bunifuCustomLabel7);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1129, 31);
            this.header.TabIndex = 0;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.infob);
            this.leftpanel.Controls.Add(this.driversb);
            this.leftpanel.Controls.Add(this.updaterideb);
            this.leftpanel.Controls.Add(this.newrideb);
            this.leftpanel.Controls.Add(this.homeb);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 31);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(320, 713);
            this.leftpanel.TabIndex = 0;
            // 
            // homeb
            // 
            this.homeb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.homeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.homeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeb.BorderRadius = 0;
            this.homeb.ButtonText = "HOME";
            this.homeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeb.DisabledColor = System.Drawing.Color.Gray;
            this.homeb.Iconcolor = System.Drawing.Color.Transparent;
            this.homeb.Iconimage = ((System.Drawing.Image)(resources.GetObject("homeb.Iconimage")));
            this.homeb.Iconimage_right = null;
            this.homeb.Iconimage_right_Selected = null;
            this.homeb.Iconimage_Selected = null;
            this.homeb.IconMarginLeft = 0;
            this.homeb.IconMarginRight = 0;
            this.homeb.IconRightVisible = true;
            this.homeb.IconRightZoom = 0D;
            this.homeb.IconVisible = true;
            this.homeb.IconZoom = 90D;
            this.homeb.IsTab = false;
            this.homeb.Location = new System.Drawing.Point(-1, 5);
            this.homeb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homeb.Name = "homeb";
            this.homeb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.homeb.OnHovercolor = System.Drawing.Color.Teal;
            this.homeb.OnHoverTextColor = System.Drawing.Color.White;
            this.homeb.selected = false;
            this.homeb.Size = new System.Drawing.Size(320, 138);
            this.homeb.TabIndex = 0;
            this.homeb.Text = "HOME";
            this.homeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeb.Textcolor = System.Drawing.Color.White;
            this.homeb.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // newrideb
            // 
            this.newrideb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.newrideb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.newrideb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newrideb.BorderRadius = 0;
            this.newrideb.ButtonText = "ADD TRIP";
            this.newrideb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newrideb.DisabledColor = System.Drawing.Color.Gray;
            this.newrideb.Iconcolor = System.Drawing.Color.Transparent;
            this.newrideb.Iconimage = ((System.Drawing.Image)(resources.GetObject("newrideb.Iconimage")));
            this.newrideb.Iconimage_right = null;
            this.newrideb.Iconimage_right_Selected = null;
            this.newrideb.Iconimage_Selected = null;
            this.newrideb.IconMarginLeft = 0;
            this.newrideb.IconMarginRight = 0;
            this.newrideb.IconRightVisible = true;
            this.newrideb.IconRightZoom = 0D;
            this.newrideb.IconVisible = true;
            this.newrideb.IconZoom = 90D;
            this.newrideb.IsTab = false;
            this.newrideb.Location = new System.Drawing.Point(-1, 147);
            this.newrideb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newrideb.Name = "newrideb";
            this.newrideb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.newrideb.OnHovercolor = System.Drawing.Color.Teal;
            this.newrideb.OnHoverTextColor = System.Drawing.Color.White;
            this.newrideb.selected = false;
            this.newrideb.Size = new System.Drawing.Size(320, 138);
            this.newrideb.TabIndex = 0;
            this.newrideb.Text = "ADD TRIP";
            this.newrideb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newrideb.Textcolor = System.Drawing.Color.White;
            this.newrideb.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // updaterideb
            // 
            this.updaterideb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updaterideb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updaterideb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updaterideb.BorderRadius = 0;
            this.updaterideb.ButtonText = "         UPDATE TRIP";
            this.updaterideb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updaterideb.DisabledColor = System.Drawing.Color.Gray;
            this.updaterideb.Iconcolor = System.Drawing.Color.Transparent;
            this.updaterideb.Iconimage = ((System.Drawing.Image)(resources.GetObject("updaterideb.Iconimage")));
            this.updaterideb.Iconimage_right = null;
            this.updaterideb.Iconimage_right_Selected = null;
            this.updaterideb.Iconimage_Selected = null;
            this.updaterideb.IconMarginLeft = 0;
            this.updaterideb.IconMarginRight = 0;
            this.updaterideb.IconRightVisible = true;
            this.updaterideb.IconRightZoom = 0D;
            this.updaterideb.IconVisible = true;
            this.updaterideb.IconZoom = 90D;
            this.updaterideb.IsTab = false;
            this.updaterideb.Location = new System.Drawing.Point(-1, 289);
            this.updaterideb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updaterideb.Name = "updaterideb";
            this.updaterideb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updaterideb.OnHovercolor = System.Drawing.Color.Teal;
            this.updaterideb.OnHoverTextColor = System.Drawing.Color.White;
            this.updaterideb.selected = false;
            this.updaterideb.Size = new System.Drawing.Size(320, 138);
            this.updaterideb.TabIndex = 0;
            this.updaterideb.Text = "         UPDATE TRIP";
            this.updaterideb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updaterideb.Textcolor = System.Drawing.Color.White;
            this.updaterideb.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // driversb
            // 
            this.driversb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.driversb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.driversb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.driversb.BorderRadius = 0;
            this.driversb.ButtonText = "DRIVERS";
            this.driversb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.driversb.DisabledColor = System.Drawing.Color.Gray;
            this.driversb.Iconcolor = System.Drawing.Color.Transparent;
            this.driversb.Iconimage = ((System.Drawing.Image)(resources.GetObject("driversb.Iconimage")));
            this.driversb.Iconimage_right = null;
            this.driversb.Iconimage_right_Selected = null;
            this.driversb.Iconimage_Selected = null;
            this.driversb.IconMarginLeft = 0;
            this.driversb.IconMarginRight = 0;
            this.driversb.IconRightVisible = true;
            this.driversb.IconRightZoom = 0D;
            this.driversb.IconVisible = true;
            this.driversb.IconZoom = 90D;
            this.driversb.IsTab = false;
            this.driversb.Location = new System.Drawing.Point(0, 431);
            this.driversb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.driversb.Name = "driversb";
            this.driversb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.driversb.OnHovercolor = System.Drawing.Color.Teal;
            this.driversb.OnHoverTextColor = System.Drawing.Color.White;
            this.driversb.selected = false;
            this.driversb.Size = new System.Drawing.Size(320, 138);
            this.driversb.TabIndex = 0;
            this.driversb.Text = "DRIVERS";
            this.driversb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.driversb.Textcolor = System.Drawing.Color.White;
            this.driversb.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // infob
            // 
            this.infob.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.infob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.infob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infob.BorderRadius = 0;
            this.infob.ButtonText = "INFO";
            this.infob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infob.DisabledColor = System.Drawing.Color.Gray;
            this.infob.Iconcolor = System.Drawing.Color.Transparent;
            this.infob.Iconimage = ((System.Drawing.Image)(resources.GetObject("infob.Iconimage")));
            this.infob.Iconimage_right = null;
            this.infob.Iconimage_right_Selected = null;
            this.infob.Iconimage_Selected = null;
            this.infob.IconMarginLeft = 0;
            this.infob.IconMarginRight = 0;
            this.infob.IconRightVisible = true;
            this.infob.IconRightZoom = 0D;
            this.infob.IconVisible = true;
            this.infob.IconZoom = 90D;
            this.infob.IsTab = false;
            this.infob.Location = new System.Drawing.Point(0, 573);
            this.infob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infob.Name = "infob";
            this.infob.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.infob.OnHovercolor = System.Drawing.Color.Teal;
            this.infob.OnHoverTextColor = System.Drawing.Color.White;
            this.infob.selected = false;
            this.infob.Size = new System.Drawing.Size(320, 138);
            this.infob.TabIndex = 0;
            this.infob.Text = "INFO";
            this.infob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infob.Textcolor = System.Drawing.Color.White;
            this.infob.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // newridepanel
            // 
            this.newridepanel.Controls.Add(this.pictureBox1);
            this.newridepanel.Controls.Add(this.okay);
            this.newridepanel.Controls.Add(this.carsel);
            this.newridepanel.Controls.Add(this.driversel);
            this.newridepanel.Controls.Add(this.bunifuDatepicker1);
            this.newridepanel.Controls.Add(this.bunifuCustomLabel4);
            this.newridepanel.Controls.Add(this.bunifuCustomLabel6);
            this.newridepanel.Controls.Add(this.bunifuCustomLabel2);
            this.newridepanel.Controls.Add(this.bunifuCustomLabel3);
            this.newridepanel.Controls.Add(this.bunifuCustomLabel5);
            this.newridepanel.Controls.Add(this.driverpnolabel);
            this.newridepanel.Controls.Add(this.cpnumlabel);
            this.newridepanel.Controls.Add(this.drivernamelabel);
            this.newridepanel.Controls.Add(this.cnamelabel);
            this.newridepanel.Controls.Add(this.bunifuCustomLabel14);
            this.newridepanel.Controls.Add(this.bunifuCustomLabel13);
            this.newridepanel.Controls.Add(this.bunifuCustomLabel11);
            this.newridepanel.Controls.Add(this.bunifuCustomLabel9);
            this.newridepanel.Controls.Add(this.bunifuCustomLabel1);
            this.newridepanel.Controls.Add(this.caddress);
            this.newridepanel.Controls.Add(this.cpno);
            this.newridepanel.Controls.Add(this.cname);
            this.newridepanel.Location = new System.Drawing.Point(326, 37);
            this.newridepanel.Name = "newridepanel";
            this.newridepanel.Size = new System.Drawing.Size(803, 705);
            this.newridepanel.TabIndex = 1;
            // 
            // cname
            // 
            this.cname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cname.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cname.HintText = null;
            this.cname.IsPassword = false;
            this.cname.Location = new System.Drawing.Point(92, 79);
            this.cname.Margin = new System.Windows.Forms.Padding(4);
            this.cname.MaxLength = 32767;
            this.cname.Name = "cname";
            this.cname.OnFocusedColor = System.Drawing.Color.White;
            this.cname.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.cname.ReadOnly = false;
            this.cname.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.cname.Size = new System.Drawing.Size(283, 38);
            this.cname.TabIndex = 0;
            this.cname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cname.TextName = "";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(86, 31);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(189, 32);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Customer Name";
            // 
            // cpno
            // 
            this.cpno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cpno.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cpno.HintText = null;
            this.cpno.IsPassword = false;
            this.cpno.Location = new System.Drawing.Point(430, 79);
            this.cpno.Margin = new System.Windows.Forms.Padding(4);
            this.cpno.MaxLength = 32767;
            this.cpno.Name = "cpno";
            this.cpno.OnFocusedColor = System.Drawing.Color.White;
            this.cpno.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.cpno.ReadOnly = false;
            this.cpno.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.cpno.Size = new System.Drawing.Size(283, 38);
            this.cpno.TabIndex = 0;
            this.cpno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cpno.TextName = "";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(424, 31);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(194, 32);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Customer phone";
            // 
            // caddress
            // 
            this.caddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.caddress.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.caddress.HintText = null;
            this.caddress.IsPassword = false;
            this.caddress.Location = new System.Drawing.Point(92, 188);
            this.caddress.Margin = new System.Windows.Forms.Padding(4);
            this.caddress.MaxLength = 32767;
            this.caddress.Name = "caddress";
            this.caddress.OnFocusedColor = System.Drawing.Color.White;
            this.caddress.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.caddress.ReadOnly = false;
            this.caddress.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.caddress.Size = new System.Drawing.Size(283, 38);
            this.caddress.TabIndex = 0;
            this.caddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.caddress.TextName = "";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(86, 140);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(209, 32);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Customer Address";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(424, 140);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(107, 32);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Trip date";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(430, 188);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(283, 38);
            this.bunifuDatepicker1.TabIndex = 8;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 1, 5, 20, 47, 4, 125);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(86, 285);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(150, 32);
            this.bunifuCustomLabel5.TabIndex = 6;
            this.bunifuCustomLabel5.Text = "Select Driver";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(424, 285);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(121, 32);
            this.bunifuCustomLabel6.TabIndex = 6;
            this.bunifuCustomLabel6.Text = "Select Car";
            // 
            // driversel
            // 
            this.driversel.DataSource = this.driverBindingSource;
            this.driversel.DisplayMember = "d_name";
            this.driversel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversel.FormattingEnabled = true;
            this.driversel.Location = new System.Drawing.Point(92, 334);
            this.driversel.Name = "driversel";
            this.driversel.Size = new System.Drawing.Size(281, 33);
            this.driversel.TabIndex = 9;
            this.driversel.ValueMember = "Id";
            // 
            // carsel
            // 
            this.carsel.DataSource = this.carBindingSource;
            this.carsel.DisplayMember = "c_name";
            this.carsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsel.FormattingEnabled = true;
            this.carsel.Location = new System.Drawing.Point(432, 334);
            this.carsel.Name = "carsel";
            this.carsel.Size = new System.Drawing.Size(281, 33);
            this.carsel.TabIndex = 9;
            this.carsel.ValueMember = "Id";
            // 
            // drivername_dataset
            // 
            this.drivername_dataset.DataSetName = "drivername_dataset";
            this.drivername_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "driver";
            this.driverBindingSource.DataSource = this.drivername_dataset;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // carselect_dataset
            // 
            this.carselect_dataset.DataSetName = "carselect_dataset";
            this.carselect_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.carselect_dataset;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(559, -1);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(195, 32);
            this.bunifuCustomLabel7.TabIndex = 6;
            this.bunifuCustomLabel7.Text = "- CAR RENTALS -";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(1099, 0);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(29, 32);
            this.bunifuCustomLabel8.TabIndex = 7;
            this.bunifuCustomLabel8.Text = "X";
            this.bunifuCustomLabel8.Click += new System.EventHandler(this.bunifuCustomLabel8_Click);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(49, 425);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(189, 32);
            this.bunifuCustomLabel9.TabIndex = 6;
            this.bunifuCustomLabel9.Text = "Customer Name";
            // 
            // cnamelabel
            // 
            this.cnamelabel.AutoSize = true;
            this.cnamelabel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnamelabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cnamelabel.Location = new System.Drawing.Point(305, 425);
            this.cnamelabel.Name = "cnamelabel";
            this.cnamelabel.Size = new System.Drawing.Size(35, 32);
            this.cnamelabel.TabIndex = 6;
            this.cnamelabel.Text = "--";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(49, 473);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(223, 32);
            this.bunifuCustomLabel11.TabIndex = 6;
            this.bunifuCustomLabel11.Text = "Customer pho num";
            // 
            // cpnumlabel
            // 
            this.cpnumlabel.AutoSize = true;
            this.cpnumlabel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpnumlabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cpnumlabel.Location = new System.Drawing.Point(305, 473);
            this.cpnumlabel.Name = "cpnumlabel";
            this.cpnumlabel.Size = new System.Drawing.Size(35, 32);
            this.cpnumlabel.TabIndex = 6;
            this.cpnumlabel.Text = "--";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(49, 519);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(150, 32);
            this.bunifuCustomLabel13.TabIndex = 6;
            this.bunifuCustomLabel13.Text = "Driver Name";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(49, 567);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(211, 32);
            this.bunifuCustomLabel14.TabIndex = 6;
            this.bunifuCustomLabel14.Text = "Driver phone num";
            // 
            // drivernamelabel
            // 
            this.drivernamelabel.AutoSize = true;
            this.drivernamelabel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivernamelabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.drivernamelabel.Location = new System.Drawing.Point(305, 519);
            this.drivernamelabel.Name = "drivernamelabel";
            this.drivernamelabel.Size = new System.Drawing.Size(35, 32);
            this.drivernamelabel.TabIndex = 6;
            this.drivernamelabel.Text = "--";
            // 
            // driverpnolabel
            // 
            this.driverpnolabel.AutoSize = true;
            this.driverpnolabel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverpnolabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.driverpnolabel.Location = new System.Drawing.Point(305, 567);
            this.driverpnolabel.Name = "driverpnolabel";
            this.driverpnolabel.Size = new System.Drawing.Size(35, 32);
            this.driverpnolabel.TabIndex = 6;
            this.driverpnolabel.Text = "--";
            // 
            // okay
            // 
            this.okay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.okay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.okay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okay.BorderRadius = 0;
            this.okay.ButtonText = "CREATE TRIP";
            this.okay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okay.DisabledColor = System.Drawing.Color.Gray;
            this.okay.Iconcolor = System.Drawing.Color.Transparent;
            this.okay.Iconimage = null;
            this.okay.Iconimage_right = null;
            this.okay.Iconimage_right_Selected = null;
            this.okay.Iconimage_Selected = null;
            this.okay.IconMarginLeft = 0;
            this.okay.IconMarginRight = 0;
            this.okay.IconRightVisible = true;
            this.okay.IconRightZoom = 0D;
            this.okay.IconVisible = true;
            this.okay.IconZoom = 90D;
            this.okay.IsTab = false;
            this.okay.Location = new System.Drawing.Point(55, 635);
            this.okay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okay.Name = "okay";
            this.okay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.okay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.okay.OnHoverTextColor = System.Drawing.Color.White;
            this.okay.selected = false;
            this.okay.Size = new System.Drawing.Size(217, 44);
            this.okay.TabIndex = 10;
            this.okay.Text = "CREATE TRIP";
            this.okay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okay.Textcolor = System.Drawing.Color.White;
            this.okay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(531, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 233);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1129, 744);
            this.Controls.Add(this.newridepanel);
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "control";
            this.Text = "control";
            this.Load += new System.EventHandler(this.control_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.leftpanel.ResumeLayout(false);
            this.newridepanel.ResumeLayout(false);
            this.newridepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivername_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carselect_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel leftpanel;
        private Bunifu.Framework.UI.BunifuFlatButton homeb;
        private Bunifu.Framework.UI.BunifuFlatButton updaterideb;
        private Bunifu.Framework.UI.BunifuFlatButton newrideb;
        private Bunifu.Framework.UI.BunifuFlatButton infob;
        private Bunifu.Framework.UI.BunifuFlatButton driversb;
        private System.Windows.Forms.Panel newridepanel;
        private JTextBox2.JTextBox cname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private JTextBox2.JTextBox caddress;
        private JTextBox2.JTextBox cpno;
        private System.Windows.Forms.ComboBox carsel;
        private System.Windows.Forms.ComboBox driversel;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private drivername_dataset drivername_dataset;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private drivername_datasetTableAdapters.driverTableAdapter driverTableAdapter;
        private carselect_dataset carselect_dataset;
        private System.Windows.Forms.BindingSource carBindingSource;
        private carselect_datasetTableAdapters.carTableAdapter carTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton okay;
        private Bunifu.Framework.UI.BunifuCustomLabel driverpnolabel;
        private Bunifu.Framework.UI.BunifuCustomLabel cpnumlabel;
        private Bunifu.Framework.UI.BunifuCustomLabel drivernamelabel;
        private Bunifu.Framework.UI.BunifuCustomLabel cnamelabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
    }
}