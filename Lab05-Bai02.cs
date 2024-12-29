﻿using System;
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
    public partial class Lab05_Bai02 : Form
    {
        private List<Button> buttons = new List<Button>();
        private List<string> images = new List<string>();
        private Button firstClicked = null;
        private Button secondClicked = null;
        public Lab05_Bai02()
        {
            InitializeComponent();
            LoadImages();
            SetupGame(8, 8);
        }
        private void LoadImages()
        {
            string imageFolder = Path.Combine(Directory.GetCurrentDirectory(), "Images");
            if (Directory.Exists(imageFolder))
            {
                var files = Directory.GetFiles(imageFolder, "*.jpg"); 
                foreach (var file in files)
                {
                    images.Add(file);
                    images.Add(file); 
                }
            }
        }
        private void SetupGame(int rows, int cols)
        {
            tableLayoutPanel.RowCount = rows;
            tableLayoutPanel.ColumnCount = cols;
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Clear();
            for (int i = 0; i < rows; i++)
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));
            for (int j = 0; j < cols; j++)
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / cols));
            Random random = new Random();
            var shuffledImages = images.OrderBy(x => random.Next()).Take(rows * cols).ToList();
            foreach (var image in shuffledImages)
            {
                Button button = new Button
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.LightBlue,
                    Tag = image, 
                    Text = "", 
                    Font = new Font("Webdings", 72, FontStyle.Bold) 
                };
                button.Click += Button_Click;
                buttons.Add(button);
                tableLayoutPanel.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;
            Button clickedButton = sender as Button;
            if (clickedButton == null || clickedButton == firstClicked)
                return;
            string imagePath = clickedButton.Tag.ToString();
            clickedButton.BackgroundImage = Image.FromFile(imagePath);
            clickedButton.BackgroundImageLayout = ImageLayout.Stretch;

            if (firstClicked == null)
            {
                firstClicked = clickedButton;
            }
            else
            {
                secondClicked = clickedButton;
                CheckForMatch();
            }
        }

        private void CheckForMatch()
        {
            if (firstClicked.Tag.ToString() == secondClicked.Tag.ToString())
            {
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 500; 
                timer.Tick += (s, e) =>
                {
                    tableLayoutPanel.Controls.Remove(firstClicked);
                    tableLayoutPanel.Controls.Remove(secondClicked);
                    firstClicked = null;
                    secondClicked = null;
                    timer.Stop();
                    if (tableLayoutPanel.Controls.Count == 0)
                    {
                        MessageBox.Show("Bạn đã chiến thắng!");
                    }
                };
                timer.Start();
            }
            else
            {
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; 
                timer.Tick += (s, e) =>
                {
                    firstClicked.BackgroundImage = null;
                    secondClicked.BackgroundImage = null;
                    firstClicked = null;
                    secondClicked = null;
                    timer.Stop();
                };
                timer.Start();
            }
        }
    }
}
