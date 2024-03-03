namespace SalesSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel7 = new Panel();
            btnChicken = new Button();
            btnProfile = new Button();
            btnDashboard = new Button();
            panel6 = new Panel();
            label1 = new Label();
            Welcome = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnLogout = new Button();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 40, 76);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1759, 750);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(32, 35, 68);
            panel7.Controls.Add(btnLogout);
            panel7.Controls.Add(btnChicken);
            panel7.Controls.Add(btnProfile);
            panel7.Controls.Add(btnDashboard);
            panel7.Location = new Point(0, 176);
            panel7.Name = "panel7";
            panel7.Size = new Size(236, 574);
            panel7.TabIndex = 4;
            // 
            // btnChicken
            // 
            btnChicken.BackColor = Color.FromArgb(32, 35, 68);
            btnChicken.ForeColor = Color.Transparent;
            btnChicken.Image = Properties.Resources.chicken1;
            btnChicken.ImageAlign = ContentAlignment.MiddleLeft;
            btnChicken.Location = new Point(3, 175);
            btnChicken.Name = "btnChicken";
            btnChicken.Size = new Size(220, 46);
            btnChicken.TabIndex = 4;
            btnChicken.Text = "Chickens";
            btnChicken.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(32, 35, 68);
            btnProfile.ForeColor = Color.Transparent;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(3, 107);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(220, 46);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(32, 35, 68);
            btnDashboard.ForeColor = Color.Transparent;
            btnDashboard.Image = Properties.Resources.eggs1;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 32);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 46);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(32, 35, 68);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(Welcome);
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(236, 187);
            panel6.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(143, 139);
            label1.Name = "label1";
            label1.Size = new Size(82, 26);
            label1.TabIndex = 2;
            label1.Text = "Admin";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Rage Italic", 17F);
            Welcome.ForeColor = SystemColors.ButtonHighlight;
            Welcome.Location = new Point(3, 132);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(121, 43);
            Welcome.TabIndex = 1;
            Welcome.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(240, 155);
            panel5.Name = "panel5";
            panel5.Size = new Size(1505, 592);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 49, 93);
            panel4.Location = new Point(383, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 100);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 49, 93);
            panel3.Location = new Point(843, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 100);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 49, 93);
            panel2.Location = new Point(1354, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 100);
            panel2.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(32, 35, 68);
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Image = Properties.Resources.shutdown1;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(5, 507);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 46);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1757, 751);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9.74999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Label label1;
        private Label Welcome;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Button btnDashboard;
        private Button btnChicken;
        private Button btnProfile;
        private Button btnLogout;
    }
}