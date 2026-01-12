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
            button5 = new Button();
            calculatorButton = new Button();
            totalGiveButton = new Button();
            totalTextBox = new TextBox();
            label6 = new Label();
            requestItemButtons = new Label();
            stockChowButton = new Button();
            stockRaincoatButton = new Button();
            stockMalkButton = new Button();
            stockPlushiesButton = new Button();
            button10 = new Button();
            linetimeOutputLabel = new Label();
            eventPeriodLabel = new Label();
            timeLeftOutput = new Label();
            lineTimeOutput = new Label();
            playButton = new Button();
            label1 = new Label();
            Playtime = new System.Windows.Forms.Timer(components);
            CurrentCustomer = new System.Windows.Forms.Timer(components);
            secondCustomer = new System.Windows.Forms.Timer(components);
            entrance = new System.Windows.Forms.Timer(components);
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
            addChowButton.Location = new Point(194, 59);
            addChowButton.Name = "addChowButton";
            addChowButton.Size = new Size(55, 29);
            addChowButton.TabIndex = 7;
            addChowButton.Text = "Add";
            addChowButton.UseVisualStyleBackColor = true;
            // 
            // addRaincoatButton
            // 
            addRaincoatButton.Location = new Point(194, 96);
            addRaincoatButton.Name = "addRaincoatButton";
            addRaincoatButton.Size = new Size(55, 29);
            addRaincoatButton.TabIndex = 8;
            addRaincoatButton.Text = "Add";
            addRaincoatButton.UseVisualStyleBackColor = true;
            // 
            // addMalkButton
            // 
            addMalkButton.Location = new Point(194, 131);
            addMalkButton.Name = "addMalkButton";
            addMalkButton.Size = new Size(55, 29);
            addMalkButton.TabIndex = 9;
            addMalkButton.Text = "Add";
            addMalkButton.UseVisualStyleBackColor = true;
            // 
            // addPlushiesButton
            // 
            addPlushiesButton.Location = new Point(194, 166);
            addPlushiesButton.Name = "addPlushiesButton";
            addPlushiesButton.Size = new Size(55, 29);
            addPlushiesButton.TabIndex = 10;
            addPlushiesButton.Text = "Add";
            addPlushiesButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(194, 204);
            button5.Name = "button5";
            button5.Size = new Size(55, 29);
            button5.TabIndex = 11;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            // 
            // calculatorButton
            // 
            calculatorButton.Location = new Point(530, 584);
            calculatorButton.Name = "calculatorButton";
            calculatorButton.Size = new Size(126, 63);
            calculatorButton.TabIndex = 12;
            calculatorButton.Text = "Open \r\nCalculator\r\n";
            calculatorButton.UseVisualStyleBackColor = true;
            calculatorButton.Click += calculatorButton_Click;
            // 
            // totalGiveButton
            // 
            totalGiveButton.Location = new Point(825, 584);
            totalGiveButton.Name = "totalGiveButton";
            totalGiveButton.Size = new Size(241, 65);
            totalGiveButton.TabIndex = 13;
            totalGiveButton.Text = "Give total";
            totalGiveButton.UseVisualStyleBackColor = true;
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
            // requestItemButtons
            // 
            requestItemButtons.BackColor = Color.SteelBlue;
            requestItemButtons.Location = new Point(420, 80);
            requestItemButtons.Name = "requestItemButtons";
            requestItemButtons.Size = new Size(153, 290);
            requestItemButtons.TabIndex = 16;
            requestItemButtons.Text = "I want";
            requestItemButtons.TextAlign = ContentAlignment.TopCenter;
            // 
            // stockChowButton
            // 
            stockChowButton.Location = new Point(267, 59);
            stockChowButton.Name = "stockChowButton";
            stockChowButton.Size = new Size(61, 29);
            stockChowButton.TabIndex = 17;
            stockChowButton.Text = "Stock";
            stockChowButton.UseVisualStyleBackColor = true;
            stockChowButton.Click += stockChowButton_Click;
            // 
            // stockRaincoatButton
            // 
            stockRaincoatButton.Location = new Point(267, 94);
            stockRaincoatButton.Name = "stockRaincoatButton";
            stockRaincoatButton.Size = new Size(61, 29);
            stockRaincoatButton.TabIndex = 18;
            stockRaincoatButton.Text = "Stock";
            stockRaincoatButton.UseVisualStyleBackColor = true;
            // 
            // stockMalkButton
            // 
            stockMalkButton.Location = new Point(267, 129);
            stockMalkButton.Name = "stockMalkButton";
            stockMalkButton.Size = new Size(61, 29);
            stockMalkButton.TabIndex = 19;
            stockMalkButton.Text = "Stock";
            stockMalkButton.UseVisualStyleBackColor = true;
            // 
            // stockPlushiesButton
            // 
            stockPlushiesButton.Location = new Point(267, 166);
            stockPlushiesButton.Name = "stockPlushiesButton";
            stockPlushiesButton.Size = new Size(61, 29);
            stockPlushiesButton.TabIndex = 20;
            stockPlushiesButton.Text = "Stock";
            stockPlushiesButton.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(267, 204);
            button10.Name = "button10";
            button10.Size = new Size(61, 29);
            button10.TabIndex = 21;
            button10.Text = "Stock";
            button10.UseVisualStyleBackColor = true;
            // 
            // linetimeOutputLabel
            // 
            linetimeOutputLabel.ForeColor = Color.FromArgb(255, 128, 128);
            linetimeOutputLabel.Location = new Point(28, 385);
            linetimeOutputLabel.Name = "linetimeOutputLabel";
            linetimeOutputLabel.Size = new Size(350, 22);
            linetimeOutputLabel.TabIndex = 22;
            linetimeOutputLabel.Text = "3rd-5th In Line Time left: 450";
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
            lineTimeOutput.Text = "2nd In Line Time left: 350";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 299);
            label1.Name = "label1";
            label1.Size = new Size(251, 22);
            label1.TabIndex = 27;
            label1.Text = "A Customer Has entered the line";
            label1.Visible = false;
            // 
            // Playtime
            // 
            Playtime.Interval = 1000;
            // 
            // secondCustomer
            // 
            secondCustomer.Tick += timer3_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1125, 661);
            Controls.Add(label1);
            Controls.Add(playButton);
            Controls.Add(lineTimeOutput);
            Controls.Add(timeLeftOutput);
            Controls.Add(eventPeriodLabel);
            Controls.Add(linetimeOutputLabel);
            Controls.Add(button10);
            Controls.Add(stockPlushiesButton);
            Controls.Add(stockMalkButton);
            Controls.Add(stockRaincoatButton);
            Controls.Add(stockChowButton);
            Controls.Add(requestItemButtons);
            Controls.Add(label6);
            Controls.Add(totalTextBox);
            Controls.Add(totalGiveButton);
            Controls.Add(calculatorButton);
            Controls.Add(button5);
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
        private Button button5;
        private Button calculatorButton;
        private Button totalGiveButton;
        private TextBox totalTextBox;
        private Label label6;
        private Label requestItemButtons;
        private Button stockChowButton;
        private Button stockRaincoatButton;
        private Button stockMalkButton;
        private Button stockPlushiesButton;
        private Button button10;
        private Label linetimeOutputLabel;
        private Label eventPeriodLabel;
        private Label timeLeftOutput;
        private Label lineTimeOutput;
        private Button playButton;
        private Label label1;
        private System.Windows.Forms.Timer Playtime;
        private System.Windows.Forms.Timer CurrentCustomer;
        private System.Windows.Forms.Timer secondCustomer;
        private System.Windows.Forms.Timer entrance;
    }
}
