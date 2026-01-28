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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
          
        }

        private void Instructions_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
