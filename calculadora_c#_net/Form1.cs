using System.Diagnostics.Eventing.Reader;

namespace calculadora_c__net
{
    public partial class Form1 : Form
    {
        private double operand1 = 0;
        private double operand2 = 0;
        private string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(textBox1.Text);
            operation = "+";
            textBox1.Clear();
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(textBox1.Text);
            operation = "-";
            textBox1.Clear();
        }


        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(textBox1.Text);
            operation = "/";
            textBox1.Clear();

        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(textBox1.Text);
            operation = "*";
            textBox1.Clear();

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operand2 = Convert.ToDouble(textBox1.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "/":
                    result = operand1 / operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;

                default:
                    // En caso de que la operación no sea reconocida
                    result = 0; // o cualquier valor predeterminado
                    break;
            }
            textBox1.Text = result.ToString();
        }

    }
}
