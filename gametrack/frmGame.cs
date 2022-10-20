using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace gametrack
{
    public partial class frmGame : Form
    {
        #region Class defined Variables

        #region Player Data
        // Players - Wins
        int p1w = 0;
        int p2w = 0;
        int p3w = 0;
        int p4w = 0;
        int p5w = 0;
        int p6w = 0;
        int p7w = 0;
        int p8w = 0;
        int p9w = 0;
        int p10w = 0;

        // Players - Losses
        int p1l = 0;
        int p2l = 0;
        int p3l = 0;
        int p4l = 0;
        int p5l = 0;
        int p6l = 0;
        int p7l = 0;
        int p8l = 0;
        int p9l = 0;
        int p10l = 0;

        // Player count
        int pCount = 0;

        #endregion

        DateTime start = DateTime.Now;
        DateTime startTime;

        #endregion

        #region Player Properties
        private void cbPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer1.Checked == true)
            {
                txtP1Name.Enabled = true;
                lblPlayer1.Visible = true;
                lblP1Win.Visible = true;
                lblP1Loss.Visible = true;
                btnP1WinAdd.Visible = true;
                btnP1LossAdd.Visible = true;
                btnP1Remove.Visible = true;
                pCount = pCount + 1;
            }
            else
            {
                txtP1Name.Enabled = false;
                lblPlayer1.Visible = false;
                lblP1Win.Visible = false;
                lblP1Loss.Visible = false;
                btnP1WinAdd.Visible = false;
                btnP1LossAdd.Visible = false;
                btnP1Remove.Visible = false;
                pCount = pCount - 1;
            }
        }

        private void cbPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer2.Checked == true)
            {
                txtP2Name.Enabled = true;
                lblPlayer2.Visible = true;
                lblP2Win.Visible = true;
                lblP2Loss.Visible = true;
                btnP2WinAdd.Visible = true;
                btnP2LossAdd.Visible = true;
                btnP2Remove.Visible = true;
                pCount = pCount + 1;
            }
            else
            {
                txtP2Name.Enabled = false;
                lblPlayer2.Visible = false;
                lblP2Win.Visible = false;
                lblP2Loss.Visible = false;
                btnP2WinAdd.Visible = false;
                btnP2LossAdd.Visible = false;
                btnP2Remove.Visible = false;
                pCount = pCount - 1;
            }
        }

        private void cbPlayer3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer3.Checked == true)
            {
                txtP3Name.Enabled = true;
                lblPlayer3.Visible = true;
                lblP3Win.Visible = true;
                lblP3Loss.Visible = true;
                btnP3WinAdd.Visible = true;
                btnP3LossAdd.Visible = true;
                btnP3Remove.Visible = true;
                pCount = pCount + 1;
            }
            else
            {
                txtP3Name.Enabled = false;
                lblPlayer3.Visible = false;
                lblP3Win.Visible = false;
                lblP3Loss.Visible = false;
                btnP3WinAdd.Visible = false;
                btnP3LossAdd.Visible = false;
                btnP3Remove.Visible = false;
                pCount = pCount - 1;
            }
        }

        private void cbPlayer4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer4.Checked == true)
            {
                txtP4Name.Enabled = true;
                lblPlayer4.Visible = true;
                lblP4Win.Visible = true;
                lblP4Loss.Visible = true;
                btnP4WinAdd.Visible = true;
                btnP4LossAdd.Visible = true;
                btnP4Remove.Visible = true;
                pCount = pCount + 1;
            }
            else
            {
                txtP4Name.Enabled = false;
                lblPlayer4.Visible = false;
                lblP4Win.Visible = false;
                lblP4Loss.Visible = false;
                btnP4WinAdd.Visible = false;
                btnP4LossAdd.Visible = false;
                btnP4Remove.Visible = false;
                pCount = pCount - 1;
            }
        }

        private void cbPlayer5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer5.Checked == true)
            {
                txtP5Name.Enabled = true;
                lblPlayer5.Visible = true;
                lblP5Win.Visible = true;
                lblP5Loss.Visible = true;
                btnP5WinAdd.Visible = true;
                btnP5LossAdd.Visible = true;
                btnP5Remove.Visible = true;
                pCount = pCount + 1;
            }
            else
            {
                txtP5Name.Enabled = false;
                lblPlayer5.Visible = false;
                lblP5Win.Visible = false;
                lblP5Loss.Visible = false;
                btnP5WinAdd.Visible = false;
                btnP5LossAdd.Visible = false;
                btnP5Remove.Visible = false;
                pCount = pCount - 1;
            }
        }

        private void cbPlayer6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer6.Checked == true)
            {
                txtP6Name.Enabled = true;
                lblPlayer6.Visible = true;
                lblP6Win.Visible = true;
                lblP6Loss.Visible = true;
                btnP6WinAdd.Visible = true;
                btnP6LossAdd.Visible = true;
                btnP6Remove.Visible = true;
                pCount = pCount + 1;
            }
            else
            {
                txtP6Name.Enabled = false;
                lblPlayer6.Visible = false;
                lblP6Win.Visible = false;
                lblP6Loss.Visible = false;
                btnP6WinAdd.Visible = false;
                btnP6LossAdd.Visible = false;
                btnP6Remove.Visible = false;
                pCount = pCount - 1;
            }
        }

        private void cbPlayer7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer7.Checked == true)
            {
                txtP7Name.Enabled = true;
                lblPlayer7.Visible = true;
                lblP7Win.Visible = true;
                lblP7Loss.Visible = true;
                btnP7WinAdd.Visible = true;
                btnP7LossAdd.Visible = true;
                btnP7Remove.Visible = true;
                pCount = pCount + 1;
            }
            else
            {
                txtP7Name.Enabled = false;
                lblPlayer7.Visible = false;
                lblP7Win.Visible = false;
                lblP7Loss.Visible = false;
                btnP7WinAdd.Visible = false;
                btnP7LossAdd.Visible = false;
                btnP7Remove.Visible = false;
                pCount = pCount - 1;
            }
        }

        private void cbPlayerx8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer8.Checked == true)
            {
                txtP8Name.Enabled = true;
                lblPlayer8.Visible = true;
                lblP8Win.Visible = true;
                lblP8Loss.Visible = true;
                btnP8WinAdd.Visible = true;
                btnP8LossAdd.Visible = true;
                btnP8Remove.Visible = true;
                pCount = pCount + 1;
            }
            else
            {
                txtP8Name.Enabled = false;
                lblPlayer8.Visible = false;
                lblP8Win.Visible = false;
                lblP8Loss.Visible = false;
                btnP8WinAdd.Visible = false;
                btnP8LossAdd.Visible = false;
                btnP8Remove.Visible = false;
                pCount = pCount - 1;
            }
        }

        private void cbPlayer9_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer9.Checked == true)
            {
                txtP9Name.Enabled = true;
                lblPlayer9.Visible = true;
                lblP9Win.Visible = true;
                lblP9Loss.Visible = true;
                btnP9WinAdd.Visible = true;
                btnP9LossAdd.Visible = true;
                btnP9Remove.Visible = true;
                pCount = pCount + 1;
            }
            else
            {
                txtP9Name.Enabled = false;
                lblPlayer9.Visible = false;
                lblP9Win.Visible = false;
                lblP9Loss.Visible = false;
                btnP9WinAdd.Visible = false;
                btnP9LossAdd.Visible = false;
                btnP9Remove.Visible = false;
                pCount = pCount - 1;
            }
        }

        private void cbPlayer10_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayer10.Checked == true)
            {
                txtP10Name.Enabled = true;
                lblPlayer10.Visible = true;
                lblP10Win.Visible = true;
                lblP10Loss.Visible = true;
                btnP10WinAdd.Visible = true;
                btnP10LossAdd.Visible = true;
                btnP10Remove.Visible = true;
                pCount = pCount + 1;
            }
            else
            {
                txtP10Name.Enabled = false;
                lblPlayer10.Visible = false;
                lblP10Win.Visible = false;
                lblP10Loss.Visible = false;
                btnP10WinAdd.Visible = false;
                btnP10LossAdd.Visible = false;
                btnP10Remove.Visible = false;
                pCount = pCount - 1;
            }
        }
        #endregion

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            lblGameName.Text = "Game: " + frmStart.GameName.ToString();
            lblEvent.Text = "Event: " + frmStart.Event.ToString();
            lblPlayers.Text = "Players: " + frmStart.playerAmt.ToString();

            #region Player Amount Data

            switch (frmStart.playerAmt)
            {
                case 1:
                    cbPlayer1.Enabled = true;
                    break;
                case 2:
                    cbPlayer1.Enabled = true;
                    cbPlayer2.Enabled = true;

                    break;
                case 3:
                    cbPlayer1.Enabled = true;
                    cbPlayer2.Enabled = true;
                    cbPlayer3.Enabled = true;

                    break;
                case 4:
                    cbPlayer1.Enabled = true;
                    cbPlayer2.Enabled = true;
                    cbPlayer3.Enabled = true;
                    cbPlayer4.Enabled = true;

                    break;
                case 5:
                    cbPlayer1.Enabled = true;
                    cbPlayer2.Enabled = true;
                    cbPlayer3.Enabled = true;
                    cbPlayer4.Enabled = true;
                    cbPlayer5.Enabled = true;

                    break;
                case 6:
                    cbPlayer1.Enabled = true;
                    cbPlayer2.Enabled = true;
                    cbPlayer3.Enabled = true;
                    cbPlayer4.Enabled = true;
                    cbPlayer5.Enabled = true;
                    cbPlayer6.Enabled = true;

                    break;
                case 7:
                    cbPlayer1.Enabled = true;
                    cbPlayer2.Enabled = true;
                    cbPlayer3.Enabled = true;
                    cbPlayer4.Enabled = true;
                    cbPlayer5.Enabled = true;
                    cbPlayer6.Enabled = true;
                    cbPlayer7.Enabled = true;

                    break;
                case 8:
                    cbPlayer1.Enabled = true;
                    cbPlayer2.Enabled = true;
                    cbPlayer3.Enabled = true;
                    cbPlayer4.Enabled = true;
                    cbPlayer5.Enabled = true;
                    cbPlayer6.Enabled = true;
                    cbPlayer7.Enabled = true;
                    cbPlayer8.Enabled = true;

                    break;
                case 9:
                    cbPlayer1.Enabled = true;
                    cbPlayer2.Enabled = true;
                    cbPlayer3.Enabled = true;
                    cbPlayer4.Enabled = true;
                    cbPlayer5.Enabled = true;
                    cbPlayer6.Enabled = true;
                    cbPlayer7.Enabled = true;
                    cbPlayer8.Enabled = true;
                    cbPlayer9.Enabled = true;
                    break;
                case 10:
                    cbPlayer1.Enabled = true;
                    cbPlayer2.Enabled = true;
                    cbPlayer3.Enabled = true;
                    cbPlayer4.Enabled = true;
                    cbPlayer5.Enabled = true;
                    cbPlayer6.Enabled = true;
                    cbPlayer7.Enabled = true;
                    cbPlayer8.Enabled = true;
                    cbPlayer9.Enabled = true;
                    cbPlayer10.Enabled = true;

                    break;
            }
            #endregion
        }

        private void AddWin(int playerNo)
        {
            // Input    -> Process ->     Output
            // playerNo -> pXw     -> pXw = pXw + 1

            switch (playerNo)
            {
                // Player 1
                case 1:
                    p1w = p1w + 1;
                    break;

                // Player 2
                case 2:
                    p2w = p2w + 1;
                    break;

                // Player 3
                case 3:
                    p3w = p3w + 1;
                    break;

                // Player 4
                case 4:
                    p4w = p4w + 1;
                    break;

                // Player 5
                case 5:
                    p5w = p5w + 1;
                    break;

                // Player 6
                case 6:
                    p6w = p6w + 1;
                    break;

                // Player 7
                case 7:
                    p7w = p7w + 1;
                    break;

                // Player 8
                case 8:
                    p8w = p8w + 1;
                    break;

                // Player 9
                case 9:
                    p9w = p9w + 1;
                    break;

                // Player 10
                case 10:
                    p10w = p10w + 1;
                    break;
            }

        }

        private void AddLoss(int playerNo)
        {
            // Input    -> Process ->     Output
            // playerNo -> pXw     -> pXw = pXw + 1

            switch (playerNo)
            {
                // Player 1
                case 1:
                    p1l = p1l + 1;
                    break;

                // Player 2
                case 2:
                    p2l = p2l + 1;
                    break;

                // Player 3
                case 3:
                    p3l = p3l + 1;
                    break;

                // Player 4
                case 4:
                    p4l = p4l + 1;
                    break;

                // Player 5
                case 5:
                    p5l = p5l + 1;
                    break;

                // Player 6
                case 6:
                    p6l = p6l + 1;
                    break;

                // Player 7
                case 7:
                    p7l = p7l + 1;
                    break;

                // Player 8
                case 8:
                    p8l = p8l + 1;
                    break;

                // Player 9
                case 9:
                    p9l = p9l + 1;
                    break;

                // Player 10
                case 10:
                    p10l = p10l + 1;
                    break;
            }

        }

        #region Add/Lose Buttons
        private void btnP1WinAdd_Click(object sender, EventArgs e)
        {
            AddWin(1);
            lblP1Win.Text = p1w.ToString();
        }

        private void btnP1LossAdd_Click(object sender, EventArgs e)
        {
            AddLoss(1);
            lblP1Loss.Text = p1l.ToString();
        }

        private void btnP2WinAdd_Click(object sender, EventArgs e)
        {
            AddWin(2);
            lblP2Win.Text = p2w.ToString();
        }

        private void btnP2LossAdd_Click(object sender, EventArgs e)
        {
            AddLoss(2);
            lblP2Loss.Text = p2l.ToString();
        }

        private void btnP3WinAdd_Click(object sender, EventArgs e)
        {
            AddWin(3);
            lblP3Win.Text = p3w.ToString();
        }

        private void btnP3LossAdd_Click(object sender, EventArgs e)
        {
            AddLoss(3);
            lblP3Loss.Text = p3l.ToString();
        }

        private void btnP4WinAdd_Click(object sender, EventArgs e)
        {
            AddWin(4);
            lblP4Win.Text = p4w.ToString();
        }

        private void btnP4LossAdd_Click(object sender, EventArgs e)
        {
            AddLoss(4);
            lblP4Loss.Text = p4l.ToString();
        }

        private void btnP5WinAdd_Click(object sender, EventArgs e)
        {
            AddWin(5);
            lblP5Win.Text = p5w.ToString();
        }

        private void btnP5LossAdd_Click(object sender, EventArgs e)
        {
            AddLoss(5);
            lblP5Loss.Text = p5l.ToString();
        }

        private void btnP6WinAdd_Click(object sender, EventArgs e)
        {
            AddWin(6);
            lblP6Win.Text = p6w.ToString();
        }

        private void btnP6LossAdd_Click(object sender, EventArgs e)
        {
            AddLoss(6);
            lblP6Loss.Text = p6l.ToString();
        }

        private void btnP7WinAdd_Click(object sender, EventArgs e)
        {
            AddWin(7);
            lblP7Win.Text = p7w.ToString();
        }

        private void btnP7LossAdd_Click(object sender, EventArgs e)
        {
            AddLoss(7);
            lblP7Loss.Text = p7l.ToString();
        }

        private void btnP8WinAdd_Click(object sender, EventArgs e)
        {
            AddWin(8);
            lblP8Win.Text = p8w.ToString();
        }

        private void btnP8LossAdd_Click(object sender, EventArgs e)
        {
            AddLoss(8);
            lblP8Loss.Text = p8l.ToString();
        }

        private void btnP9WinAdd_Click(object sender, EventArgs e)
        {
            AddWin(9);
            lblP9Win.Text = p9w.ToString();
        }

        private void btnP9LossAdd_Click(object sender, EventArgs e)
        {
            AddLoss(9);
            lblP9Loss.Text = p9l.ToString();
        }

        private void btnP10WinAdd_Click(object sender, EventArgs e)
        {
            AddWin(10);
            lblP10Win.Text = p10w.ToString();
        }

        private void btnP10LossAdd_Click(object sender, EventArgs e)
        {
            AddLoss(10);
            lblP10Loss.Text = p10l.ToString();
        }
        #endregion

        #region Remove Players
        public void removePlayer(int playerNo)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this player?", "Remove Player", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                switch (playerNo)
                {
                    case 1:
                        btnP1WinAdd.Enabled = false;
                        btnP1LossAdd.Enabled = false;
                        pCount = pCount - 1;
                        break;

                    case 2:
                        btnP2WinAdd.Enabled = false;
                        btnP2LossAdd.Enabled = false;
                        pCount = pCount - 1;
                        break;

                    case 3:
                        btnP3WinAdd.Enabled = false;
                        btnP3LossAdd.Enabled = false;
                        pCount = pCount - 1;
                        break;

                    case 4:
                        btnP4WinAdd.Enabled = false;
                        btnP4LossAdd.Enabled = false;
                        pCount = pCount - 1;
                        break;

                    case 5:
                        btnP5WinAdd.Enabled = false;
                        btnP5LossAdd.Enabled = false;
                        pCount = pCount - 1;
                        break;

                    case 6:
                        btnP6WinAdd.Enabled = false;
                        btnP6LossAdd.Enabled = false;
                        pCount = pCount - 1;
                        break;

                    case 7:
                        btnP7WinAdd.Enabled = false;
                        btnP7LossAdd.Enabled = false;
                        pCount = pCount - 1;
                        break;

                    case 8:
                        btnP8WinAdd.Enabled = false;
                        btnP8LossAdd.Enabled = false;
                        pCount = pCount - 1;
                        break;

                    case 9:
                        btnP9WinAdd.Enabled = false;
                        btnP9LossAdd.Enabled = false;
                        pCount = pCount - 1;
                        break;

                    case 10:
                        btnP10WinAdd.Enabled = false;
                        btnP10LossAdd.Enabled = false;
                        pCount = pCount - 1;
                        break;
                }
            }
            else
            {
                // do nothing i guess! :D
            }
        }

     
        private void btnP1Remove_Click(object sender, EventArgs e)
        {
            removePlayer(1);
            lblP1Removed.Text = "REMOVED";
            btnP1Remove.Enabled = false;
        }

        private void btnP2Remove_Click(object sender, EventArgs e)
        {
            removePlayer(2);
            lblP2Removed.Text = "REMOVED";
            btnP2Remove.Enabled = false;
        }

        private void btnP3Remove_Click(object sender, EventArgs e)
        {
            removePlayer(3);
            lblP3Removed.Text = "REMOVED";
            btnP3Remove.Enabled = false;
        }

        private void btnP4Remove_Click(object sender, EventArgs e)
        {
            removePlayer(4);
            lblP4Removed.Text = "REMOVED";
            btnP4Remove.Enabled = false;
        }

        private void btnP5Remove_Click(object sender, EventArgs e)
        {
            removePlayer(5);
            lblP5Removed.Text = "REMOVED";
            btnP5Remove.Enabled = false;
        }

        private void btnP6Remove_Click(object sender, EventArgs e)
        {
            removePlayer(6);
            lblP6Removed.Text = "REMOVED";
            btnP6Remove.Enabled = false;
        }

        private void btnP7Remove_Click(object sender, EventArgs e)
        {
            removePlayer(7);
            lblP7Removed.Text = "REMOVED";
            btnP7Remove.Enabled = false;
        }

        private void btnP8Remove_Click(object sender, EventArgs e)
        {
            removePlayer(8);
            lblP8Removed.Text = "REMOVED";
            btnP8Remove.Enabled = false;
        }

        private void btnP9Remove_Click(object sender, EventArgs e)
        {
            removePlayer(9);
            lblP9Removed.Text = "REMOVED";
            btnP9Remove.Enabled = false;
        }

        private void btnP10Remove_Click(object sender, EventArgs e)
        {
            removePlayer(10);
            lblP10Removed.Text = "REMOVED";
            btnP10Remove.Enabled = false;
        }

        #endregion

        private void drawHTMLFile()
        {
            StringWriter s = new StringWriter();
            lblPlaytime.Text.Remove(9);

            // header
            txtHTML.AppendText("<html>");
            txtHTML.AppendText("<head>");
            txtHTML.AppendText("       <title> RoflCorp Game Track </title> ");
            txtHTML.AppendText("</head");

            // body
            txtHTML.AppendText("<body>");
            txtHTML.AppendText("<h1 align=center> RoflCorp Game Track </h1> </br>"); // H1 Header
            txtHTML.AppendText("<h2 align=center> " + lblEvent.Text + "</h2> </br>"); // Event Name
            txtHTML.AppendText("Game started at: " + startTime + "</br>"); // Start Time
            txtHTML.AppendText("Game ended at: " + DateTime.Now + "</br>");
            txtHTML.AppendText("Played " + lblGameName.Text + "</br>"); // Game that was played 
            txtHTML.AppendText("Total  " + lblPlaytime.Text + "</br>"); // Total Play time
            txtHTML.AppendText("Total " + lblPlayers.Text + "</br> </br>"); // Total Players
            txtHTML.AppendText("Players: </br> </br>"); // Player list (PNAME - W - L - REMOVED)
            txtHTML.AppendText("Player 1: " + "<b>" + lblPlayer1.Text + "</b>" + " -- Win: " + lblP1Win.Text + " Lose: " + lblP1Loss.Text + " -- " + lblP1Removed.Text + "</br>");
            txtHTML.AppendText("Player 2: " + "<b>" + lblPlayer2.Text + "</b>" + " -- Win: " + lblP2Win.Text + " Lose: " + lblP2Loss.Text + " -- " + lblP2Removed.Text + "</br>");
            txtHTML.AppendText("Player 3: " + "<b>" + lblPlayer3.Text + "</b>" + " -- Win: " + lblP3Win.Text + " Lose: " + lblP3Loss.Text + " -- " + lblP3Removed.Text + "</br>");
            txtHTML.AppendText("Player 4: " + "<b>" + lblPlayer4.Text + "</b>" + " -- Win: " + lblP4Win.Text + " Lose: " + lblP4Loss.Text + " -- " + lblP4Removed.Text + "</br>");
            txtHTML.AppendText("Player 5: " + "<b>" + lblPlayer5.Text + "</b>" + " -- Win: " + lblP5Win.Text + " Lose: " + lblP5Loss.Text + " -- " + lblP5Removed.Text + "</br>");
            txtHTML.AppendText("Player 6: " + "<b>" + lblPlayer6.Text + "</b>" + " -- Win: " + lblP6Win.Text + " Lose: " + lblP6Loss.Text + " -- " + lblP6Removed.Text + "</br>");
            txtHTML.AppendText("Player 7: " + "<b>" + lblPlayer7.Text + "</b>" + " -- Win: " + lblP7Win.Text + " Lose: " + lblP7Loss.Text + " --  " + lblP7Removed.Text + "</br>");
            txtHTML.AppendText("Player 8: " + "<b>" + lblPlayer8.Text + "</b>" + " -- Win: " + lblP8Win.Text + " Lose: " + lblP8Loss.Text + " -- " + lblP8Removed.Text + "</br>");
            txtHTML.AppendText("Player 9: " + "<b>" + lblPlayer9.Text + "</b>" + " -- Win: " + lblP9Win.Text + " Lose: " + lblP9Loss.Text + " -- " + lblP9Removed.Text + "</br>");
            txtHTML.AppendText("Player 10: " + "<b>" + lblPlayer10.Text + "</b>" + "-- Win: " + lblP10Win.Text + " Lose: " + lblP10Loss.Text + " -- " + lblP10Removed.Text + "</br>");
            txtHTML.AppendText("</br> </br>");
            txtHTML.AppendText("Host OS: " + Environment.OSVersion + "</br>"); // Operating System Version
            txtHTML.AppendText("Game Track Version: " + Application.ProductVersion + "</br></br"); // Game Track Version
            txtHTML.AppendText("</body> </html>");

           

        }

        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Clear Data

        private void clearData()
        {
            btnStartGame.Enabled = true;

            // Win Data
            lblP1Win.Text = "0";
            lblP2Win.Text = "0";
            lblP3Win.Text = "0";
            lblP4Win.Text = "0";
            lblP5Win.Text = "0";
            lblP6Win.Text = "0";
            lblP7Win.Text = "0";
            lblP8Win.Text = "0";
            lblP9Win.Text = "0";
            lblP10Win.Text = "0";

            // Lose Data
            lblP1Loss.Text = "0";
            lblP2Loss.Text = "0";
            lblP3Loss.Text = "0";
            lblP4Loss.Text = "0";
            lblP5Loss.Text = "0";
            lblP6Loss.Text = "0";
            lblP7Loss.Text = "0";
            lblP8Loss.Text = "0";
            lblP9Loss.Text = "0";
            lblP10Loss.Text = "0";

            // Players
            lblPlayer1.Text = "";
            lblPlayer2.Text = "";
            lblPlayer3.Text = "";
            lblPlayer4.Text = "";
            lblPlayer5.Text = "";
            lblPlayer6.Text = "";
            lblPlayer7.Text = "";
            lblPlayer8.Text = "";
            lblPlayer9.Text = "";
            lblPlayer10.Text = "";

            // Buttons
            btnP1WinAdd.Enabled = false;
            btnP2WinAdd.Enabled = false;
            btnP3WinAdd.Enabled = false;
            btnP4WinAdd.Enabled = false;
            btnP5WinAdd.Enabled = false;
            btnP6WinAdd.Enabled = false;
            btnP7WinAdd.Enabled = false;
            btnP8WinAdd.Enabled = false;
            btnP9WinAdd.Enabled = false;
            btnP10WinAdd.Enabled = false;
            btnP1LossAdd.Enabled = false;
            btnP2LossAdd.Enabled = false;
            btnP3LossAdd.Enabled = false;
            btnP4LossAdd.Enabled = false;
            btnP5LossAdd.Enabled = false;
            btnP6LossAdd.Enabled = false;
            btnP7LossAdd.Enabled = false;
            btnP8LossAdd.Enabled = false;
            btnP9LossAdd.Enabled = false;
            btnP10LossAdd.Enabled = false;
            btnEndGame.Enabled = false;
            btnP1Remove.Enabled = false;
            btnP2Remove.Enabled = false;
            btnP3Remove.Enabled = false;
            btnP4Remove.Enabled = false;
            btnP5Remove.Enabled = false;
            btnP6Remove.Enabled = false;
            btnP7Remove.Enabled = false;
            btnP8Remove.Enabled = false;
            btnP9Remove.Enabled = false;
            btnP10Remove.Enabled = false;

            // Text Boxes
            txtP1Name.Text = "";
            txtP2Name.Text = "";
            txtP3Name.Text = "";
            txtP4Name.Text = "";
            txtP5Name.Text = "";
            txtP6Name.Text = "";
            txtP7Name.Text = "";
            txtP8Name.Text = "";
            txtP9Name.Text = "";
            txtP10Name.Text = "";

            // Labels
            lblP1Removed.Text = "";
            lblP2Removed.Text = "";
            lblP3Removed.Text = "";
            lblP4Removed.Text = "";
            lblP5Removed.Text = "";
            lblP6Removed.Text = "";
            lblP7Removed.Text = "";
            lblP8Removed.Text = "";
            lblP9Removed.Text = "";
            lblP10Removed.Text = "";

            // Check boxes
            cbPlayer1.Checked = false;
            cbPlayer2.Checked = false;
            cbPlayer3.Checked = false;
            cbPlayer4.Checked = false;
            cbPlayer5.Checked = false;
            cbPlayer6.Checked = false;
            cbPlayer7.Checked = false;
            cbPlayer8.Checked = false;
            cbPlayer9.Checked = false;
            cbPlayer10.Checked = false;

        }

        #endregion

        #region Buttons

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Check if there is players
            if (pCount < 1)
            {
                MessageBox.Show("You require atleast one player!", "Require a player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStartGame.Enabled = true;
            }
            else // There are players, continue
            {
                string playcount = Convert.ToString(pCount);
                btnEndGame.Enabled = true;
                lblPlayerCount.Text = "Total Players: " + playcount;
                #region Enable Controls
                btnStartGame.Enabled = false;
                btnP1WinAdd.Enabled = true;
                btnP2WinAdd.Enabled = true;
                btnP3WinAdd.Enabled = true;
                btnP4WinAdd.Enabled = true;
                btnP5WinAdd.Enabled = true;
                btnP6WinAdd.Enabled = true;
                btnP7WinAdd.Enabled = true;
                btnP8WinAdd.Enabled = true;
                btnP9WinAdd.Enabled = true;
                btnP10WinAdd.Enabled = true;
                btnP1LossAdd.Enabled = true;
                btnP2LossAdd.Enabled = true;
                btnP3LossAdd.Enabled = true;
                btnP4LossAdd.Enabled = true;
                btnP5LossAdd.Enabled = true;
                btnP6LossAdd.Enabled = true;
                btnP7LossAdd.Enabled = true;
                btnP8LossAdd.Enabled = true;
                btnP9LossAdd.Enabled = true;
                btnP10LossAdd.Enabled = true;

                btnP1Remove.Enabled = true;
                btnP2Remove.Enabled = true;
                btnP3Remove.Enabled = true;
                btnP4Remove.Enabled = true;
                btnP5Remove.Enabled = true;
                btnP6Remove.Enabled = true;
                btnP7Remove.Enabled = true;
                btnP8Remove.Enabled = true;
                btnP9Remove.Enabled = true;
                btnP10Remove.Enabled = true;

                #endregion
                // Hide Open button
                btnOpen.Visible = false;
            }

       

            
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            // Send a message to the user telling them the game is now over
            MessageBox.Show("Game over! Good game! ;)", "Game over", MessageBoxButtons.OK, MessageBoxIcon.None);

            // Calculate the total play time (HH/MM/SS/MS)
            DateTime end = DateTime.Now;
            TimeSpan totalTime = end - start;
            lblPlaytime.Visible = true;
            lblPlaytime.Text = "Time played: " + Convert.ToString(totalTime);

            // Enable the StartGame button
            btnStartGame.Enabled = true;
            
            // Enable the export button
            btnExport.Enabled = true;

            // Disable this button
            btnEndGame.Enabled = false;

            // Assign the start time
            startTime = start;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Save to HTML file
            drawHTMLFile();

            // Write to a file (Gametrack.html)
            string path = Environment.CurrentDirectory + @"\Gametrack.html";
            File.WriteAllText(path, txtHTML.Text, Encoding.ASCII);
            MessageBox.Show("File saved! Clearing the game board.", "Done and dusted!");

            // Disable this button
            btnExport.Enabled = false;

            // Make Open HTML button visible
            btnOpen.Visible = true;

            // Clear the game board
            clearData();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            #region Clear the contents
            // Clear the players
            cbPlayer1.Checked = false;
            cbPlayer2.Checked = false;
            cbPlayer3.Checked = false;
            cbPlayer4.Checked = false;
            cbPlayer5.Checked = false;
            cbPlayer6.Checked = false;
            cbPlayer7.Checked = false;
            cbPlayer8.Checked = false;
            cbPlayer9.Checked = false;
            cbPlayer10.Checked = false;

            // Clear the names
            txtP1Name.Clear();
            txtP2Name.Clear();
            txtP3Name.Clear();
            txtP4Name.Clear();
            txtP5Name.Clear();
            txtP6Name.Clear();
            txtP7Name.Clear();
            txtP8Name.Clear();
            txtP9Name.Clear();
            txtP10Name.Clear();
            #endregion
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Set Names

            lblPlayer1.Text = txtP1Name.Text;
            lblPlayer2.Text = txtP2Name.Text;
            lblPlayer3.Text = txtP3Name.Text;
            lblPlayer4.Text = txtP4Name.Text;
            lblPlayer5.Text = txtP5Name.Text;
            lblPlayer6.Text = txtP6Name.Text;
            lblPlayer7.Text = txtP7Name.Text;
            lblPlayer8.Text = txtP8Name.Text;
            lblPlayer9.Text = txtP9Name.Text;
            lblPlayer10.Text = txtP10Name.Text;

            #endregion
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            tcGame.SelectTab(1);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RoflCorp Game Track v" + Application.ProductVersion + " (c) Copyright RoflCorp 2011. All rights reserved.", "About this application");
        }
     

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process.Start("Gametrack.html");
        }
        #endregion

    }
}
