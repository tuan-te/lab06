namespace Lab6_Nhóm5_23521757
{
    partial class Lab05_Bai01
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
            pbBai1 = new PictureBox();
            lblTimeLeft = new Label();
            btnStart = new Button();
            numDiv = new NumericUpDown();
            numProd = new NumericUpDown();
            numDiff = new NumericUpDown();
            numSum = new NumericUpDown();
            lblDiv = new Label();
            lblProd = new Label();
            lblDiff = new Label();
            lblSum = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBai1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSum).BeginInit();
            SuspendLayout();
            // 
            // pbBai1
            // 
            pbBai1.BackgroundImage = Properties.Resources.gif11;
            pbBai1.Dock = DockStyle.Fill;
            pbBai1.Location = new Point(0, 0);
            pbBai1.Name = "pbBai1";
            pbBai1.Size = new Size(800, 450);
            pbBai1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBai1.TabIndex = 0;
            pbBai1.TabStop = false;
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeLeft.Location = new Point(337, 45);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(113, 28);
            lblTimeLeft.TabIndex = 19;
            lblTimeLeft.Text = "Time Left: ";
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.GradientActiveCaption;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(12, 393);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(216, 45);
            btnStart.TabIndex = 18;
            btnStart.Text = "Start the Quiz !";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click_1;
            // 
            // numDiv
            // 
            numDiv.BackColor = SystemColors.ControlLight;
            numDiv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numDiv.Location = new Point(453, 331);
            numDiv.Name = "numDiv";
            numDiv.Size = new Size(135, 34);
            numDiv.TabIndex = 17;
            // 
            // numProd
            // 
            numProd.BackColor = SystemColors.ControlLight;
            numProd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numProd.Location = new Point(453, 258);
            numProd.Name = "numProd";
            numProd.Size = new Size(135, 34);
            numProd.TabIndex = 16;
            // 
            // numDiff
            // 
            numDiff.BackColor = SystemColors.ControlLight;
            numDiff.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numDiff.Location = new Point(453, 186);
            numDiff.Name = "numDiff";
            numDiff.Size = new Size(135, 34);
            numDiff.TabIndex = 15;
            // 
            // numSum
            // 
            numSum.BackColor = SystemColors.ControlLight;
            numSum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numSum.Location = new Point(453, 118);
            numSum.Name = "numSum";
            numSum.Size = new Size(135, 34);
            numSum.TabIndex = 14;
            // 
            // lblDiv
            // 
            lblDiv.AutoSize = true;
            lblDiv.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiv.Location = new Point(272, 334);
            lblDiv.Name = "lblDiv";
            lblDiv.Size = new Size(24, 31);
            lblDiv.TabIndex = 13;
            lblDiv.Text = "/";
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProd.Location = new Point(272, 258);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(27, 31);
            lblProd.TabIndex = 12;
            lblProd.Text = "x";
            // 
            // lblDiff
            // 
            lblDiff.AutoSize = true;
            lblDiff.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiff.Location = new Point(272, 186);
            lblDiff.Name = "lblDiff";
            lblDiff.Size = new Size(23, 31);
            lblDiff.TabIndex = 11;
            lblDiff.Text = "-";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(272, 118);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(30, 31);
            lblSum.TabIndex = 10;
            lblSum.Text = "+";
            // 
            // Lab05_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTimeLeft);
            Controls.Add(btnStart);
            Controls.Add(numDiv);
            Controls.Add(numProd);
            Controls.Add(numDiff);
            Controls.Add(numSum);
            Controls.Add(lblDiv);
            Controls.Add(lblProd);
            Controls.Add(lblDiff);
            Controls.Add(lblSum);
            Controls.Add(pbBai1);
            Name = "Lab05_Bai01";
            Text = "Lab05_Bai01";
            ((System.ComponentModel.ISupportInitialize)pbBai1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiv).EndInit();
            ((System.ComponentModel.ISupportInitialize)numProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiff).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBai1;
        private Label lblTimeLeft;
        private Button btnStart;
        private NumericUpDown numDiv;
        private NumericUpDown numProd;
        private NumericUpDown numDiff;
        private NumericUpDown numSum;
        private Label lblDiv;
        private Label lblProd;
        private Label lblDiff;
        private Label lblSum;
    }
}