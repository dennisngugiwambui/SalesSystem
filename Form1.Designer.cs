namespace SalesSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 40, 76);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1332, 609);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 255, 128);
            label4.Location = new Point(980, 551);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 9;
            label4.Text = "Do you want to";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(255, 255, 192);
            linkLabel1.Location = new Point(1112, 551);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 25);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Signup";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Olive;
            label3.Location = new Point(874, 114);
            label3.Name = "label3";
            label3.Size = new Size(328, 52);
            label3.TabIndex = 7;
            label3.Text = "WELCOME BACK ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(660, 361);
            label2.Name = "label2";
            label2.Size = new Size(193, 52);
            label2.TabIndex = 6;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(660, 243);
            label1.Name = "label1";
            label1.Size = new Size(123, 52);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(859, 245);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(432, 56);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(859, 361);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 56);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(642, 594);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(709, 464);
            button2.Name = "button2";
            button2.Size = new Size(200, 53);
            button2.TabIndex = 1;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1091, 464);
            button1.Name = "button1";
            button1.Size = new Size(200, 53);
            button1.TabIndex = 0;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 609);
            ControlBox = false;
            Controls.Add(panel1);
            ForeColor = Color.Chocolate;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Duka System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}
