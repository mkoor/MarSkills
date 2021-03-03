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
    public partial class MyRaceRezults : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 5, 16);

        public MyRaceRezults()
        {
            InitializeComponent();
            timer1.Start();
            ShowRezults();
        }

        void ShowRezults()
        {
            listViewRezults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void labelTime_Click(object sender, EventArgs e)
        {
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            RunnerMenu rm = new RunnerMenu();
            rm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
