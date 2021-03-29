
namespace Dog_Race
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.P3Bet = new System.Windows.Forms.Label();
            this.P2Bet = new System.Windows.Forms.Label();
            this.P1Bet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.DogsNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dogRaceAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.btnp3 = new System.Windows.Forms.RadioButton();
            this.btnp2 = new System.Windows.Forms.RadioButton();
            this.btnp1 = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogRaceAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupbox.Controls.Add(this.P3Bet);
            this.groupbox.Controls.Add(this.P2Bet);
            this.groupbox.Controls.Add(this.P1Bet);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.race);
            this.groupbox.Controls.Add(this.DogsNumber);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.dogRaceAmount);
            this.groupbox.Controls.Add(this.Bets);
            this.groupbox.Controls.Add(this.btnp3);
            this.groupbox.Controls.Add(this.btnp2);
            this.groupbox.Controls.Add(this.btnp1);
            this.groupbox.Controls.Add(this.MaximumBet);
            this.groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupbox.Location = new System.Drawing.Point(-1, 358);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(1081, 168);
            this.groupbox.TabIndex = 12;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Dog Race";
            // 
            // P3Bet
            // 
            this.P3Bet.BackColor = System.Drawing.SystemColors.Info;
            this.P3Bet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P3Bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.P3Bet.Location = new System.Drawing.Point(747, 120);
            this.P3Bet.Name = "P3Bet";
            this.P3Bet.Size = new System.Drawing.Size(290, 29);
            this.P3Bet.TabIndex = 13;
            this.P3Bet.Text = "Player 3 Detail";
            // 
            // P2Bet
            // 
            this.P2Bet.BackColor = System.Drawing.SystemColors.Info;
            this.P2Bet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P2Bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.P2Bet.Location = new System.Drawing.Point(747, 73);
            this.P2Bet.Name = "P2Bet";
            this.P2Bet.Size = new System.Drawing.Size(290, 30);
            this.P2Bet.TabIndex = 12;
            this.P2Bet.Text = "Player 2 Detail";
            // 
            // P1Bet
            // 
            this.P1Bet.BackColor = System.Drawing.SystemColors.Info;
            this.P1Bet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P1Bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.P1Bet.Location = new System.Drawing.Point(747, 33);
            this.P1Bet.Name = "P1Bet";
            this.P1Bet.Size = new System.Drawing.Size(290, 27);
            this.P1Bet.TabIndex = 11;
            this.P1Bet.Text = "Player 1 Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.Color.Crimson;
            this.race.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.ForeColor = System.Drawing.Color.White;
            this.race.Location = new System.Drawing.Point(509, 80);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(135, 30);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // DogsNumber
            // 
            this.DogsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DogsNumber.Location = new System.Drawing.Point(320, 80);
            this.DogsNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogsNumber.Name = "DogsNumber";
            this.DogsNumber.Size = new System.Drawing.Size(64, 23);
            this.DogsNumber.TabIndex = 8;
            this.DogsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(306, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dog number";
            // 
            // dogRaceAmount
            // 
            this.dogRaceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dogRaceAmount.Location = new System.Drawing.Point(174, 80);
            this.dogRaceAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.dogRaceAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogRaceAmount.Name = "dogRaceAmount";
            this.dogRaceAmount.Size = new System.Drawing.Size(63, 23);
            this.dogRaceAmount.TabIndex = 6;
            this.dogRaceAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.Color.Crimson;
            this.Bets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Bets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bets.Location = new System.Drawing.Point(222, 120);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(126, 30);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // btnp3
            // 
            this.btnp3.AutoSize = true;
            this.btnp3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnp3.Checked = true;
            this.btnp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnp3.Location = new System.Drawing.Point(35, 138);
            this.btnp3.Name = "btnp3";
            this.btnp3.Size = new System.Drawing.Size(78, 21);
            this.btnp3.TabIndex = 3;
            this.btnp3.TabStop = true;
            this.btnp3.Text = "Player 3";
            this.btnp3.UseVisualStyleBackColor = false;
            this.btnp3.CheckedChanged += new System.EventHandler(this.btnp3_CheckedChanged);
            // 
            // btnp2
            // 
            this.btnp2.AutoSize = true;
            this.btnp2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnp2.Location = new System.Drawing.Point(35, 100);
            this.btnp2.Name = "btnp2";
            this.btnp2.Size = new System.Drawing.Size(78, 21);
            this.btnp2.TabIndex = 2;
            this.btnp2.Text = "Player 2";
            this.btnp2.UseVisualStyleBackColor = false;
            this.btnp2.CheckedChanged += new System.EventHandler(this.btnp2_CheckedChanged);
            // 
            // btnp1
            // 
            this.btnp1.AutoSize = true;
            this.btnp1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnp1.Location = new System.Drawing.Point(35, 62);
            this.btnp1.Name = "btnp1";
            this.btnp1.Size = new System.Drawing.Size(78, 21);
            this.btnp1.TabIndex = 1;
            this.btnp1.Text = "Player 1";
            this.btnp1.UseVisualStyleBackColor = false;
            this.btnp1.CheckedChanged += new System.EventHandler(this.btnp1_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(155, 43);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(101, 17);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            // 
            // Dog4
            // 
            this.Dog4.Image = global::Dog_Race.Properties.Resources.images;
            this.Dog4.Location = new System.Drawing.Point(-1, 253);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(83, 54);
            this.Dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog4.TabIndex = 11;
            this.Dog4.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.Image = global::Dog_Race.Properties.Resources.images;
            this.Dog3.Location = new System.Drawing.Point(-1, 179);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(83, 53);
            this.Dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog3.TabIndex = 10;
            this.Dog3.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.Image = global::Dog_Race.Properties.Resources.images;
            this.Dog2.Location = new System.Drawing.Point(-1, 100);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(83, 49);
            this.Dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog2.TabIndex = 9;
            this.Dog2.TabStop = false;
            // 
            // Dog1
            // 
            this.Dog1.Image = ((System.Drawing.Image)(resources.GetObject("Dog1.Image")));
            this.Dog1.Location = new System.Drawing.Point(-1, 26);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(83, 55);
            this.Dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog1.TabIndex = 8;
            this.Dog1.TabStop = false;
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.racetrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.racetrack.Location = new System.Drawing.Point(-1, 2);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1081, 326);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 7;
            this.racetrack.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1012, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 326);
            this.button1.TabIndex = 13;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.racetrack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogRaceAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Label P3Bet;
        private System.Windows.Forms.Label P2Bet;
        private System.Windows.Forms.Label P1Bet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.NumericUpDown DogsNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown dogRaceAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.RadioButton btnp3;
        private System.Windows.Forms.RadioButton btnp2;
        private System.Windows.Forms.RadioButton btnp1;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.Button button1;
    }
}

