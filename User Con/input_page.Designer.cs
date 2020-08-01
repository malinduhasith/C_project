using Guna.UI2.WinForms;

namespace C_2sem_Project.User_Con
{
    partial class input_page
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(input_page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_INp_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_INp_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_INp_contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_INp_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_INp_bday = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_IN_sub = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txt_IN_bday = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_IN_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_IN_contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_IN_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_IN_name = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 86);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(892, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_INp_name
            // 
            this.txt_INp_name.BorderRadius = 15;
            this.txt_INp_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_INp_name.DefaultText = "";
            this.txt_INp_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_INp_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_INp_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_INp_name.DisabledState.Parent = this.txt_INp_name;
            this.txt_INp_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_INp_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_INp_name.FocusedState.Parent = this.txt_INp_name;
            this.txt_INp_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_INp_name.HoverState.Parent = this.txt_INp_name;
            this.txt_INp_name.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_INp_name.IconLeft")));
            this.txt_INp_name.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_INp_name.Location = new System.Drawing.Point(2197, 435);
            this.txt_INp_name.Margin = new System.Windows.Forms.Padding(37, 35, 37, 35);
            this.txt_INp_name.Name = "txt_INp_name";
            this.txt_INp_name.PasswordChar = '\0';
            this.txt_INp_name.PlaceholderText = "Name";
            this.txt_INp_name.SelectedText = "";
            this.txt_INp_name.ShadowDecoration.Parent = this.txt_INp_name;
            this.txt_INp_name.Size = new System.Drawing.Size(1431, 133);
            this.txt_INp_name.TabIndex = 0;
            // 
            // txt_INp_email
            // 
            this.txt_INp_email.BorderRadius = 15;
            this.txt_INp_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_INp_email.DefaultText = "";
            this.txt_INp_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_INp_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_INp_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_INp_email.DisabledState.Parent = this.txt_INp_email;
            this.txt_INp_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_INp_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_INp_email.FocusedState.Parent = this.txt_INp_email;
            this.txt_INp_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_INp_email.HoverState.Parent = this.txt_INp_email;
            this.txt_INp_email.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_INp_email.IconLeft")));
            this.txt_INp_email.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_INp_email.Location = new System.Drawing.Point(2197, 638);
            this.txt_INp_email.Margin = new System.Windows.Forms.Padding(49, 46, 49, 46);
            this.txt_INp_email.Name = "txt_INp_email";
            this.txt_INp_email.PasswordChar = '\0';
            this.txt_INp_email.PlaceholderText = "Email";
            this.txt_INp_email.SelectedText = "";
            this.txt_INp_email.ShadowDecoration.Parent = this.txt_INp_email;
            this.txt_INp_email.Size = new System.Drawing.Size(1431, 133);
            this.txt_INp_email.TabIndex = 2;
            // 
            // txt_INp_contact
            // 
            this.txt_INp_contact.BorderRadius = 15;
            this.txt_INp_contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_INp_contact.DefaultText = "";
            this.txt_INp_contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_INp_contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_INp_contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_INp_contact.DisabledState.Parent = this.txt_INp_contact;
            this.txt_INp_contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_INp_contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_INp_contact.FocusedState.Parent = this.txt_INp_contact;
            this.txt_INp_contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_INp_contact.HoverState.Parent = this.txt_INp_contact;
            this.txt_INp_contact.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_INp_contact.IconLeft")));
            this.txt_INp_contact.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_INp_contact.Location = new System.Drawing.Point(2197, 843);
            this.txt_INp_contact.Margin = new System.Windows.Forms.Padding(65, 60, 65, 60);
            this.txt_INp_contact.Name = "txt_INp_contact";
            this.txt_INp_contact.PasswordChar = '\0';
            this.txt_INp_contact.PlaceholderText = "Contact";
            this.txt_INp_contact.SelectedText = "";
            this.txt_INp_contact.ShadowDecoration.Parent = this.txt_INp_contact;
            this.txt_INp_contact.Size = new System.Drawing.Size(1431, 133);
            this.txt_INp_contact.TabIndex = 3;
            // 
            // txt_INp_address
            // 
            this.txt_INp_address.BorderRadius = 15;
            this.txt_INp_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_INp_address.DefaultText = "";
            this.txt_INp_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_INp_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_INp_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_INp_address.DisabledState.Parent = this.txt_INp_address;
            this.txt_INp_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_INp_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_INp_address.FocusedState.Parent = this.txt_INp_address;
            this.txt_INp_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_INp_address.HoverState.Parent = this.txt_INp_address;
            this.txt_INp_address.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_INp_address.IconLeft")));
            this.txt_INp_address.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_INp_address.Location = new System.Drawing.Point(2197, 1045);
            this.txt_INp_address.Margin = new System.Windows.Forms.Padding(87, 78, 87, 78);
            this.txt_INp_address.Name = "txt_INp_address";
            this.txt_INp_address.PasswordChar = '\0';
            this.txt_INp_address.PlaceholderText = "Address";
            this.txt_INp_address.SelectedText = "";
            this.txt_INp_address.ShadowDecoration.Parent = this.txt_INp_address;
            this.txt_INp_address.Size = new System.Drawing.Size(1431, 133);
            this.txt_INp_address.TabIndex = 4;
            // 
            // txt_INp_bday
            // 
            this.txt_INp_bday.BorderRadius = 15;
            this.txt_INp_bday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_INp_bday.DefaultText = "";
            this.txt_INp_bday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_INp_bday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_INp_bday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_INp_bday.DisabledState.Parent = this.txt_INp_bday;
            this.txt_INp_bday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_INp_bday.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_INp_bday.FocusedState.Parent = this.txt_INp_bday;
            this.txt_INp_bday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_INp_bday.HoverState.Parent = this.txt_INp_bday;
            this.txt_INp_bday.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_INp_bday.IconLeft")));
            this.txt_INp_bday.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_INp_bday.Location = new System.Drawing.Point(2197, 1245);
            this.txt_INp_bday.Margin = new System.Windows.Forms.Padding(116, 102, 116, 102);
            this.txt_INp_bday.Name = "txt_INp_bday";
            this.txt_INp_bday.PasswordChar = '\0';
            this.txt_INp_bday.PlaceholderText = "Birth day";
            this.txt_INp_bday.SelectedText = "";
            this.txt_INp_bday.ShadowDecoration.Parent = this.txt_INp_bday;
            this.txt_INp_bday.Size = new System.Drawing.Size(1431, 133);
            this.txt_INp_bday.TabIndex = 5;
            // 
            // btn_IN_sub
            // 
            this.btn_IN_sub.BorderRadius = 15;
            this.btn_IN_sub.CheckedState.Parent = this.btn_IN_sub;
            this.btn_IN_sub.CustomImages.Parent = this.btn_IN_sub;
            this.btn_IN_sub.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(33)))));
            this.btn_IN_sub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_IN_sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(63)))), ((int)(((byte)(122)))));
            this.btn_IN_sub.HoverState.Parent = this.btn_IN_sub;
            this.btn_IN_sub.Location = new System.Drawing.Point(612, 412);
            this.btn_IN_sub.Name = "btn_IN_sub";
            this.btn_IN_sub.ShadowDecoration.Parent = this.btn_IN_sub;
            this.btn_IN_sub.Size = new System.Drawing.Size(180, 45);
            this.btn_IN_sub.TabIndex = 6;
            this.btn_IN_sub.Text = "Submit";
            this.btn_IN_sub.Click += new System.EventHandler(this.btn_INp_sub_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = null;
            // 
            // txt_IN_bday
            // 
            this.txt_IN_bday.BackColor = System.Drawing.Color.White;
            this.txt_IN_bday.BorderRadius = 15;
            this.txt_IN_bday.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_IN_bday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IN_bday.DefaultText = "";
            this.txt_IN_bday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IN_bday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IN_bday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IN_bday.DisabledState.Parent = this.txt_IN_bday;
            this.txt_IN_bday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IN_bday.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IN_bday.FocusedState.Parent = this.txt_IN_bday;
            this.txt_IN_bday.ForeColor = System.Drawing.Color.Black;
            this.txt_IN_bday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IN_bday.HoverState.Parent = this.txt_IN_bday;
            this.txt_IN_bday.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_IN_bday.IconLeft")));
            this.txt_IN_bday.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_IN_bday.Location = new System.Drawing.Point(532, 334);
            this.txt_IN_bday.Margin = new System.Windows.Forms.Padding(49, 55, 49, 55);
            this.txt_IN_bday.Name = "txt_IN_bday";
            this.txt_IN_bday.PasswordChar = '\0';
            this.txt_IN_bday.PlaceholderText = "Birth day";
            this.txt_IN_bday.SelectedText = "";
            this.txt_IN_bday.ShadowDecoration.Parent = this.txt_IN_bday;
            this.txt_IN_bday.Size = new System.Drawing.Size(340, 35);
            this.txt_IN_bday.TabIndex = 16;
            // 
            // txt_IN_address
            // 
            this.txt_IN_address.BackColor = System.Drawing.Color.White;
            this.txt_IN_address.BorderRadius = 15;
            this.txt_IN_address.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_IN_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IN_address.DefaultText = "";
            this.txt_IN_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IN_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IN_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IN_address.DisabledState.Parent = this.txt_IN_address;
            this.txt_IN_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IN_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IN_address.FocusedState.Parent = this.txt_IN_address;
            this.txt_IN_address.ForeColor = System.Drawing.Color.Black;
            this.txt_IN_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IN_address.HoverState.Parent = this.txt_IN_address;
            this.txt_IN_address.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_IN_address.IconLeft")));
            this.txt_IN_address.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_IN_address.Location = new System.Drawing.Point(532, 281);
            this.txt_IN_address.Margin = new System.Windows.Forms.Padding(39, 43, 39, 43);
            this.txt_IN_address.Name = "txt_IN_address";
            this.txt_IN_address.PasswordChar = '\0';
            this.txt_IN_address.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_IN_address.PlaceholderText = "Address";
            this.txt_IN_address.SelectedText = "";
            this.txt_IN_address.ShadowDecoration.Parent = this.txt_IN_address;
            this.txt_IN_address.Size = new System.Drawing.Size(340, 35);
            this.txt_IN_address.TabIndex = 15;
            // 
            // txt_IN_contact
            // 
            this.txt_IN_contact.BackColor = System.Drawing.Color.White;
            this.txt_IN_contact.BorderRadius = 15;
            this.txt_IN_contact.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_IN_contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IN_contact.DefaultText = "";
            this.txt_IN_contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IN_contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IN_contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IN_contact.DisabledState.Parent = this.txt_IN_contact;
            this.txt_IN_contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IN_contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IN_contact.FocusedState.Parent = this.txt_IN_contact;
            this.txt_IN_contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IN_contact.HoverState.Parent = this.txt_IN_contact;
            this.txt_IN_contact.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_IN_contact.IconLeft")));
            this.txt_IN_contact.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_IN_contact.Location = new System.Drawing.Point(532, 228);
            this.txt_IN_contact.Margin = new System.Windows.Forms.Padding(28, 31, 28, 31);
            this.txt_IN_contact.Name = "txt_IN_contact";
            this.txt_IN_contact.PasswordChar = '\0';
            this.txt_IN_contact.PlaceholderText = "Contact";
            this.txt_IN_contact.SelectedText = "";
            this.txt_IN_contact.ShadowDecoration.Parent = this.txt_IN_contact;
            this.txt_IN_contact.Size = new System.Drawing.Size(340, 35);
            this.txt_IN_contact.TabIndex = 14;
            // 
            // txt_IN_email
            // 
            this.txt_IN_email.BackColor = System.Drawing.Color.White;
            this.txt_IN_email.BorderRadius = 15;
            this.txt_IN_email.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_IN_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IN_email.DefaultText = "";
            this.txt_IN_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IN_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IN_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IN_email.DisabledState.Parent = this.txt_IN_email;
            this.txt_IN_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IN_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IN_email.FocusedState.Parent = this.txt_IN_email;
            this.txt_IN_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IN_email.HoverState.Parent = this.txt_IN_email;
            this.txt_IN_email.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_IN_email.IconLeft")));
            this.txt_IN_email.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_IN_email.Location = new System.Drawing.Point(532, 175);
            this.txt_IN_email.Margin = new System.Windows.Forms.Padding(21, 24, 21, 24);
            this.txt_IN_email.Name = "txt_IN_email";
            this.txt_IN_email.PasswordChar = '\0';
            this.txt_IN_email.PlaceholderText = "Email";
            this.txt_IN_email.SelectedText = "";
            this.txt_IN_email.ShadowDecoration.Parent = this.txt_IN_email;
            this.txt_IN_email.Size = new System.Drawing.Size(340, 35);
            this.txt_IN_email.TabIndex = 13;
            // 
            // txt_IN_name
            // 
            this.txt_IN_name.BackColor = System.Drawing.Color.White;
            this.txt_IN_name.BorderRadius = 15;
            this.txt_IN_name.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_IN_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IN_name.DefaultText = "";
            this.txt_IN_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IN_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IN_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IN_name.DisabledState.Parent = this.txt_IN_name;
            this.txt_IN_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IN_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IN_name.FocusedState.Parent = this.txt_IN_name;
            this.txt_IN_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IN_name.HoverState.Parent = this.txt_IN_name;
            this.txt_IN_name.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_IN_name.IconLeft")));
            this.txt_IN_name.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_IN_name.Location = new System.Drawing.Point(532, 122);
            this.txt_IN_name.Margin = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.txt_IN_name.Name = "txt_IN_name";
            this.txt_IN_name.PasswordChar = '\0';
            this.txt_IN_name.PlaceholderText = "Name";
            this.txt_IN_name.SelectedText = "";
            this.txt_IN_name.ShadowDecoration.Parent = this.txt_IN_name;
            this.txt_IN_name.Size = new System.Drawing.Size(340, 35);
            this.txt_IN_name.TabIndex = 12;
            // 
            // input_page
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_IN_bday);
            this.Controls.Add(this.txt_IN_address);
            this.Controls.Add(this.txt_IN_contact);
            this.Controls.Add(this.txt_IN_email);
            this.Controls.Add(this.txt_IN_name);
            this.Controls.Add(this.btn_IN_sub);
            this.Controls.Add(this.txt_INp_bday);
            this.Controls.Add(this.txt_INp_address);
            this.Controls.Add(this.txt_INp_contact);
            this.Controls.Add(this.txt_INp_email);
            this.Controls.Add(this.txt_INp_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "input_page";
            this.Size = new System.Drawing.Size(892, 608);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_INp_name;

        public input_page(Guna2TextBox txt_INp_name)
        {
            this.txt_INp_name = txt_INp_name;
        }

        private Guna.UI2.WinForms.Guna2TextBox txt_INp_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_INp_contact;
        private Guna.UI2.WinForms.Guna2TextBox txt_INp_address;
        private Guna.UI2.WinForms.Guna2TextBox txt_INp_bday;
        private Guna.UI2.WinForms.Guna2Button btn_IN_sub;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna2TextBox txt_IN_bday;
        private Guna2TextBox txt_IN_address;
        private Guna2TextBox txt_IN_contact;
        private Guna2TextBox txt_IN_email;
        private Guna2TextBox txt_IN_name;
    }
}
