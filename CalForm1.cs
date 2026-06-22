using WinFormsApp2;

namespace pag_ito_nawala_pa
{
    public partial class CalForm1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        string operation = "";
        public CalForm1()
        {
            InitializeComponent();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            operation = "+";
            textBox1.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            operation = "-";
            textBox1.Clear();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            operation = "*";
            textBox1.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            operation = "/";
            textBox1.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                if (value >= 0)
                {
                    textBox1.Text = Math.Sqrt(value).ToString();
                }
                else
                {
                    MessageBox.Show("Cannot calculate square root of a negative number");
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
                textBox1.Clear();
            }

        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (value / 100).ToString();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            switch (operation)
            {
                case "+":
                    textBox1.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        textBox1.Text = (num1 / num2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        textBox1.Clear();
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transition transition = new Transition();
            transition.Show();

            this.Hide();
        }
    }
}
