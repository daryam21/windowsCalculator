﻿using System;
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
	public partial class Calculator : Form
	{

		Double value = 0;
		string operation = "";
		bool operation_pressed = false;

		public Calculator()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button12_Click(object sender, EventArgs e)
		{

		}

		private void button11_Click(object sender, EventArgs e)
		{

		}

		private void button_Click(object sender, EventArgs e)
		{

			if ((result.Text == "0") || (operation_pressed))
				result.Clear();
			operation_pressed = false;
			Button b = (Button)sender;
			result.Text = result.Text + b.Text;
		}

		private void button13_Click(object sender, EventArgs e)
		{
			result.Text = "0";
			operate.Text = " ";
		}

		private void Operator_Click(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			operation = b.Text;
			operation_pressed = true;
			value = Double.Parse(result.Text);
			operate.Text = value + " " + operation;
		}

		private void button20_Click(object sender, EventArgs e)
		{
			
			operate.Text = " ";
			switch (operation)
			{

				case "+":
					result.Text = (value + Double.Parse(result.Text)).ToString();
					break;
				case "-":
					result.Text = (value - Double.Parse(result.Text)).ToString();
					break;
				case "*":
					result.Text = (value * Double.Parse(result.Text)).ToString();
					break;
				case "/":
					result.Text = (value / Double.Parse(result.Text)).ToString();
					break;
				default:
					break;
					

			}
		}

		private void button19_Click(object sender, EventArgs e)
		{
			
			operate.Text = "";
			value = 0;
			result.Text = "0";
		}

		private void result_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
