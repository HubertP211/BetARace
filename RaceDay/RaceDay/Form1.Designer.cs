namespace RaceDay
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.player3Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.placeBetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.player3Radio = new System.Windows.Forms.RadioButton();
            this.player2Radio = new System.Windows.Forms.RadioButton();
            this.player1Radio = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrack
            // 
            this.racetrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("racetrack.BackgroundImage")));
            this.racetrack.Location = new System.Drawing.Point(7, 21);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(965, 230);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // car2
            // 
            this.car2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car2.BackgroundImage")));
            this.car2.Location = new System.Drawing.Point(12, 112);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(100, 50);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 2;
            this.car2.TabStop = false;
            // 
            // car3
            // 
            this.car3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car3.BackgroundImage")));
            this.car3.Location = new System.Drawing.Point(12, 187);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(100, 50);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car3.TabIndex = 3;
            this.car3.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = ((System.Drawing.Image)(resources.GetObject("car1.Image")));
            this.car1.Location = new System.Drawing.Point(12, 42);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(100, 50);
            this.car1.TabIndex = 4;
            this.car1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.player3Label);
            this.groupBox1.Controls.Add(this.player2Label);
            this.groupBox1.Controls.Add(this.player1Label);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.placeBetButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownCar);
            this.groupBox1.Controls.Add(this.numericUpDownBet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.player3Radio);
            this.groupBox1.Controls.Add(this.player2Radio);
            this.groupBox1.Controls.Add(this.player1Radio);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(7, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dom bukmacherski";
            // 
            // player3Label
            // 
            this.player3Label.AutoSize = true;
            this.player3Label.Location = new System.Drawing.Point(275, 93);
            this.player3Label.Name = "player3Label";
            this.player3Label.Size = new System.Drawing.Size(79, 13);
            this.player3Label.TabIndex = 16;
            this.player3Label.Text = "Brak zakładów";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(275, 68);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(79, 13);
            this.player2Label.TabIndex = 15;
            this.player2Label.Text = "Brak zakładów";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(275, 45);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(79, 13);
            this.player1Label.TabIndex = 14;
            this.player1Label.Text = "Brak zakładów";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(723, 75);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(224, 55);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // placeBetButton
            // 
            this.placeBetButton.Location = new System.Drawing.Point(565, 76);
            this.placeBetButton.Name = "placeBetButton";
            this.placeBetButton.Size = new System.Drawing.Size(75, 23);
            this.placeBetButton.TabIndex = 12;
            this.placeBetButton.Text = "Obstaw";
            this.placeBetButton.UseVisualStyleBackColor = true;
            this.placeBetButton.Click += new System.EventHandler(this.placeBetButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nr samochodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Zakład";
            // 
            // numericUpDownCar
            // 
            this.numericUpDownCar.Location = new System.Drawing.Point(828, 40);
            this.numericUpDownCar.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCar.Name = "numericUpDownCar";
            this.numericUpDownCar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCar.TabIndex = 9;
            this.numericUpDownCar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBet
            // 
            this.numericUpDownBet.Location = new System.Drawing.Point(610, 40);
            this.numericUpDownBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBet.Name = "numericUpDownBet";
            this.numericUpDownBet.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBet.TabIndex = 8;
            this.numericUpDownBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(260, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zakłady";
            // 
            // player3Radio
            // 
            this.player3Radio.AutoSize = true;
            this.player3Radio.Location = new System.Drawing.Point(9, 89);
            this.player3Radio.Name = "player3Radio";
            this.player3Radio.Size = new System.Drawing.Size(63, 17);
            this.player3Radio.TabIndex = 3;
            this.player3Radio.Text = "Player 3";
            this.player3Radio.UseVisualStyleBackColor = true;
            this.player3Radio.CheckedChanged += new System.EventHandler(this.player3Radio_CheckedChanged);
            // 
            // player2Radio
            // 
            this.player2Radio.AutoSize = true;
            this.player2Radio.Location = new System.Drawing.Point(9, 66);
            this.player2Radio.Name = "player2Radio";
            this.player2Radio.Size = new System.Drawing.Size(63, 17);
            this.player2Radio.TabIndex = 2;
            this.player2Radio.Text = "Player 2";
            this.player2Radio.UseVisualStyleBackColor = true;
            this.player2Radio.CheckedChanged += new System.EventHandler(this.player2Radio_CheckedChanged);
            // 
            // player1Radio
            // 
            this.player1Radio.AutoSize = true;
            this.player1Radio.Checked = true;
            this.player1Radio.Location = new System.Drawing.Point(9, 43);
            this.player1Radio.Name = "player1Radio";
            this.player1Radio.Size = new System.Drawing.Size(63, 17);
            this.player1Radio.TabIndex = 1;
            this.player1Radio.TabStop = true;
            this.player1Radio.Text = "Player 1";
            this.player1Radio.UseVisualStyleBackColor = true;
            this.player1Radio.CheckedChanged += new System.EventHandler(this.player1Radio_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumBetLabel.Location = new System.Drawing.Point(5, 16);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(184, 20);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimalny zakład: 5 zł";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.racetrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button placeBetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCar;
        private System.Windows.Forms.NumericUpDown numericUpDownBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton player3Radio;
        private System.Windows.Forms.RadioButton player2Radio;
        private System.Windows.Forms.RadioButton player1Radio;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label player3Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Timer timer1;
    }
}

