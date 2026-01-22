using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace Final_Project___Buba_s_Variety
{
    public partial class Form1 : Form
    { //file path for holding high scores
        string filePath = @"C:\Users\RayaScot583\Documents\Raya\High score.txt";
        int coins = 150;
        int raincoat, chow, malk, plushies, treatgiver;
        int playingtime;
        int firstMer = 300;
        //Decided to get rid of waiting customer timers to save on remaing time.
        int wantset;
        int UserTotal;
        int score;
        int NPC, daycycle;
        Random monies = new Random();
        int days; //used to count if players want to continue with leftover money and stock
        List<Person> Highscore = new List<Person>
    {
        new Person { Score = 65 }
    };

        public Form1()
        {
            InitializeComponent();
        }
        class Person
        {
            //didn't really understand this code so using lesson 16 (ii) as a support!
            
            public int Score { get; set; }
        }
        private void FileUpdates()
        {
            if (daycycle == 3)
            {
                Highscore.Add(new Person { Score = score });
                File.WriteAllText(filePath, ""); // clear file first

                using (StreamWriter writer = new StreamWriter(filePath))
                /*StreamWriter is a class that lets you write text to a file, one line at a time.
                new StreamWriter(filePath) opens the file for writing.
                using (...) ensures that when the code inside the braces is finished, the file is
                properly saved and closed*/
                {
                    for (int i = 0; i < Highscore.Count; i++)
                    {
                        writer.WriteLine(Highscore[i].Score);
                    }
                }
            }
        }
        private void coinManagement()
        {
            coinOutput.Text = $"Coins: {coins}";
            if (coins == 0)
            {
                stockChowButton.Enabled = false;
                stockMalkButton.Enabled = false;
                stockPlushiesButton.Enabled = false;
                stockRaincoatButton.Enabled = false;
                stockTreatGiverButton.Enabled = false;
                debtOutput.Visible = false;
            }
            else if (coins < 0)
            {
                stockChowButton.Enabled = false;
                stockMalkButton.Enabled = false;
                stockPlushiesButton.Enabled = false;
                stockRaincoatButton.Enabled = false;
                stockTreatGiverButton.Enabled = false;
                debtOutput.Visible = true;
                coinOutput.Text = $"Coins: -{coins}";
            }

        } 
        private void Stockingtime()
        { if (daycycle == 2)
            {
                stockChowButton.Enabled = true;
                stockMalkButton.Enabled = true;
                stockPlushiesButton.Enabled = true;
                stockRaincoatButton.Enabled = true;
                stockTreatGiverButton.Enabled = true;
            }
            else
            {
                stockChowButton.Enabled = false;
                stockMalkButton.Enabled = false;
                stockPlushiesButton.Enabled = false;
                stockRaincoatButton.Enabled = false;
                stockTreatGiverButton.Enabled = false;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {//total button
            try
            {
                UserTotal = Convert.ToInt32(totalTextBox.Text);

                switch (wantset)
                {
                    case (1):

                        if (UserTotal == 29)
                        {
                            score += 5;
                            coins += 29;
                        }
                        else { score -= 1; }
                        break;
                    case (2):

                        if (UserTotal == 24)
                        {
                            score += 5;
                            coins += 24;
                        }
                        else
                        {
                            score -= 1;
                        }
                        break;
                    case (3):

                        if (UserTotal == 33)
                        {
                            score += 5;
                            coins += 33;
                        }
                        else { score -= 1; }
                        break;
                    case (4):

                        if (UserTotal == 21)
                        {
                            score += 5;
                            coins += 21;
                        }
                        else { score -= 1; }
                        break;
                    case (5):
                        if (UserTotal == 30)
                        {
                            score += 5;
                            coins += 30;
                        }
                        else { score -= 1; }
                        break;
                    case (6):
                        if (UserTotal == 24)
                        {
                            score += 5;
                            coins += 24;
                        }
                        else { score -= 1; }
                        break;
                    case (7):
                        if (UserTotal == 56)
                        {
                            score += 5;
                            coins += 56;
                        }
                        else { score -= 1; }
                        break;
                    case (8):
                        if (UserTotal == 32)
                        {
                            score += 5;
                            coins += 32;
                        }
                        else { score -= 1; }
                        break;
                    case (9):
                        if (UserTotal == 32)
                        {
                            score += 5;
                            coins += 32;
                        }
                        else { score -= 1; }

                        break;
                    case (10):
                        if (UserTotal == 42)
                        {
                            score += 5;
                            coins += 42;
                        }
                        else { score -= 1; }
                        break;

                }
                requestItems.Text = "I want";
                coinManagement();
                NPCEnter();
                NPC += 1;
                Random chaos = new Random();
                int chaosnum = chaos.Next(1, 11);
                if (chaosnum == 5)
                {
                    chaosForm CF = new chaosForm();
                    CF.ShowDialog();
                } 
                if (NPC==5)
                {
                    daycycle += 1;
                    Stockingtime();
                    Playtime.Enabled=false;
                    coinManagement();
                    totalGiveButton.Enabled=false;
                    eventPeriodLabel.Text = "Stocking period: Active";
                    requestItems.Text = "I want";
                    NPC = 0;
                }else if (daycycle ==3)
                {
                    FileUpdates();
                    stockChowButton.Enabled = false;
                    stockMalkButton.Enabled = false;
                    stockPlushiesButton.Enabled = false;
                    stockRaincoatButton.Enabled = false;
                    stockTreatGiverButton.Enabled = false;
                    playButton.Enabled = true;
                    totalGiveButton.Enabled = false;
                    days += 1;
                    gameFInish.Visible = true;
                }
            }
            catch { requestItems.Text += "Error"; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
        private void NPCEnter()
        { //output to say if a customer has entered the shop
            custNotifcation.Visible = true;
            Random UI = new Random();
            int npcUI = UI.Next(1,15);
            firstMer = 300;
            switch(npcUI)
            {
                case 1: frontCustomerImage.Image = Properties.Resources.animal_dog_115245;
                    customerName.Text = "PupperMan";
                    break;
                case 2: frontCustomerImage.Image = Properties.Resources.bear_wild_animal_wildlife_nature_big_fur_icon_127304;
                    customerName.Text = "Goldy";
                    break;
                case 3: frontCustomerImage.Image = Properties.Resources.black_cat_halloween_icon_155986;
                    customerName.Text = "Lucky";
                    break;
                case 4: frontCustomerImage.Image = Properties.Resources.fox_scarf_icon_159308;
                    customerName.Text = "Snooch";
                    break;
                case 5: frontCustomerImage.Image = Properties.Resources._94_85291;
                    customerName.Text = "Uni";
                    break;
                case 6: frontCustomerImage.Image = Properties.Resources.iconfinder_dog_4591896_122115;
                    customerName.Text = "Tism";
                    break;
                case 7: frontCustomerImage.Image = Properties.Resources.valentine_teddy_bear_love_valentines_romantic_gift_icon_179616;
                    customerName.Text = "Val";
                    break;
                case 8: frontCustomerImage.Image = Properties.Resources._10_info_cat_icon_icons_com_76686;
                    customerName.Text = "Fluff";
                    break;
                case 9: frontCustomerImage.Image = Properties.Resources.iconfinder_husky_dog_4591888_122123;
                    customerName.Text = "Cloudy & Meatballs";
                    break;
                case 10: frontCustomerImage.Image = Properties.Resources._446foxface2_100697;
                    customerName.Text = "Impulsive";
                    break;
                case 11: frontCustomerImage.Image = Properties.Resources._39_85225;
                    customerName.Text = "Lil dude";
                    break;
                case 12: frontCustomerImage.Image = Properties.Resources.dogbaby_119594;
                    customerName.Text = "Child";
                    break;
                case 13: frontCustomerImage.Image = Properties.Resources.iconfinder_bird_4591877_122110;
                    customerName.Text = "The great";
                    break;
                case 14: frontCustomerImage.Image = Properties.Resources._22226horseface_98740;
                    customerName.Text = "Grain";
                    break;
            }
            //presets decided for the enterance for 1st in line customers

            wantset = monies.Next(1, 11);
            switch (wantset)
            {
                case (1):
                    requestItems.Text += "\n" + "Chow X2" + "\n" + "TreatGiver X1";
                    if (chow >=2 && treatgiver >=1)
                    {
                        chow -= 2;
                        treatgiver -= 2;
                        chowOutput.Text = $"Chow: X{chow}";
                        treatgiverOutput.Text = $"Treatgiver: X{treatgiver}";
                    } else
                    {
                        requestItems.Text = "Uh oh! you didn't stock enough! The customer is unhappy now :(";
                        
                    }
                        break;
                case (2):
                    requestItems.Text += "\n" + "Raincoat X1" + "\n" + "Malk X2" + "\n" + "Plushie X1";
                    if (raincoat >= 1 && malk >= 2 && plushies >= 1)
                    {
                        raincoat -= 1;
                        malk -= 2;
                        plushies -= 1;
                        RaincoatOutput.Text = $"Raincoat: X{raincoat}";
                        malkOutput.Text = $"Malk: X{malk}";
                        plushiesOutput.Text = $"Plushies: X{plushies}";
                    }else
                    {
                        requestItems.Text = "Uh oh! you didn't stock enough! The customer is unhappy now :(";
                        
                    }
                        break;
                case (3):
                    requestItems.Text += "\n" + "Chow X3" + "\n" + "Plushie X2";
                    if (chow >=3 && plushies>=2)
                    {
                        chow -= 3;
                        plushies -= 2;
                        chowOutput.Text = $"Chow: X{chow}";
                        plushiesOutput.Text = $"Plushies: X{plushies}";
                    } else
                    {
                        requestItems.Text = "Uh oh! you didn't stock enough! The customer is unhappy now :(";
                       
                    }
                        break;
                case (4):
                    requestItems.Text += "\n" + "Chow X1" + "\n" + "Malk X2" + "\n" + "Plushie X1";
                    if (chow >=1&& malk>=2&& plushies>=1)
                    {
                        chow -= 1;
                        malk -= 2;
                        plushies -= 1;
                        chowOutput.Text = $"Chow: X{chow}";
                        plushiesOutput.Text = $"Plushies: X{plushies}";
                        malkOutput.Text = $"Malk: X{malk}";
                    } else 
                    {
                        requestItems.Text = "Uh oh! you didn't stock enough! The customer is unhappy now :(";
                        
                    }
                        break;
                case (5):
                    requestItems.Text += "\n" + "Treatgiver X2";
                    if (treatgiver>=2)
                    {
                        treatgiver -= 2;
                        treatgiverOutput.Text = $"Treatgiver: X{treatgiver}";
                    } else
                    {
                        requestItems.Text = "Uh oh! you didn't stock enough! The customer is unhappy now :(";
                       
                    }
                        break;
                case (6):
                    requestItems.Text += "\n" + "Chow X2" + "\n" + "Raincoat X1";
                    if (chow >=2 && raincoat>=1)
                    {
                        chow -= 2;
                        raincoat -= 1;
                        chowOutput.Text = $"Chow: X{chow}";
                        RaincoatOutput.Text = $"Raincoat: X{raincoat}";
                    } else
                    {
                        requestItems.Text = "Uh oh! you didn't stock enough! The customer is unhappy now :(";
                       
                    }
                        break;
                case (7):
                    requestItems.Text += "\n" + "Chow X2" + "\n" + "Raincoat X2" + "\n" + "Malk X4" + "\n" + "Plushie X1";
                    if (chow>=2 && raincoat>=2&& malk >=4&& plushies>=1)
                    {
                        chow -= 2;
                        raincoat -= 2;
                        malk -= 4;
                        plushies -= 1;
                        chowOutput.Text = $"Chow: X{chow}";
                        plushiesOutput.Text = $"Plushies: X{plushies}";
                        malkOutput.Text = $"Malk: X{malk}";
                        RaincoatOutput.Text = $"Raincoat: X{raincoat}";
                    } else
                    {
                        requestItems.Text = "Uh oh! you didn't stock enough! The customer is unhappy now :(";

                    }
                        break;
                case (8):
                    requestItems.Text += "\n" + "Chow X4" + "\n" + "Malk x1";
                    if (chow >=4&& malk>=1)
                    {
                        chow -= 4;
                        malk -= 1;
                        chowOutput.Text = $"Chow: X{chow}";
                        malkOutput.Text = $"Malk: X{malk}";
                    }else
                    {
                        requestItems.Text = "Uh oh! you didn't stock enough! The customer is unhappy now :(";
                       
                    }
                        break;
                case (9):
                    requestItems.Text += "\n" + "Chow X1" + "\n" + "Raincoat X1" + "\n" + "Treatgiver X1";
                    if (chow>=1&&raincoat>=1 &&treatgiver>=1)
                    {
                        chow -= 1;
                        raincoat -= 1;
                        treatgiver -= 1;
                        chowOutput.Text = $"Chow: X{chow}";
                        treatgiverOutput.Text = $"Treatgiver: X{treatgiver}";
                        RaincoatOutput.Text = $"Raincoat: X{raincoat}";
                    }else
                    {
                        requestItems.Text = "Uh oh! you didn't stock enough! The customer is unhappy now :(";
                        
                    }
                        break;
                case (10):
                    requestItems.Text += "\n" + "Chow X1" + "\n" + "Raincoat X1" + "\n" + "Malk X1" + "\n" + "Plushies X1" + "\n" + "Treatgiver X1";
                    if (chow >= 1 && raincoat >= 1 && treatgiver >= 1 && malk >=1 &&plushies>=1)
                    {
                        chow -= 1;
                        raincoat -= 1;
                        treatgiver -= 1;
                        malk -= 1;
                        plushies -= 1;
                        plushiesOutput.Text = $"Plushies: X{plushies}";
                        malkOutput.Text = $"Malk: X{malk}";
                        chowOutput.Text = $"Chow: X{chow}";
                        treatgiverOutput.Text = $"Treatgiver: X{treatgiver}";
                        RaincoatOutput.Text = $"Raincoat: X{raincoat}";
                    }
                    else
                    {
                        requestItems.Text = "Uh oh! you didn't stock enough! The customer is unhappy now :(";
                      
                    }
                    break;
            }
            //shows the notifcation and gives a second for the User to prepare.
            Refresh();
            Thread.Sleep(1000);
            custNotifcation.Visible = false;
        }
        private void playButton_Click(object sender, EventArgs e)
        {//Day will end after daycycle reaches 3
            if (days <= 0)
            {
                daycycle += 1;
                Playtime.Enabled = true;
                eventPeriodLabel.Text = "Stocking period:Deactive";
                NPCEnter();
                Stockingtime();
                //enables timers and buttons
                CurrentCustomer.Enabled = true;
                NPC += 1;
                totalGiveButton.Enabled = true;
            } else if (days <= 1) 
            {
                NPC = 1;
                totalGiveButton.Enabled = true;
                daycycle = 1;
                Playtime.Enabled = true;
                eventPeriodLabel.Text = "Stocking period:Deactive";
                NPCEnter();
                Stockingtime();
                //enables timers and buttons
                CurrentCustomer.Enabled = true;

            }

        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {//shows calculator
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
        //Stock buttons 
        private void stockChowButton_Click(object sender, EventArgs e)
        {
            chow += 1;
            coins -= 5;
            chowOutput.Text = $"Chow: X{chow}";
            coinManagement();
        }

        private void stockMalkButton_Click(object sender, EventArgs e)
        {
            malk += 1;
            coins -= 2;
            malkOutput.Text = $"Malk: X{malk}";
            coinManagement();
        }

        private void stockRaincoatButton_Click(object sender, EventArgs e)
        {
            raincoat += 1;
            coins -= 8;
            RaincoatOutput.Text = $"Raincoat: X{raincoat}";
            coinManagement();
        }

        private void stockPlushiesButton_Click(object sender, EventArgs e)
        {
            plushies += 1;
            coins -= 4;
            plushiesOutput.Text = $"Plushies: X{plushies}";
            coinManagement();
        }

        private void stockTreatGiverButton_Click(object sender, EventArgs e)
        {
            treatgiver += 1;
            coins -= 12;
            treatgiverOutput.Text = $"TreatGiver: X{treatgiver}";
            coinManagement();
        }

        private void Playtime_Tick(object sender, EventArgs e)
        {
            playingtime += 1;
            TimePlayedOutput.Text = $"Time Played:{playingtime}";

        }

        private void coinOutput_Click(object sender, EventArgs e)
        {


        }

        private void CurrentCustomer_Tick(object sender, EventArgs e)
        {
            firstMer -= 1;
            timeLeftOutput.Text = $" {firstMer}";
            if (firstMer ==0)
            {
                requestItems.Text = "you've run out of time!!!";
                NPCEnter();
            }
        }

        private void addChowButton_Click(object sender, EventArgs e)
        {
            chow -= 1;
        }
        //Add buttons are no longer being used but I didn't want to delete them in case I accidentally broke the program!
        private void addRaincoatButton_Click(object sender, EventArgs e)
        {
            raincoat -= 1;
        }

        private void addMalkButton_Click(object sender, EventArgs e)
        {
            malk -= 1;
        }

        private void addPlushiesButton_Click(object sender, EventArgs e)
        {
            plushies -= 1;
        }

        private void addTreatGiverButton_Click(object sender, EventArgs e)
        {
            treatgiver -= 1;
        }
    }
}
