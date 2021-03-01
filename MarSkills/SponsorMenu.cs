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
    public partial class SponsorMenu : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 5, 16);

        int a;

        public SponsorMenu()
        {
            InitializeComponent();
            timer1.Start();
            ShowRunners();
        }

        private void SponsorMenu_Load(object sender, EventArgs e)
        {
            textBoxName.Text = "Ваше имя";//подсказка
            textBoxName.ForeColor = Color.Gray;

            comboBoxRunner.Text = "Иван Прудов - 204 (Russia)";
            comboBoxRunner.ForeColor = Color.Gray;

            textBoxCard.Text = "Владелец";
            textBoxCard.ForeColor = Color.Gray;

            textBoxNumCard.Text = "1234 5678 9123 4567";
            textBoxNumCard.ForeColor = Color.Gray;

            textBoxMonCard.Text = "01";
            textBoxMonCard.ForeColor = Color.Gray;

            textBoxYearCard.Text = "23";
            textBoxYearCard.ForeColor = Color.Gray;

            textBoxCVC.Text = "123";
            textBoxCVC.ForeColor = Color.Gray;

        }
        void ShowRunners()
        {
            comboBoxRunner.Items.Clear();
            foreach (User user in Program.mskills.User )
            {
                if (user.RoleId == "R")
                {
                    string[] item = { user.LastName + " ", user.FirstName + " - " };
                    comboBoxRunner.Items.Add(string.Join(" ", item));
                }
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            if (textBoxName.Text == "Ваше имя")
            {
                textBoxName.Clear();
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void comboBoxRunner_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {

        }

        private void textBoxCard_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            if (textBoxCard.Text == "Владелец")
            {
                textBoxCard.Clear();
                textBoxCard.ForeColor = Color.Black;
            }
        }

        private void textBoxNumCard_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            if (textBoxNumCard.Text == "1234 5678 9123 4567")
            {
                textBoxNumCard.Clear();
                textBoxNumCard.ForeColor = Color.Black;
            }
        }

        private void textBoxMonCard_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            if (textBoxMonCard.Text == "01")
            {
                textBoxMonCard.Clear();
                textBoxMonCard.ForeColor = Color.Black;
            }
        }

        private void textBoxYearCard_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            if (textBoxYearCard.Text == "23")
            {
                textBoxYearCard.Clear();
                textBoxYearCard.ForeColor = Color.Black;
            }
        }

        private void textBoxCVC_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            if (textBoxCVC.Text == "123")
            {
                textBoxCVC.Clear();
                textBoxCVC.ForeColor = Color.Black;
            }
        }

        private void textBoxPrice_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(textBoxPrice.Text);
                if (a >= 0)
                {
                    a = a + 10;
                    textBoxPrice.Text = Convert.ToString(a);
                    labelDollars.Text = Convert.ToString(a) + "$";
                }
                else throw new Exception("Сумма пожертвования заполнена не правильно");
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(textBoxPrice.Text);
                if (a > 9)
                {
                    a = a - 10;
                    textBoxPrice.Text = Convert.ToString(a);
                    labelDollars.Text = Convert.ToString(a) + "$";
                }
                else throw new Exception("Сумма пожертвования заполнена не правильно");
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void textBoxPrice_TextChanged_1(object sender, EventArgs e)
        {
            labelDollars.Text = textBoxPrice.Text + "$";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                Sponsorship spship = new Sponsorship();

                if (textBoxCard.Text == "" || textBoxCVC.Text == "" || textBoxMonCard.Text == "" ||
                       textBoxName.Text == "" || textBoxNumCard.Text == "" || textBoxPrice.Text == "" ||
                       textBoxYearCard.Text == "" || comboBoxRunner.SelectedItem == null)
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    spship.SponsorName = textBoxName.Text;
                    spship.RegistrationId = Convert.ToInt32(comboBoxRunner.SelectedItem.ToString().Split('.')[0]);
                    spship.Amount = Convert.ToInt32(textBoxPrice.Text);

                    SponsInfo info = new SponsInfo();
                    info.Show();
                    this.Hide();
                }

                Program.mskills.Sponsorship.Add(spship);
                Program.mskills.SaveChanges();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Glavnaya gl = new Glavnaya();
            gl.Show();
            this.Hide();
        }
    }
}
