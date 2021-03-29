using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dog_Race;

namespace UnitTest
{
   
    [TestClass]
    public class UnitTest1
    {
        RacerFactory pFactory = new Dog_Race.RacerFactory();
        Racer Player1;
        Dogs[] Dogss = new Dogs[2];
        [TestMethod]
        public void TestMethod1()
        {
        }
        public void TestWinnerOutcome()
        {
            Dogs.startline1 = 0;
            Dogs.rtlength1 = 50;
            int carRaceAmount = 45;
            int DogsNumber = 2;
            int expectedWin = 90;
            int expectedLose = 0;
            Dogss[0] = new Dogs() { DogsPictureBox = null };
            Dogss[1] = new Dogs() { DogsPictureBox = null };
            Player1 = pFactory.getRacer("player1", null, null);
            Player1.Cash = carRaceAmount;
            Player1.PlaceBet((int)carRaceAmount, DogsNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < Dogss.Length; i++)
                {
                    if (Dogs.Run(Dogss[i]))
                    {
                        win = i + 1;
                        Player1.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Player1.bet.dogNum == win)
            {
                Assert.AreEqual(expectedWin, Player1.Cash, "Account not credited correctly");
            }
            if (Player1.bet.dogNum != win)
            {
                Assert.AreEqual(expectedLose, Player1.Cash, "Account not debited correctly");

            }
        }
    }

}
