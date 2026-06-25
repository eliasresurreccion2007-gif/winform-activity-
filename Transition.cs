using Activity_4;
using ACTIVITY_5;
using pag_ito_nawala_pa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Transition : Form
    {
        public Transition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Starting_Form sf = new Starting_Form();
            sf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalForm1 Calform1 = new CalForm1();
            Calform1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Scale scaleForm = new Scale();
            scaleForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Data dataForm = new Data();
            dataForm.Show();
            this.Hide();
        }
    }
}

