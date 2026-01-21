using System.Reflection.Metadata.Ecma335;

namespace Final_Project___Buba_s_Variety
{
    public partial class Form1 : Form
    {
        int coins = 100;
        int raincoat, chow, malk, plushies, treatgiver;
        int playingtime;
        int firstMer = 300;
        int secondMer = 350;
        int lastmer = 400;
        int wantset;
        int UserTotal;
        int score;
        int NPC, daycycle;
        Random monies = new Random();

        public Form1()
        {
            InitializeComponent();
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
                        if (UserTotal == 29)
                        {
                            score += 5;
                            coins += 29;
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
        {//presets decided for the enterance for 1st in line customers

            wantset = monies.Next(1, 11);
            switch (wantset)
            {
                case (1):
                    requestItems.Text += "\n" + "Chow X2" + "\n" + "TreatGiver X1";
                    if (chow >=2 || treatgiver >=1)
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
                    if (raincoat >= 1 || malk >= 2 || plushies >= 1)
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
                    if (chow >=3|| plushies>=2)
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
                    if (chow >=1|| malk>=2|| plushies>=1)
                    {
                        chow -= 1;
                        malk -= 2;
                        plushies -= 1;
                        chowOutput.Text = $"Chow: X{chow}";
                        plushiesOutput.Text = $"Plushies: X{plushies}";
                        malkOutput.Text = $"Malk: X{malk}";
                    } else if (chow<1|| malk<2|| plushies<1)
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
                    if (chow >=2|| raincoat>=1)
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
                    if (chow>=2|| raincoat>=2|| malk >=4|| plushies>=1)
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
                    if (chow >=4|| malk>=1)
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
                    if (chow>=1||raincoat>=1||treatgiver>=1)
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
                    if (chow >= 1 || raincoat >= 1 || treatgiver >= 1||malk >=1||plushies>=1)
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

        }
        private void playButton_Click(object sender, EventArgs e)
        {
            Playtime.Enabled = true;
            eventPeriodLabel.Text = "Stocking period:Deactive";
            NPCEnter();
            CurrentCustomer.Enabled = true;
            NPC += 1;
            
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

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

        }

        private void addChowButton_Click(object sender, EventArgs e)
        {
            chow -= 1;
        }

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
