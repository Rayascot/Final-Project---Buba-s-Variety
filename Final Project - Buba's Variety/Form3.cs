using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project___Buba_s_Variety
{
    public partial class Form3 : Form
    {
        int num1, num2;
        int[] products = new int[10];
        int calcClick;
        int function;
        public Form3()
        {
            InitializeComponent();
        }

        private void calcuButton_Click(object sender, EventArgs e)
        {switch (function)
            {
                case (1):
                    products[calcClick] = num1 - num2;
                    productOutput.Text += $"{products[calcClick]}, ";
                    break;
                case (2):
                    products[calcClick] = num1 + num2;
                    productOutput.Text += $"{products[calcClick]}, ";
                    break;
                case (3):
                    products[calcClick] = num1 * num2;
                    productOutput.Text += $"{products[calcClick]}, ";
                    break;
            }
            if (calcClick < 10)
            { calcClick++; }
            else if (calcClick == 10)
            { numbersOutput.Text = "Current products will be reset, press reset to reset the product label.";
                calcClick = 0;
            }
        }

        private void firstSetButton_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToInt32(set1Textbox.Text);
            }
            catch
            {

            }
        }

        private void secondsSetButton_Click(object sender, EventArgs e)
        {
            try { 
                num2 = Convert.ToInt32(set2Textbox.Text);

            }catch
            {
                
            }
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            numbersOutput.Text = $"{num1} - {num2}";
            function = 1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            function = 2;
            numbersOutput.Text = $"{num1} + {num2}";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = 3;
            numbersOutput.Text = $"{num1} x {num2}";
        }
    }
}
