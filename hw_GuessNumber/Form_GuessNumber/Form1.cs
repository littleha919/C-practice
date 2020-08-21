using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Form_GuessNumber
{
    public partial class Form1 : Form
    {
        int num;
        private string inputBox;

        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            num = r.Next(1, 100);
        }

        int large = 1;
        int small = 100;

        private void button1_Click(object sender, EventArgs e)
        {
            inputBox = Interaction.InputBox("Please input a number.", "Guess");

            int guess;

            bool isCovert = int.TryParse(inputBox, out guess);

            if (isCovert == false)
            {
                MessageBox.Show("請輸入數字");
                return;
            }

            Guess(num, int.Parse(inputBox));
        }

        void Guess(int num, int inputBox)  
        {
            if (inputBox > 100 || inputBox < 0)
            {
                MessageBox.Show("請輸入介於 0 至 100 的數字");
                return;
            }
            else if (num == inputBox)
            {
                MessageBox.Show("Congradulations!!! You got" + inputBox + "!!!");
                
                Form1 f = new Form1();
                f.Show();
            }
            else if (num < inputBox)
            {
                label1.Text = "Too Large!!!";
                small = inputBox;
                label2.Text = "Between" + large + "and" + small;
                
            }
            else
            {
                label1.Text = "Too Small!!!";
                large = inputBox;
                label2.Text = "Between" + large + " and " + small;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"本局的數字為：{num.ToString()}");
            try
            {
                MessageBox.Show("請按下 Guess 進行新一局遊戲");

            }
            catch (Exception ex)
            {
                Close();
            }
            finally
            {
                Close();
            }
        }
    }
}

