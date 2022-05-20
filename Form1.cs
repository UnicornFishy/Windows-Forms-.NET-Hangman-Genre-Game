using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace HangManGame
{
    public partial class a2 : Form
    {
        public a2()
        {
            InitializeComponent();
        }

        private void LoadBt_Click(object sender, EventArgs e)
        {
           //These are the strings and bools for the topics and word/answers
            bool Nintendo;
            bool Number;
            bool Planet;

            string NintendoTopic = "Nintendo";
            string NumberTopic = "Number";
            string PlanetTopic = "Planet";

            
            //This code sets the word into the text boxes if the player clicks load which the chosen topic
            if (TopicMenu.Text == NintendoTopic)
            {
                string NintendString = "Mario";
                Nintendo = true;

                Char[] array = NintendString.ToCharArray();

                Hiddentxt1.Text = array[0].ToString();
                Hiddentxt2.Text = array[1].ToString();
                Hiddentxt3.Text = array[2].ToString();
                Hiddentxt4.Text = array[3].ToString();
                Hiddentxt5.Text = array[4].ToString();

               
            }
            else if (TopicMenu.Text == NumberTopic)
            {
                string NumberString = "Eight";
                Number = true;

                Char[] array = NumberString.ToCharArray();
                
                Hiddentxt1.Text = array[0].ToString();
                Hiddentxt2.Text = array[1].ToString();
                Hiddentxt3.Text = array[2].ToString();
                Hiddentxt4.Text = array[3].ToString();
                Hiddentxt5.Text = array[4].ToString();

            }

            else if (TopicMenu.Text == PlanetTopic){ 
           
                string PlanetString = "Earth";
                Planet = true;

                Char[] array = PlanetString.ToCharArray();

                Hiddentxt1.Text = array[0].ToString();
                Hiddentxt2.Text = array[1].ToString();
                Hiddentxt3.Text = array[2].ToString();
                Hiddentxt4.Text = array[3].ToString();
                Hiddentxt5.Text = array[4].ToString();
            }
        }

        private void CheckBt_Click(object sender, EventArgs e)
        {
            // these bools are to indicate whether the answer lbls are correct or not
            bool correct = false;
            bool ans1 = false;
            bool ans2 = false;
            bool ans3 = false;
            bool ans4 = false;
            bool ans5 = false;

            //to calculate how many letters are correct
            int amountCorrect = 0;
            string amountCorrectStr;

           //The player can only enter one charater per box so this is to help them from entering more than one

            if (AnswerBox1.Text.Length > 1 || AnswerBox2.Text.Length >1 || AnswerBox3.Text.Length > 1 || AnswerBox4.Text.Length > 1 || AnswerBox5.Text.Length > 1)
            {
                Lbl1.Text = ("you can only enter one charater per box");
               
            }
            
            // to change the players input text into the string sensitive text, doesnt work for some reason

            AnswerBox1.Text.ToUpper();
            AnswerBox2.Text.ToLower();
            AnswerBox3.Text.ToLower();
            AnswerBox4.Text.ToLower();
            AnswerBox5.Text.ToLower();
             

            //This section displays if the letter is correct underneath the playerintput boxes
            if ( Hiddentxt1.Text == AnswerBox1.Text)
            {
                a1.Text = ("correct");
                ans1 = true;
            }
            else { a1.Text = ("incorrect"); }
            
            if ( Hiddentxt2.Text == AnswerBox2.Text)
            {
                aa2.Text = ("correct");
                ans2 = true;
            }
            else { aa2.Text = ("incorrect"); }
            
            if (Hiddentxt3.Text == AnswerBox3.Text)
            {
                a3.Text = ("correct");
                ans3 = true;
            }
            else { a3.Text = ("incorrect"); }
            
            if (Hiddentxt4.Text == AnswerBox4.Text)
            {
                a4.Text = ("correct");
                ans4 = true;
            }
            else { a4.Text = ("incorrect"); }

            
            if (Hiddentxt5.Text == AnswerBox5.Text)
            {
                a5.Text = ("correct");
                ans5 = true;
            }
            else { a5.Text = ("incorrect"); }

            if ( ans1 && ans2 && ans3 && ans4 && ans5 == true)
            {
                WinLbl.Text = ("You have won");
            }
            
            if(a1.Text == "correct")
            {
                amountCorrect++;
            }
            if (aa2.Text == "correct")
            {
                amountCorrect++;
            }
            if (a3.Text == "correct")
            {
                amountCorrect++;
            }
            if (a4.Text == "correct")
            {
                amountCorrect++;
            }
            if (a5.Text == "correct")
            {
                amountCorrect++;
            }

            amountCorrectStr = Convert.ToString(amountCorrect);

            amountCorrectLbl.Text = ("Out of 5 words you have " + amountCorrectStr + "correct");
        }

        

        private void a5_Click(object sender, EventArgs e)
        { }

        private void HideBt_Click(object sender, EventArgs e)
        {
            //hide word button is toggle-able so that you can toggle the boxes from visible to invisible or visa versa
            
            if (Hiddentxt1.Visible &&  Hiddentxt2.Visible && Hiddentxt3.Visible && Hiddentxt4.Visible && Hiddentxt5.Visible ) 
            { Hiddentxt1.Visible = false; Hiddentxt2.Visible = false; Hiddentxt3.Visible = false; Hiddentxt4.Visible = false; Hiddentxt5.Visible = false; }
            else { Hiddentxt1.Visible = true; Hiddentxt2.Visible = true; Hiddentxt3.Visible = true; Hiddentxt4.Visible = true; Hiddentxt5.Visible = true; }

            if (Hiddentxt1.Visible is false)
            {
                HideBt.Text = ("Show hint");
            }
            else 
            {
                HideBt.Text = ("Hide hint");
                    }
            
            
        }

        private void TopicMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // *unnessesary* On selection of topic boxes go invisible so that the word will not be seen when load word is clicked
            
            //if (Hiddentxt1.Visible && Hiddentxt2.Visible && Hiddentxt3.Visible && Hiddentxt4.Visible && Hiddentxt5.Visible)
            //{ Hiddentxt1.Visible = false; Hiddentxt2.Visible = false; Hiddentxt3.Visible = false; Hiddentxt4.Visible = false; Hiddentxt5.Visible = false; }

            
           
        }
    }
}

//Planet Earth
//Number Eight
//Nintendo Mario
/**
                foreach (char value in array)
               {
                 Write( "{0}, {1}, {2}, {3}, {4}", Hiddentxt1, Hiddentxt2, Hiddentxt3, Hiddentxt4, Hiddentxt5);

               }
               
               WriteLine (array, "{0}, {1}, {2}, {3}, {4}", Hiddentxt1, Hiddentxt2, Hiddentxt3, Hiddentxt4, Hiddentxt5);

              
            if (Hiddentxt1.Visible,  Hiddentxt2.Visible , Hiddentxt3.Visible , Hiddentxt4.Visible , Hiddentxt5.Visible ) 
            { Hiddentxt1.Visible = false && Hiddentxt2.Visible = false && Hiddentxt3.Visible = false&& Hiddentxt4.Visible = false && Hiddentxt5.Visible = false; }
            else { Hiddentxt1.Visible = true && Hiddentxt2.Visible = true&& Hiddentxt3.Visible = true&& Hiddentxt4.Visible = true&& Hiddentxt5.Visible = true; } 

 **/