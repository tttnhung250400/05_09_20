using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Clickballoon
{
    public partial class Form2 : Form
    {
        int score = 0;
        int speed = 5;
        Random rand = new Random();
        bool gameOver = false;
        PictureBox boom = new PictureBox();
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player1 = new WMPLib.WindowsMediaPlayer();
        
    
        public Form2()
        {
            InitializeComponent();
            player.URL = "win.wav";
            player1.URL = "bk.wav";
            resetGame();
            
        }
        
        private void pop_Balloon(object sender, EventArgs e)
        {
            
            player.controls.play();
            if (gameOver == false)
            {   
                var balloon = (PictureBox) sender;
                balloon.Cursor = Cursors.Hand;
                balloon.Top = rand.Next(700, 1000);
                balloon.Left = rand.Next(5, 500);
                score++;
            }
        }
        // Khi người chơi chọn quả bom , quả bom sẽ nổ và dừng game
        private void popBomb(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                bomb.Image = Properties.Resources.boom; // chuyển thành nổ
                gametimer.Stop();
                lb1.Text = "Game Over!";
                gameOver = true;
            }
        }

        private void gameEngine(object sender, EventArgs e)
        {

            lbDiem.Text = "Score:" + score;
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox)
                {
                    X.Top -= speed;
                    if (X.Top + X.Height < 0)
                    {
                        X.Top = rand.Next(700, 1000);
                        X.Left = rand.Next(5, 500);
                    }
                    if ( X.Top < -500)
                    {
                        gametimer.Stop();
                        lb1.Text = "Over";
                        gameOver = true;
                    }
                }
            }
            // Nếu điểm lớn hơn 10 / 20 / 35/ 45 -> tốc độ bóng bay sẽ nhanh dần
            // Tăng độ khó vủa game
            if (score >= 10)
            { speed = 8; }

            if (score >= 20)
            { speed = 10; }

            if (score >= 35)
            { speed = 13; }

            if (score >= 45)
            { speed = 17; }
        }
        // Nhấn phím Enter để quay lại game
        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                resetGame();
                lb1.Text = "";
                
            }
        }


        private void resetGame()
        {
            player1.controls.play();
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox)
                {
                    X.Top = rand.Next(700, 1000);
                    X.Left = rand.Next(5, 500);
                }
            }
            // Chơi lại game, điểm, tốc độ quay về lúc bắt đầu game 
            bomb.Image = Properties.Resources.bomb;
            speed = 5;    // reset tốc độ
            score = 0;   // reset điểm 
            gameOver = false;
            lbDiem.Text = "Score: " + score;
            gametimer.Start();  // bắt đầu lại game 
        }
        private void btRetry_Click(object sender, EventArgs e)
        {
            resetGame();
            lb1.Text = "";
        }

        
    }
    }

