using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINGO
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            //start the game and close this form
            playForm form2 = new playForm();
            form2.Show();
            
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //done this program
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
