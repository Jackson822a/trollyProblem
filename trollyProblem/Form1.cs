using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Security.Cryptography;

namespace trollyProblem
{
    public partial class Form1 : Form
    {
        int page = 1;
        Random RandGen = new Random();
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "A train is heading towards 5 people.";
            outputLabel.Text += "\nYou can pull a lever to change the tracks, killing one person instead.";
            outputLabel.Text += "\n Do you pull the lever?";
            option1Label.Text = "Yes";
            option2Label.Text = "No";
            
        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 11;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 99)
            {
                Refresh();
                outputLabel.Text = "Thank you for playing";
                Thread.Sleep(2000);
                Application.Exit();
            }
            else if (page == 101)
            {
                page = 99;
            }

            switch (page)
            {
                case 1:
                    outputLabel.Text = "A train is heading towards 5 people. ";
                    outputLabel.Text += "\nYou can pull a lever to change the tracks, killing one person instead.";
                    outputLabel.Text += "\n Do you pull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.image1;
               break;

                case 2:

                    outputLabel.Text = "The train runs over the 5 people.";
                    outputLabel.Text += " \n You black out, when you wake up you find yourself standing beside more train tracks.";
                    outputLabel.Text += " \n A train is heading towards 5 more people.";
                    outputLabel.Text += " \n You can pull a lever to change the tracks, killing 4 people instead.";
                    outputLabel.Text += " \n Pull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    
                    pictureBox1.Image = Properties.Resources.image2;
                    break;

                case 3:

                    outputLabel.Text = "You pull the lever when it is in the middle of the fork. The train falls of the track and kills you";
                    outputLabel.Text += " \n Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;


                    break;

                case 4:
                    outputLabel.Text = "You pull the lever, the train runs over 4 people.";
                    outputLabel.Text += "\nYou blackout again and find yourself on the tracks.";
                    outputLabel.Text += "\nYou can pull the lever, killing yourself and saving 5 people.";
                    outputLabel.Text += "\nPull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.image3;
                    break;
                    

                case 5:

                    outputLabel.Text = "The train runs over the 5 people. You die of guilt.";
                    outputLabel.Text += " \n Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;

                case 6:

                    outputLabel.Text = "You pull the lever, the train switches tracks, running you over.";
                    outputLabel.Text += " \n Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;
                case 7:
                    outputLabel.Text = "The train runs over the 5 people. You blackout again. ";
                    outputLabel.Text += "\nThe train is heading for 5 people. The lever doesn't change the tracks";
                    outputLabel.Text += "\nIt only speeds up the train, which might make it less painful.";
                    outputLabel.Text += "\nPull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.image1;
                    break;
                case 8:
                    outputLabel.Text = "The train kills the 5 people. You blackout, now there are 5 lobsters on the track.";
                    outputLabel.Text += "\nIf you pull the lever the train would switch tracks killing one cat instead.";
                    outputLabel.Text += "\nPull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.image4;
                    break;
                case 9:

                    outputLabel.Text = "You pull the lever, the train speeds up... too fast.";
                    outputLabel.Text += "\nThe train falls off the tracks and explodes.";
                    outputLabel.Text += "\nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;

                case 10:
                    outputLabel.Text = "The train runs over the cat. It's okay though, it has more lives.";
                    outputLabel.Text += "\nYou blackout again. This time there is 1 person in the way.";
                    outputLabel.Text += "\nIf you pull the lever the train runs over a box with a 50% chance of having 5 people or nobody inside.";
                    outputLabel.Text += "\nPull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.imageChance;
                    break;

                case 11:
                    outputLabel.Text = "You don't pull the lever. The train runs over the lobsters.";
                    outputLabel.Text += "\nOne of the lobster claws flies out and hits you.";
                    outputLabel.Text += "\nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;

                case 12:

                    outputLabel.Text = "You don't pull the lever. The one person dies";
                    outputLabel.Text += "\nLightning strikes you and you die.";
                    outputLabel.Text += "\nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;
                case 13:
                    outputLabel.Text = "The train hits the 5 people.This time there are 2 levers and 3 tracks.";
                    outputLabel.Text += "\nYou can pull the first lever and your enemy will get hit. ";
                    outputLabel.Text += "\nYou can pull the 2nd lever and you will get hit.";
                    outputLabel.Text += "\nYou can do nothing and nobody will get hit.";
                    outputLabel.Text += "\nPull lever 1,2 or do nothing?";
                    option3.Visible = true;
                    option3Label.Visible = true;
                    option1Label.Text = "Lever 1";
                    option2Label.Text = "Lever 2";
                    option3Label.Text = "Do nothing";
                    pictureBox1.Image = Properties.Resources.image3tracks;
                    break;
                case 14:
                    outputLabel.Text = "The train hits nobody.This time there are 2 levers and 3 tracks.";
                    outputLabel.Text += "\nYou can pull the first lever and your enemy will get hit. ";
                    outputLabel.Text += "\nYou can pull the 2nd lever and you will get hit.";
                    outputLabel.Text += "\nYou can do nothing and nobody will get hit.";
                    outputLabel.Text += "\nPull lever 1,2 or do nothing?";
                    option3.Visible = true;
                    option3Label.Visible = true;
                    option1Label.Text = "Lever 1";
                    option2Label.Text = "Lever 2";
                    option3Label.Text = "Do nothing";
                    pictureBox1.Image = Properties.Resources.image3tracks;
                    break;
                case 15:
                    outputLabel.Text = "You pull the second lever. The train hits you.";
                    outputLabel.Text += "\nPlay again?";
                    option3.Visible = false;
                    option3Label.Visible = false;
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;
                case 16:
                    outputLabel.Text = "Your enemy gets hit. Now there are 2 tracks again.";
                    outputLabel.Text += "\nA track is heading towards 5 people, you can pull the lever to divert it to one person.";
                    outputLabel.Text += "\nAt least that is what you think is happening.";
                    outputLabel.Text += "\nYou don't have your glasses and can't see well.";
                    outputLabel.Text += "\nPull the lever?";
                    option3.Visible = false;
                    option3Label.Visible = false;
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.imageBlind;
                    break;
                case 17:
                    outputLabel.Text = "Nobody gets hit. Now there are 2 tracks again.";
                    outputLabel.Text += "\nA track is heading towards 5 people, you can pull the lever to divert it to one person.";
                    outputLabel.Text += "\nAt least that is what you think is happening.";
                    outputLabel.Text += "\nYou don't have your glasses and can't see well.";
                    outputLabel.Text += "\nPull the lever?";
                    option3.Visible = false;
                    option3Label.Visible = false;
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.imageBlind;
                    break;
                case 18:
                    outputLabel.Text = "You don't pull the lever. Since you couldn't see, the train was actually headed towards you.";
                    outputLabel.Text += "\nPlay again?";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;
                case 19:
                    outputLabel.Text = "You pull the lever, 1 person gets hit... maybe.";
                    outputLabel.Text += "\nYou blackout. This time you can pull the lever and you would just win.";
                    outputLabel.Text += "\nIf you don't pull the lever a train hits you.";
                    outputLabel.Text += "\nPull the lever?";
                    pictureBox1.Image = Properties.Resources.imageWinChoice;
                    break;
                case 20:
                    outputLabel.Text = "You don't pull the lever. The train hits you.";
                    outputLabel.Text += "Play again?";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;
                case 99:
                    Refresh();
                    outputLabel.Text = "Thank you for playing";
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                case 101:
                    outputLabel.Text = "You beat the trolley problem. Thank you for playing!";
                    outputLabel.Text += "\nWould you like to play again?";
                    pictureBox1.Image = Properties.Resources.imageWin;
                    break;
            }
        }

        private void option1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                int pageChance;
                pageChance = RandGen.Next(1, 101);
                if (pageChance > 50)
                {
                    page = 13;
                }
                else
                {
                    page = 14;
                }
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 16;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 19;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 101;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 99)
            {
                page = 1;
            }
            else if (page == 101)
            {
                page = 99;
            }


            switch (page)
            {
                case 1:
                    outputLabel.Text = "A train is heading towards 5 people.";
                    outputLabel.Text += "\nYou can pull a lever to change the tracks, killing one person instead.";
                    outputLabel.Text += "\n Do you pull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.image1;
                    break;

                case 2:

                    outputLabel.Text = "The train runs over the 5 people.";
                    outputLabel.Text += " \n You black out, when you wake up you find yourself standing beside more train tracks.";
                    outputLabel.Text += " \n A train is heading towards 5 more people.";
                    outputLabel.Text += " \n You can pull a lever to change the tracks, killing four people instead.";
                    outputLabel.Text += " \n Pull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.image2;


                    break;

                case 3:

                    outputLabel.Text = "You pull the lever when it is in the middle of the fork. The train falls of the track and kills you";
                    outputLabel.Text += " \n Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox1.Image = Properties.Resources.gameOver;

                    break;

                case 4:
                    outputLabel.Text = "You pull the lever, the train runs over 4 people.";
                    outputLabel.Text += "\nYou blackout again and find yourself on the tracks.";
                    outputLabel.Text += "\nYou can pull the lever, killing yourself and saving 5 people.";
                    outputLabel.Text += "\nPull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.image3;
                    break;

                case 5:

                    outputLabel.Text = "The train runs over the 5 people. You die of guilt.";
                    outputLabel.Text += " \n Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;

                case 6:

                    outputLabel.Text = "You pull the lever, the train switches tracks, running you over.";
                    outputLabel.Text += " \n Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;
                case 7:
                    outputLabel.Text = "The train runs over the 5 people. You blackout again. ";
                    outputLabel.Text += "\nThe train is heading for 5 people. The lever doesn't change the tracks";
                    outputLabel.Text += "\nIt only speeds up the train, which might make it less painful.";
                    outputLabel.Text += "\nPull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.image1;
                    break;
                case 8:
                    outputLabel.Text = "The train kills the 5 people. You blackout, now there are 5 lobsters on the track.";
                    outputLabel.Text += "\nIf you pull the lever the train would switch tracks killing one cat instead.";
                    outputLabel.Text += "\nPull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.image4;
                    break;
                case 9:

                    outputLabel.Text = "You pull the lever, the train speeds up... too fast.";
                    outputLabel.Text += "\nThe train falls off the tracks and explodes.";
                    outputLabel.Text += "\nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;

                case 10:
                    outputLabel.Text = "The train runs over the cat. It's okay though, it has more lives.";
                    outputLabel.Text += "\nYou blackout again. This time there is 1 person in the way.";
                    outputLabel.Text += "\nIf you pull the lever the train runs over a box with a 50% chance of having 5 people or nobody inside.";
                    outputLabel.Text += "\nPull the lever?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.imageChance;
                    break;

                case 11:
                    outputLabel.Text = "You don't pull the lever. The train runs over the lobsters.";
                    outputLabel.Text += "\nOne of the lobster claws flies out and hits you.";
                    outputLabel.Text += "\nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;

                case 12:

                    outputLabel.Text = "You don't pull the lever. The one person dies";
                    outputLabel.Text += "\nLightning strikes you and you die.";
                    outputLabel.Text += "\nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;
                case 13:
                    outputLabel.Text = "The train hits the 5 people.This time there are 2 levers and 3 tracks.";
                    outputLabel.Text += "\nYou can pull the first lever and your enemy will get hit. ";
                    outputLabel.Text += "\nYou can pull the 2nd lever and you will get hit.";
                    outputLabel.Text += "\nYou can do nothing and nobody will get hit.";
                    outputLabel.Text += "\nPull lever 1,2 or do nothing?";
                    option3.Visible = true;
                    option3Label.Visible = true;
                    option1Label.Text = "Lever 1";
                    option2Label.Text = "Lever 2";
                    option3Label.Text = "Do nothing";
                    pictureBox1.Image = Properties.Resources.image3tracks;
                    break;
                case 14:
                    outputLabel.Text = "The train hits nobody.This time there are 2 levers and 3 tracks.";
                    outputLabel.Text += "\nYou can pull the first lever and your enemy will get hit. ";
                    outputLabel.Text += "\nYou can pull the 2nd lever and you will get hit.";
                    outputLabel.Text += "\nYou can do nothing and nobody will get hit.";
                    outputLabel.Text += "\nPull lever 1,2 or do nothing?";
                    option3.Visible = true;
                    option3Label.Visible = true;
                    option1Label.Text = "Lever 1";
                    option2Label.Text = "Lever 2";
                    option3Label.Text = "Do nothing";
                    pictureBox1.Image = Properties.Resources.image3tracks;
                    break;
                case 15:
                    outputLabel.Text = "You pull the second lever. The train hits you.";
                    outputLabel.Text += "\nPlay again?";
                    option3.Visible = false;
                    option3Label.Visible = false;
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;
                case 16:
                    outputLabel.Text = "Your enemy gets hit. Now there are 2 tracks again.";
                    outputLabel.Text += "\nA track is heading towards 5 people, you can pull the lever to divert it to one person.";
                    outputLabel.Text += "\nAt least that is what you think is happening.";
                    outputLabel.Text += "\nYou don't have your glasses and can't see well.";
                    outputLabel.Text += "\nPull the lever?";
                    option3.Visible = false;
                    option3Label.Visible = false;
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.imageBlind;
                    break;
                case 17:
                    outputLabel.Text = "Nobody gets hit. Now there are 2 tracks again.";
                    outputLabel.Text += "\nA track is heading towards 5 people, you can pull the lever to divert it to one person.";
                    outputLabel.Text += "\nAt least that is what you think is happening.";
                    outputLabel.Text += "\nYou don't have your glasses and can't see well.";
                    outputLabel.Text += "\nPull the lever?";
                    option3.Visible = false;
                    option3Label.Visible = false;
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.imageBlind;
                    break;
                case 18:
                    outputLabel.Text = "You don't pull the lever. Since you couldn't see, the train was actually headed towards you.";
                    outputLabel.Text += "\nPlay again?";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;
                case 19:
                    outputLabel.Text = "You pull the lever, 1 person gets hit... maybe.";
                    outputLabel.Text += "\nYou blackout. This time you can pull the lever and you would just win.";
                    outputLabel.Text += "\nIf you don't pull the lever a train hits you.";
                    outputLabel.Text += "\nPull the lever?";
                    pictureBox1.Image = Properties.Resources.imageWinChoice;
                    break;
                case 20:
                    outputLabel.Text = "You don't pull the lever. The train hits you.";
                    outputLabel.Text += "Play again?";
                    pictureBox1.Image = Properties.Resources.gameOver;
                    break;
                
                case 101:
                    outputLabel.Text = "You beat the trolley problem. Thank you for playing!";
                    outputLabel.Text += "\nWould you like to play again?";
                    pictureBox1.Image = Properties.Resources.imageWin;
                    break;
            }

        }

        private void option3_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Nobody gets hit. Now there are 2 tracks again.";
            outputLabel.Text += "\nA track is heading towards 5 people, you can pull the lever to divert it to one person.";
            outputLabel.Text += "\nAt least that is what you think is happening.";
            outputLabel.Text += "\nYou don't have your glasses and can't see well.";
            outputLabel.Text += "\nPull the lever?";
            option3.Visible = false;
            option3Label.Visible = false;
            option1Label.Text = "Yes";
            option2Label.Text = "No";
            pictureBox1.Image = Properties.Resources.imageBlind;

        }

     
    }
}
