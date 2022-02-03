using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yasyagame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gravity = 10;
        int speed = 25;
        int score = 0;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 15;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -15;
            else if (e.KeyCode == Keys.Enter)
                timer1.Start();
        }

        Random rnd=new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            yasya.Top += gravity;
            DanaBot.Left -= speed;
            DanaTop.Left -= speed;
            sky.Left -= speed;
            lblScore.Text = $"Score: {score}";
            //adding score
            if (DanaBot.Left < - 220)
            {
                DanaBot.Left = rnd.Next(100, 600);
                score++;
            }
            if (DanaTop.Left < -220)
            {
                int top = rnd.Next(300, 700);
                DanaTop.Left = rnd.Next(300, 700);
                sky.Left = rnd.Next(top + 100, 800);
                score++;
            }
            if (yasya.Bounds.IntersectsWith(DanaBot.Bounds)||yasya.Bounds.IntersectsWith(DanaTop.Bounds)||yasya.Bounds.IntersectsWith(ground.Bounds))
            {
                timer1.Stop();
                lblScore.Text += "Dana FOO!!!";
            }
            if (score > 10)
                speed += 5;
        }

        private void yasya_Click(object sender, EventArgs e)
        {

        }
    }
}
