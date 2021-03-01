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
    public partial class EditRunProfile : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 5, 16);

        public EditRunProfile()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void buttonPhotoIn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();// создаем диалоговое окно
            openFile.ShowDialog();// открываем окно
            string FileName = openFile.FileName;// берем полный адрес картинки            
            pictureBoxImage.ImageLocation = FileName;// грузим картинку в pictureBox
            textBoxPhoto.Text = FileName;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
               throw new Exception("Данные изменены!");
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            this.Hide();
            RunnerMenu rm = new RunnerMenu();
            rm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RunnerMenu rm = new RunnerMenu();
            rm.Show();
        }
    }
}
