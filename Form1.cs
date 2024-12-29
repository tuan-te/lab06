namespace Lab6_Nhóm5_23521757
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.gif4;
        }
        private void btnBai1_Click(object sender, EventArgs e)
        {
            Lab05_Bai01 b1 = new Lab05_Bai01();
            b1.Show();
        }

        private void btnBai1_Click_1(object sender, EventArgs e)
        {
            Lab05_Bai01 b1 = new Lab05_Bai01();
            b1.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Lab05_Bai02 b2 = new Lab05_Bai02();
            b2.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Lab05_Bai03 b3 = new Lab05_Bai03();
            b3.Show();
        }
    }
}
