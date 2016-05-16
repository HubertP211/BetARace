using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceDay
{
    class Player
    {
        public string name;
        public int cash;
        public Bet myBet;

        public RadioButton myRadioButton;
        public Label myLabel;


        public Player(int _cash, RadioButton _radioButton, Label _myLabel, string _name)
        {
            cash = _cash;
            myRadioButton = _radioButton;
            myLabel = _myLabel;
            name = _name;
            myBet = null;

                   
        }

        public void UpdateLabels()
        {
            myRadioButton.Text = name + " posiada " + cash + " zł";
        }

        public void ClearBet()
        {
            myBet = null;
        }

        public void PlaceBet(int ammount, int carNumber)
        {
            if(myRadioButton.Checked)
            {
                if (cash >= ammount && ammount >= 5)
                {
                    myBet = new Bet(ammount, carNumber, this);
                    myLabel.Text = myBet.GetDescription();
                    cash -= ammount;
                    UpdateLabels();


                }
                else MessageBox.Show("Brak pieniędzy");
            }
            
            
        }

        


    }
}
