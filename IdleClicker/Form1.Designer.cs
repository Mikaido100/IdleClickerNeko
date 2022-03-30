namespace IdleClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.buttonLevelTextBox = new System.Windows.Forms.TextBox();
            this.A1AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A1UpgradeAmmount = new System.Windows.Forms.Button();
            this.A1UpgradeInterval = new System.Windows.Forms.Button();
            this.A1Label = new System.Windows.Forms.Label();
            this.A1IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A1Timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Napiwki = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(674, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kasa: $0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // upgradeButton
            // 
            this.upgradeButton.BackColor = System.Drawing.Color.Linen;
            this.upgradeButton.Location = new System.Drawing.Point(346, 382);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(75, 56);
            this.upgradeButton.TabIndex = 2;
            this.upgradeButton.Text = "Upgrade\r\n($10)";
            this.upgradeButton.UseVisualStyleBackColor = false;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // buttonLevelTextBox
            // 
            this.buttonLevelTextBox.BackColor = System.Drawing.Color.Snow;
            this.buttonLevelTextBox.Location = new System.Drawing.Point(346, 353);
            this.buttonLevelTextBox.Name = "buttonLevelTextBox";
            this.buttonLevelTextBox.ReadOnly = true;
            this.buttonLevelTextBox.Size = new System.Drawing.Size(75, 23);
            this.buttonLevelTextBox.TabIndex = 3;
            this.buttonLevelTextBox.Text = "1";
            this.buttonLevelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1AmmountTextBox
            // 
            this.A1AmmountTextBox.BackColor = System.Drawing.Color.Snow;
            this.A1AmmountTextBox.Location = new System.Drawing.Point(118, 28);
            this.A1AmmountTextBox.Name = "A1AmmountTextBox";
            this.A1AmmountTextBox.ReadOnly = true;
            this.A1AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1AmmountTextBox.TabIndex = 4;
            this.A1AmmountTextBox.Text = "0";
            this.A1AmmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1UpgradeAmmount
            // 
            this.A1UpgradeAmmount.BackColor = System.Drawing.Color.Linen;
            this.A1UpgradeAmmount.Location = new System.Drawing.Point(224, 9);
            this.A1UpgradeAmmount.Name = "A1UpgradeAmmount";
            this.A1UpgradeAmmount.Size = new System.Drawing.Size(107, 52);
            this.A1UpgradeAmmount.TabIndex = 5;
            this.A1UpgradeAmmount.Text = "Ulepsz ilość";
            this.A1UpgradeAmmount.UseVisualStyleBackColor = false;
            this.A1UpgradeAmmount.Click += new System.EventHandler(this.A1UpgradeAmmount_Click);
            // 
            // A1UpgradeInterval
            // 
            this.A1UpgradeInterval.BackColor = System.Drawing.Color.Linen;
            this.A1UpgradeInterval.Location = new System.Drawing.Point(443, 9);
            this.A1UpgradeInterval.Name = "A1UpgradeInterval";
            this.A1UpgradeInterval.Size = new System.Drawing.Size(124, 52);
            this.A1UpgradeInterval.TabIndex = 6;
            this.A1UpgradeInterval.Text = "Ulepsz częstotliwość";
            this.A1UpgradeInterval.UseVisualStyleBackColor = false;
            this.A1UpgradeInterval.Click += new System.EventHandler(this.A1UpgradeInterval_Click);
            // 
            // A1Label
            // 
            this.A1Label.AutoSize = true;
            this.A1Label.Location = new System.Drawing.Point(28, 36);
            this.A1Label.Name = "A1Label";
            this.A1Label.Size = new System.Drawing.Size(84, 15);
            this.A1Label.TabIndex = 7;
            this.A1Label.Text = "AutoUpgrade1";
            // 
            // A1IntervalTextBox
            // 
            this.A1IntervalTextBox.BackColor = System.Drawing.Color.Snow;
            this.A1IntervalTextBox.Location = new System.Drawing.Point(337, 28);
            this.A1IntervalTextBox.Name = "A1IntervalTextBox";
            this.A1IntervalTextBox.ReadOnly = true;
            this.A1IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1IntervalTextBox.TabIndex = 8;
            this.A1IntervalTextBox.Text = "0";
            this.A1IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1Timer
            // 
            this.A1Timer.Tick += new System.EventHandler(this.A1Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "/min";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::IdleClicker.Properties.Resources.chocola;
            this.pictureBox1.Location = new System.Drawing.Point(458, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 343);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(598, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 17);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "boop me!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Napiwki
            // 
            this.Napiwki.BackColor = System.Drawing.Color.Linen;
            this.Napiwki.Location = new System.Drawing.Point(28, 217);
            this.Napiwki.Name = "Napiwki";
            this.Napiwki.Size = new System.Drawing.Size(107, 56);
            this.Napiwki.TabIndex = 12;
            this.Napiwki.Text = "Napiwki";
            this.Napiwki.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Location = new System.Drawing.Point(224, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ulepsz ilość2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Snow;
            this.textBox2.Location = new System.Drawing.Point(118, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "AutoUpgrade2";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.Location = new System.Drawing.Point(443, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 52);
            this.button3.TabIndex = 16;
            this.button3.Text = "Ulepsz częstotliwość2";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Snow;
            this.textBox3.Location = new System.Drawing.Point(337, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "/min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::IdleClicker.Properties.Resources.lasoleil;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Napiwki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A1IntervalTextBox);
            this.Controls.Add(this.A1Label);
            this.Controls.Add(this.A1UpgradeInterval);
            this.Controls.Add(this.A1UpgradeAmmount);
            this.Controls.Add(this.A1AmmountTextBox);
            this.Controls.Add(this.buttonLevelTextBox);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button upgradeButton;
        private TextBox buttonLevelTextBox;
        private TextBox A1AmmountTextBox;
        private Button A1UpgradeAmmount;
        private Button A1UpgradeInterval;
        private Label A1Label;
        private TextBox A1IntervalTextBox;
        private System.Windows.Forms.Timer A1Timer;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button Napiwki;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Button button3;
        private TextBox textBox3;
        private Label label4;
    }
}