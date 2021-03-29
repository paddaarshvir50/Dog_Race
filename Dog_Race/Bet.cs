using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Race
{
   public class Bet
    {

        public int Amount;
        public int dogNum;
        public Racer Bettor;

        public Bet(int Amount, int dogNum, Racer Bettor)
        {
            this.Amount = Amount;
            this.dogNum = dogNum;
            this.Bettor = Bettor;
        }
        // this coding is for description
        public string GetDesc()
        {
            string description = "";

            if (Amount > 0)
            {
                description = String.Format("{0} bets {1} on Dog #{2}",
                    Bettor.Name, Amount, dogNum);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets",
                    Bettor.Name);
            }
            return description;
        }
        //this coding is for winner class

        public int Pay(int Winner)
        {
            if (dogNum == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
