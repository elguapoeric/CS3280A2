using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{   /// <summary>
    /// Game that simulates rolling a single die the user guesses what the roll will be,
    /// keep track of number of times won and lost.  Also keep track of frequency each die
    /// is rolled. 
    ///
    /// </summary>
    public partial class Form1 : Form
    {
        #region variables
        /// <summary>
        /// Number of games played
        /// </summary>
        private int countPlayed;
        /// <summary>
        /// Holds the random number generated from random class
        /// </summary>
        private int ranFace = 0;  
        /// <summary>
        /// Counts the number of times face 1 was rolled
        /// </summary>
        private int freq1 = 0;
        /// <summary>
        /// Counts the number of times face 2 was rolled
        /// </summary>
        private int freq2 = 0;
        /// <summary>
        /// Counts the number of times face 3 was rolled
        /// </summary>
        private int freq3 = 0;
        /// <summary>
        /// Counts the number of times face 4 was rolled
        /// </summary>
        private int freq4 = 0;
        /// <summary>
        /// Counts the numer of times face 5 was rolled
        /// </summary>
        private int freq5 = 0;
        /// <summary>
        /// Counts the number of times face 6 was rolled
        /// </summary>
        private int freq6 = 0;
        /// <summary>
        /// Counts the number of times user chose face 1
        /// </summary>
        private int gs1 = 0;
        /// <summary>
        /// Counts the number of times the user chose face 2
        /// </summary>
        private int gs2 = 0;
        /// <summary>
        /// Counts the number of times the user chose face 3
        /// </summary>
        private int gs3 = 0;
        /// <summary>
        /// Counts the number of times the user chose face 4
        /// </summary>
        private int gs4 = 0;
        /// <summary>
        /// Counts the number of times the user chose face 5
        /// </summary>
        private int gs5 = 0;
        /// <summary>
        /// Counts the number of times the user chose face 6
        /// </summary>
        private int gs6 = 0;
        /// <summary>
        /// Keeps track if user chose correct input
        /// </summary>
        private bool userTF = false; 
        /// <summary>
        /// Holds the number the user entered in the textbox 
        /// </summary>
        private int userGuess = 0;  
        /// <summary>
        /// keeps track of games won
        /// </summary>
        private int gamesWon = 0;   
        /// <summary>
        /// Keeps track of games lost
        /// </summary>
        private int gamesLost = 0;  //keeps track of incorrect guesses
        #endregion

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add(6);//Addign six rows
            this.dataGridView1.Columns[2].DefaultCellStyle.Format = "0.00,%"; //set format of percent column in table
        }


        /// <summary>
        /// Method used to update the score and number of time played
        /// </summary>
        private void updateCounts()
        {
            cntPlayed.Text = "Number of Times Played: " + countPlayed;      //Total Number of games played
            cntWon.Text = "Number of Times Won: " + gamesWon;               //Total Number of games won
            cntLost.Text = " Number of Times Lost: " + gamesLost;           //Total number of games lost
        }

        /// <summary>
        /// Updates the values of the table
        /// </summary>
        private void statsTable() {
            for (int i = 0; i < 6; i++)                                                         //This loop will go through each row of the table and update values
            {
                int[] frequencies = new int[6] { freq1, freq2, freq3, freq4, freq5, freq6 };    //array to hold the frequencies of each face
                int[] gs = new int[6] { gs1, gs2, gs3, gs4, gs5, gs6 };                         //array to hold the user guess counts
                dataGridView1.Rows[i].Cells[0].Value = 1 + i;                                   //Identify each face
                dataGridView1.Rows[i].Cells[1].Value = frequencies[i];                          //Update value of frequencies of each face
                dataGridView1.Rows[i].Cells[2].Value = (float)(frequencies[i] / (float)countPlayed); //Update percentages of each side
                dataGridView1.Rows[i].Cells[3].Value = (gs[i]);                          //Update user guesses for each side
            }
        
            dataGridView1.Refresh(); //Refresh to actually make changes visible
        }

        /// <summary>
        /// Used to reset all variables back to zero
        /// </summary>
        private void reset()
        {
            this.countPlayed = 0;
            this.ranFace = 0;
            this.freq1 = 0;
            this.freq2 = 0;
            this.freq3 = 0;
            this.freq4 = 0;
            this.freq5 = 0;
            this.freq6 = 0;
            this.gs1 = 0;      
            this.gs2 = 0;
            this.gs3 = 0;
            this.gs4 = 0;
            this.gs5 = 0;
            this.gs6 = 0;
            this.userTF = false;
            this.userGuess = 0;
            this.gamesWon = 0;
            this.gamesLost = 0;
            guessBox.Text = null;
            updateCounts();

        }

        

        /// <summary>
        /// When user clicks roll button will check if number is between 1 and six
        /// Will prompt will keep track of user stats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollButton_Click(object sender, EventArgs e)
        {
            
            diceImageBox.SizeMode = PictureBoxSizeMode.StretchImage; //Stretching image to fit box
            Random randomNumber = new Random();                      //creating object
            userTF = Int32.TryParse(guessBox.Text, out userGuess);  //parsing users value and return true if it can be parsed
            warnLbl.Visible = false;                                //Used for turning warning label on and off if users enter incorrect number 

            if (userTF && userGuess >= 1 && userGuess <= 6) //If user picks a correct number
            {
                switch (userGuess) //keep count of which number the user picks
                {
                    case 1:
                        gs1++;
                        break;
                    case 2:
                        gs2++;
                        break;
                    case 3:
                        gs3++;
                        break;
                    case 4:
                        gs4++;
                        break;
                    case 5:
                        gs5++;
                        break;
                    case 6:
                        gs6++;
                        break;
                }//End switch

                for (int i = 1; i < 7; i++) //Randomly cycle through dice and pick the sixth random face
                {
                    int ranNum = randomNumber.Next(1, 7); //creating a random number 1 to 6
                    diceImageBox.Image = Image.FromFile("die" + ranNum.ToString() + ".gif"); //simulating rolling a dice by randomly chaning image
                    diceImageBox.Refresh(); //update image so it shows
                    Thread.Sleep(300);  //slowing down each image change

                    if (i == 6)     //the sixth number that comes up will be the number thats passed back to the global variable
                    {
                        this.ranFace = ranNum; //update the ranFace variable from the random number that came up
                        this.countPlayed++; //increment games played

                        if (userGuess == ranNum) //If the user guesses correct or incorrect increment the count
                        {
                            gamesWon++;
                        }
                        else
                        {
                            gamesLost++;
                        }

                        switch (ranNum) //increments counts based on random number that comes up
                        {
                            case 1:
                                freq1++;
                                updateCounts();
                                break;
                            case 2:
                                freq2++;
                                updateCounts();
                                break;
                            case 3:
                                freq3++;
                                updateCounts();
                                break;
                            case 4:
                                freq4++;
                                updateCounts();
                                break;
                            case 5:
                                freq5++;
                                updateCounts();
                                break;
                            case 6:
                                freq6++;
                                updateCounts();
                                break;
                        }//End switch
                    }//End for loop
                }//End outer for loop

                statsTable();
                
            }
            else if (string.IsNullOrWhiteSpace(guessBox.Text)) //If no number in box prompt user to enter one
            {
                warnLbl.Text = "You must enter a number 1-6";
                warnLbl.Visible = true;
                warnLbl.Refresh();
            }
            else
            {
                warnLbl.Text = "You must enter a number 1-6"; //If number is in box is not 1-6 prompt user to enter one
                warnLbl.Visible = true;
                warnLbl.Refresh();
            }

           


        }
        /// <summary>
        /// Reset all variable back to 0 starting a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
