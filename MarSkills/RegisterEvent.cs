using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarSkills
{
    public partial class RegisterEvent : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 5, 16);

        int a;

        public RegisterEvent()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void RegisterEvent_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            RegisterRunner rr = new RegisterRunner();
            rr.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                {
                    a = 220;
                    labelDollars.Text = a + "$";  
                }
                else if (checkBox3.Checked)
                {
                    a = 165;
                    labelDollars.Text = a + "$";
                }
                else { a = 145; labelDollars.Text = a + "$"; }
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                a = 240;
                labelDollars.Text = a + "$";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            { 
                if (checkBox1.Checked)
                {
                    a = 220;
                    labelDollars.Text = a + "$";
                }
                else if (checkBox1.Checked && checkBox3.Checked)
                {
                    a = 240;
                    labelDollars.Text = a + "$";
                }
                else if (checkBox3.Checked)
                {
                    a = 95;
                    labelDollars.Text = a + "$";
                }
                else { a = 75; labelDollars.Text = a + "$"; }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {                
                if (checkBox1.Checked)
                {
                    a = 165;
                    labelDollars.Text = a + "$";
                }
                else if (checkBox1.Checked && checkBox2.Checked) 
                {
                    a = 240;
                    labelDollars.Text = a + "$";
                }
                else if (checkBox2.Checked)
                {
                    a = 95;
                    labelDollars.Text = a + "$";
                }
                else { a = 20; labelDollars.Text = a + "$"; }
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            RegistrationConfirmation rc = new RegistrationConfirmation();
            rc.Show();
            this.Hide();
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFond.Text == "Выберите фонд")
            {
                comboBoxFond.Text = "";
            }
        }

        private void textBoxLatName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "1")
            {
                textBoxPrice.Text = "";
            }
        }
    }
}
