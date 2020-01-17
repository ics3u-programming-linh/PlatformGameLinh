using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformGameLinh
{
    public partial class frmLevel2 : Form
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
        int totalSeconds = 16;
        int timeLeft = 15;

        public frmLevel2()
        {
            InitializeComponent();
            // call hide objects
            HideWinLose();
            Wall();
        }

        private void ShowWinLose()
        {
            // Show pictures, buttons, images
            btnNext.Show();
        }

        private void HideWinLose()
        {
            // hide pictures, labels
            btnNext.Hide();
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

            // call wall
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

        private void TmrTimer_Tick(object sender, EventArgs e)
        {

            // call wall
            Wall();

            // continously drop player towards the platform (the ground)
            picPlayer.Top += jumpSpeed;

            // if jumping and force is less than 0, create a gravity effect
            if (jumping && force < 0)
            {
                // make jumping false
                jumping = false;
            }

            if (goleft)
            {
                // push character towards left of screen
                picPlayer.Left -= 5;
            }

            if (goright)
            {
                // push character towards right of screen
                picPlayer.Left += 5;
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
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        // set force to 8, and player is going to be above the platform
                        force = 8;
                        picPlayer.Top = x.Top - picPlayer.Height;

                    }
                }
            
                // if x is a picture box and tag is coin, continue
                if (x is PictureBox && x.Tag == "coin")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && !jumping)
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
            
                // if player touches the sad face, lose a life
                if (x is PictureBox && x.Tag == "sad")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        // remove lives
                        lives = lives - 1;

                        // play lose sound
                        LoseLifeSound();

                        // decrease the score
                        score--;

                        // display the score
                        lblScore.Text = "Score: " + score;

                        // remove the coin
                        this.Controls.Remove(x);

                        if (lives == 3)
                        {
                            picHeart1.Show();
                            picHeart2.Show();
                            picHeart3.Show();
                        }
                        else if (lives == 2)
                        {
                            // display 2 lives
                            picHeart1.Show();
                            picHeart2.Show();
                            picHeart3.Hide();
                        }
                        else if (lives == 1)
                        { 
                            // display 1 life
                            picHeart1.Show();
                            picHeart2.Hide();
                            picHeart3.Hide();
                        }
                        else
                        {
                            // display no lives
                            picHeart1.Hide();
                            picHeart2.Hide();
                            picHeart3.Hide();

                            // Stop timer
                            tmrTimer.Stop();
                            tmrCountdown.Stop();

                            // close this form and open lose form
                            this.Hide();
                            var LoseScreen = new frmLose();
                            LoseScreen.Closed += (s, args) => this.Close();
                            LoseScreen.Show();
                        }

                    }
                }
            
                // if player touches the door, stop timer and display you win
                if (picPlayer.Bounds.IntersectsWith(picDoor.Bounds))
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

        private void TmrCountdown_Tick(object sender, EventArgs e)
        {
            // Call Update Time
            UpdateTime();
        }
    
        private void UpdateTime()
        {

            // decrease the number of seconds by 1
            totalSeconds = totalSeconds - 1;
            timeLeft = totalSeconds;

            // display the time left
            lblTimer.Text = "Time Left: " + timeLeft;

            // remove a life if total seconds is 0
            if (totalSeconds == 0)
            {
                // remove a life
                lives = lives - 1;

                // call lose life sound
                LoseLifeSound();

                if (lives == 2)
                {
                    // display lives
                    picHeart1.Show();
                    picHeart2.Show();
                    picHeart3.Hide();

                    // Call reset time
                    ResetTime();
                }
                else if (lives == 1)
                {
                    // display lives
                    picHeart1.Show();
                    picHeart2.Hide();
                    picHeart3.Hide();

                    // Call reset time
                    ResetTime();
                }
                else 
                {
                    // stop time
                    tmrTimer.Stop();
                    tmrCountdown.Stop();

                    // Call Image to Front
                    ImageToFront();

                    // display lives
                    picHeart1.Hide();
                    picHeart2.Hide();
                    picHeart3.Hide();

                    // close this form and open lose form
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
            totalSeconds = 16;
            timeLeft = 15;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // close this form and open win screen
            this.Hide();
            var WinScreen = new frmWin2();
            WinScreen.Closed += (s, args) => this.Close();
            WinScreen.Show();
        }

        private void Wall()
        {
            // moves player to the other side
            if ((picPlayer).Bounds.IntersectsWith(wall1.Bounds))
            {
                picPlayer.Left = 414;
            }

            // moves player to the other side
            if ((picPlayer).Bounds.IntersectsWith(wall2.Bounds))
            {
                picPlayer.Left = 12;
            }
        }

    }
}
