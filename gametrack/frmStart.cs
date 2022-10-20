using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gametrack
{
    public partial class frmStart : Form
    {
        #region Public accessable Variables

        // The games name
        public static string gameName = string.Empty;

        // The games amount of players
        public static int playerAmount = 0;

        // The events type
        public static string eventType = string.Empty;


        #endregion

        public frmStart()
        {
            InitializeComponent();
        }

        private void cboGameslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Warning Label - Player Limits
            if (cboGameslist.SelectedItem == "Age of Empires")
            {
                lblWarning.Text = "Maximum amount of players: 8";
            }

            if (cboGameslist.SelectedItem == "Age of Mythology")
            {
                lblWarning.Text = "Maximum amount of players: 8";
            }

            if (cboGameslist.SelectedItem == "Warcraft 3")
            {
                lblWarning.Text = "DoTA has a maximum amount of players of 5v5";
            }

            #region Players Check

            if (cboGameslist.SelectedItem == "Age of Empires" || cboGameslist.SelectedItem == "Age of Mythology")
            {
                cboPlayerslist.Items.Clear();
                for (int i = 1; i < 9; i++)
                {
                    cboPlayerslist.Items.Add(i);
                }
            }
            else
            {
                cboPlayerslist.Items.Clear();
                for (int i = 1; i < 11; i++)
                {
                    cboPlayerslist.Items.Add(i);
                }
            }

            #endregion
            #endregion
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            // Set the gameName
            GameName = Convert.ToString(cboGameslist.SelectedItem);

            // Set the amount of players
            playerAmount = Convert.ToInt32(cboPlayerslist.SelectedItem);

            // Set the event type
            eventType = Convert.ToString(cboEventlist.SelectedItem);


            // Promp the user with a dialog and ask for Event name
            frmPrompt prompt = new frmPrompt();
            prompt.ShowDialog();

            // Hide this form
            this.Hide();
        }


        #region Variable Settings

        // Game name
        public static string GameName
        {
            get
            {
                return gameName;
            }
            set
            {
                gameName = value;
            }
        }

        // Amount of players
        public static int playerAmt
        {
            get
            {
                return playerAmount;
            }
            set
            {
                playerAmount = value;
            }
        }

        // Event Type
        public static string Event
        {
            get
            {
                return eventType;
            }
            set
            {
                eventType = value;
            }
        }


        #endregion

        private void frmStart_Load(object sender, EventArgs e)
        {

        }



    }
}
