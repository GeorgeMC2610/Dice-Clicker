namespace csharp_vathomologoumeni_1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.playButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearHighscores = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Nickname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HI_Scores = new System.Windows.Forms.Label();
            this.Expert_HI = new System.Windows.Forms.Button();
            this.Hard_HI = new System.Windows.Forms.Button();
            this.Normal_HI = new System.Windows.Forms.Button();
            this.Easy_HI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Expert = new System.Windows.Forms.RadioButton();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.ExitGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theCreatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nicknameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playButton.Location = new System.Drawing.Point(1, 349);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(1215, 48);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "START GAME";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ClearHighscores);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Nickname);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.HI_Scores);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.Expert_HI);
            this.panel1.Controls.Add(this.Hard_HI);
            this.panel1.Controls.Add(this.Normal_HI);
            this.panel1.Controls.Add(this.Easy_HI);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 405);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ClearHighscores
            // 
            this.ClearHighscores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearHighscores.BackColor = System.Drawing.Color.Brown;
            this.ClearHighscores.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearHighscores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearHighscores.Location = new System.Drawing.Point(1041, 222);
            this.ClearHighscores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearHighscores.Name = "ClearHighscores";
            this.ClearHighscores.Size = new System.Drawing.Size(165, 44);
            this.ClearHighscores.TabIndex = 51;
            this.ClearHighscores.Text = "CLEAR HIGHSCORES";
            this.ClearHighscores.UseVisualStyleBackColor = false;
            this.ClearHighscores.Click += new System.EventHandler(this.ClearHighscores_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(6, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 45);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select a difficulty and \r\nenter a nickname to \r\nstart the game!";
            // 
            // Nickname
            // 
            this.Nickname.AutoSize = true;
            this.Nickname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nickname.Location = new System.Drawing.Point(194, 104);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(81, 19);
            this.Nickname.TabIndex = 11;
            this.Nickname.Text = "Nickname";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 127);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaxLength = 45;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HI_Scores
            // 
            this.HI_Scores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HI_Scores.AutoSize = true;
            this.HI_Scores.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HI_Scores.ForeColor = System.Drawing.SystemColors.Control;
            this.HI_Scores.Location = new System.Drawing.Point(1036, 4);
            this.HI_Scores.Name = "HI_Scores";
            this.HI_Scores.Size = new System.Drawing.Size(178, 24);
            this.HI_Scores.TabIndex = 50;
            this.HI_Scores.Text = "Highest Scores";
            // 
            // Expert_HI
            // 
            this.Expert_HI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Expert_HI.BackColor = System.Drawing.Color.Maroon;
            this.Expert_HI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Expert_HI.Location = new System.Drawing.Point(1041, 142);
            this.Expert_HI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Expert_HI.Name = "Expert_HI";
            this.Expert_HI.Size = new System.Drawing.Size(165, 27);
            this.Expert_HI.TabIndex = 11;
            this.Expert_HI.Text = "Expert level";
            this.Expert_HI.UseVisualStyleBackColor = false;
            this.Expert_HI.Click += new System.EventHandler(this.Expert_HI_Click);
            // 
            // Hard_HI
            // 
            this.Hard_HI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Hard_HI.BackColor = System.Drawing.Color.Red;
            this.Hard_HI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Hard_HI.Location = new System.Drawing.Point(1041, 110);
            this.Hard_HI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Hard_HI.Name = "Hard_HI";
            this.Hard_HI.Size = new System.Drawing.Size(165, 27);
            this.Hard_HI.TabIndex = 10;
            this.Hard_HI.Text = "Hard level";
            this.Hard_HI.UseVisualStyleBackColor = false;
            this.Hard_HI.Click += new System.EventHandler(this.Hard_HI_Click);
            // 
            // Normal_HI
            // 
            this.Normal_HI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Normal_HI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Normal_HI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Normal_HI.Location = new System.Drawing.Point(1041, 77);
            this.Normal_HI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Normal_HI.Name = "Normal_HI";
            this.Normal_HI.Size = new System.Drawing.Size(165, 27);
            this.Normal_HI.TabIndex = 9;
            this.Normal_HI.Text = "Normal level";
            this.Normal_HI.UseVisualStyleBackColor = false;
            this.Normal_HI.Click += new System.EventHandler(this.Normal_HI_Click);
            // 
            // Easy_HI
            // 
            this.Easy_HI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Easy_HI.BackColor = System.Drawing.Color.Green;
            this.Easy_HI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Easy_HI.Location = new System.Drawing.Point(1041, 44);
            this.Easy_HI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Easy_HI.Name = "Easy_HI";
            this.Easy_HI.Size = new System.Drawing.Size(165, 27);
            this.Easy_HI.TabIndex = 8;
            this.Easy_HI.Text = "Easy level";
            this.Easy_HI.UseVisualStyleBackColor = false;
            this.Easy_HI.Click += new System.EventHandler(this.Easy_HI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Expert);
            this.groupBox1.Controls.Add(this.Easy);
            this.groupBox1.Controls.Add(this.Hard);
            this.groupBox1.Controls.Add(this.Normal);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(162, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Difficulty";
            // 
            // Expert
            // 
            this.Expert.AutoSize = true;
            this.Expert.Location = new System.Drawing.Point(6, 112);
            this.Expert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Expert.Name = "Expert";
            this.Expert.Size = new System.Drawing.Size(81, 23);
            this.Expert.TabIndex = 5;
            this.Expert.Text = "Expert";
            this.Expert.UseVisualStyleBackColor = true;
            this.Expert.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Cursor = System.Windows.Forms.Cursors.Default;
            this.Easy.Location = new System.Drawing.Point(6, 25);
            this.Easy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(63, 23);
            this.Easy.TabIndex = 2;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.CheckedChanged += new System.EventHandler(this.Easy_CheckedChanged);
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Location = new System.Drawing.Point(6, 83);
            this.Hard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(63, 23);
            this.Hard.TabIndex = 4;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.CheckedChanged += new System.EventHandler(this.Hard_CheckedChanged);
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Location = new System.Drawing.Point(6, 53);
            this.Normal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(81, 23);
            this.Normal.TabIndex = 3;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.CheckedChanged += new System.EventHandler(this.Normal_CheckedChanged);
            // 
            // ExitGame
            // 
            this.ExitGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitGame.Location = new System.Drawing.Point(1125, 28);
            this.ExitGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(110, 34);
            this.ExitGame.TabIndex = 12;
            this.ExitGame.Text = "Close Game";
            this.ExitGame.UseVisualStyleBackColor = false;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(565, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dice";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(500, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 58);
            this.label2.TabIndex = 11;
            this.label2.Text = "CLICKER";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisGameToolStripMenuItem,
            this.theCreatorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // thisGameToolStripMenuItem
            // 
            this.thisGameToolStripMenuItem.Name = "thisGameToolStripMenuItem";
            this.thisGameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.thisGameToolStripMenuItem.Text = "This Game";
            this.thisGameToolStripMenuItem.Click += new System.EventHandler(this.thisGameToolStripMenuItem_Click);
            // 
            // theCreatorToolStripMenuItem
            // 
            this.theCreatorToolStripMenuItem.Name = "theCreatorToolStripMenuItem";
            this.theCreatorToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.theCreatorToolStripMenuItem.Text = "The Creator";
            this.theCreatorToolStripMenuItem.Click += new System.EventHandler(this.theCreatorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.difficultiesToolStripMenuItem,
            this.nicknameToolStripMenuItem,
            this.highScoresToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.howToPlayToolStripMenuItem.Text = "How to play?";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // difficultiesToolStripMenuItem
            // 
            this.difficultiesToolStripMenuItem.Name = "difficultiesToolStripMenuItem";
            this.difficultiesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.difficultiesToolStripMenuItem.Text = "Difficulties";
            this.difficultiesToolStripMenuItem.Click += new System.EventHandler(this.difficultiesToolStripMenuItem_Click);
            // 
            // nicknameToolStripMenuItem
            // 
            this.nicknameToolStripMenuItem.Name = "nicknameToolStripMenuItem";
            this.nicknameToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.nicknameToolStripMenuItem.Text = "Nickname";
            this.nicknameToolStripMenuItem.Click += new System.EventHandler(this.nicknameToolStripMenuItem_Click);
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.highScoresToolStripMenuItem.Text = "High Scores";
            this.highScoresToolStripMenuItem.Click += new System.EventHandler(this.highScoresToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1247, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Expert;
        private System.Windows.Forms.Label HI_Scores;
        private System.Windows.Forms.Button Expert_HI;
        private System.Windows.Forms.Button Hard_HI;
        private System.Windows.Forms.Button Normal_HI;
        private System.Windows.Forms.Button Easy_HI;
        private System.Windows.Forms.Button ExitGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nickname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theCreatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nicknameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
        private System.Windows.Forms.Button ClearHighscores;
    }
}

