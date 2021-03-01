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
    public partial class Glavnaya : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 5, 16);
        public Glavnaya()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
            labelMyTime.Text = Convert.ToString(DateTime.Now);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void buttonRunner_Click(object sender, EventArgs e)
        {
            RunnersReg rr = new RunnersReg();
            rr.Show();
            this.Hide();
        }

        private void buttonEvent_Click(object sender, EventArgs e)
        {
            InfoAbout ia = new InfoAbout();
            ia.Show();
            this.Hide();
        }

        private void buttonSponsor_Click(object sender, EventArgs e)
        {
            SponsorMenu sm = new SponsorMenu();
            sm.Show();
            this.Hide();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}
