namespace Poker_Dice
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Player2Name_textbox = new System.Windows.Forms.TextBox();
            this.Player1Name_textbox = new System.Windows.Forms.TextBox();
            this.Player2_label = new System.Windows.Forms.Label();
            this.Player1_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start.Font = new System.Drawing.Font("Lithos Pro Regular", 18.75F);
            this.start.Location = new System.Drawing.Point(779, 520);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(107, 44);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lithos Pro Regular", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 113);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dice Poker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Player2Name_textbox
            // 
            this.Player2Name_textbox.Font = new System.Drawing.Font("Lithos Pro Regular", 12.75F);
            this.Player2Name_textbox.Location = new System.Drawing.Point(477, 399);
            this.Player2Name_textbox.MaxLength = 15;
            this.Player2Name_textbox.Name = "Player2Name_textbox";
            this.Player2Name_textbox.Size = new System.Drawing.Size(142, 28);
            this.Player2Name_textbox.TabIndex = 7;
            // 
            // Player1Name_textbox
            // 
            this.Player1Name_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.Player1Name_textbox.Font = new System.Drawing.Font("Lithos Pro Regular", 12.75F);
            this.Player1Name_textbox.Location = new System.Drawing.Point(477, 347);
            this.Player1Name_textbox.MaxLength = 15;
            this.Player1Name_textbox.Name = "Player1Name_textbox";
            this.Player1Name_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Player1Name_textbox.Size = new System.Drawing.Size(141, 28);
            this.Player1Name_textbox.TabIndex = 6;
            // 
            // Player2_label
            // 
            this.Player2_label.AutoSize = true;
            this.Player2_label.BackColor = System.Drawing.Color.Transparent;
            this.Player2_label.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player2_label.ForeColor = System.Drawing.Color.White;
            this.Player2_label.Location = new System.Drawing.Point(367, 401);
            this.Player2_label.Name = "Player2_label";
            this.Player2_label.Size = new System.Drawing.Size(112, 25);
            this.Player2_label.TabIndex = 5;
            this.Player2_label.Text = "Player 2:";
            // 
            // Player1_label
            // 
            this.Player1_label.AutoSize = true;
            this.Player1_label.BackColor = System.Drawing.Color.Transparent;
            this.Player1_label.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player1_label.ForeColor = System.Drawing.Color.White;
            this.Player1_label.Location = new System.Drawing.Point(367, 349);
            this.Player1_label.Name = "Player1_label";
            this.Player1_label.Size = new System.Drawing.Size(112, 25);
            this.Player1_label.TabIndex = 4;
            this.Player1_label.Text = "Player 1:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 678);
            this.ControlBox = false;
            this.Controls.Add(this.Player2Name_textbox);
            this.Controls.Add(this.Player1Name_textbox);
            this.Controls.Add(this.Player2_label);
            this.Controls.Add(this.Player1_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poker Dice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button start;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Player2Name_textbox;
        public System.Windows.Forms.TextBox Player1Name_textbox;
        public System.Windows.Forms.Label Player2_label;
        public System.Windows.Forms.Label Player1_label;
    }
}

