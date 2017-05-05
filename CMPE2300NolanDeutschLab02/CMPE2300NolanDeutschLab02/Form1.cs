/******************************************************************************
*   Class:          CMPE2300
*   Description:    Create the game missile command
*   Assignment:     Lab02
*   Name:           Nolan Deutsch
* * **************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE2300NolanDeutschLab02
{
    public partial class Form1 : Form
    {
        //Two lists to save the incoming and outgoing missiles
        List<Missile> incoming;
        List<Missile> outgoing;
        //List to keep track of the highscores reached
        List<int>  highScore;
        //The drawer for the game
        CDrawer canvas;
        //Stats for the form
        int numIncomingTotal; int numIncomingDestroyed; int numLaunched;
        double killRatio;
        //The number of lives left until game over
        int livesLeft;
        //The number of missiles generated each time
        int currentIncoming;
        //The number of missiles the player gets at one time
        int maxOutgoing;
        //The sum of the the number of missiles hit * weight
        int score;
        //Keeps track of the number of times missiles are generated
        int count;
        //The point at which the game increases speed
        int threshold;
        //The ammount hitting a missile adds to score in diffirent modes
        int weight;
        //The different difficulty modes
        Difficulty choice;
        public enum Difficulty
        {
            Easy, Moderate, Hard, Legendary
        }
        
        public Form1()
        {
            InitializeComponent();
            //Initialize the canvas
            canvas = new CDrawer();
            //Set the class canvas to be the same as the forms
            Missile.Canvas = canvas;
            //Turn off continuous update
            canvas.ContinuousUpdate = false;
            //Set the background to black
            canvas.BBColour = Color.Black;
            //Initialize the lists
            incoming = new List<Missile>(); outgoing = new List<Missile>();
            
            //Call the initilizer method
            Initilizer();
            //Set defult radio button to easy
            rbEasy.Checked = true;
            //Initialize the highscore list
            highScore = new List<int>();
        }
        /******************************************************************************
        * Region:      Initilizer
        * Description: Initilizes all varaibles and lists as well as switch depending 
                            on radio button difficulty
        * * **************************************************************************/
        public void Initilizer()
        {
            //Initialize ints and doubles
            numIncomingTotal = 0; numIncomingDestroyed = 0; numLaunched = 0;
            killRatio = 0.0; currentIncoming = 0; score = 0; livesLeft = 0;
            score = 0;
            //Set the current incoming value displayed to the screen to the tbincomingMissiles
            currentIncoming = tbIncomingMissiles.Value;
            //A temporary point
            Point temp;
            //Gets the last canvas click to get rid of the run overs
            canvas.GetLastMouseLeftClick(out temp);
            canvas.GetLastMouseRightClick(out temp);
            //Sets the max and min values of the trackbars
            tbExplosionRadius.Maximum = 100;
            tbIncomingMissiles.Minimum = 5;
            switch (choice)
            {
                case Difficulty.Easy:       //Easist difficulty
                    livesLeft = 5;          //Set the number of lives left
                    timer.Interval = 100;   //Set the initial speed of the timer
                    maxOutgoing = 50;       //Set the number of max outgoing missiles
                    threshold = -1;         //Set the threshold to not speed up
                    weight = 100;           //Each missile hit give 100 points
                    break;
                case Difficulty.Moderate:   //Moderate difficulty
                    livesLeft = 5;          //Set the number of lives left
                    timer.Interval = 80;   //Set the initial speed of the timer
                    maxOutgoing = 25;       //Set the number of max outgoing missiles
                    threshold = 300;        //Set to speed up when threshold reaches #
                    weight = 250;           //Each missile hit give 250 points
                    break;
                case Difficulty.Hard:       //Hard difficulty
                    livesLeft = 3;          //Set the number of lives left
                    timer.Interval = 70;    //Set the initial speed of the timer
                    maxOutgoing = 15;       //Set the number of max outgoing missiles
                    threshold = 429;        //Set to speed up when threshold reaches #
                    weight = 500;           //Each missile hit give 500 points
                    break;
                case Difficulty.Legendary:  //Legendary difficulty
                    livesLeft = 2;          //Set the number of lives left
                    timer.Interval = 50;    //Set the initial speed of the timer
                    maxOutgoing = 5;        //Set the number of max outgoing missiles
                    threshold = 200;        //Set to speed up when threshold reaches #
                    weight = 1000;          //Each missile hit give 1000 points
                    break;
            }
        }
        /******************************************************************************
        * Region:      timer tick
        * Description: fires every time the timer fires
        * * **************************************************************************/
        private void timer_Tick(object sender, EventArgs e)
        {
            //Temp point
            Point p;
            //Clear the canvas
            canvas.Clear();
            //If the player still has some lives left
            if(livesLeft > 0)
            {
                //If there are less then the already rendered missiles are less then 
                        //number you are supposed to have 
                if (incoming.Count < currentIncoming)
                {
                    //Add a new missile to the incoming list
                    incoming.Add(new Missile());
                    //Increment the number of incoming total
                    numIncomingTotal++;
                }
                //If the user right or left clicks the canvas 
                if (canvas.GetLastMouseLeftClick(out p) || canvas.GetLastMouseRightClick(out p))
                    //If the player still has some missiles left to use
                    if (outgoing.Count < maxOutgoing)   
                    {
                        //Add a new missile to the outgoing list
                        outgoing.Add(new Missile(p));
                        //Increment the number of missiles launched
                        numLaunched++;
                    }
                //Call missileManagement method
                MissileManagement();
                //Render the canvas
                canvas.Render();
                //Update labels on form for stats and on canvas by calling method CanvasStringOutput
                CanvasStringOutput();
                //Increment the count
                count++;
                //If the mode isn't easy, where threshold would equal -1, and the count 
                        //equals the threshold value set for the difficulty
                        //and the timer interval isn't already going to fast
                if(threshold != -1 && count == threshold && timer.Interval > 25)
                {
                    //Decrement the timer interval
                    timer.Interval -= 5;
                    //reset the count
                    count = 0;
                }
            }
            else
            {
                //Call The GameOver method
                GameOver();
                //Call the HighScore method
                HighScore();
                //Write Game ending message to canvas
                canvas.AddText("Game Over", 25, Color.Red);
            }
        }
        /******************************************************************************
        * Region:      MissileManagement
        * Description: moves the missiles and checks if they are out of bounds or hit 
                            each other
        * * **************************************************************************/
        public void MissileManagement()
        {
            //Itterates through the incoming list and calls the move method in the missile class
            incoming.ForEach(m => m.Move());
            //Looks at all the missiles in the incoming and calls the SideBoundary method in 
                //the missile class and the itterates through those removing them from the 
                //incoming list
            incoming.FindAll(dead => dead.SideBoundary()).ForEach(dud => incoming.Remove(dud));
            //Looks at all the missiles in the incoming and calls the BotBoundary method in 
                //the missile class and if true itterate through those decrimenting the livesLeft
                //and removing them from the incoming list
            incoming.FindAll(kill => kill.BotBoundary()).ForEach(hit => { livesLeft--; incoming.Remove(hit); });
            //Itterates through the outgoing list and calls the move method in the missile class
            outgoing.ForEach(m => m.Move());
            //Looks at all the missiles in the outgoing list and calls AlphaCheck if it returns true
                //itterate through them removing them from the outgoing list
            outgoing.FindAll(explode => explode.AlphaCheck()).ForEach(explode => outgoing.Remove(explode));
            //Itterates through the outgoing list and finds all those that equal those in the incoming list 
                //itterating through them removing them from the incoming list adding to the score
                //incrementing the number of incoming destroyed
            outgoing.ForEach(m => incoming.FindAll(hit => hit.Equals(m)).ForEach(dead =>
                 { incoming.Remove(dead); score += weight; numIncomingDestroyed++; }));
            //Itterate through the incoming list and render the missiles
            incoming.ForEach(m => m.Rendering());
            //Itterate through the outgoing list and render the missiles
            outgoing.ForEach(m => m.Rendering());
        }
        /******************************************************************************
         * Region:      CanvasStringOutput
         * Description: 
         * * **************************************************************************/
        public void CanvasStringOutput()
        {
            //Changes the stats labels on the form
            lblTotalIncoming.Text = numIncomingTotal.ToString();
            lblDestroyed.Text = numIncomingDestroyed.ToString();
            lblLaunched.Text = numLaunched.ToString();
            if (numLaunched != 0)
                killRatio = 1.0 * numIncomingTotal / numLaunched;
            else
                killRatio = 0;
            lblKillRatio.Text = killRatio.ToString();
            lblScore.Text = score.ToString();
            //Adding the text to the canvas with the current values
            canvas.AddText("Missiles Remaining: " + (maxOutgoing - outgoing.Count).ToString(), 20, 0, canvas.ScaledHeight - 30, 300, 30, Color.Purple);
            canvas.AddText("Current Score: " + score.ToString(), 20, (canvas.ScaledWidth / 2) - 100, canvas.ScaledHeight - 30, 300, 30, Color.Purple);
            canvas.AddText("Lives Left: " + livesLeft, 20, canvas.ScaledWidth - 190, canvas.ScaledHeight - 30, 200, 30, Color.Purple);
        }
        /******************************************************************************
        * Region:      GameOver
        * Description: Method triggered when game ends
        * * **************************************************************************/
        public void GameOver()
        {
            //Disable the timer
            timer.Enabled = false;
            //Clear the canvas
            canvas.Clear();
            //Clear the incoming list
            incoming.Clear();
            //Clear the outgoing list
            outgoing.Clear();
            //Render the canvas
            canvas.Render();
            //Set defult radio button to easy
            rbEasy.Checked = true;
            //Button Management
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnCancel.Enabled = false;
        }
        /******************************************************************************
        * Region:      HighScore
        * Description: Finds the top five scores and sorts and writes them to the form
        * * **************************************************************************/
        public void HighScore()
        {
            //If the highScore list has less then 5
            if (highScore.Count < 5)
            {
                //Add the score to the list
                highScore.Add(score);
                //Sort the highScore list
                highScore.Sort();
                //Reverse the list
                highScore.Reverse();
            }
            //If the highScore list is already full
            else
            {
                //Itterate through the highScore list
                for (int index = 0; index < highScore.Count; index++)
                {
                    //If the current score is greater then the score at the index in the list
                    if (score > highScore[index])
                    {
                        //Find the max location in the list -1 and itterate through
                            //while your max is greader then the index decrementing 
                            //max each time
                        for (int max = highScore.Count - 1; max > index; max--)
                        {
                            //Set the current max to the location 1 before it
                            highScore[max] = highScore[max - 1];
                        }
                        //Set the score to the location of the index in highScore
                        highScore[index] = score;
                    }
                }
            }
            //Set the labels on the form to the highScores in the list
            lbl01.Text = highScore[0].ToString();
            if (highScore.Count > 1)
                lbl02.Text = highScore[1].ToString();
            if (highScore.Count > 2)
                lbl03.Text = highScore[2].ToString();
            if (highScore.Count > 3)
                lbl04.Text = highScore[3].ToString();
            if (highScore.Count > 4)
                lbl05.Text = highScore[4].ToString();
        }
        #region formEvents
        /******************************************************************************
        * Region:      FormEvents
        * Description: Methods that are triggered by events that take place on the form
        * * **************************************************************************/
        //Start Button---------------------//
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Enable the timer
            timer.Enabled = true;
            //Call the initilizer method
            Initilizer();
            //Button Management
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnCancel.Enabled = true;
            
        }
        //Pause Button---------------------//
        private void btnPause_Click(object sender, EventArgs e)
        {
            //Button Management
            if (timer.Enabled)
            {
                //Diable the timer
                timer.Enabled = false;
                btnPause.Text = "Continue";
            }
            else
            {
                timer.Enabled = true;
                btnPause.Text = "Pause";
            }
        }
        //Stop Button---------------------//
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Enable the timer
            timer.Enabled = false;
            //Call the gameOver method
            GameOver();
            //Print string to canvas
            canvas.AddText("Press start to try again...", 30, Color.Red);
            //Button text
            btnPause.Text = "Pause";
        }
        //Radio Buttons--------------------//
        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEasy.Checked)
            {
                //Set the choice to easy
                choice = Difficulty.Easy;
                //Set the bounds
                tbExplosionRadius.Maximum = 100;
                tbIncomingMissiles.Minimum = 5;
                //Set the default values of the trackbars
                tbIncomingMissiles.Value = 25;
                tbExplosionRadius.Value = 75;
                //Change the tickfrequency on the form
                tbIncomingMissiles.TickFrequency = 5;
            }
            else if (rbModerate.Checked)
            {
                //Set the choice to moderate
                choice = Difficulty.Moderate;
                //Set the bounds
                tbExplosionRadius.Maximum = 75;
                tbIncomingMissiles.Minimum = 25;
                //Set the default values of the trackbars
                tbIncomingMissiles.Value = 50;
                tbExplosionRadius.Value = 50;
                //Change the tickfrequency on the form
                tbIncomingMissiles.TickFrequency = 5;

            }
            else if (rbHard.Checked)
            {
                //Set the choice to hard
                choice = Difficulty.Hard;
                //Set the bounds
                tbExplosionRadius.Maximum = 50;
                tbIncomingMissiles.Minimum = 50;
                //Set the default values of the trackbars
                tbIncomingMissiles.Value = 75;
                tbExplosionRadius.Value = 25;
                //Change the tickfrequency on the form
                tbIncomingMissiles.TickFrequency = 2;

            }
            else if (rbLegendary.Checked)
            {
                //Set the choice to legendary
                choice = Difficulty.Legendary;
                //Set the bounds
                tbExplosionRadius.Maximum = 25;
                tbIncomingMissiles.Minimum = 75;
                //Set the default values of the trackbars
                tbIncomingMissiles.Value = 100;
                tbExplosionRadius.Value = 10;
                //Change the tickfrequency on the form
                tbIncomingMissiles.TickFrequency = 1;

            }
            //Update the trackBar labels
            lblNumMissiles.Text = tbIncomingMissiles.Value.ToString();
            lblExplosionRadius.Text = tbExplosionRadius.Value.ToString();
            //Set the explosionRadius of the class to the trackBar value
            Missile.ExplosionRadius = tbExplosionRadius.Value;
        }
        //ExplosionRadius trackBar----------//
        private void tbExplosionRadius_Scroll(object sender, EventArgs e)
        {
            //Changes the label for explosion radius as you move the trackbar
            lblExplosionRadius.Text = tbExplosionRadius.Value.ToString();
            //Sets the missile explosionRadius to the trackBar value
            Missile.ExplosionRadius = tbExplosionRadius.Value;
        }
        //IncomingMissiles trackBar----------//
        private void tbIncomingMissiles_Scroll(object sender, EventArgs e)
        {
            //Changes the label for number of missiles as you move the trackbar
            lblNumMissiles.Text = tbIncomingMissiles.Value.ToString();
        }
        #endregion
    }
}
