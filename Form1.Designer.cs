namespace Hangman
{
    partial class StartScreen
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
            this.Welcome = new System.Windows.Forms.Label();
            this.StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HangmanLabel
            // 
            this.HangmanLabel.AutoSize = true;
            this.HangmanLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangmanLabel.Location = new System.Drawing.Point(201, 103);
            this.HangmanLabel.Name = "HangmanLabel";
            this.HangmanLabel.Size = new System.Drawing.Size(348, 69);
            this.HangmanLabel.TabIndex = 0;
            this.HangmanLabel.Text = "HANGMAN";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(330, 85);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(99, 18);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "Welcome to";
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(299, 241);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(151, 64);
            this.StartGame.TabIndex = 2;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 449);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.HangmanLabel);
            this.Name = "StartScreen";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HangmanLabel;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button StartGame;
    }
}