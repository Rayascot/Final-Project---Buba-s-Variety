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
    public partial class chaosForm : Form
    {
        int numbonk;
        public chaosForm()
        {
            InitializeComponent();
        }

        private void bonktick_Tick(object sender, EventArgs e)
        {
            bonksClick();
            if (numbonk == 10) { 
                this.Close(); }
        }
        private void bonksClick()
        {
            bonkClick1.Visible = true;
            bonkClick2.Visible = true;
            bonkClick3.Visible = true;
            bonkClick4.Visible = true;
            bonkClick5.Visible = true;
            bonkClick6.Visible = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            numbonk = 0;
            bonksClick();
            bonktick.Enabled = true;
        }

        private void bonkClick6_Click(object sender, EventArgs e)
        {
            bonkClick6.Visible = false;
            numbonk += 1;
        }

        private void bonkClick1_Click(object sender, EventArgs e)
        {
            bonkClick1.Visible = false;
            numbonk += 1;
        }

        private void bonkClick2_Click(object sender, EventArgs e)
        {
            numbonk += 1;
            bonkClick2.Visible = false;
        }

        private void bonkClick3_Click(object sender, EventArgs e)
        {
            numbonk += 1;
            bonkClick3.Visible = false;
        }

        private void bonkClick4_Click(object sender, EventArgs e)
        {
            numbonk += 1;
            bonkClick4.Visible = false;
        }

        private void bonkClick5_Click(object sender, EventArgs e)
        {
            numbonk += 1;
            bonkClick5.Visible = false;
        }
    }
}
