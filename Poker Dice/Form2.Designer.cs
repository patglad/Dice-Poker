using System.Drawing;
using System.Windows.Forms;

namespace Poker_Dice
{
    public struct SingleDice
    {
        public int value;
        public string image;
        public PictureBox pictureBox;
    }
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        public const int maxPoints = 20;
        public int points1 = maxPoints;
        public int points2 = maxPoints;
        public int pool = 0;
        public int n1, n2 = 0;  //how many dice to change
        public int whichDice = 0;   //number of dice to change
        public int configuration1, configuration2 = 0;  //poker, one pair, two pair etc.
        public bool changeDice = false;
        public int numberOfBets1 = 0;
        public int numberOfBets2 = 0;   // ilosc postawionych punktow w calej licytacji przez gracza 1 i 2
        public int betByPlayer1 = 0;
        public int betByPlayer2 = 0;  // pojedyncze obstawienie gracza 1 i 2
        public int min, max;           // dozwolone minimalne i maksymalne obstawienie
        public bool player1Active = true;
        public string gameStage = "";
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Player1_label = new System.Windows.Forms.Label();
            this.Player2_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Player1Points_label = new System.Windows.Forms.Label();
            this.Player2Points_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PoolPoints_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.WhichPlayer_label = new System.Windows.Forms.Label();
            this.Random1_button = new System.Windows.Forms.Button();
            this.Result1_label = new System.Windows.Forms.Label();
            this.Result2_label = new System.Windows.Forms.Label();
            this.Random2_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Raise = new System.Windows.Forms.Button();
            this.StartGame_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Change1_button = new System.Windows.Forms.Button();
            this.Change2_button = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1_label
            // 
            this.Player1_label.AutoSize = true;
            this.Player1_label.BackColor = System.Drawing.Color.Transparent;
            this.Player1_label.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.Player1_label.ForeColor = System.Drawing.Color.White;
            this.Player1_label.Location = new System.Drawing.Point(69, 8);
            this.Player1_label.Name = "Player1_label";
            this.Player1_label.Size = new System.Drawing.Size(106, 25);
            this.Player1_label.TabIndex = 0;
            this.Player1_label.Text = "Player 1";
            // 
            // Player2_label
            // 
            this.Player2_label.AutoSize = true;
            this.Player2_label.BackColor = System.Drawing.Color.Transparent;
            this.Player2_label.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.Player2_label.ForeColor = System.Drawing.Color.White;
            this.Player2_label.Location = new System.Drawing.Point(445, 8);
            this.Player2_label.Name = "Player2_label";
            this.Player2_label.Size = new System.Drawing.Size(106, 25);
            this.Player2_label.TabIndex = 1;
            this.Player2_label.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Points:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(445, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Points:";
            // 
            // Player1Points_label
            // 
            this.Player1Points_label.AutoSize = true;
            this.Player1Points_label.BackColor = System.Drawing.Color.Transparent;
            this.Player1Points_label.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.Player1Points_label.ForeColor = System.Drawing.Color.White;
            this.Player1Points_label.Location = new System.Drawing.Point(153, 33);
            this.Player1Points_label.Name = "Player1Points_label";
            this.Player1Points_label.Size = new System.Drawing.Size(42, 25);
            this.Player1Points_label.TabIndex = 6;
            this.Player1Points_label.Text = "20";
            // 
            // Player2Points_label
            // 
            this.Player2Points_label.AutoSize = true;
            this.Player2Points_label.BackColor = System.Drawing.Color.Transparent;
            this.Player2Points_label.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.Player2Points_label.ForeColor = System.Drawing.Color.White;
            this.Player2Points_label.Location = new System.Drawing.Point(529, 33);
            this.Player2Points_label.Name = "Player2Points_label";
            this.Player2Points_label.Size = new System.Drawing.Size(42, 25);
            this.Player2Points_label.TabIndex = 7;
            this.Player2Points_label.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(799, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "POOL:";
            // 
            // PoolPoints_label
            // 
            this.PoolPoints_label.AutoSize = true;
            this.PoolPoints_label.BackColor = System.Drawing.Color.Transparent;
            this.PoolPoints_label.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.PoolPoints_label.ForeColor = System.Drawing.Color.White;
            this.PoolPoints_label.Location = new System.Drawing.Point(878, 23);
            this.PoolPoints_label.Name = "PoolPoints_label";
            this.PoolPoints_label.Size = new System.Drawing.Size(27, 25);
            this.PoolPoints_label.TabIndex = 9;
            this.PoolPoints_label.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(524, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(600, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(679, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.Location = new System.Drawing.Point(751, 174);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.Location = new System.Drawing.Point(820, 208);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox6.Location = new System.Drawing.Point(142, 350);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox7.Location = new System.Drawing.Point(205, 394);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(57, 57);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox8.Location = new System.Drawing.Point(279, 427);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(57, 57);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox9.Location = new System.Drawing.Point(364, 446);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(57, 57);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox10.Location = new System.Drawing.Point(451, 458);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(57, 57);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // WhichPlayer_label
            // 
            this.WhichPlayer_label.AutoSize = true;
            this.WhichPlayer_label.BackColor = System.Drawing.Color.Transparent;
            this.WhichPlayer_label.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.WhichPlayer_label.ForeColor = System.Drawing.Color.White;
            this.WhichPlayer_label.Location = new System.Drawing.Point(215, 289);
            this.WhichPlayer_label.Name = "WhichPlayer_label";
            this.WhichPlayer_label.Size = new System.Drawing.Size(85, 25);
            this.WhichPlayer_label.TabIndex = 24;
            this.WhichPlayer_label.Text = "Player";
            // 
            // Random1_button
            // 
            this.Random1_button.Enabled = false;
            this.Random1_button.Font = new System.Drawing.Font("Lithos Pro Regular", 12.75F);
            this.Random1_button.Location = new System.Drawing.Point(405, 115);
            this.Random1_button.Name = "Random1_button";
            this.Random1_button.Size = new System.Drawing.Size(104, 30);
            this.Random1_button.TabIndex = 25;
            this.Random1_button.Text = "Roll dice";
            this.Random1_button.UseVisualStyleBackColor = true;
            this.Random1_button.Click += new System.EventHandler(this.Random1_button_Click);
            // 
            // Result1_label
            // 
            this.Result1_label.AutoSize = true;
            this.Result1_label.BackColor = System.Drawing.Color.Transparent;
            this.Result1_label.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.Result1_label.ForeColor = System.Drawing.Color.White;
            this.Result1_label.Location = new System.Drawing.Point(710, 107);
            this.Result1_label.Name = "Result1_label";
            this.Result1_label.Size = new System.Drawing.Size(114, 25);
            this.Result1_label.TabIndex = 26;
            this.Result1_label.Text = "Nothing";
            // 
            // Result2_label
            // 
            this.Result2_label.AutoSize = true;
            this.Result2_label.BackColor = System.Drawing.Color.Transparent;
            this.Result2_label.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.Result2_label.ForeColor = System.Drawing.Color.White;
            this.Result2_label.Location = new System.Drawing.Point(543, 478);
            this.Result2_label.Name = "Result2_label";
            this.Result2_label.Size = new System.Drawing.Size(114, 25);
            this.Result2_label.TabIndex = 27;
            this.Result2_label.Text = "Nothing";
            // 
            // Random2_button
            // 
            this.Random2_button.Enabled = false;
            this.Random2_button.Font = new System.Drawing.Font("Lithos Pro Regular", 12.75F);
            this.Random2_button.Location = new System.Drawing.Point(778, 562);
            this.Random2_button.Name = "Random2_button";
            this.Random2_button.Size = new System.Drawing.Size(104, 30);
            this.Random2_button.TabIndex = 28;
            this.Random2_button.Text = "Roll dice";
            this.Random2_button.UseVisualStyleBackColor = true;
            this.Random2_button.Click += new System.EventHandler(this.Random2_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Player 2";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.numericUpDown1.Location = new System.Drawing.Point(433, 343);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 33);
            this.numericUpDown1.TabIndex = 32;
            // 
            // Raise
            // 
            this.Raise.Enabled = false;
            this.Raise.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.Raise.Location = new System.Drawing.Point(505, 343);
            this.Raise.Name = "Raise";
            this.Raise.Size = new System.Drawing.Size(89, 33);
            this.Raise.TabIndex = 34;
            this.Raise.Text = "Raise";
            this.Raise.UseVisualStyleBackColor = true;
            this.Raise.Click += new System.EventHandler(this.Raise_Click);
            // 
            // StartGame_button
            // 
            this.StartGame_button.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.StartGame_button.Location = new System.Drawing.Point(29, 625);
            this.StartGame_button.Name = "StartGame_button";
            this.StartGame_button.Size = new System.Drawing.Size(217, 41);
            this.StartGame_button.TabIndex = 46;
            this.StartGame_button.Text = "Start new game";
            this.StartGame_button.UseVisualStyleBackColor = true;
            this.StartGame_button.Click += new System.EventHandler(this.StartGame_button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.button3.Location = new System.Drawing.Point(908, 635);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 39);
            this.button3.TabIndex = 47;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Change1_button
            // 
            this.Change1_button.Enabled = false;
            this.Change1_button.Font = new System.Drawing.Font("Lithos Pro Regular", 12.75F);
            this.Change1_button.Location = new System.Drawing.Point(415, 151);
            this.Change1_button.Name = "Change1_button";
            this.Change1_button.Size = new System.Drawing.Size(94, 26);
            this.Change1_button.TabIndex = 48;
            this.Change1_button.Text = "Change";
            this.Change1_button.UseVisualStyleBackColor = true;
            this.Change1_button.Click += new System.EventHandler(this.Change1_button_Click);
            // 
            // Change2_button
            // 
            this.Change2_button.Enabled = false;
            this.Change2_button.Font = new System.Drawing.Font("Lithos Pro Regular", 12.75F);
            this.Change2_button.Location = new System.Drawing.Point(788, 530);
            this.Change2_button.Name = "Change2_button";
            this.Change2_button.Size = new System.Drawing.Size(94, 26);
            this.Change2_button.TabIndex = 49;
            this.Change2_button.Text = "Change";
            this.Change2_button.UseVisualStyleBackColor = true;
            this.Change2_button.Click += new System.EventHandler(this.Change2_button_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(364, 113);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 35);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 50;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(737, 559);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(35, 35);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 51;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox13.Enabled = false;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(165, 111);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(70, 70);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 52;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Visible = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox14.Enabled = false;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(66, 457);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(70, 70);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 53;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Visible = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(747, 522);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(35, 35);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 54;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(372, 151);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(35, 35);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 55;
            this.pictureBox16.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 678);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.Change2_button);
            this.Controls.Add(this.Change1_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.StartGame_button);
            this.Controls.Add(this.Raise);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Random2_button);
            this.Controls.Add(this.Result2_label);
            this.Controls.Add(this.Result1_label);
            this.Controls.Add(this.Random1_button);
            this.Controls.Add(this.WhichPlayer_label);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PoolPoints_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Player2Points_label);
            this.Controls.Add(this.Player1Points_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Player2_label);
            this.Controls.Add(this.Player1_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poker Dice";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player1_label;
        private System.Windows.Forms.Label Player2_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Player1Points_label;
        private System.Windows.Forms.Label Player2Points_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PoolPoints_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label WhichPlayer_label;
        private System.Windows.Forms.Button Random1_button;
        private System.Windows.Forms.Label Result1_label;
        private System.Windows.Forms.Label Result2_label;
        private System.Windows.Forms.Button Random2_button;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button Raise;
        private Button StartGame_button;
        private Button button3;
        private Button Change1_button;
        private Button Change2_button;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
    }
}