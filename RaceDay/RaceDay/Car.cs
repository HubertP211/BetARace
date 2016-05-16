using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceDay
{
    class Car
    {
        public int startingPosition;
        public int raceTrackLenght;
        public PictureBox myPictureBox;
        public int location = 0;
        public Random random;

        public Car(PictureBox _car, PictureBox _racetrack, Random _random)
        {
            startingPosition = _car.Left;
            raceTrackLenght = _racetrack.Width - _car.Width;
            myPictureBox = _car;
            random = _random;
        }


        public bool Run()
        {


            myPictureBox.Left = myPictureBox.Left + random.Next(20, 50);

            if (myPictureBox.Left >= raceTrackLenght)
            {
               
                return true;
            }

            return false;
        }

        public void resetCar()
        {
            myPictureBox.Left = startingPosition;
        }
    }
}
