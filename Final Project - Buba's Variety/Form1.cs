namespace Final_Project___Buba_s_Variety
{
    public partial class Form1 : Form
    {
        int coins = 50;
        int raincoat;
        public Form1()
        {
            InitializeComponent();
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
            Application.Run(new Form3());
        }

        private void stockChowButton_Click(object sender, EventArgs e)
        {

        }
    }
}
