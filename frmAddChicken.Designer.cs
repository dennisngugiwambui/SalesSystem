namespace SalesSystem
{
    partial class frmAddChicken
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
            labelAddChicken = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonAddChicken = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelAddChicken
            // 
            labelAddChicken.AutoSize = true;
            labelAddChicken.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddChicken.ForeColor = Color.Transparent;
            labelAddChicken.Location = new Point(304, 55);
            labelAddChicken.Name = "labelAddChicken";
            labelAddChicken.Size = new Size(269, 52);
            labelAddChicken.TabIndex = 0;
            labelAddChicken.Text = "Add Chicken";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chicken;
            pictureBox1.Location = new Point(171, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(41, 226);
            label1.Name = "label1";
            label1.Size = new Size(269, 32);
            label1.TabIndex = 2;
            label1.Text = "Number of Chickens";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(160, 352);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 3;
            label2.Text = "Comments";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(386, 227);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(386, 337);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(436, 182);
            textBox2.TabIndex = 5;
            // 
            // buttonAddChicken
            // 
            buttonAddChicken.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddChicken.ForeColor = SystemColors.Info;
            buttonAddChicken.Location = new Point(279, 582);
            buttonAddChicken.Name = "buttonAddChicken";
            buttonAddChicken.Size = new Size(294, 55);
            buttonAddChicken.TabIndex = 6;
            buttonAddChicken.Text = "Submit";
            buttonAddChicken.UseVisualStyleBackColor = false;
            buttonAddChicken.Click += buttonAddChicken_Click;
            // 
            // frmAddChicken
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 40, 76);
            ClientSize = new Size(900, 659);
            Controls.Add(buttonAddChicken);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(labelAddChicken);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddChicken";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddChicken";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddChicken;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonAddChicken;
    }
}