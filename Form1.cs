namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(NUM1TB.Text);
            double num2 = Convert.ToDouble(NUM2TB.Text);

            if (num1 / 2 != 0)
            {
                double result = num1 / num2;
                resultsTB.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Cannot divide by zero!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(NUM1TB.Text);
            double num2 = Convert.ToDouble(NUM2TB.Text);

            double result = num1 % num2;
            resultsTB.Text = result.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(NUM1TB.Text);
            double num2 = Convert.ToDouble(NUM2TB.Text);

            double sum = num1 + num2;
            resultsTB.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(NUM1TB.Text);
            double num2 = Convert.ToDouble(NUM2TB.Text);

            double result = num1 - num2;
            resultsTB.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(NUM1TB.Text);
            double num2 = Convert.ToDouble(NUM2TB.Text);

            double result = num1 * num2;
            resultsTB.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Transition transition = new Transition();
            transition.Show();

            this.Hide();
        }
    }
}
