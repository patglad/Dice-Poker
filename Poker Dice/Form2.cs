using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Poker_Dice
{
    public partial class Game : Form
    {
        Dice player1Dice = new Dice();
        Dice player2Dice = new Dice();

        public Game(string strTextbox1, string strTextbox2)
        {
            InitializeComponent();
            player1Dice.tab[0].pictureBox = pictureBox1;
            player1Dice.tab[1].pictureBox = pictureBox2;
            player1Dice.tab[2].pictureBox = pictureBox3;
            player1Dice.tab[3].pictureBox = pictureBox4;
            player1Dice.tab[4].pictureBox = pictureBox5;

            player2Dice.tab[0].pictureBox = pictureBox6;
            player2Dice.tab[1].pictureBox = pictureBox7;
            player2Dice.tab[2].pictureBox = pictureBox8;
            player2Dice.tab[3].pictureBox = pictureBox9;
            player2Dice.tab[4].pictureBox = pictureBox10;

            // Rounded pictureboxes.
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox11.Width - 3, pictureBox11.Height - 3);
            Region rg = new Region(gp);
            pictureBox11.Region = rg;
            pictureBox12.Region = rg;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

            Player1_label.Text = strTextbox1;
            Player2_label.Text = strTextbox2;
            label1.Text = strTextbox1;
            label2.Text = strTextbox2;
            Result1_label.Text = "";
            Result2_label.Text = "";
            WhichPlayer_label.Text = "";

            numericUpDown1.Value = 0;

            Player1Points_label.Text = Convert.ToString(maxPoints);
            Player2Points_label.Text = Convert.ToString(maxPoints);
        }

        private void Random1_button_Click(object sender, EventArgs e)
        {
            player1Dice.DrawDiceRandomly();
            Dice diceSort = new Dice();
            player1Dice.SortDice(player1Dice, diceSort);
            Result1_label.Text = player1Dice.ConfigurationName(diceSort);
            Random1_button.Enabled = false;
            if (Random1_button.Enabled == false && Random2_button.Enabled == false && points1 > 0 && points2 > 0)
            {
                gameStage = "raise2";
                numericUpDown1.Enabled = true;
                Raise.Enabled = true;
                numberOfBets1 = 0;
                numberOfBets2 = 0;
                betByPlayer1 = 0;
                betByPlayer2 = 0;
                min = Math.Max(numberOfBets2 - numberOfBets1, 1);
                max = Math.Min(points2 + numberOfBets2 - numberOfBets1, points1);
                numericUpDown1.Minimum = min;
                numericUpDown1.Maximum = max;
                
                player1Active = true;
                WhichPlayer_label.Text = Player1_label.Text + ", how many points do you bet? [" + min + ", " + max + "]: ";
            }
            if (Random1_button.Enabled == false && Random2_button.Enabled == false && (points1 == 0 || points2 == 0))
            {
                gameStage = "change";
                MessageBox.Show("Choose dice to change");
                Raise.Enabled = false;
                numericUpDown1.Enabled = false;
                Random1_button.Enabled = false;
                Random2_button.Enabled = false;
                Change1_button.Enabled = true;
                Change2_button.Enabled = true;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                WhichPlayer_label.Text = "";
            }
        }

        private void Random2_button_Click(object sender, EventArgs e)
        {
            player2Dice.DrawDiceRandomly();
            Dice diceSort = new Dice();
            player2Dice.SortDice(player2Dice, diceSort);
            Result2_label.Text = player2Dice.ConfigurationName(diceSort);
            Random2_button.Enabled = false;
            if (Random1_button.Enabled == false && Random2_button.Enabled == false && points1 > 0 && points2 > 0)
            {
                gameStage = "raise2";
                numericUpDown1.Enabled = true;
                Raise.Enabled = true;
                numberOfBets1 = 0;
                numberOfBets2 = 0;
                betByPlayer1 = 0;
                betByPlayer2 = 0;
                min = Math.Max(numberOfBets2 - numberOfBets1, 1);
                max = Math.Min(points2 + numberOfBets2 - numberOfBets1, points1);
                numericUpDown1.Minimum = min;
                numericUpDown1.Maximum = max;

                player1Active = true;
                WhichPlayer_label.Text = Player1_label.Text + ", how many points do you bet? [" + min + ", " + max + "]: ";
            }
            if (Random1_button.Enabled == false && Random2_button.Enabled == false && (points1 == 0 || points2 == 0))
            {
                gameStage = "change";
                MessageBox.Show("Choose dice to change");
                Raise.Enabled = false;
                numericUpDown1.Enabled = false;
                Random1_button.Enabled = false;
                Random2_button.Enabled = false;
                Change1_button.Enabled = true;
                Change2_button.Enabled = true;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                WhichPlayer_label.Text = "";
            }
        }

        public void ScreenRefresh(int points1, int points2, int pool)
        {
            Player1Points_label.Text = points1.ToString();
            Player2Points_label.Text = points2.ToString();
            PoolPoints_label.Text = pool.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (gameStage == "change")
            {
                if (player1Dice.tab[0].image == "../../0.png")
                {
                    player1Dice.tab[0].image = "../../" + player1Dice.tab[0].value + ".png";
                    player1Dice.tab[0].pictureBox.Image = Image.FromFile(player1Dice.tab[0].image);
                }
                else
                {
                    player1Dice.tab[0].image = "../../0.png";
                    player1Dice.tab[0].pictureBox.Image = Image.FromFile(player1Dice.tab[0].image);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (gameStage == "change")
            {
                if (player1Dice.tab[1].image == "../../0.png")
                {
                    player1Dice.tab[1].image = "../../" + player1Dice.tab[1].value + ".png";
                    player1Dice.tab[1].pictureBox.Image = Image.FromFile(player1Dice.tab[1].image);
                }
                else
                {
                    player1Dice.tab[1].image = "../../0.png";
                    player1Dice.tab[1].pictureBox.Image = Image.FromFile(player1Dice.tab[1].image);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (gameStage == "change")
            {
                if (player1Dice.tab[2].image == "../../0.png")
                {
                    player1Dice.tab[2].image = "../../" + player1Dice.tab[2].value + ".png";
                    player1Dice.tab[2].pictureBox.Image = Image.FromFile(player1Dice.tab[2].image);
                }
                else
                {
                    player1Dice.tab[2].image = "../../0.png";
                    player1Dice.tab[2].pictureBox.Image = Image.FromFile(player1Dice.tab[2].image);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (gameStage == "change")
            {
                if (player1Dice.tab[3].image == "../../0.png")
                {
                    player1Dice.tab[3].image = "../../" + player1Dice.tab[3].value + ".png";
                    player1Dice.tab[3].pictureBox.Image = Image.FromFile(player1Dice.tab[3].image);
                }
                else
                {
                    player1Dice.tab[3].image = "../../0.png";
                    player1Dice.tab[3].pictureBox.Image = Image.FromFile(player1Dice.tab[3].image);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (gameStage == "change")
            {
                if (player1Dice.tab[4].image == "../../0.png")
                {
                    player1Dice.tab[4].image = "../../" + player1Dice.tab[4].value + ".png";
                    player1Dice.tab[4].pictureBox.Image = Image.FromFile(player1Dice.tab[4].image);
                }
                else
                {
                    player1Dice.tab[4].image = "../../0.png";
                    player1Dice.tab[4].pictureBox.Image = Image.FromFile(player1Dice.tab[4].image);
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (gameStage == "change")
            {
                if (player2Dice.tab[0].image == "../../0.png")
                {
                    player2Dice.tab[0].image = "../../" + player2Dice.tab[0].value + ".png";
                    player2Dice.tab[0].pictureBox.Image = Image.FromFile(player2Dice.tab[0].image);
                }
                else
                {
                    player2Dice.tab[0].image = "../../0.png";
                    player2Dice.tab[0].pictureBox.Image = Image.FromFile(player2Dice.tab[0].image);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (gameStage == "change")
            {
                if (player2Dice.tab[1].image == "../../0.png")
                {
                    player2Dice.tab[1].image = "../../" + player2Dice.tab[1].value + ".png";
                    player2Dice.tab[1].pictureBox.Image = Image.FromFile(player2Dice.tab[1].image);
                }
                else
                {
                    player2Dice.tab[1].image = "../../0.png";
                    player2Dice.tab[1].pictureBox.Image = Image.FromFile(player2Dice.tab[1].image);
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (gameStage == "change")
            {
                if (player2Dice.tab[2].image == "../../0.png")
                {
                    player2Dice.tab[2].image = "../../" + player2Dice.tab[2].value + ".png";
                    player2Dice.tab[2].pictureBox.Image = Image.FromFile(player2Dice.tab[2].image);
                }
                else
                {
                    player2Dice.tab[2].image = "../../0.png";
                    player2Dice.tab[2].pictureBox.Image = Image.FromFile(player2Dice.tab[2].image);
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (gameStage == "change")
            {
                if (player2Dice.tab[3].image == "../../0.png")
                {
                    player2Dice.tab[3].image = "../../" + player2Dice.tab[3].value + ".png";
                    player2Dice.tab[3].pictureBox.Image = Image.FromFile(player2Dice.tab[3].image);
                }
                else
                {
                    player2Dice.tab[3].image = "../../0.png";
                    player2Dice.tab[3].pictureBox.Image = Image.FromFile(player2Dice.tab[3].image);
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (gameStage == "change")
            {
                if (player2Dice.tab[4].image == "../../0.png")
                {
                    player2Dice.tab[4].image = "../../" + player2Dice.tab[4].value + ".png";
                    player2Dice.tab[4].pictureBox.Image = Image.FromFile(player2Dice.tab[4].image);
                }
                else
                {
                    player2Dice.tab[4].image = "../../0.png";
                    player2Dice.tab[4].pictureBox.Image = Image.FromFile(player2Dice.tab[4].image);
                }
            }
        }

        private void StartGame_button_Click(object sender, EventArgs e)
        {
            points1 = 20;
            points2 = 20;
            pool = 0;
            numberOfBets1 = 0;
            numberOfBets2 = 0;
            betByPlayer1 = 0;
            betByPlayer2 = 0;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;

            player1Dice.ZeroDice();
            player2Dice.ZeroDice();
            ScreenRefresh(points1, points2, pool);

            min = Math.Max(numberOfBets2 - numberOfBets1, 1);
            max = Math.Min(points2 + numberOfBets2 - numberOfBets1, points1);
            numericUpDown1.Minimum = min;
            numericUpDown1.Maximum = max;
            WhichPlayer_label.Text = Player1_label.Text + ", how many points do you bet? [" + min + ", " + max + "]: ";

            Raise.Enabled = true;
            numericUpDown1.Enabled = true;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;

            player1Active = true;
            gameStage = "raise1";
        }

        private void Raise_Click(object sender, EventArgs e)
        {
            if (player1Active)
            {
                min = Math.Max(numberOfBets2 - numberOfBets1, 1);
                max = Math.Min(points2 + numberOfBets2 - numberOfBets1, points1);
                numericUpDown1.Minimum = min;
                numericUpDown1.Maximum = max;
                WhichPlayer_label.Text = Player1_label.Text + ", how many points do you bet? [" + min + ", " + max + "]: ";
                betByPlayer1 = Convert.ToInt32(numericUpDown1.Value);
                
                if (betByPlayer1>=min && betByPlayer1<=max)
                {
                    numberOfBets1 = numberOfBets1 + betByPlayer1;
                    points1 = points1 - betByPlayer1;
                    pool = pool + betByPlayer1;

                    ScreenRefresh(points1, points2, pool);
                    player1Active = false;

                    if (numberOfBets1 != numberOfBets2)   
                    {
                        min = Math.Max(numberOfBets1 - numberOfBets2, 1);
                        max = Math.Min(points1 + numberOfBets1 - numberOfBets2, points2);
                        numericUpDown1.Minimum = min;
                        numericUpDown1.Maximum = max;
                        WhichPlayer_label.Text = Player2_label.Text + ", how many points do you bet? [" + min + ", " + max + "]: ";
                    }
                }
            }
            // If playerActive==false.
            else
            {
                if (numberOfBets1 != numberOfBets2)
                {
                    min = Math.Max(numberOfBets1 - numberOfBets2, 1);
                    max = Math.Min(points1 + numberOfBets1 - numberOfBets2, points2);
                    numericUpDown1.Minimum = min;
                    numericUpDown1.Maximum = max;
                    WhichPlayer_label.Text = Player2_label.Text + ", how many points do you bet? [" + min + ", " + max + "]: ";
                    betByPlayer2 = Convert.ToInt32(numericUpDown1.Value);
                    
                    if (betByPlayer2>=min && betByPlayer2<=max)
                    {
                        numberOfBets2 = numberOfBets2 + betByPlayer2;
                        points2 = points2 - betByPlayer2;
                        pool = pool + betByPlayer2;

                        ScreenRefresh(points1, points2, pool);
                        player1Active = true;

                        if(numberOfBets1!=numberOfBets2)  
                        {
                            min = Math.Max(numberOfBets2 - numberOfBets1, 1);
                            max = Math.Min(points2 + numberOfBets2 - numberOfBets1, points1);
                            numericUpDown1.Minimum = min;
                            numericUpDown1.Maximum = max;
                            WhichPlayer_label.Text = Player1_label.Text + ", how many points do you bet? [" + min + ", " + max + "]: ";
                        }
                    }
                }
            }
            if (numberOfBets1 == numberOfBets2)
            {
                numericUpDown1.Enabled = false;
                Raise.Enabled = false;
                Random1_button.Enabled = true;
                Random2_button.Enabled = true;
                WhichPlayer_label.Text = "";
                if (gameStage == "raise1")
                    MessageBox.Show("Rolling!");
                else if (gameStage == "raise2")
                {
                    gameStage = "change";
                    MessageBox.Show("Choose dice to change");
                    Change1_button.Enabled = true;
                    Change2_button.Enabled = true;
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    pictureBox10.Enabled = true;
                    Random1_button.Enabled = false;
                    Random2_button.Enabled = false;
                }
            }
        }

        private void Change1_button_Click(object sender, EventArgs e)
        {
            Change1_button.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;

            if (Change1_button.Enabled == false && Change2_button.Enabled == false)
            {
                gameStage = "final";
                player1Dice.DrawDiceRandomly();
                player2Dice.DrawDiceRandomly();
               
                Dice diceSort = new Dice();
                
                player1Dice.SortDice(player1Dice, diceSort);
                Result1_label.Text = player1Dice.ConfigurationName(diceSort);
                configuration1 = player1Dice.Value(diceSort);
                
                player2Dice.SortDice(player2Dice, diceSort);
                Result2_label.Text = player2Dice.ConfigurationName(diceSort);
                configuration2 = player2Dice.Value(diceSort);

                if (configuration1 > configuration2)
                {
                    points1 = points1 + pool;
                    pool = 0;
                    ScreenRefresh(points1, points2, pool);
                    pictureBox13.Visible = true;
                    MessageBox.Show("The winner is " + Player1_label.Text + "!", "Congratulations");
                }
                else if (configuration1 < configuration2)
                {
                    points2 = points2 + pool;
                    pool = 0;
                    ScreenRefresh(points1, points2, pool);
                    pictureBox14.Visible = true;
                    MessageBox.Show("The winner is " + Player2_label.Text + "!", "Congratulations");
                }
                else
                {
                    points1 = points1 + pool / 2;
                    points2 = points2 + pool / 2;
                    pool = 0;
                    ScreenRefresh(points1, points2, pool);
                    pictureBox13.Visible = true;
                    pictureBox14.Visible = true;
                    MessageBox.Show("We have a tie!");
                }
                    
                if (points1 > 0 && points2 > 0)
                {
                    gameStage = "raise1";
                    numberOfBets1 = 0;
                    numberOfBets2 = 0;
                    betByPlayer1 = 0;
                    betByPlayer2 = 0;
                    player1Dice.ZeroDice();
                    player2Dice.ZeroDice();
                    ScreenRefresh(points1, points2, pool);
                    min = Math.Max(numberOfBets2 - numberOfBets1, 1);
                    max = Math.Min(points2 + numberOfBets2 - numberOfBets1, points1);
                    numericUpDown1.Minimum = min;
                    numericUpDown1.Maximum = max;
                    WhichPlayer_label.Text = Player1_label.Text + ", how many points do you bet? [" + min + ", " + max + "]: ";

                    Random1_button.Enabled = false;
                    Random2_button.Enabled = false;
                    Raise.Enabled = true;
                    numericUpDown1.Enabled = true;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    Result1_label.Text = "";
                    Result2_label.Text = "";

                    player1Active = true;
                }
                else if (points1 == 0)
                        MessageBox.Show(Player2_label.Text + " won the game!", "Congratulations!");
                else if (points2 == 0)
                        MessageBox.Show(Player1_label.Text + " won the game!", "Congratulations!");
            }
        }

        private void Change2_button_Click(object sender, EventArgs e)
        {
            Change2_button.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;

            if (Change1_button.Enabled == false && Change2_button.Enabled == false)
            {
                gameStage = "final";
                player1Dice.DrawDiceRandomly();
                player2Dice.DrawDiceRandomly();

                Dice diceSort = new Dice();

                player1Dice.SortDice(player1Dice, diceSort);
                Result1_label.Text = player1Dice.ConfigurationName(diceSort);
                configuration1 = player1Dice.Value(diceSort);

                player2Dice.SortDice(player2Dice, diceSort);
                Result2_label.Text = player2Dice.ConfigurationName(diceSort);
                configuration2 = player2Dice.Value(diceSort);

                if (configuration1 > configuration2)
                {
                    points1 = points1 + pool;
                    pool = 0;
                    ScreenRefresh(points1, points2, pool);
                    pictureBox13.Visible = true;
                    MessageBox.Show("The winner is " + Player1_label.Text + "!", "Congratulations");
                }
                else if (configuration1 < configuration2)
                {
                    points2 = points2 + pool;
                    pool = 0;
                    ScreenRefresh(points1, points2, pool);
                    pictureBox14.Visible = true;
                    MessageBox.Show("The winner is " + Player2_label.Text + "!", "Congratulations");
                }
                else
                {
                    points1 = points1 + pool / 2;
                    points2 = points2 + pool / 2;
                    pool = 0;
                    ScreenRefresh(points1, points2, pool);
                    pictureBox13.Visible = true;
                    pictureBox14.Visible = true;
                    MessageBox.Show("We have a tie!");
                }

                if (points1 > 0 && points2 > 0)
                {
                    gameStage = "raise1";
                    numberOfBets1 = 0;
                    numberOfBets2 = 0;
                    betByPlayer1 = 0;
                    betByPlayer2 = 0;
                    player1Dice.ZeroDice();
                    player2Dice.ZeroDice();
                    ScreenRefresh(points1, points2, pool);
                    min = Math.Max(numberOfBets2 - numberOfBets1, 1);
                    max = Math.Min(points2 + numberOfBets2 - numberOfBets1, points1);
                    numericUpDown1.Minimum = min;
                    numericUpDown1.Maximum = max;
                    WhichPlayer_label.Text = Player1_label.Text + ", how many points do you bet? [" + min + ", " + max + "]: ";

                    Random1_button.Enabled = false;
                    Random2_button.Enabled = false;
                    Raise.Enabled = true;
                    numericUpDown1.Enabled = true;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    Result1_label.Text = "";
                    Result2_label.Text = "";

                    player1Active = true;
                }
                else if (points1 == 0)
                    MessageBox.Show(Player2_label.Text + " won the game!", "Congratulations");
                else if (points2 == 0)
                    MessageBox.Show(Player1_label.Text + " won the game!", "Congratulations");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }// Class.
}// Namespace.
