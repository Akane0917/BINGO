using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINGO
{
    public partial class playForm : Form
    {
    
        public playForm()
        {
            InitializeComponent();
            

        }
       
        //creat Random variable
        Random random = new Random();
        private void Form2_Load(object sender, EventArgs e)
        {

           
            //set the number from 1 to 30
          List<int> numbers = Enumerable.Range(1, 29).ToList();

            //grouping labels 1 to 18 as a
            for (int i = 1; i <= 18; i++)
            {

                //set the random number to each label
                Label a = this.Controls["label" + i] as Label;
                a.Text = random.Next(1, 30).ToString();
            

              //do not set the same number
                int b = random.Next(numbers.Count);
                a.Text = numbers[b].ToString();
                numbers.RemoveAt(b);
            }
        }
        private void spinButton_Click(object sender, EventArgs e)
        {}

        //display random number 
        private void spinButtom_Click(object sender, EventArgs e)
        {
            numberLabel.Text = random.Next(1, 30).ToString();
            CheckNumber();
        }

        //check the number
        //if the number of labels is the same  as the number of drawn, remove the labels
        async Task CheckNumber()
        {
            try
            {
                for (int i = 1; i <= 18; i++)
                {
                    Label a = this.Controls["label" + i] as Label;
                    if (a !=null && a.Text == numberLabel.Text)
                    {
                        await Task .Delay(1000);
                        a.Visible = false;
                    }
                }
            }
            catch { }
        }

      

        

        //check the answer
        //if the answer is correct, win the game
        //if the answer is incorrect, keep playing the game
        private void answerButton_Click(object sender, EventArgs e)
        {
            if (ansTextBox.Text == "Banana" || ansTextBox.Text == "banana")
            {
                ansLabel.Text = "Player2 wins!!!! & push homeButton";
            }

            else if(ansTextBox.Text == "apple"|| ansTextBox.Text == "Apple")
            {
                ansLabel.Text = "Player1 wins!!! & push homeButton";
            }
            else
            {
                ansLabel.Text = "no******* keep playing the game";
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homeForm form1 = new homeForm();
            form1.Show();

            this.Hide();
        }
    }
}
