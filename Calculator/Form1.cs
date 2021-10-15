using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		private double value;
		char operatorType;
		bool operationPressed;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
		}

		private void button13_Click(object sender, EventArgs e)
		{
			operationPressed = true;
			operatorType = '%';
			value = Convert.ToDouble(textBox1.Text);
		}

		private void btn1_Click(object sender, EventArgs e)
		{

			if (textBox1.Text == "0"||operationPressed==true)
				textBox1.Clear();
			textBox1.Text += "1";
			operationPressed = false;
			
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || operationPressed == true)
				textBox1.Clear();
			textBox1.Text += "2";
			operationPressed = false;
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || operationPressed == true)
				textBox1.Clear();
			textBox1.Text += "3";
			operationPressed = false;
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || operationPressed == true)
				textBox1.Clear();
			textBox1.Text += "4";
			operationPressed = false;
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || operationPressed == true)
				textBox1.Clear();
			textBox1.Text += "5";
			operationPressed = false;
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || operationPressed == true)
				textBox1.Clear();
			textBox1.Text += "6";
			operationPressed = false;
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || operationPressed == true)
				textBox1.Clear();
			textBox1.Text += "7";
			operationPressed = false;
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || operationPressed == true)
				textBox1.Clear();
			textBox1.Text += "8";
			operationPressed = false;
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || operationPressed == true)
				textBox1.Clear();
			textBox1.Text += "9";
			operationPressed = false;
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "0" || operationPressed == true)
			
			textBox1.Text += "0";
			operationPressed = false;
		}

		private void btnCE_Click(object sender, EventArgs e)
		{
			textBox1.Text = "0";
		}

		private void btnC_Click(object sender, EventArgs e)
		{
			textBox1.Text = "0";
		}

		private void btnplus_Click(object sender, EventArgs e)
		{
			operationPressed = true;
			operatorType = '+';
			value = Convert.ToDouble(textBox1.Text);
		}

		private void btnminus_Click(object sender, EventArgs e)
		{
			operationPressed = true;
			operatorType = '-';
			value = Convert.ToDouble(textBox1.Text);
		}

		private void btnmultiply_Click(object sender, EventArgs e)
		{
			operationPressed = true;
			operatorType = '*';
			value = Convert.ToDouble(textBox1.Text);
		}

		private void btndivide_Click(object sender, EventArgs e)
		{
			operationPressed = true;
			operatorType = '/';
			value = Convert.ToDouble(textBox1.Text);
		}

		private void btneq_Click(object sender, EventArgs e)
		{
			switch(operatorType)
			{
				case '+':value += Convert.ToDouble(textBox1.Text);
					break;
				case '-':value -= Convert.ToDouble(textBox1.Text);
					break;
				case '*':value *= Convert.ToDouble(textBox1.Text);
					break;
				case '/':value /= Convert.ToDouble(textBox1.Text);
					break;
			}
			textBox1.Text = value.ToString();
			operationPressed = true;
		}

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            operationPressed = true;
        }
    }
}
