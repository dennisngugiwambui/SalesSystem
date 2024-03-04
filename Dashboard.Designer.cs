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
            btnLogout = new Button();
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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            NumberOfChickens = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            comments = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel7.Controls.Add(button3);
            panel7.Controls.Add(button2);
            panel7.Controls.Add(button1);
            panel7.Controls.Add(btnLogout);
            panel7.Controls.Add(btnChicken);
            panel7.Controls.Add(btnProfile);
            panel7.Controls.Add(btnDashboard);
            panel7.Location = new Point(0, 176);
            panel7.Name = "panel7";
            panel7.Size = new Size(236, 574);
            panel7.TabIndex = 4;
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
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(240, 155);
            panel5.Name = "panel5";
            panel5.Size = new Size(1505, 592);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 49, 93);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(383, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 122);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 49, 93);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(843, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 122);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 49, 93);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(1354, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 122);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.chicken__2_;
            pictureBox2.Location = new Point(14, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.chicken__1_;
            pictureBox3.Location = new Point(3, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.earnings;
            pictureBox4.Location = new Point(3, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(111, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 35, 68);
            button1.ForeColor = Color.Transparent;
            button1.Image = Properties.Resources.chicken1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 242);
            button1.Name = "button1";
            button1.Size = new Size(220, 46);
            button1.TabIndex = 6;
            button1.Text = "Chicks";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 35, 68);
            button2.ForeColor = Color.Transparent;
            button2.Image = Properties.Resources.chicken1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 310);
            button2.Name = "button2";
            button2.Size = new Size(220, 46);
            button2.TabIndex = 7;
            button2.Text = "Eggs";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 35, 68);
            button3.ForeColor = Color.Transparent;
            button3.Image = Properties.Resources.chicken1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 377);
            button3.Name = "button3";
            button3.Size = new Size(220, 46);
            button3.TabIndex = 8;
            button3.Text = "Earnings";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(205, 206, 222);
            label2.Location = new Point(189, 12);
            label2.Name = "label2";
            label2.Size = new Size(64, 46);
            label2.TabIndex = 1;
            label2.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(205, 206, 222);
            label3.Location = new Point(153, 58);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 2;
            label3.Text = "Total Chickens";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(205, 206, 222);
            label4.Location = new Point(140, 58);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 3;
            label4.Text = "Total Chicks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(205, 206, 222);
            label5.Location = new Point(152, 58);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 4;
            label5.Text = "Total Earnings";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(105, 108, 145);
            label6.Location = new Point(96, 97);
            label6.Name = "label6";
            label6.Size = new Size(220, 25);
            label6.TabIndex = 3;
            label6.Text = "Total chickens available";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(105, 108, 145);
            label7.Location = new Point(65, 97);
            label7.Name = "label7";
            label7.Size = new Size(220, 25);
            label7.TabIndex = 4;
            label7.Text = "Total chickens available";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(105, 108, 145);
            label8.Location = new Point(70, 97);
            label8.Name = "label8";
            label8.Size = new Size(220, 25);
            label8.TabIndex = 5;
            label8.Text = "Total chickens available";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, NumberOfChickens, date, comments });
            dataGridView1.Location = new Point(2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1500, 586);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            id.HeaderText = "ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 67;
            // 
            // NumberOfChickens
            // 
            NumberOfChickens.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NumberOfChickens.HeaderText = "Number Of Chickens";
            NumberOfChickens.MinimumWidth = 8;
            NumberOfChickens.Name = "NumberOfChickens";
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date.HeaderText = "Date";
            date.MinimumWidth = 8;
            date.Name = "date";
            // 
            // comments
            // 
            comments.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            comments.HeaderText = "Comments";
            comments.MinimumWidth = 8;
            comments.Name = "comments";
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
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label5;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn NumberOfChickens;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn comments;
    }
}