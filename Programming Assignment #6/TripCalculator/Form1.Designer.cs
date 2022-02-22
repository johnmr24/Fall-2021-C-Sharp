
namespace TripCalculator
{
    partial class Form1
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
            this.DestinationText = new System.Windows.Forms.Label();
            this.MilesTraveledText = new System.Windows.Forms.Label();
            this.GallonsOfGasConsumedText = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.TextBox();
            this.milesTraveled = new System.Windows.Forms.TextBox();
            this.gallonsOfGasConsumed = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.milesPerGallon = new System.Windows.Forms.TextBox();
            this.MilesPerGallonText = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.RoyalBlue;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Gold;
            this.Title.Location = new System.Drawing.Point(171, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(258, 39);
            this.Title.TabIndex = 0;
            this.Title.Text = "Trip Calculator";
            // 
            // DestinationText
            // 
            this.DestinationText.AutoSize = true;
            this.DestinationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationText.Location = new System.Drawing.Point(176, 112);
            this.DestinationText.Name = "DestinationText";
            this.DestinationText.Size = new System.Drawing.Size(125, 24);
            this.DestinationText.TabIndex = 1;
            this.DestinationText.Text = "Destination: ";
            // 
            // MilesTraveledText
            // 
            this.MilesTraveledText.AutoSize = true;
            this.MilesTraveledText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilesTraveledText.Location = new System.Drawing.Point(142, 174);
            this.MilesTraveledText.Name = "MilesTraveledText";
            this.MilesTraveledText.Size = new System.Drawing.Size(159, 24);
            this.MilesTraveledText.TabIndex = 2;
            this.MilesTraveledText.Text = "Miles Traveled: ";
            // 
            // GallonsOfGasConsumedText
            // 
            this.GallonsOfGasConsumedText.AutoSize = true;
            this.GallonsOfGasConsumedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GallonsOfGasConsumedText.Location = new System.Drawing.Point(33, 236);
            this.GallonsOfGasConsumedText.Name = "GallonsOfGasConsumedText";
            this.GallonsOfGasConsumedText.Size = new System.Drawing.Size(268, 24);
            this.GallonsOfGasConsumedText.TabIndex = 3;
            this.GallonsOfGasConsumedText.Text = "Gallons Of Gas Consumed: ";
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(366, 115);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(100, 20);
            this.destination.TabIndex = 4;
            // 
            // milesTraveled
            // 
            this.milesTraveled.Location = new System.Drawing.Point(366, 177);
            this.milesTraveled.Name = "milesTraveled";
            this.milesTraveled.Size = new System.Drawing.Size(100, 20);
            this.milesTraveled.TabIndex = 5;
            this.milesTraveled.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gallonsOfGasConsumed
            // 
            this.gallonsOfGasConsumed.Location = new System.Drawing.Point(366, 239);
            this.gallonsOfGasConsumed.Name = "gallonsOfGasConsumed";
            this.gallonsOfGasConsumed.Size = new System.Drawing.Size(100, 20);
            this.gallonsOfGasConsumed.TabIndex = 6;
            this.gallonsOfGasConsumed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.SpringGreen;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.Tomato;
            this.CalculateButton.Location = new System.Drawing.Point(359, 366);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(113, 48);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // milesPerGallon
            // 
            this.milesPerGallon.BackColor = System.Drawing.Color.Moccasin;
            this.milesPerGallon.Enabled = false;
            this.milesPerGallon.Location = new System.Drawing.Point(366, 301);
            this.milesPerGallon.Name = "milesPerGallon";
            this.milesPerGallon.Size = new System.Drawing.Size(100, 20);
            this.milesPerGallon.TabIndex = 9;
            this.milesPerGallon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MilesPerGallonText
            // 
            this.MilesPerGallonText.AutoSize = true;
            this.MilesPerGallonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilesPerGallonText.Location = new System.Drawing.Point(132, 298);
            this.MilesPerGallonText.Name = "MilesPerGallonText";
            this.MilesPerGallonText.Size = new System.Drawing.Size(169, 24);
            this.MilesPerGallonText.TabIndex = 8;
            this.MilesPerGallonText.Text = "Miles Per Gallon:";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.SpringGreen;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.Tomato;
            this.ResetButton.Location = new System.Drawing.Point(167, 366);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(113, 48);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.milesPerGallon);
            this.Controls.Add(this.MilesPerGallonText);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.gallonsOfGasConsumed);
            this.Controls.Add(this.milesTraveled);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.GallonsOfGasConsumedText);
            this.Controls.Add(this.MilesTraveledText);
            this.Controls.Add(this.DestinationText);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Calculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label DestinationText;
        private System.Windows.Forms.Label MilesTraveledText;
        private System.Windows.Forms.Label GallonsOfGasConsumedText;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.TextBox milesTraveled;
        private System.Windows.Forms.TextBox gallonsOfGasConsumed;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox milesPerGallon;
        private System.Windows.Forms.Label MilesPerGallonText;
        private System.Windows.Forms.Button ResetButton;
    }
}

