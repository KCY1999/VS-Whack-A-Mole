using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rd;
        int[] posX = { 150, 250, 300 };
        int[] posY = { 150, 300 };
        int score;
        public Form1()
        {
            InitializeComponent();
            Kk();
        }

        void Kk()
        {
            rd = new Random();
            pictureBox1.Image = Image.FromFile("地鼠.png");
            score = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = rd.Next(3);
            y = rd.Next(2);
            pictureBox1.Left = posX[x];
            pictureBox1.Top = posY[y];
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            score += 5;
            label1.Text = score.ToString();
            pictureBox1.Image = Image.FromFile("被打的地鼠.png");
        }
    }

}
