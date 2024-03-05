namespace SalesSystem
{
    partial class frmChicken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChicken));
            panel1 = new Panel();
            label1 = new Label();
            Welcome = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnLogout = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnChicken = new Button();
            btnProfile = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 35, 68);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Welcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 182);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(166, 127);
            label1.Name = "label1";
            label1.Size = new Size(82, 26);
            label1.TabIndex = 3;
            label1.Text = "Admin";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Rage Italic", 17F);
            Welcome.ForeColor = SystemColors.ButtonHighlight;
            Welcome.Location = new Point(30, 120);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(121, 43);
            Welcome.TabIndex = 2;
            Welcome.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 35, 68);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnChicken);
            panel2.Controls.Add(btnProfile);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(0, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 562);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(32, 35, 68);
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Image = Properties.Resources.shutdown1;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 504);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(232, 46);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 35, 68);
            button3.ForeColor = Color.Transparent;
            button3.Image = Properties.Resources.chicken1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 380);
            button3.Name = "button3";
            button3.Size = new Size(220, 46);
            button3.TabIndex = 9;
            button3.Text = "Earnings";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 35, 68);
            button2.ForeColor = Color.Transparent;
            button2.Image = Properties.Resources.chicken1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 303);
            button2.Name = "button2";
            button2.Size = new Size(220, 46);
            button2.TabIndex = 8;
            button2.Text = "Eggs";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 35, 68);
            button1.ForeColor = Color.Transparent;
            button1.Image = Properties.Resources.chicken1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 235);
            button1.Name = "button1";
            button1.Size = new Size(220, 46);
            button1.TabIndex = 7;
            button1.Text = "Chicks";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnChicken
            // 
            btnChicken.BackColor = Color.FromArgb(32, 35, 68);
            btnChicken.ForeColor = Color.Transparent;
            btnChicken.Image = Properties.Resources.chicken1;
            btnChicken.ImageAlign = ContentAlignment.MiddleLeft;
            btnChicken.Location = new Point(12, 165);
            btnChicken.Name = "btnChicken";
            btnChicken.Size = new Size(220, 46);
            btnChicken.TabIndex = 5;
            btnChicken.Text = "Chickens";
            btnChicken.UseVisualStyleBackColor = false;
            btnChicken.Click += btnChicken_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(32, 35, 68);
            btnProfile.ForeColor = Color.Transparent;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(12, 98);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(220, 46);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(32, 35, 68);
            btnDashboard.ForeColor = Color.Transparent;
            btnDashboard.Image = Properties.Resources.eggs1;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(12, 29);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 46);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.ForeColor = Color.IndianRed;
            panel3.Location = new Point(279, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(1463, 512);
            panel3.TabIndex = 2;
            // 
            // frmChicken
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 40, 76);
            ClientSize = new Size(1754, 731);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9.79999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmChicken";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChicken";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label Welcome;
        private Label label1;
        private Panel panel2;
        private Button btnDashboard;
        private Button btnProfile;
        private Button btnChicken;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnLogout;
        private Panel panel3;
    }
}