using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		double value = 0;
		string operation = "";
		bool operation_pressed = false;

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		//CE Button
		private void button5_Click(object sender, EventArgs e)
		{
			txt_result.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if ((txt_result.Text=="0")||operation_pressed==true)
			{
				txt_result.Clear();
			}

			operation_pressed = false;

			Button b = (Button) sender;
			txt_result.Text += b.Text;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			operation_pressed = true;
			Button b = (Button) sender;
			operation = b.Text;
			value = double.Parse(txt_result.Text);
		}

		//C Button
		private void button12_Click(object sender, EventArgs e)
		{
			txt_result.Clear();
			value = 0;
		}

		//= Button
		private void button20_Click(object sender, EventArgs e)
		{
			switch (operation)
			{
				case "+":
					txt_result.Text = (value + double.Parse(txt_result.Text)).ToString();
					break;
				case "-":
					txt_result.Text = (value - double.Parse(txt_result.Text)).ToString();
					break;
				case "*":
					txt_result.Text = (value * double.Parse(txt_result.Text)).ToString();
					break;
				case "/":
					txt_result.Text = (value / double.Parse(txt_result.Text)).ToString();
					break;
				default:
					break;
			}
		}

		private void txt_result_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
