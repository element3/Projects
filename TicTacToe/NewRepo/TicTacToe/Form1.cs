using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            click1 = 0;
        }



        //check for X's wins
        void check()
        {

            //check for X's wins

            //check rows
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X's Win This Round!");
                reset();
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X's Win This Round!");
                reset();
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X's Win This Round!");
                reset();
            }
            //check columns
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X's Win This Round!");
                reset();
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X's Win This Round!");
                reset();
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X's Win This Round!");
                reset();
            }
            // check diagonal
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X's Win This Round!");
                reset();
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X's Win This Round!");
                reset();
            }
            //check for O's win
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O's Win This Round!");
                reset();
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O's Win This Round!");
                reset();
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O's Win This Round!");
                reset();
            }
            //check columns
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O's Win This Round!");
                reset();
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O's Win This Round!");
                reset();
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O's Win This Round!");
                reset();
            }
            // check diagonal
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O's Win This Round!");
                reset();
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O's Win This Round!");
                reset();
            }
            else if(button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text !="" )
            {
                MessageBox.Show("Draw Game");
            }

        }








        int click1 = 0;




        private void button1_Click(object sender, EventArgs e)
        {

            if (click1 == 0)
            {
                //if (turn % 2 != 0)

                button1.Text = "X";
                click1++;
            }
            else if (click1 == 1)
            {
                button1.Text = "O";
                click1--;
            }


            else
            {
                button1.Text = button1.Text;
            }
            check();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                //if (turn % 2 != 0)

                button2.Text = "X";
                click1++;
            }
            else if (click1 == 1)
            {
                button2.Text = "O";
                click1--;
            }

            else
            {
                button2.Text = button2.Text;
            }
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                //if (turn % 2 != 0)

                button3.Text = "X";
                click1++;
            }
            else if (click1 == 1)
            {
                button3.Text = "O";
                click1--;
            }

            else
            {
                button3.Text = button3.Text;
            }
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                //if (turn % 2 != 0)

                button4.Text = "X";
                click1++;
            }
            else if (click1 == 1)
            {
                button4.Text = "O";
                click1--;
            }

            else
            {
                button4.Text = button4.Text;
            }
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                //if (turn % 2 != 0)

                button5.Text = "X";
                click1++;
            }
            else if (click1 == 1)
            {
                button5.Text = "O";
                click1--;
            }

            else
            {
                button5.Text = button5.Text;
            }
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                //if (turn % 2 != 0)

                button6.Text = "X";
                click1++;
            }
            else if (click1 == 1)
            {
                button6.Text = "O";
                click1--;
            }

            else
            {
                button6.Text = button6.Text;
            }
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                //if (turn % 2 != 0)

                button7.Text = "X";
                click1++;
            }
            else if (click1 == 1)
            {
                button7.Text = "O";
                click1--;
            }

            else
            {
                button7.Text = button7.Text;
            }
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                //if (turn % 2 != 0)

                button8.Text = "X";
                click1++;
            }
            else if (click1 == 1)
            {
                button8.Text = "O";
                click1--;
            }

            else
            {
                button8.Text = button8.Text;
            }
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                //if (turn % 2 != 0)

                button9.Text = "X";
                click1++;
            }
            else if (click1 == 1)
            {
                button9.Text = "O";
                click1--;
            }

            else
            {
                button9.Text = button9.Text;
            }
            check();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  

        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();
        }
    }


}// end of class

