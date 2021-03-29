using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Race
{
   public  class Dogs
    {
        private static int startline;
        private static int rtlength;
        public PictureBox DogsPictureBox = null;
        public int Location = 0;
        public static Random rand = new Random(); //declared random object as static to avoid same random number

        public static int startline1 { get => startline; set => startline = value; }
        public static int rtlength1 { get => rtlength; set => rtlength = value; }

        // generation across all Cars objects

        public static bool Run(Dogs obj)
        {
            int distance = rand.Next(2, 6);
            if (obj.DogsPictureBox != null)
                obj.MoveDogsPictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (rtlength1 - startline1))
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            MoveDogsPictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveDogsPictureBox(int distance)
        {
            Point p = DogsPictureBox.Location;
            p.X += distance;
            DogsPictureBox.Location = p; //move Cars in x-axis left to right side 
        }
    }
}
