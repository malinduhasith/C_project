namespace C_2sem_Project
{
    partial class log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_log_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_log_pw = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.reg1 = new C_2sem_Project.User_Con.reg();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_log_email
            // 
            this.txt_log_email.BackColor = System.Drawing.Color.White;
            this.txt_log_email.BorderRadius = 15;
            this.txt_log_email.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_log_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_log_email.DefaultText = "";
            this.txt_log_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_log_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_log_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_log_email.DisabledState.Parent = this.txt_log_email;
            this.txt_log_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_log_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_log_email.FocusedState.Parent = this.txt_log_email;
            this.txt_log_email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_log_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_log_email.HoverState.Parent = this.txt_log_email;
            this.txt_log_email.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_log_email.IconLeft")));
            this.txt_log_email.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_log_email.Location = new System.Drawing.Point(12, 254);
            this.txt_log_email.Margin = new System.Windows.Forms.Padding(24, 30, 24, 30);
            this.txt_log_email.Name = "txt_log_email";
            this.txt_log_email.PasswordChar = '\0';
            this.txt_log_email.PlaceholderText = "Email";
            this.txt_log_email.SelectedText = "";
            this.txt_log_email.ShadowDecoration.Parent = this.txt_log_email;
            this.txt_log_email.Size = new System.Drawing.Size(275, 30);
            this.txt_log_email.TabIndex = 14;
            this.txt_log_email.TextChanged += new System.EventHandler(this.txt_IN_email_TextChanged);
            // 
            // txt_log_pw
            // 
            this.txt_log_pw.BackColor = System.Drawing.Color.White;
            this.txt_log_pw.BorderRadius = 15;
            this.txt_log_pw.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_log_pw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_log_pw.DefaultText = "";
            this.txt_log_pw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_log_pw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_log_pw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_log_pw.DisabledState.Parent = this.txt_log_pw;
            this.txt_log_pw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_log_pw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_log_pw.FocusedState.Parent = this.txt_log_pw;
            this.txt_log_pw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_log_pw.HoverState.Parent = this.txt_log_pw;
            this.txt_log_pw.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_log_pw.IconLeft")));
            this.txt_log_pw.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_log_pw.Location = new System.Drawing.Point(12, 295);
            this.txt_log_pw.Margin = new System.Windows.Forms.Padding(12, 17, 12, 17);
            this.txt_log_pw.Name = "txt_log_pw";
            this.txt_log_pw.PasswordChar = '*';
            this.txt_log_pw.PlaceholderText = "Password";
            this.txt_log_pw.SelectedText = "";
            this.txt_log_pw.ShadowDecoration.Parent = this.txt_log_pw;
            this.txt_log_pw.Size = new System.Drawing.Size(275, 30);
            this.txt_log_pw.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2ImageButton2);
            this.panel3.Controls.Add(this.guna2ImageButton1);
            this.panel3.Location = new System.Drawing.Point(203, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 41);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.Location = new System.Drawing.Point(7, 2);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(40, 34);
            this.guna2ImageButton2.TabIndex = 1;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(53, 2);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(40, 34);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 22;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_login.Location = new System.Drawing.Point(76, 183);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(146, 32);
            this.lbl_login.TabIndex = 18;
            this.lbl_login.Text = "Mr.Rxncor";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BorderRadius = 15;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(219)))), ((int)(((byte)(194)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(42)))), ((int)(((byte)(40)))));
            this.btn_login.HoverState.Parent = this.btn_login;
            this.btn_login.Location = new System.Drawing.Point(69, 347);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.ShadowDecoration.Parent = this.btn_login;
            this.btn_login.Size = new System.Drawing.Size(158, 37);
            this.btn_login.TabIndex = 22;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(42)))), ((int)(((byte)(40)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(12, 7);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(64, 37);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "Register";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // reg1
            // 
            this.reg1.BackColor = System.Drawing.Color.Transparent;
            this.reg1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg1.Location = new System.Drawing.Point(-3, 1);
            this.reg1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reg1.Name = "reg1";
            this.reg1.Size = new System.Drawing.Size(300, 450);
            this.reg1.TabIndex = 24;
            this.reg1.Load += new System.EventHandler(this.reg1_Load_1);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.reg1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.txt_log_pw);
            this.Controls.Add(this.txt_log_email);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "log_in";
            this.Load += new System.EventHandler(this.log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_log_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_log_pw;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbl_login;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private User_Con.reg reg1;
    }
}