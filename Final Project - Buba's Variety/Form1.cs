using System.Reflection.Metadata.Ecma335;

namespace Final_Project___Buba_s_Variety
{
    public partial class Form1 : Form
    {
        int coins = 50;
        int raincoat, chow, malk, plushies, treatgiver;
        int playingtime,firstMer, secondMer, lastmer;

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

        private void playButton_Click(object sender, EventArgs e)
        {
            Playtime.Enabled = true;
            eventPeriodLabel.Text = "Stocking period:Deactive";
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
    }
}
