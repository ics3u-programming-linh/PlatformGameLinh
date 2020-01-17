using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PlatformGameLinh
{
    public partial class frmLevel1 : Form
    {
        // declare variables and set bool variables 
        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        int jumpSpeed = 10;
        int force = 5;

        // declare variables for lives and score
        int lives = 3;
        int score = 0;

        // declare variables for timer
        int totalSeconds = 6;
        int timeLeft = 5;
 
        public frmLevel1()
        {
            InitializeComponent();

            // call initializations
            HideWinLose();
            Wall();

        }

        private void HideWinLose()
        {
            // hide pictures, labels
            btnNext.Hide();
        }

        private void ShowWinLose()
        {
            // Show pictures, buttons, images
            btnNext.Show();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            // if left key is pressed, set goleft to true
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            // if right key is pressed, set goright to true
            if (e.KeyCode == Keys.Right)
            {
                goright = true;

            }
            // if space key is pressed, set jumping to true
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
            Wall();
        }
        

        private void keyisup(object sender, KeyEventArgs e)
        {
            // if left key is pressed, set goleft to false
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            // if right key is pressed, set goright to false
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            // if space key is pressed, set jumping to true
            if (jumping)
            {
                jumping = false;
            }
            // call wall
            Wall();
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            // call wall
            Wall();

            // continously drop player towards the platform (the ground)
            player.Top += jumpSpeed;

            // if jumping and force is less than 0, create a gravity effect
            if (jumping && force < 0)
            {
                // make jumping false
                jumping = false;
            }

            if (goleft)
            {
                // push character towards left of screen
                player.Left -= 5;
            }

            if (goright)
            {
                // push character towards right of screen
                player.Left += 5;
            }

            if (jumping)
            {
                // set force to 1, jumpspeed to -12
                jumpSpeed = -12;
                force -= 1;
            }
            // if it's not jumping set speed to 12
            else
            {
                jumpSpeed = 12;
            }

            // look through whole form to find picture boxes that player interacts with, in order to land on top of it.
            foreach (Control x in this.Controls)
            {
                // continue if x is a picturebox and the tag equals to the platform
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        // set force to 8, and player is going to be above the platform
                        force = 8;
                        player.Top = x.Top - player.Height;

                    }
                }

                // if x is a picture box and tag is coin, continue
                if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {

                        // assign url
                        wmpChime.URL = "Sounds/chime.wav";

                        // Play the sound
                        wmpChime.Ctlcontrols.play();

                        // increment the score
                        score++;

                        // display the score
                        lblScore.Text = "Score: " + score;

                        // remove the coin
                        this.Controls.Remove(x);
                    }
                }

                // if player touches the door, stop timer and display you win
                if (player.Bounds.IntersectsWith(picDoor.Bounds))
                {
                    // stop timers
                    tmrTimer.Stop();
                    tmrCountdown.Stop();

                    // assign url
                    wmpDoor.URL = "Sounds/clink.mp3";

                    // Play the sound
                    wmpDoor.Ctlcontrols.play();

                    // Call Show Win
                    ShowWinLose();

                    // Call image to front
                    ImageToFront();

                }
            }
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {

            // decrease the number of seconds by 1
            totalSeconds = totalSeconds - 1;
            timeLeft = totalSeconds;

            // display the time left
            lblTimer.Text = "Time Left: " + timeLeft;

            // Call update lives
            UpdateLives();

        }

        private void UpdateLives()
        {
            // remove a life if total seconds is 0
            if (totalSeconds == 0)
            {
                if (lives == 3)
                {
                    // remove a life
                    lives = lives - 1;

                    // display lives
                    picHeart1.Show();
                    picHeart2.Show();
                    picHeart3.Hide();

                    // call lose life sound
                    LoseLifeSound();

                    // call reset time
                    ResetTime();
                }
                else if (lives == 2)
                {
                    // remove a life
                    lives = lives - 1;

                    // display lives
                    picHeart1.Show();
                    picHeart2.Hide();
                    picHeart3.Hide();

                    // call lose life sound
                    LoseLifeSound();

                    // call reset time
                    ResetTime();
                }
                else
                {

                    // remove a life
                    lives = lives - 1;

                    // call lose life sound
                    LoseLifeSound();

                    // stop time
                    tmrTimer.Stop();
                    tmrCountdown.Stop();

                    // display lives
                    picHeart1.Hide();
                    picHeart2.Hide();
                    picHeart3.Hide();

                    // Call Image to Front
                    ImageToFront();

                    // call reset time
                    ResetTime();

                    // new stuff
                    lives = 3;

                    // close this form and open instructions form
                    this.Hide();
                    var LoseScreen = new frmLose();
                    LoseScreen.Closed += (s, args) => this.Close();
                    LoseScreen.Show();
                }
            }
        }

        private void LoseLifeSound()
        {
            // assign url
            wmpLoseLife.URL = "Sounds/quack.mp3";

            // Play the sound
            wmpLoseLife.Ctlcontrols.play();
        }

        private void ImageToFront()
        {
            // Bring images to the front 
            btnNext.BringToFront();
        }
        private void ResetTime()
        {
            // reset time
            totalSeconds = 6;
            timeLeft = 5;
        }

        private void BtnLevel2_Click(object sender, EventArgs e)
        {
            // close this form and open win screen
            this.Hide();
            var WinScreen = new frmWin();
            WinScreen.Closed += (s, args) => this.Close();
            WinScreen.Show();
        }

        private void Wall()
        {
            // if player intersects with either wall, it will not allows the user to pass through the wall.
            if ((player).Bounds.IntersectsWith(wall1.Bounds))
            {
                player.Left = 414;
            }

            // if player intersects with either wall, it will not allows the user to pass through the wall.
            if ((player).Bounds.IntersectsWith(wall2.Bounds))
            {
                player.Left = 12;
            }
        }
    }
}
