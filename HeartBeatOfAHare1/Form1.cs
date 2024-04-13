using System;
using System.Drawing;
using System.Windows.Forms;

namespace HeartBeatOfAHare1
{
    public partial class Form1 : Form
    {
        int objectSpeed;

        int leftPlayerSpeed;
        int rightPlayerSpeed;
        int verticalPlayerSpeed;

        public Form1()
        {
            InitializeComponent();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"C:\Users\aleja\Downloads\Launchpad Projects\Clean Bandit - Solo Project\Clean Bandit - Solo Project\Heartbeat of a harefinal.wav";
            player.Play();

            this.player.Parent = pictureBox1;
            this.grasss.Parent = pictureBox1;
            this.grasss2.Parent = pictureBox1;
            this.grasss3.Parent = pictureBox1;
            this.grasss4.Parent = pictureBox1;
            this.rokk.Parent = pictureBox1;
            this.rokk2.Parent = pictureBox1;
            this.rokk3.Parent = pictureBox1;
            this.rokk4.Parent = pictureBox1;

            leftPlayerSpeed = 12;
            verticalPlayerSpeed = 12;
            rightPlayerSpeed = 24;
            objectSpeed = 50;
            moveObjectTimer.Start();
        }

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Left > 5)
            {
                player.Left -= leftPlayerSpeed;
            }
        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Right < 1595)
            {
                player.Left += rightPlayerSpeed;
            }
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Bottom < 395)
            {
                player.Top += verticalPlayerSpeed;
            }
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Top > 5)
            {
                player.Top -= verticalPlayerSpeed;
            }
        }

        private void moveObjectTimer_Tick(object sender, EventArgs e)
        {
            Rectangle playerBounds = player.Bounds;

            Rectangle[] obstacleBoundsArray = new Rectangle[]
            {
                rokk.Bounds,
                rokk2.Bounds,
                rokk3.Bounds,
                rokk4.Bounds
            };

            foreach (Rectangle obstacleBounds in obstacleBoundsArray)
            {
                if (playerBounds.IntersectsWith(obstacleBounds))
                {
                    Application.Exit();
                    break;
                }
            }

            if (grasss.Right < 1595)
            {
                grasss.Left += objectSpeed;
            }
            else
            {
                grasss.Left = 0;
            }

            if (grasss2.Right < 1595)
            {
                grasss2.Left += objectSpeed;
            }
            else
            {
                grasss2.Left = 10;
            }

            if (rokk.Right < 1595)
            {
                rokk.Left += objectSpeed;
            }
            else
            {
                rokk.Left = 90;
            }

            if (rokk2.Right < 1595)
            {
                rokk2.Left += objectSpeed;
            }
            else
            {
                rokk2.Left = 40;
            }

            if (rokk3.Right < 1595)
            {
                rokk3.Left += objectSpeed;
            }
            else
            {
                rokk3.Left = 70;
            }

            if (rokk4.Right < 1595)
            {
                rokk4.Left += objectSpeed;
            }
            else
            {
                rokk4.Left = 60;
            }

            if (grasss3.Right < 1595)
            {
                grasss3.Left += objectSpeed;
            }
            else
            {
                grasss3.Left = 2;
            }

            if (grasss4.Right < 1595)
            {
                grasss4.Left += objectSpeed;
            }
            else
            {
                grasss4.Left = 20;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                LeftMoveTimer.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                RightMoveTimer.Start();
            }

            if (e.KeyCode == Keys.Down)
            {
                DownMoveTimer.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                UpMoveTimer.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            LeftMoveTimer.Stop();
            RightMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();
        }

        //No utilizados --------------------------------------------|

        private void timer1_Tick(object sender, EventArgs e)
        { }
        private void player_Click(object sender, EventArgs e)
        { }
        private void grasss_Click(object sender, EventArgs e)
        { }
        private void pictureBox2_Click(object sender, EventArgs e)
        { }
        private void Form1_load(object sender, EventArgs e)
        { }
        private void pictureBox1_Click(object sender, EventArgs e)
        { }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        { }
        private void Form1_Load(object sender, EventArgs e) 
        { }
        private void HeartBeatofaHare_Load(object sender, EventArgs e)
        { }
    }
}