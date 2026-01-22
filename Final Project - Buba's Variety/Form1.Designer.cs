namespace Final_Project___Buba_s_Variety
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            frontCustomerImage = new PictureBox();
            customerName = new Label();
            chowOutput = new Label();
            RaincoatOutput = new Label();
            malkOutput = new Label();
            plushiesOutput = new Label();
            treatgiverOutput = new Label();
            addChowButton = new Button();
            addRaincoatButton = new Button();
            addMalkButton = new Button();
            addPlushiesButton = new Button();
            addTreatGiverButton = new Button();
            calculatorButton = new Button();
            totalGiveButton = new Button();
            totalTextBox = new TextBox();
            label6 = new Label();
            requestItems = new Label();
            stockChowButton = new Button();
            stockRaincoatButton = new Button();
            stockMalkButton = new Button();
            stockPlushiesButton = new Button();
            stockTreatGiverButton = new Button();
            linetimeOutputLabel = new Label();
            eventPeriodLabel = new Label();
            timeLeftOutput = new Label();
            lineTimeOutput = new Label();
            playButton = new Button();
            custNotifcation = new Label();
            Playtime = new System.Windows.Forms.Timer(components);
            CurrentCustomer = new System.Windows.Forms.Timer(components);
            secondCustomer = new System.Windows.Forms.Timer(components);
            entrance = new System.Windows.Forms.Timer(components);
            coinOutput = new Label();
            debtOutput = new Label();
            TimePlayedOutput = new Label();
            label1 = new Label();
            gameFInish = new Label();
            resetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)frontCustomerImage).BeginInit();
            SuspendLayout();
            // 
            // frontCustomerImage
            // 
            frontCustomerImage.BackColor = Color.Azure;
            frontCustomerImage.BorderStyle = BorderStyle.FixedSingle;
            frontCustomerImage.ImageLocation = "front";
            frontCustomerImage.Location = new Point(530, 41);
            frontCustomerImage.Name = "frontCustomerImage";
            frontCustomerImage.Size = new Size(536, 522);
            frontCustomerImage.TabIndex = 0;
            frontCustomerImage.TabStop = false;
            // 
            // customerName
            // 
            customerName.Font = new Font("Jokerman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerName.Location = new Point(554, 513);
            customerName.Name = "customerName";
            customerName.Size = new Size(501, 39);
            customerName.TabIndex = 1;
            customerName.Text = "Pupperman";
            customerName.TextAlign = ContentAlignment.TopCenter;
            // 
            // chowOutput
            // 
            chowOutput.Location = new Point(12, 62);
            chowOutput.Name = "chowOutput";
            chowOutput.Size = new Size(176, 25);
            chowOutput.TabIndex = 2;
            chowOutput.Text = "Chow: X0";
            // 
            // RaincoatOutput
            // 
            RaincoatOutput.Location = new Point(12, 99);
            RaincoatOutput.Name = "RaincoatOutput";
            RaincoatOutput.Size = new Size(176, 25);
            RaincoatOutput.TabIndex = 3;
            RaincoatOutput.Text = "Raincoat: X0";
            RaincoatOutput.Click += label2_Click;
            // 
            // malkOutput
            // 
            malkOutput.Location = new Point(12, 135);
            malkOutput.Name = "malkOutput";
            malkOutput.Size = new Size(176, 25);
            malkOutput.TabIndex = 4;
            malkOutput.Text = "Malk: X0";
            // 
            // plushiesOutput
            // 
            plushiesOutput.Location = new Point(12, 173);
            plushiesOutput.Name = "plushiesOutput";
            plushiesOutput.Size = new Size(176, 22);
            plushiesOutput.TabIndex = 5;
            plushiesOutput.Text = "Plushies: X0";
            // 
            // treatgiverOutput
            // 
            treatgiverOutput.Location = new Point(12, 204);
            treatgiverOutput.Name = "treatgiverOutput";
            treatgiverOutput.Size = new Size(176, 22);
            treatgiverOutput.TabIndex = 6;
            treatgiverOutput.Text = "TreatGiver: X0";
            // 
            // addChowButton
            // 
            addChowButton.BackColor = Color.SpringGreen;
            addChowButton.Enabled = false;
            addChowButton.Location = new Point(194, 59);
            addChowButton.Name = "addChowButton";
            addChowButton.Size = new Size(55, 29);
            addChowButton.TabIndex = 7;
            addChowButton.Text = "Add";
            addChowButton.UseVisualStyleBackColor = false;
            addChowButton.Visible = false;
            addChowButton.Click += addChowButton_Click;
            // 
            // addRaincoatButton
            // 
            addRaincoatButton.BackColor = Color.SpringGreen;
            addRaincoatButton.Enabled = false;
            addRaincoatButton.Location = new Point(194, 96);
            addRaincoatButton.Name = "addRaincoatButton";
            addRaincoatButton.Size = new Size(55, 29);
            addRaincoatButton.TabIndex = 8;
            addRaincoatButton.Text = "Add";
            addRaincoatButton.UseVisualStyleBackColor = false;
            addRaincoatButton.Visible = false;
            addRaincoatButton.Click += addRaincoatButton_Click;
            // 
            // addMalkButton
            // 
            addMalkButton.BackColor = Color.SpringGreen;
            addMalkButton.Enabled = false;
            addMalkButton.Location = new Point(194, 131);
            addMalkButton.Name = "addMalkButton";
            addMalkButton.Size = new Size(55, 29);
            addMalkButton.TabIndex = 9;
            addMalkButton.Text = "Add";
            addMalkButton.UseVisualStyleBackColor = false;
            addMalkButton.Visible = false;
            addMalkButton.Click += addMalkButton_Click;
            // 
            // addPlushiesButton
            // 
            addPlushiesButton.BackColor = Color.SpringGreen;
            addPlushiesButton.Enabled = false;
            addPlushiesButton.Location = new Point(194, 166);
            addPlushiesButton.Name = "addPlushiesButton";
            addPlushiesButton.Size = new Size(55, 29);
            addPlushiesButton.TabIndex = 10;
            addPlushiesButton.Text = "Add";
            addPlushiesButton.UseVisualStyleBackColor = false;
            addPlushiesButton.Visible = false;
            addPlushiesButton.Click += addPlushiesButton_Click;
            // 
            // addTreatGiverButton
            // 
            addTreatGiverButton.BackColor = Color.SpringGreen;
            addTreatGiverButton.Enabled = false;
            addTreatGiverButton.Location = new Point(194, 204);
            addTreatGiverButton.Name = "addTreatGiverButton";
            addTreatGiverButton.Size = new Size(55, 29);
            addTreatGiverButton.TabIndex = 11;
            addTreatGiverButton.Text = "Add";
            addTreatGiverButton.UseVisualStyleBackColor = false;
            addTreatGiverButton.Visible = false;
            addTreatGiverButton.Click += addTreatGiverButton_Click;
            // 
            // calculatorButton
            // 
            calculatorButton.BackColor = Color.MediumTurquoise;
            calculatorButton.Location = new Point(530, 584);
            calculatorButton.Name = "calculatorButton";
            calculatorButton.Size = new Size(126, 63);
            calculatorButton.TabIndex = 12;
            calculatorButton.Text = "Open \r\nCalculator\r\n";
            calculatorButton.UseVisualStyleBackColor = false;
            calculatorButton.Click += calculatorButton_Click;
            // 
            // totalGiveButton
            // 
            totalGiveButton.BackColor = Color.SpringGreen;
            totalGiveButton.Enabled = false;
            totalGiveButton.Location = new Point(825, 584);
            totalGiveButton.Name = "totalGiveButton";
            totalGiveButton.Size = new Size(241, 65);
            totalGiveButton.TabIndex = 13;
            totalGiveButton.Text = "Give total";
            totalGiveButton.UseVisualStyleBackColor = false;
            totalGiveButton.Click += button7_Click;
            // 
            // totalTextBox
            // 
            totalTextBox.Location = new Point(674, 619);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.Size = new Size(145, 30);
            totalTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDarkDark;
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(694, 589);
            label6.Name = "label6";
            label6.Size = new Size(89, 22);
            label6.TabIndex = 15;
            label6.Text = "Enter total";
            // 
            // requestItems
            // 
            requestItems.BackColor = Color.SteelBlue;
            requestItems.Location = new Point(420, 80);
            requestItems.Name = "requestItems";
            requestItems.Size = new Size(153, 290);
            requestItems.TabIndex = 16;
            requestItems.Text = "I want";
            requestItems.TextAlign = ContentAlignment.TopCenter;
            // 
            // stockChowButton
            // 
            stockChowButton.BackColor = Color.DarkCyan;
            stockChowButton.Location = new Point(267, 59);
            stockChowButton.Name = "stockChowButton";
            stockChowButton.Size = new Size(61, 29);
            stockChowButton.TabIndex = 17;
            stockChowButton.Text = "Stock";
            stockChowButton.UseVisualStyleBackColor = false;
            stockChowButton.Click += stockChowButton_Click;
            // 
            // stockRaincoatButton
            // 
            stockRaincoatButton.BackColor = Color.DarkCyan;
            stockRaincoatButton.Location = new Point(267, 94);
            stockRaincoatButton.Name = "stockRaincoatButton";
            stockRaincoatButton.Size = new Size(61, 29);
            stockRaincoatButton.TabIndex = 18;
            stockRaincoatButton.Text = "Stock";
            stockRaincoatButton.UseVisualStyleBackColor = false;
            stockRaincoatButton.Click += stockRaincoatButton_Click;
            // 
            // stockMalkButton
            // 
            stockMalkButton.BackColor = Color.DarkCyan;
            stockMalkButton.Location = new Point(267, 129);
            stockMalkButton.Name = "stockMalkButton";
            stockMalkButton.Size = new Size(61, 29);
            stockMalkButton.TabIndex = 19;
            stockMalkButton.Text = "Stock";
            stockMalkButton.UseVisualStyleBackColor = false;
            stockMalkButton.Click += stockMalkButton_Click;
            // 
            // stockPlushiesButton
            // 
            stockPlushiesButton.BackColor = Color.DarkCyan;
            stockPlushiesButton.Location = new Point(267, 166);
            stockPlushiesButton.Name = "stockPlushiesButton";
            stockPlushiesButton.Size = new Size(61, 29);
            stockPlushiesButton.TabIndex = 20;
            stockPlushiesButton.Text = "Stock";
            stockPlushiesButton.UseVisualStyleBackColor = false;
            stockPlushiesButton.Click += stockPlushiesButton_Click;
            // 
            // stockTreatGiverButton
            // 
            stockTreatGiverButton.BackColor = Color.DarkCyan;
            stockTreatGiverButton.Location = new Point(267, 204);
            stockTreatGiverButton.Name = "stockTreatGiverButton";
            stockTreatGiverButton.Size = new Size(61, 29);
            stockTreatGiverButton.TabIndex = 21;
            stockTreatGiverButton.Text = "Stock";
            stockTreatGiverButton.UseVisualStyleBackColor = false;
            stockTreatGiverButton.Click += stockTreatGiverButton_Click;
            // 
            // linetimeOutputLabel
            // 
            linetimeOutputLabel.ForeColor = Color.FromArgb(255, 128, 128);
            linetimeOutputLabel.Location = new Point(28, 385);
            linetimeOutputLabel.Name = "linetimeOutputLabel";
            linetimeOutputLabel.Size = new Size(350, 22);
            linetimeOutputLabel.TabIndex = 22;
            linetimeOutputLabel.Visible = false;
            // 
            // eventPeriodLabel
            // 
            eventPeriodLabel.Location = new Point(12, 20);
            eventPeriodLabel.Name = "eventPeriodLabel";
            eventPeriodLabel.Size = new Size(409, 25);
            eventPeriodLabel.TabIndex = 23;
            eventPeriodLabel.Text = "Stocking period: Active";
            // 
            // timeLeftOutput
            // 
            timeLeftOutput.Location = new Point(694, 41);
            timeLeftOutput.Name = "timeLeftOutput";
            timeLeftOutput.Size = new Size(192, 25);
            timeLeftOutput.TabIndex = 24;
            timeLeftOutput.Text = "Time Left:";
            // 
            // lineTimeOutput
            // 
            lineTimeOutput.ForeColor = Color.FromArgb(255, 128, 128);
            lineTimeOutput.Location = new Point(28, 345);
            lineTimeOutput.Name = "lineTimeOutput";
            lineTimeOutput.Size = new Size(350, 25);
            lineTimeOutput.TabIndex = 25;
            lineTimeOutput.Visible = false;
            // 
            // playButton
            // 
            playButton.BackColor = Color.MidnightBlue;
            playButton.Font = new Font("Jokerman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playButton.ForeColor = Color.White;
            playButton.Location = new Point(28, 584);
            playButton.Name = "playButton";
            playButton.Size = new Size(120, 65);
            playButton.TabIndex = 26;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // custNotifcation
            // 
            custNotifcation.AutoSize = true;
            custNotifcation.Location = new Point(28, 299);
            custNotifcation.Name = "custNotifcation";
            custNotifcation.Size = new Size(251, 22);
            custNotifcation.TabIndex = 27;
            custNotifcation.Text = "A Customer Has entered the line";
            custNotifcation.Visible = false;
            // 
            // Playtime
            // 
            Playtime.Interval = 1000;
            Playtime.Tick += Playtime_Tick;
            // 
            // CurrentCustomer
            // 
            CurrentCustomer.Interval = 800;
            CurrentCustomer.Tick += CurrentCustomer_Tick;
            // 
            // secondCustomer
            // 
            secondCustomer.Tick += timer3_Tick;
            // 
            // coinOutput
            // 
            coinOutput.Font = new Font("Jokerman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coinOutput.ForeColor = Color.Yellow;
            coinOutput.Location = new Point(28, 414);
            coinOutput.Name = "coinOutput";
            coinOutput.Size = new Size(393, 57);
            coinOutput.TabIndex = 28;
            coinOutput.Text = "Coins: 100";
            coinOutput.Click += coinOutput_Click;
            // 
            // debtOutput
            // 
            debtOutput.AutoSize = true;
            debtOutput.BackColor = SystemColors.ButtonFace;
            debtOutput.Font = new Font("Jokerman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            debtOutput.ForeColor = Color.Red;
            debtOutput.Location = new Point(12, 471);
            debtOutput.Name = "debtOutput";
            debtOutput.Size = new Size(409, 25);
            debtOutput.TabIndex = 29;
            debtOutput.Text = "Uh oh your in debt!! Be more careful next time!";
            debtOutput.Visible = false;
            // 
            // TimePlayedOutput
            // 
            TimePlayedOutput.Location = new Point(12, 496);
            TimePlayedOutput.Name = "TimePlayedOutput";
            TimePlayedOutput.Size = new Size(207, 25);
            TimePlayedOutput.TabIndex = 30;
            TimePlayedOutput.Text = "Time Played: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(171, 515);
            label1.Name = "label1";
            label1.Size = new Size(250, 132);
            label1.TabIndex = 31;
            label1.Text = "Price guide: \r\nChow =5 to buy, 7 to sell\r\nRaincoat = 8 to buy, 10 to sell\r\nMalk = 2 to buy, 4 to sell\r\nPlusies = 4 to buy, 6 to sell\r\nTreatGiver = 12 to buy, 15 to sell.";
            // 
            // gameFInish
            // 
            gameFInish.BackColor = Color.MediumOrchid;
            gameFInish.Font = new Font("Jokerman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameFInish.Location = new Point(-6, 149);
            gameFInish.Name = "gameFInish";
            gameFInish.Size = new Size(1132, 294);
            gameFInish.TabIndex = 32;
            gameFInish.Text = "Game is finished!!!\r\nIf you want to continue with your leftover money and stock press Play";
            gameFInish.TextAlign = ContentAlignment.MiddleCenter;
            gameFInish.Visible = false;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(28, 549);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(120, 29);
            resetButton.TabIndex = 33;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1125, 661);
            Controls.Add(resetButton);
            Controls.Add(gameFInish);
            Controls.Add(label1);
            Controls.Add(TimePlayedOutput);
            Controls.Add(debtOutput);
            Controls.Add(coinOutput);
            Controls.Add(custNotifcation);
            Controls.Add(playButton);
            Controls.Add(lineTimeOutput);
            Controls.Add(timeLeftOutput);
            Controls.Add(eventPeriodLabel);
            Controls.Add(linetimeOutputLabel);
            Controls.Add(stockTreatGiverButton);
            Controls.Add(stockPlushiesButton);
            Controls.Add(stockMalkButton);
            Controls.Add(stockRaincoatButton);
            Controls.Add(stockChowButton);
            Controls.Add(requestItems);
            Controls.Add(label6);
            Controls.Add(totalTextBox);
            Controls.Add(totalGiveButton);
            Controls.Add(calculatorButton);
            Controls.Add(addTreatGiverButton);
            Controls.Add(addPlushiesButton);
            Controls.Add(addMalkButton);
            Controls.Add(addRaincoatButton);
            Controls.Add(addChowButton);
            Controls.Add(treatgiverOutput);
            Controls.Add(plushiesOutput);
            Controls.Add(malkOutput);
            Controls.Add(RaincoatOutput);
            Controls.Add(chowOutput);
            Controls.Add(customerName);
            Controls.Add(frontCustomerImage);
            Font = new Font("Jokerman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)frontCustomerImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox frontCustomerImage;
        private Label customerName;
        private Label chowOutput;
        private Label RaincoatOutput;
        private Label malkOutput;
        private Label plushiesOutput;
        private Label treatgiverOutput;
        private Button addChowButton;
        private Button addRaincoatButton;
        private Button addMalkButton;
        private Button addPlushiesButton;
        private Button addTreatGiverButton;
        private Button calculatorButton;
        private Button totalGiveButton;
        private TextBox totalTextBox;
        private Label label6;
        private Label requestItems;
        private Button stockChowButton;
        private Button stockRaincoatButton;
        private Button stockMalkButton;
        private Button stockPlushiesButton;
        private Button stockTreatGiverButton;
        private Label linetimeOutputLabel;
        private Label eventPeriodLabel;
        private Label timeLeftOutput;
        private Label lineTimeOutput;
        private Button playButton;
        private Label custNotifcation;
        private System.Windows.Forms.Timer Playtime;
        private System.Windows.Forms.Timer CurrentCustomer;
        private System.Windows.Forms.Timer secondCustomer;
        private System.Windows.Forms.Timer entrance;
        private Label coinOutput;
        private Label debtOutput;
        private Label TimePlayedOutput;
        private Label label1;
        private Label gameFInish;
        private Button resetButton;
    }
}
