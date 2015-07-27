using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float firstNum;
            float secNum;
            float answer;
            string operation;

            if (comboBox1.SelectedIndex == -1 || textBox1.Text == "" || textBox3.Text == "")
            {
                operation = "Nothing Selected";
                firstNum = 0;
                secNum = 0;
            }
            else
            {
                operation = comboBox1.SelectedItem.ToString();
                firstNum = float.Parse(textBox1.Text);
                secNum = float.Parse(textBox3.Text);
            }

            switch (operation)
            {
                case "Plus":
                    answer = firstNum + secNum;
                    label1.Text = answer.ToString();
                    break;
                case "Minus":
                    answer = firstNum - secNum;
                    label1.Text = answer.ToString();
                    break;
                case "Multiply":
                    answer = firstNum * secNum;
                    label1.Text = answer.ToString();
                    break;
                case "Divide":
                    answer = firstNum / secNum;
                    label1.Text = answer.ToString();
                    break;
                default:
                    label1.Text = "Missing inputs";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+") && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a digit 0-9");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
