namespace Lab6_Nhóm5_23521757
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
            pictureBox1 = new PictureBox();
            btnBai2 = new Button();
            btnBai3 = new Button();
            btnBai1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.gif4;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnBai2
            // 
            btnBai2.BackColor = SystemColors.GradientActiveCaption;
            btnBai2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai2.Location = new Point(346, 197);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(108, 55);
            btnBai2.TabIndex = 5;
            btnBai2.Text = "Bài 2";
            btnBai2.UseVisualStyleBackColor = false;
            btnBai2.Click += btnBai2_Click;
            // 
            // btnBai3
            // 
            btnBai3.BackColor = SystemColors.GradientActiveCaption;
            btnBai3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai3.Location = new Point(346, 306);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(108, 55);
            btnBai3.TabIndex = 4;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = false;
            btnBai3.Click += btnBai3_Click;
            // 
            // btnBai1
            // 
            btnBai1.BackColor = SystemColors.GradientActiveCaption;
            btnBai1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai1.Location = new Point(346, 90);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(108, 55);
            btnBai1.TabIndex = 3;
            btnBai1.Text = "Bài 1";
            btnBai1.UseVisualStyleBackColor = false;
            btnBai1.Click += btnBai1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBai2);
            Controls.Add(btnBai3);
            Controls.Add(btnBai1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBai2;
        private Button btnBai3;
        private Button btnBai1;
    }
}
