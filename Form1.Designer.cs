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
            this.playButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Expert = new System.Windows.Forms.RadioButton();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.playButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.SystemColors.Control;
            this.playButton.Location = new System.Drawing.Point(3, 271);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(952, 47);
            this.playButton.TabIndex = 0;
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
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Location = new System.Drawing.Point(12, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 325);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Expert);
            this.groupBox1.Controls.Add(this.Easy);
            this.groupBox1.Controls.Add(this.Hard);
            this.groupBox1.Controls.Add(this.Normal);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // Expert
            // 
            this.Expert.AutoSize = true;
            this.Expert.Location = new System.Drawing.Point(6, 112);
            this.Expert.Name = "Expert";
            this.Expert.Size = new System.Drawing.Size(81, 23);
            this.Expert.TabIndex = 4;
            this.Expert.TabStop = true;
            this.Expert.Text = "Expert";
            this.Expert.UseVisualStyleBackColor = true;
            this.Expert.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Location = new System.Drawing.Point(6, 25);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(63, 23);
            this.Easy.TabIndex = 1;
            this.Easy.TabStop = true;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.CheckedChanged += new System.EventHandler(this.Easy_CheckedChanged);
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Location = new System.Drawing.Point(6, 83);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(63, 23);
            this.Hard.TabIndex = 3;
            this.Hard.TabStop = true;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.CheckedChanged += new System.EventHandler(this.Hard_CheckedChanged);
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Location = new System.Drawing.Point(6, 54);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(81, 23);
            this.Normal.TabIndex = 2;
            this.Normal.TabStop = true;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.CheckedChanged += new System.EventHandler(this.Normal_CheckedChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Expert;
    }
}

