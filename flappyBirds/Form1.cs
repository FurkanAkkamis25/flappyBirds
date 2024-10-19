using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace flappyBirds
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        int engelHizi = 12;
        int gravity = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            pictureBox2.Top += gravity;
            pictureBox4.Left -= engelHizi;
            pictureBox1.Left -= engelHizi;
            label3.Text = "Score :" +score;
            if (pictureBox4.Left < -150)
            {
                pictureBox4.Left = 1100;
                score++;
            }
            if (pictureBox1.Left < -180)
            {
                pictureBox1.Left = 1200;
                score++;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds) || pictureBox2.Bounds.IntersectsWith(panel1.Bounds))
            {
                endGame();
            }
            if (score > 6)
            {
                engelHizi = 16;
            }
            if (score > 14)
            {
                engelHizi = 22;
            }
            if (score > 20)
            {
                engelHizi = 28;
            }
            if (score > 28)
            {
                engelHizi = 34;
            }
            if (score > 34)
            {
                engelHizi = 42;
            }
            if (score > 40)
            {
                engelHizi = 46;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

       private void endGame()
        {
            gameTimer.Stop();
            label3.Text = "GAME OVER :( "+"Score ="+score;
        }

    }
}
