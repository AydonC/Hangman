namespace Hangman
{
    partial class MainGamescreen
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
            this.HangmanLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Letters = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.CorrectLetters = new System.Windows.Forms.Label();
            this.MissedLetters = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.Scoreboard = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // HangmanLabel
            // 
            this.HangmanLabel.AutoSize = true;
            this.HangmanLabel.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangmanLabel.Location = new System.Drawing.Point(3, -2);
            this.HangmanLabel.Name = "HangmanLabel";
            this.HangmanLabel.Size = new System.Drawing.Size(201, 42);
            this.HangmanLabel.TabIndex = 0;
            this.HangmanLabel.Text = "HANGMAN GAME";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(459, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 451);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 432);
            this.panel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Exit.Location = new System.Drawing.Point(276, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(49, 43);
            this.Exit.TabIndex = 36;
            this.Exit.Text = "Exit Game";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Letters);
            this.groupBox3.Controls.Add(this.Submit);
            this.groupBox3.Location = new System.Drawing.Point(12, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 114);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // Letters
            // 
            this.Letters.AcceptsReturn = true;
            this.Letters.AcceptsTab = true;
            this.Letters.Location = new System.Drawing.Point(27, 18);
            this.Letters.MaxLength = 1;
            this.Letters.Name = "Letters";
            this.Letters.Size = new System.Drawing.Size(45, 20);
            this.Letters.TabIndex = 30;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(27, 44);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(123, 38);
            this.Submit.TabIndex = 30;
            this.Submit.Text = "Submit Letter";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button27_Click_1);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.CorrectLetters);
            this.groupBoxMain.Controls.Add(this.MissedLetters);
            this.groupBoxMain.Controls.Add(this.Length);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 43);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(430, 257);
            this.groupBoxMain.TabIndex = 29;
            this.groupBoxMain.TabStop = false;
            // 
            // CorrectLetters
            // 
            this.CorrectLetters.AutoSize = true;
            this.CorrectLetters.Location = new System.Drawing.Point(6, 201);
            this.CorrectLetters.Name = "CorrectLetters";
            this.CorrectLetters.Size = new System.Drawing.Size(44, 13);
            this.CorrectLetters.TabIndex = 30;
            this.CorrectLetters.Text = "Correct:";
            // 
            // MissedLetters
            // 
            this.MissedLetters.AutoSize = true;
            this.MissedLetters.Location = new System.Drawing.Point(6, 224);
            this.MissedLetters.Name = "MissedLetters";
            this.MissedLetters.Size = new System.Drawing.Size(43, 13);
            this.MissedLetters.TabIndex = 33;
            this.MissedLetters.Text = "Missed:";
            this.MissedLetters.Click += new System.EventHandler(this.label4_Click);
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(320, 224);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(72, 13);
            this.Length.TabIndex = 0;
            this.Length.Text = "Word Length:";
            // 
            // Scoreboard
            // 
            this.Scoreboard.FormattingEnabled = true;
            this.Scoreboard.Location = new System.Drawing.Point(261, 325);
            this.Scoreboard.Name = "Scoreboard";
            this.Scoreboard.Size = new System.Drawing.Size(158, 95);
            this.Scoreboard.Sorted = true;
            this.Scoreboard.TabIndex = 35;
            this.Scoreboard.SelectedIndexChanged += new System.EventHandler(this.Scoreboard_SelectedIndexChanged);
            // 
            // MainGamescreen
            // 
            this.AcceptButton = this.Submit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 461);
            this.Controls.Add(this.Scoreboard);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HangmanLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainGamescreen";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label HangmanLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox Letters;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label MissedLetters;
        private System.Windows.Forms.Label CorrectLetters;
        private System.Windows.Forms.ListBox Scoreboard;
        private System.Windows.Forms.Button Exit;
    }
}

