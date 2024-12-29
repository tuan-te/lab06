using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Nhóm5_23521757
{
    public partial class Lab05_Bai03 : Form
    {
        private string[] imagePaths;
        private Random random;
        public Lab05_Bai03()
        {
            InitializeComponent();
            pictureBox0.Image = Properties.Resources.gif31;
            random = new Random();
            string imageFolder = Path.Combine(Directory.GetCurrentDirectory(), "Images");
            if (Directory.Exists(imageFolder))
            {
                imagePaths = Directory.GetFiles(imageFolder, "*.jpg");
            }
            else
            {
                MessageBox.Show("Thư mục 'Images' không tồn tại. Vui lòng kiểm tra lại!");
                return;
            }
            if (imagePaths.Length < 1)
            {
                MessageBox.Show("Thư mục 'Images' không chứa hình ảnh nào!");
            }
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {

        }

        private void btnSpin_Click_1(object sender, EventArgs e)
        {
            if (imagePaths == null || imagePaths.Length == 0)
            {
                MessageBox.Show("Không có hình ảnh để hiển thị!");
                return;
            }
            try
            {
                string img1 = imagePaths[random.Next(imagePaths.Length)];
                string img2 = imagePaths[random.Next(imagePaths.Length)];
                string img3 = imagePaths[random.Next(imagePaths.Length)];
                pictureBox1.Image = Image.FromFile(img1);
                pictureBox2.Image = Image.FromFile(img2);
                pictureBox3.Image = Image.FromFile(img3);
                if (Path.GetFileName(img1) == Path.GetFileName(img2) && Path.GetFileName(img2) == Path.GetFileName(img3))
                {
                    lblResult.Text = "  Chúc mừng! Bạn đã thắng.";
                    lblResult.ForeColor = Color.Green;
                }
                else
                {
                    lblResult.Text = "  Rất tiếc! Bạn hãy thử lại.";
                    lblResult.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị hình ảnh: {ex.Message}");
            }
        }

        private void pictureBox0_Click(object sender, EventArgs e)
        {

        }
    }
}
