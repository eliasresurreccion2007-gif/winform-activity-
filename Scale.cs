using WinFormsApp2;

namespace ACTIVITY_5
{
    public partial class Scale : Form
    {
        string num = "";
        public Scale()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SELECTBT.Items.Add("Weight");
            SELECTBT.Items.Add("Length");
            SELECTBT.Items.Add("Temperature");
            SELECTBT.Items.Add("Volume");
        }

        private void SELECTBT_SelectedIndexChanged(object sender, EventArgs e)
        {
            ONEBT.Items.Clear();
            TWOBT.Items.Clear();

            if (SELECTBT.Text == "Weight")
            {
                string[] u = { "Grams", "Kilograms" };
                ONEBT.Items.AddRange(u);
                TWOBT.Items.AddRange(u);
            }
            else if (SELECTBT.Text == "Length")
            {
                string[] u = { "Meter", "Kilometer" };
                ONEBT.Items.AddRange(u);
                TWOBT.Items.AddRange(u);
            }
            else if (SELECTBT.Text == "Temperature")
            {
                string[] u = { "Celsius", "Fahrenheit" };
                ONEBT.Items.AddRange(u);
                TWOBT.Items.AddRange(u);

            }
            else if (SELECTBT.Text == "Volume")
            {
                string[] u = { "Milliliter", "Liter", "Gallon" };
                ONEBT.Items.AddRange(u);
                TWOBT.Items.AddRange(u);
            }
            if (ONEBT.Items.Count > 0)
            {
                ONEBT.SelectedIndex = 0;
                TWOBT.SelectedIndex = 0;
            }
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            num += b.Text;
            ONETB.Text = num;
        }

        private void DOTBT_Click(object sender, EventArgs e)
        {
            num = "";
            ONETB.Text = "";
            TWOTB.Text = "";
        }

        private void CLEARBT_Click(object sender, EventArgs e)
        {
            num = "";
            ONETB.Text = "";
            TWOTB.Text = "";
        }

        private void BACKBT_Click(object sender, EventArgs e)
        {
            if (num.Length > 0)
            {
                num = num.Substring(0, num.Length - 1);
                ONETB.Text = num;
            }

        }

        private void EQUALBT_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(ONETB.Text, out value))
            {
                MessageBox.Show("Enter valid number");
                return;
            }

            double result = value;


            if (SELECTBT.Text == "Weight")
            {
                if (ONEBT.Text == "Grams" && TWOBT.Text == "Kilograms")
                    result = value / 1000;
                else if (ONEBT.Text == "Kilograms" && TWOBT.Text == "Grams")
                    result = value * 1000;
            }


            else if (SELECTBT.Text == "Length")
            {
                if (ONEBT.Text == "Meter" && TWOBT.Text == "Kilometer")
                    result = value / 1000;
                else if (ONEBT.Text == "Kilometer" && TWOBT.Text == "Meter")
                    result = value * 1000;
            }


            else if (SELECTBT.Text == "Volume")
            {
                if (ONEBT.Text == "Liter" && TWOBT.Text == "Milliliter")
                    result = value * 1000;
                else if (ONEBT.Text == "Milliliter" && TWOBT.Text == "Liter")
                    result = value / 1000;
                else if (ONEBT.Text == "Liter" && TWOBT.Text == "Gallon")
                    result = value * 0.264172;
                else if (ONEBT.Text == "Gallon" && TWOBT.Text == "Liter")
                    result = value / 0.264172;
            }


            else if (SELECTBT.Text == "Temperature")
            {
                if (ONEBT.Text == "Celsius" && TWOBT.Text == "Fahrenheit")
                    result = (value * 9 / 5) + 32;
                else if (ONEBT.Text == "Fahrenheit" && TWOBT.Text == "Celsius")
                    result = (value - 32) * 5 / 9;
            }

            TWOTB.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transition transition = new Transition();
            transition.Show();

            this.Hide();
        }
    }
}
