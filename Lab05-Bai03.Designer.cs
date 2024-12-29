namespace Lab6_Nhóm5_23521757
{
    partial class Lab05_Bai03
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
            pictureBox0 = new PictureBox();
            lblResult = new Label();
            btnSpin = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox0
            // 
            pictureBox0.BackgroundImage = Properties.Resources.gif31;
            pictureBox0.Dock = DockStyle.Fill;
            pictureBox0.Location = new Point(0, 0);
            pictureBox0.Name = "pictureBox0";
            pictureBox0.Size = new Size(800, 450);
            pictureBox0.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox0.TabIndex = 0;
            pictureBox0.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.AccessibleName = "resultLabel";
            lblResult.AutoSize = true;
            lblResult.BackColor = SystemColors.Control;
            lblResult.FlatStyle = FlatStyle.System;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(289, 401);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 28);
            lblResult.TabIndex = 9;
            // 
            // btnSpin
            // 
            btnSpin.BackColor = Color.LightCoral;
            btnSpin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSpin.Location = new Point(325, 314);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(174, 54);
            btnSpin.TabIndex = 8;
            btnSpin.Text = "Spin";
            btnSpin.UseVisualStyleBackColor = false;
            btnSpin.Click += btnSpin_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Location = new Point(577, 126);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(133, 127);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Location = new Point(347, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(124, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Lab05_Bai03
            // 
            AccessibleName = "resultLabel";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gif21;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnSpin);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox0);
            Name = "Lab05_Bai03";
            Text = "Lab05_Bai03";
            ((System.ComponentModel.ISupportInitialize)pictureBox0).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox0;
        private Label lblResult;
        private Button btnSpin;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}