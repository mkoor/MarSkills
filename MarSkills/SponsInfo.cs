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
    public partial class SponsInfo : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 5, 16);

        public SponsInfo()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Glavnaya gl = new Glavnaya();
            gl.Show();
            this.Hide();
        }

        private void labelTime_Click_2(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }
    }
}
