using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Race
{
    public partial class Form1 : Form
    {
        Dogs[] Dogss = new Dogs[4];
        RacerFactory pFactory = new RacerFactory();
        Racer[] Racers = new Racer[3];
        public Form1()
        {
            InitializeComponent();
            SetupRaceTrack();
        }
        private void SetupRaceTrack()
        {

            Dogs.startline1 = Dog1.Right - racetrack.Left;
            Dogs.rtlength1 = racetrack.Size.Width - 60; //fixing length of race - till finish line

            Dogss[0] = new Dogs() { DogsPictureBox = Dog1 };
            Dogss[1] = new Dogs() { DogsPictureBox = Dog2 };
            Dogss[2] = new Dogs() { DogsPictureBox = Dog3 };
            Dogss[3] = new Dogs() { DogsPictureBox = Dog4 };

            Racers[0] = pFactory.getRacer("Player1", MaximumBet, P1Bet); //getting player 1 object from factory class
            Racers[1] = pFactory.getRacer("Player2", MaximumBet, P2Bet); //getting player 2 object from factory class
            Racers[2] = pFactory.getRacer("Player3", MaximumBet, P3Bet); //getting player 3 object from factory class


            foreach (Racer Racer in Racers)
            {
                Racer.UpdateLabels();
            }
        }

        private void btnp1_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(Racers[0].Cash);
        }

        private void btnp2_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(Racers[1].Cash);
        }

        private void btnp3_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(Racers[2].Cash);
        }

        private void setMaximumBetTextLabel(int Cash)
        {
            MaximumBet.Text = String.Format("Maximum Bet: ${0}", Cash);
        }

        private void race_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningDogs;
            race.Enabled = false; //disable start race button

            while (NoWinner)
            { // loop until we have a winner
                Application.DoEvents();
                for (int i = 0; i < Dogss.Length; i++)
                {
                    if (Dogs.Run(Dogss[i]))
                    {
                        winningDogs = i + 1;
                        NoWinner = false;
                        MessageBox.Show("winner of the race is - Dogs #" + winningDogs);
                        foreach (Racer Racer in Racers)
                        {
                            if (Racer.bet != null)
                            {
                                Racer.Collect(winningDogs); //give double amount to all who've won or deduce betted amount
                                Racer.bet = null;
                                Racer.UpdateLabels();
                            }
                        }
                        foreach (Dogs Dogs in Dogss)
                        {
                            Dogs.TakeStartingPosition();
                        }
                        break;
                    }
                }
            }
            if (Racers[0].busted && Racers[1].busted && Racers[2].busted)
            {  //stop Racers from betting if they run out of cash
                String message = "Do you want to Play Again?";
                String title = "GAME OVER!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SetupRaceTrack(); //restart game
                }
                else
                {
                    this.Close();
                }

            }
            race.Enabled = true; //enable race button 
        }

        private void Bets_Click(object sender, EventArgs e)
        {
            int RacerNum = 0;

            if (btnp1.Checked)
            {
                RacerNum = 0;
            }
            if (btnp2.Checked)
            {
                RacerNum = 1;
            }
            if (btnp3.Checked)
            {
                RacerNum = 2;
            }

            Racers[RacerNum].PlaceBet((int)dogRaceAmount.Value, (int)DogsNumber.Value);
            Racers[RacerNum].UpdateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
