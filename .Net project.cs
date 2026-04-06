using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Number Button Click
        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationPressed))
                textBox1.Clear();

            operationPressed = false;
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        // Operator Button Click (+, -, *, /)
        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operationPressed = true;
        }

        // Equal Button (=)
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        // Clear Button (C)
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }
    }
}