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
    public partial class frmLevel1 : Form
    {
        // declare variables and set bool variables 
        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        int jumpSpeed = 10;
        int force = 5;
        int score = 0;

        // declare variables for lives
        int lives = 3;

        // declare variables for timer
        int totalSeconds = 6;
        int timeLeft = 5;
 
        public frmLevel1()
        {
            InitializeComponent();

            //** MAKE SURE TO UNHIDE ALL OBJECTS LOL

            // hide pictures, labels
            //lblPoints.Hide();
            //btnLevel2.Hide();
            //picWinLoseScreen.Hide();
            //picWin.Hide();
            //btnRestart.Hide();
            //picLoseScreen.Hide();
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
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
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

                        // increment points
                        score = score++;

                    }
                }

                if (x is PictureBox && x.Tag == "coin")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }

                // if player touches the door, stop timer and display you win
                if (picPlayer.Bounds.IntersectsWith(picDoor.Bounds))
                {
                    // stop timers
                    tmrTimer.Stop();
                    tmrCountdown.Stop();

                    // close this form and open win screen
                    this.Hide();
                    var WinScreen = new frmWin();
                    WinScreen.Closed += (s, args) => this.Close();
                    WinScreen.Show();

                    // Show pictures, buttons, images
                    btnLevel2.Show();
                    picWin.Show();
                    picWinLoseScreen.Show();
                    lblPoints.Show();

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
            lblTimer.Text = "Time Left:" + timeLeft;

            // remove a life if total seconds is 0
            if (totalSeconds <= 0)
            {
                if (lives == 3)
                {
                    // remove a life
                    lives = lives - 1;

                    // display lives
                    picHeart1.Show();
                    picHeart2.Show();
                    picHeart3.Hide();

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

                    // call reset time
                    ResetTime();
                }
                else
                {
                    // stop time
                    tmrTimer.Stop();
                    tmrCountdown.Stop();

                    // remove a life
                    lives = lives - 1;

                    // Show pictures, boxes, labels
                    //lblPoints.Show();
                    //picWinLoseScreen.Show();
                    //btnRestart.Show();
                    //picLoseScreen.Show();

                    // Call Image to Front
                    ImageToFront();

                    // display lives
                    picHeart1.Hide();
                    picHeart2.Hide();
                    picHeart3.Hide();

                    // Go to the You Lose Form


                }
            }
        }

        private void ImageToFront()
        {
            // Bring images to the front 
            picLoseScreen.BringToFront();
            btnRestart.BringToFront();
            lblPoints.BringToFront();
            picWinLoseScreen.BringToFront();
            btnLevel2.BringToFront();
        }
        private void ResetTime()
        {
            // reset time
            totalSeconds = 6;
            timeLeft = 5;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Restart Application
            Application.Restart();
        }

        // need splash screen, 
        // error with win screen, loads multiple times... idk why...
        // instructions screen
        // extra added countdown timer... point system ... 
        // might think about it 
        // exit button, new game button...
        // if have time extra level w/ different backgrounds.
    }
}
