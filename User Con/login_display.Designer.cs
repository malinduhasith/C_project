namespace C_2sem_Project.User_Con
{
    partial class login_display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_display));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_LD_Name = new System.Windows.Forms.Label();
            this.lbl_LD_Post = new System.Windows.Forms.Label();
            this.img_LD_profile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_LD_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbl_LD_Name
            // 
            this.lbl_LD_Name.AutoSize = true;
            this.lbl_LD_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LD_Name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_LD_Name.Location = new System.Drawing.Point(87, 28);
            this.lbl_LD_Name.Name = "lbl_LD_Name";
            this.lbl_LD_Name.Size = new System.Drawing.Size(108, 16);
            this.lbl_LD_Name.TabIndex = 0;
            this.lbl_LD_Name.Text = "Malindu herath";
            // 
            // lbl_LD_Post
            // 
            this.lbl_LD_Post.AutoSize = true;
            this.lbl_LD_Post.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_LD_Post.Location = new System.Drawing.Point(87, 44);
            this.lbl_LD_Post.Name = "lbl_LD_Post";
            this.lbl_LD_Post.Size = new System.Drawing.Size(43, 16);
            this.lbl_LD_Post.TabIndex = 1;
            this.lbl_LD_Post.Text = "admin";
            // 
            // img_LD_profile
            // 
            this.img_LD_profile.Image = ((System.Drawing.Image)(resources.GetObject("img_LD_profile.Image")));
            this.img_LD_profile.Location = new System.Drawing.Point(23, 17);
            this.img_LD_profile.Name = "img_LD_profile";
            this.img_LD_profile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.img_LD_profile.ShadowDecoration.Parent = this.img_LD_profile;
            this.img_LD_profile.Size = new System.Drawing.Size(58, 56);
            this.img_LD_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_LD_profile.TabIndex = 2;
            this.img_LD_profile.TabStop = false;
            // 
            // login_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.img_LD_profile);
            this.Controls.Add(this.lbl_LD_Post);
            this.Controls.Add(this.lbl_LD_Name);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "login_display";
            this.Size = new System.Drawing.Size(269, 92);
            this.Load += new System.EventHandler(this.login_display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_LD_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox img_LD_profile;
        private System.Windows.Forms.Label lbl_LD_Post;
        private System.Windows.Forms.Label lbl_LD_Name;
    }
}
