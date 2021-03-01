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
    public partial class RegisterRunner : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 5, 16);

        public RegisterRunner()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RegisterRunner_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            RunnersReg rr = new RunnersReg();
            rr.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            RegisterEvent re = new RegisterEvent();
            re.Show();
            this.Hide();
        }

        private void buttonPhotoIn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();// создаем диалоговое окно
            openFile.ShowDialog();// открываем окно
            string FileName = openFile.FileName;// берем полный адрес картинки            
            pictureBoxImage.ImageLocation = FileName;// грузим картинку в pictureBox
            textBoxPhoto.Text = FileName;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "primer@mail.ru")
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Введите пароль")
            {
                textBoxPassword.Text = "";
            }
        }

        private void textBoxReturnPassw_TextChanged(object sender, EventArgs e)
        {
            if (textBoxReturnPassw.Text == "Повторите пароль")
            {
                textBoxReturnPassw.Text = "";
            }
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "Ваше имя")
            {
                textBoxFirstName.Text = "";
            }
        }

        private void textBoxLatName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "Ваша фамилия")
            {
                textBoxLastName.Text = "";
            }
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGender.Text == "Выберите пол")
            {
                comboBoxGender.Text = "";
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text == "Выберите страну")
            {
                comboBoxCountry.Text = "";
            }
        }
    }
}
