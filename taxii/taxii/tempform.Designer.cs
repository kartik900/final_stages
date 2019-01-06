namespace taxii
{
    partial class tempform
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
            this.updateridepanel = new System.Windows.Forms.Panel();
            this.didlabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rideselect1 = new taxii.rideselect();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpnolabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.daddresslabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dnamelabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rideTableAdapter = new taxii.rideselectTableAdapters.rideTableAdapter();
            this.drivernametex = new JTextBox2.JTextBox();
            this.driverpno = new JTextBox2.JTextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.daddress = new JTextBox2.JTextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.adddriver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updateridepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideselect1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateridepanel
            // 
            this.updateridepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.updateridepanel.Controls.Add(this.adddriver);
            this.updateridepanel.Controls.Add(this.driverpno);
            this.updateridepanel.Controls.Add(this.daddress);
            this.updateridepanel.Controls.Add(this.drivernametex);
            this.updateridepanel.Controls.Add(this.didlabel);
            this.updateridepanel.Controls.Add(this.pictureBox1);
            this.updateridepanel.Controls.Add(this.bunifuFlatButton1);
            this.updateridepanel.Controls.Add(this.bunifuCustomLabel2);
            this.updateridepanel.Controls.Add(this.bunifuCustomLabel1);
            this.updateridepanel.Controls.Add(this.bunifuCustomLabel6);
            this.updateridepanel.Controls.Add(this.bunifuCustomLabel5);
            this.updateridepanel.Controls.Add(this.dpnolabel);
            this.updateridepanel.Controls.Add(this.daddresslabel);
            this.updateridepanel.Controls.Add(this.dnamelabel);
            this.updateridepanel.Controls.Add(this.bunifuCustomLabel13);
            this.updateridepanel.Controls.Add(this.bunifuCustomLabel11);
            this.updateridepanel.Controls.Add(this.bunifuCustomLabel9);
            this.updateridepanel.Location = new System.Drawing.Point(196, 31);
            this.updateridepanel.Name = "updateridepanel";
            this.updateridepanel.Size = new System.Drawing.Size(803, 705);
            this.updateridepanel.TabIndex = 2;
            // 
            // didlabel
            // 
            this.didlabel.AutoSize = true;
            this.didlabel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.didlabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.didlabel.Location = new System.Drawing.Point(106, 623);
            this.didlabel.Name = "didlabel";
            this.didlabel.Size = new System.Drawing.Size(35, 32);
            this.didlabel.TabIndex = 7;
            this.didlabel.Text = "--";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(486, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 233);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // rideBindingSource
            // 
            this.rideBindingSource.DataMember = "ride";
            this.rideBindingSource.DataSource = this.rideselect1;
            // 
            // rideselect1
            // 
            this.rideselect1.DataSetName = "rideselect";
            this.rideselect1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(444, 48);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(190, 32);
            this.bunifuCustomLabel6.TabIndex = 6;
            this.bunifuCustomLabel6.Text = "Driver phone no";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(106, 48);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(146, 32);
            this.bunifuCustomLabel5.TabIndex = 6;
            this.bunifuCustomLabel5.Text = "Driver name";
            // 
            // dpnolabel
            // 
            this.dpnolabel.AutoSize = true;
            this.dpnolabel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpnolabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dpnolabel.Location = new System.Drawing.Point(362, 399);
            this.dpnolabel.Name = "dpnolabel";
            this.dpnolabel.Size = new System.Drawing.Size(35, 32);
            this.dpnolabel.TabIndex = 6;
            this.dpnolabel.Text = "--";
            // 
            // daddresslabel
            // 
            this.daddresslabel.AutoSize = true;
            this.daddresslabel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daddresslabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.daddresslabel.Location = new System.Drawing.Point(362, 445);
            this.daddresslabel.Name = "daddresslabel";
            this.daddresslabel.Size = new System.Drawing.Size(35, 32);
            this.daddresslabel.TabIndex = 6;
            this.daddresslabel.Text = "--";
            // 
            // dnamelabel
            // 
            this.dnamelabel.AutoSize = true;
            this.dnamelabel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnamelabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dnamelabel.Location = new System.Drawing.Point(362, 351);
            this.dnamelabel.Name = "dnamelabel";
            this.dnamelabel.Size = new System.Drawing.Size(35, 32);
            this.dnamelabel.TabIndex = 6;
            this.dnamelabel.Text = "--";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(106, 445);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(167, 32);
            this.bunifuCustomLabel13.TabIndex = 6;
            this.bunifuCustomLabel13.Text = "Driver address";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(106, 399);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(211, 32);
            this.bunifuCustomLabel11.TabIndex = 6;
            this.bunifuCustomLabel11.Text = "Driver phone num";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(106, 351);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(150, 32);
            this.bunifuCustomLabel9.TabIndex = 6;
            this.bunifuCustomLabel9.Text = "Driver Name";
            // 
            // rideTableAdapter
            // 
            this.rideTableAdapter.ClearBeforeFill = true;
            // 
            // drivernametex
            // 
            this.drivernametex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.drivernametex.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.drivernametex.HintText = null;
            this.drivernametex.IsPassword = false;
            this.drivernametex.Location = new System.Drawing.Point(112, 105);
            this.drivernametex.Margin = new System.Windows.Forms.Padding(4);
            this.drivernametex.MaxLength = 32767;
            this.drivernametex.Name = "drivernametex";
            this.drivernametex.OnFocusedColor = System.Drawing.Color.White;
            this.drivernametex.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.drivernametex.ReadOnly = false;
            this.drivernametex.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.drivernametex.Size = new System.Drawing.Size(248, 38);
            this.drivernametex.TabIndex = 12;
            this.drivernametex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.drivernametex.TextName = "";
            // 
            // driverpno
            // 
            this.driverpno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.driverpno.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.driverpno.HintText = null;
            this.driverpno.IsPassword = false;
            this.driverpno.Location = new System.Drawing.Point(450, 105);
            this.driverpno.Margin = new System.Windows.Forms.Padding(4);
            this.driverpno.MaxLength = 32767;
            this.driverpno.Name = "driverpno";
            this.driverpno.OnFocusedColor = System.Drawing.Color.White;
            this.driverpno.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.driverpno.ReadOnly = false;
            this.driverpno.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.driverpno.Size = new System.Drawing.Size(248, 38);
            this.driverpno.TabIndex = 12;
            this.driverpno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.driverpno.TextName = "";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(106, 179);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(170, 32);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Driver Address";
            // 
            // daddress
            // 
            this.daddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.daddress.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.daddress.HintText = null;
            this.daddress.IsPassword = false;
            this.daddress.Location = new System.Drawing.Point(112, 236);
            this.daddress.Margin = new System.Windows.Forms.Padding(4);
            this.daddress.MaxLength = 32767;
            this.daddress.Name = "daddress";
            this.daddress.OnFocusedColor = System.Drawing.Color.White;
            this.daddress.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.daddress.ReadOnly = false;
            this.daddress.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.daddress.Size = new System.Drawing.Size(248, 38);
            this.daddress.TabIndex = 12;
            this.daddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.daddress.TextName = "";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "choose";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(450, 230);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(248, 44);
            this.bunifuFlatButton1.TabIndex = 10;
            this.bunifuFlatButton1.Text = "choose";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.okay_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(444, 179);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(152, 32);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Driver Image";
            // 
            // adddriver
            // 
            this.adddriver.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.adddriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.adddriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adddriver.BorderRadius = 0;
            this.adddriver.ButtonText = "ADD";
            this.adddriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adddriver.DisabledColor = System.Drawing.Color.Gray;
            this.adddriver.Iconcolor = System.Drawing.Color.Transparent;
            this.adddriver.Iconimage = null;
            this.adddriver.Iconimage_right = null;
            this.adddriver.Iconimage_right_Selected = null;
            this.adddriver.Iconimage_Selected = null;
            this.adddriver.IconMarginLeft = 0;
            this.adddriver.IconMarginRight = 0;
            this.adddriver.IconRightVisible = true;
            this.adddriver.IconRightZoom = 0D;
            this.adddriver.IconVisible = true;
            this.adddriver.IconZoom = 90D;
            this.adddriver.IsTab = false;
            this.adddriver.Location = new System.Drawing.Point(112, 525);
            this.adddriver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adddriver.Name = "adddriver";
            this.adddriver.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.adddriver.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.adddriver.OnHoverTextColor = System.Drawing.Color.White;
            this.adddriver.selected = false;
            this.adddriver.Size = new System.Drawing.Size(183, 59);
            this.adddriver.TabIndex = 13;
            this.adddriver.Text = "ADD";
            this.adddriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adddriver.Textcolor = System.Drawing.Color.White;
            this.adddriver.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddriver.Click += new System.EventHandler(this.adddriver_Click);
            // 
            // tempform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1245, 795);
            this.Controls.Add(this.updateridepanel);
            this.Name = "tempform";
            this.Text = "tempform";
            this.Load += new System.EventHandler(this.tempform_Load);
            this.updateridepanel.ResumeLayout(false);
            this.updateridepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideselect1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updateridepanel;
        private Bunifu.Framework.UI.BunifuCustomLabel didlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel dpnolabel;
        private Bunifu.Framework.UI.BunifuCustomLabel daddresslabel;
        private Bunifu.Framework.UI.BunifuCustomLabel dnamelabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private rideselect rideselect1;
        private System.Windows.Forms.BindingSource rideBindingSource;
        private rideselectTableAdapters.rideTableAdapter rideTableAdapter;
        private JTextBox2.JTextBox driverpno;
        private JTextBox2.JTextBox daddress;
        private JTextBox2.JTextBox drivernametex;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton adddriver;
    }
}