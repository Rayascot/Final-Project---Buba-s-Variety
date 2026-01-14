using System.Reflection.Metadata.Ecma335;

namespace Final_Project___Buba_s_Variety
{
    public partial class Form1 : Form
    {
        int coins = 100;
        int raincoat, chow, malk, plushies, treatgiver;
        int playingtime, firstMer, secondMer, lastmer;
        int wantset;

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
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
        private void NPCEnter()
        {//presets decided for the enterance for 1st in line customers
            Random monies = new Random();
            wantset = monies.Next(1,7);
            switch (wantset)
            {
                case (1): requestItems.Text += "\n" + "Chow X2" + "\n" + "TreatGiver X1";
                    break;
                case (2): requestItems.Text += "\n" + "Raincoat X1" + "\n" + "Malk X2" + "\n" + "Plushie X1";
                    break ;
                case (3): requestItems.Text += "\n" + "Chow X3" + "\n" + "Plushie X2";
                    break ;
                case (4): requestItems.Text += "\n" + "Chow X1" + "\n" + "Malk X2" + "\n" + "Plushie X1";
                    break ;
                case (5): requestItems.Text += "\n" + "Treatgiver X2";
                    break;
                case (6): requestItems.Text += "\n" + "Chow X2" + "\n" + "Raincoat X1";
                    break ;
            }

        }
        private void playButton_Click(object sender, EventArgs e)
        {
            Playtime.Enabled = true;
            eventPeriodLabel.Text = "Stocking period:Deactive";
            NPCEnter();
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
    }
}
