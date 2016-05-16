using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDay
{
    class Bet
    {
        public int ammount;
        public int car;
        public Player bettor;
        public string description;


        public Bet(int _ammount, int _car, Player _bettor)
        {
            ammount = _ammount;
            car = _car;
            bettor = _bettor;
        }



        public string GetDescription()
        {
            if (ammount >= 5)
            {
                description = bettor.name + " obstawił " + ammount + " zł na samochód nr " + (car+1);
                return description;
            }
            else return "Zakład nieprawidłowy";

            
        }

        public int PayOut()
        {

            return ammount*2;
        }


    }
}
