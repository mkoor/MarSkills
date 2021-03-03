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
    public partial class HowLong : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 5, 16);

        public HowLong()
        {
            InitializeComponent();
            timer1.Start();

            ToolStripMenuItem fileItem = new ToolStripMenuItem("Скорость");

            fileItem.Image = Image.FromFile(@"D:\Mоё\C#\WSR 2017Программные решения для бизнеса\TP09_resources\WSR2016_TP09_ресурсы_сессия_2\how-long-is-a-marathon-images\f1-car.jpg");
            fileItem.DropDownItems.Add("F1 car");

            OpenFileDialog openFile = new OpenFileDialog();
            string FileName = openFile.FileName;
            pictureBoxImage.ImageLocation = FileName;

            menuStrip1.Items.Add(fileItem);

            ToolStripMenuItem aboutItem = new ToolStripMenuItem("Дистанция");
            aboutItem.Click += aboutItem_Click;
            menuStrip1.Items.Add(aboutItem);
        }

        void aboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дистанция");
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void HowLong_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            InfoAbout ia = new InfoAbout();
            ia.Show();
            this.Hide();
        }

        private void labelEdit_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }
    }
}
