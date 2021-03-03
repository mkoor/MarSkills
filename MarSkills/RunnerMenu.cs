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
    public partial class RunnerMenu : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 5, 16);


        public RunnerMenu()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void RunnerMenu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Glavnaya gl = new Glavnaya();
            gl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            EditRunProfile erp = new EditRunProfile();
            erp.Show();
            this.Hide();
        }

        private void buttonRezults_Click(object sender, EventArgs e)
        {
            MyRaceRezults mrr = new MyRaceRezults();
            mrr.Show();
            this.Hide();
        }
    }
}
