using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceDay
{
    public partial class Form1 : Form
    {
        int playerChecked = 0;
        Player[] players = new Player[3];
        Car[] cars = new Car[3];
        Random random = new Random();
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            

            players[0] = new Player(100, player1Radio, player1Label, "Player 1");
            players[1] = new Player(100, player2Radio, player2Label, "Player 2");
            players[2] = new Player(100, player3Radio, player3Label, "Player 3");

            cars[0] = new Car(car1, racetrack, random);
            cars[1] = new Car(car2, racetrack, random);
            cars[2] = new Car(car3, racetrack, random);

            foreach (Player pla in players)
            {
                pla.UpdateLabels();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            foreach(Player pla in players)
            {
                if(pla.myBet == null)
                {
                    counter++;
                }
            }

            if(counter==3)
            {
                MessageBox.Show("Nikt nie zawarł żadnego zakładu. Wyścig anulowany");
            }
            else timer1.Start();


        }

        private void player1Radio_CheckedChanged(object sender, EventArgs e)
        {
            playerChecked = 0;
        }

        private void player2Radio_CheckedChanged(object sender, EventArgs e)
        {
            playerChecked = 1;
        }

        private void player3Radio_CheckedChanged(object sender, EventArgs e)
        {
            playerChecked = 2;
        }

        private void placeBetButton_Click(object sender, EventArgs e)
        {
            players[playerChecked].PlaceBet((int)numericUpDownBet.Value, (int)numericUpDownCar.Value-1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i<3; i++)
            {
                if(cars[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Koniec wyścigu! Wygrał samochód nr" + (i+1));
                    foreach(Player pla in players)
                    {
                        if(pla.myBet!=null && pla.myBet.car == i)
                        {
                            pla.cash += pla.myBet.PayOut();
                            MessageBox.Show(pla.name + " wygrywa " + pla.myBet.PayOut() + " zł!");
                            pla.UpdateLabels();
                        }
                        
                    }
                    foreach(Car car in cars)
                    {
                        car.resetCar();
                    }
                    foreach(Player pla in players)
                    {
                        pla.ClearBet();
                    }
                    player1Label.Text = "Brak zakładów";
                    player2Label.Text = "Brak zakładów";
                    player3Label.Text = "Brak zakładów";

                    break;
                    
                }
                
            }
        }



    }
}
