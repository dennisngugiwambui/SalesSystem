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
            panel6 = new Panel();
            label1 = new Label();
            Welcome = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel7 = new Panel();
            lblDashboard = new Label();
            lblProfile = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
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
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1553, 645);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(32, 35, 68);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(Welcome);
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(215, 194);
            panel6.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(130, 144);
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
            Welcome.Location = new Point(3, 137);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(121, 43);
            Welcome.TabIndex = 1;
            Welcome.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(218, 161);
            panel5.Name = "panel5";
            panel5.Size = new Size(1335, 484);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 49, 93);
            panel4.Location = new Point(348, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(290, 104);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 49, 93);
            panel3.Location = new Point(766, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(290, 104);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 49, 93);
            panel2.Location = new Point(1231, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 104);
            panel2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(32, 35, 68);
            panel7.Controls.Add(lblProfile);
            panel7.Controls.Add(lblDashboard);
            panel7.Location = new Point(0, 183);
            panel7.Name = "panel7";
            panel7.Size = new Size(215, 462);
            panel7.TabIndex = 4;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 10F);
            lblDashboard.ForeColor = Color.Transparent;
            lblDashboard.Location = new Point(12, 27);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(108, 28);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 10F);
            lblProfile.ForeColor = Color.Transparent;
            lblProfile.Location = new Point(12, 84);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(68, 28);
            lblProfile.TabIndex = 1;
            lblProfile.Text = "Profile";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1553, 645);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private Label lblProfile;
        private Label lblDashboard;
    }
}