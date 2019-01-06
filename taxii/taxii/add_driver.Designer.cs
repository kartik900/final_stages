namespace taxii
{
    partial class add_driver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_driver));
            this.name = new JTextBox2.JTextBox();
            this.phno = new JTextBox2.JTextBox();
            this.address = new JTextBox2.JTextBox();
            this.browse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.save = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.name.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.name.HintText = null;
            this.name.IsPassword = false;
            this.name.Location = new System.Drawing.Point(54, 41);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.OnFocusedColor = System.Drawing.Color.White;
            this.name.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.name.ReadOnly = false;
            this.name.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(279, 38);
            this.name.TabIndex = 0;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.TextName = "";
            // 
            // phno
            // 
            this.phno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.phno.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.phno.HintText = null;
            this.phno.IsPassword = false;
            this.phno.Location = new System.Drawing.Point(54, 111);
            this.phno.Margin = new System.Windows.Forms.Padding(4);
            this.phno.MaxLength = 32767;
            this.phno.Name = "phno";
            this.phno.OnFocusedColor = System.Drawing.Color.White;
            this.phno.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.phno.ReadOnly = false;
            this.phno.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.phno.Size = new System.Drawing.Size(279, 38);
            this.phno.TabIndex = 1;
            this.phno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phno.TextName = "";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.address.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.address.HintText = null;
            this.address.IsPassword = false;
            this.address.Location = new System.Drawing.Point(54, 172);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.MaxLength = 32767;
            this.address.Name = "address";
            this.address.OnFocusedColor = System.Drawing.Color.White;
            this.address.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.address.ReadOnly = false;
            this.address.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.address.Size = new System.Drawing.Size(279, 38);
            this.address.TabIndex = 2;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address.TextName = "";
            // 
            // browse
            // 
            this.browse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browse.BorderRadius = 0;
            this.browse.ButtonText = "bunifuFlatButton1";
            this.browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse.DisabledColor = System.Drawing.Color.Gray;
            this.browse.Iconcolor = System.Drawing.Color.Transparent;
            this.browse.Iconimage = ((System.Drawing.Image)(resources.GetObject("browse.Iconimage")));
            this.browse.Iconimage_right = null;
            this.browse.Iconimage_right_Selected = null;
            this.browse.Iconimage_Selected = null;
            this.browse.IconMarginLeft = 0;
            this.browse.IconMarginRight = 0;
            this.browse.IconRightVisible = true;
            this.browse.IconRightZoom = 0D;
            this.browse.IconVisible = true;
            this.browse.IconZoom = 90D;
            this.browse.IsTab = false;
            this.browse.Location = new System.Drawing.Point(358, 41);
            this.browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browse.Name = "browse";
            this.browse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.browse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.browse.OnHoverTextColor = System.Drawing.Color.White;
            this.browse.selected = false;
            this.browse.Size = new System.Drawing.Size(61, 59);
            this.browse.TabIndex = 3;
            this.browse.Text = "bunifuFlatButton1";
            this.browse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browse.Textcolor = System.Drawing.Color.White;
            this.browse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(448, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 169);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // save
            // 
            this.save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.save.BackColor = System.Drawing.Color.Indigo;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.BorderRadius = 0;
            this.save.ButtonText = "bunifuFlatButton2";
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.DisabledColor = System.Drawing.Color.Gray;
            this.save.Iconcolor = System.Drawing.Color.Transparent;
            this.save.Iconimage = ((System.Drawing.Image)(resources.GetObject("save.Iconimage")));
            this.save.Iconimage_right = null;
            this.save.Iconimage_right_Selected = null;
            this.save.Iconimage_Selected = null;
            this.save.IconMarginLeft = 0;
            this.save.IconMarginRight = 0;
            this.save.IconRightVisible = true;
            this.save.IconRightZoom = 0D;
            this.save.IconVisible = true;
            this.save.IconZoom = 90D;
            this.save.IsTab = false;
            this.save.Location = new System.Drawing.Point(357, 151);
            this.save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save.Name = "save";
            this.save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.save.OnHoverTextColor = System.Drawing.Color.White;
            this.save.selected = false;
            this.save.Size = new System.Drawing.Size(62, 59);
            this.save.TabIndex = 5;
            this.save.Text = "bunifuFlatButton2";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Textcolor = System.Drawing.Color.White;
            this.save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // add_driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phno);
            this.Controls.Add(this.name);
            this.Name = "add_driver";
            this.Text = "add_driver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JTextBox2.JTextBox name;
        private JTextBox2.JTextBox phno;
        private JTextBox2.JTextBox address;
        private Bunifu.Framework.UI.BunifuFlatButton browse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton save;
    }
}