
namespace NumberGuessingGame
{
    partial class GuessingGame
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
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userGuess = new System.Windows.Forms.TextBox();
            this.Guess = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.RoyalBlue;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Gold;
            this.Title.Location = new System.Drawing.Point(45, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(346, 39);
            this.Title.TabIndex = 0;
            this.Title.Text = "Guess The Number!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guess: ";
            // 
            // userGuess
            // 
            this.userGuess.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.userGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuess.ForeColor = System.Drawing.Color.RoyalBlue;
            this.userGuess.Location = new System.Drawing.Point(176, 170);
            this.userGuess.Name = "userGuess";
            this.userGuess.Size = new System.Drawing.Size(84, 31);
            this.userGuess.TabIndex = 2;
            // 
            // Guess
            // 
            this.Guess.BackColor = System.Drawing.Color.RoyalBlue;
            this.Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guess.ForeColor = System.Drawing.Color.Gold;
            this.Guess.Location = new System.Drawing.Point(159, 254);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(108, 51);
            this.Guess.TabIndex = 3;
            this.Guess.Text = "Guess";
            this.Guess.UseVisualStyleBackColor = false;
            this.Guess.Click += new System.EventHandler(this.guessButton_Text);
            // 
            // Hint
            // 
            this.Hint.AutoSize = true;
            this.Hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hint.ForeColor = System.Drawing.Color.Black;
            this.Hint.Location = new System.Drawing.Point(284, 173);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(0, 25);
            this.Hint.TabIndex = 4;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.Gold;
            this.ResetButton.Location = new System.Drawing.Point(349, 406);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 32);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(23, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Score: ";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.RoyalBlue;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.Gold;
            this.score.Location = new System.Drawing.Point(107, 407);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(25, 25);
            this.score.TabIndex = 7;
            this.score.Text = "0";
            // 
            // GuessingGame
            // 
            this.AcceptButton = this.Guess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.ResetButton;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Hint);
            this.Controls.Add(this.Guess);
            this.Controls.Add(this.userGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.KeyPreview = true;
            this.Name = "GuessingGame";
            this.Text = "GuessingGame";
            this.Load += new System.EventHandler(this.GuessingGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userGuess;
        private System.Windows.Forms.Button Guess;
        private System.Windows.Forms.Label Hint;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score;
    }
}

