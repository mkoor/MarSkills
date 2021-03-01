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
    public partial class ListOfCharities : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 5, 16);

        public ListOfCharities()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void ListOfCharities_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            InfoAbout ia = new InfoAbout();
            ia.Show();
            this.Hide();
        }
    }
}
