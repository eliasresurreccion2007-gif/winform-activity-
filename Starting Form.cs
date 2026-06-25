using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp2
{
    public partial class Starting_Form : Form
    {

        private void Label1_Click(object sender, EventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            String name = NAMETB.Text;
            String age = AGETB.Text;
            String gender = GENDERTB.Text;

            INFOTB.Text = name + ", " + age + ", " + gender;
            if (gender == "male")
            {
                INFOTB.BackColor = Color.Cyan;
            }
            else if (gender == "female")
            {
                INFOTB.BackColor = Color.HotPink;
            }

        }

        private void ShowGenCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SHOWGENCB.Checked == true)
            {
                GENDERTB.UseSystemPasswordChar = false;
            }
            else if (SHOWGENCB.Checked == false)
            {
                GENDERTB.UseSystemPasswordChar = true;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            string Username = UsernameTB.Text;
            string Password = PasswordTB.Text;


            bool isLettersOnly = Regex.IsMatch(Username, @"^[a-zA-Z]+$");

            if (!string.IsNullOrEmpty(Username) &&
                !string.IsNullOrEmpty(Password) &&
                isLettersOnly)
            {
                if (Username == "admin" && Password == "1234")
                {
                    MessageBox.Show("Login successful!");
                    Transition transition = new Transition();
                    transition.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                }
            }

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transition transition = new Transition();
            transition.Show();

            this.Hide();
        }
    }
}
