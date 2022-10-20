namespace gametrack
{
    partial class frmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.lblEvent = new System.Windows.Forms.Label();
            this.cboEventlist = new System.Windows.Forms.ComboBox();
            this.lblGame = new System.Windows.Forms.Label();
            this.cboGameslist = new System.Windows.Forms.ComboBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.cboPlayerslist = new System.Windows.Forms.ComboBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(33, 80);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(38, 13);
            this.lblEvent.TabIndex = 0;
            this.lblEvent.Text = "Event:";
            // 
            // cboEventlist
            // 
            this.cboEventlist.FormattingEnabled = true;
            this.cboEventlist.Items.AddRange(new object[] {
            "LAN",
            "Casual",
            "Hardcore",
            "Competiton"});
            this.cboEventlist.Location = new System.Drawing.Point(106, 77);
            this.cboEventlist.Name = "cboEventlist";
            this.cboEventlist.Size = new System.Drawing.Size(121, 21);
            this.cboEventlist.TabIndex = 1;
            this.ttMain.SetToolTip(this.cboEventlist, "The gaming event of which you are at.\r\n\r\nLAN = Lan Party\r\nCasual = Alone\r\nHardcor" +
                    "e = Alone, on a harder difficulty\r\nCompetition = Playing at a competiton\r\n");
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(33, 9);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(38, 13);
            this.lblGame.TabIndex = 2;
            this.lblGame.Text = "Game:";
            // 
            // cboGameslist
            // 
            this.cboGameslist.FormattingEnabled = true;
            this.cboGameslist.Items.AddRange(new object[] {
            "Age of Empires",
            "Age of Mythology",
            "Warcraft 3",
            "Trackmania",
            "Counter-Strike",
            "Team Fortress 2",
            "Battlefield",
            "Quake",
            "Call of Duty",
            "Other"});
            this.cboGameslist.Location = new System.Drawing.Point(106, 6);
            this.cboGameslist.Name = "cboGameslist";
            this.cboGameslist.Size = new System.Drawing.Size(121, 21);
            this.cboGameslist.TabIndex = 3;
            this.ttMain.SetToolTip(this.cboGameslist, "Which game you will be participating in");
            this.cboGameslist.SelectedIndexChanged += new System.EventHandler(this.cboGameslist_SelectedIndexChanged);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Location = new System.Drawing.Point(33, 43);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(44, 13);
            this.lblPlayers.TabIndex = 4;
            this.lblPlayers.Text = "Players:";
            // 
            // cboPlayerslist
            // 
            this.cboPlayerslist.FormattingEnabled = true;
            this.cboPlayerslist.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboPlayerslist.Location = new System.Drawing.Point(106, 40);
            this.cboPlayerslist.Name = "cboPlayerslist";
            this.cboPlayerslist.Size = new System.Drawing.Size(121, 21);
            this.cboPlayerslist.TabIndex = 5;
            this.ttMain.SetToolTip(this.cboPlayerslist, "The amount of players in a single game");
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(12, 110);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(44, 140);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 175);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.cboPlayerslist);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.cboGameslist);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.cboEventlist);
            this.Controls.Add(this.lblEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Track - RoflCorp";
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.ComboBox cboEventlist;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.ComboBox cboGameslist;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.ComboBox cboPlayerslist;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolTip ttMain;
    }
}

