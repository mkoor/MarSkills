namespace MarSkills
{
    partial class RegisterEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxFond = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFond = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelEvent = new System.Windows.Forms.Label();
            this.labelDollars = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxFond
            // 
            this.comboBoxFond.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFond.FormattingEnabled = true;
            this.comboBoxFond.Location = new System.Drawing.Point(83, 378);
            this.comboBoxFond.Name = "comboBoxFond";
            this.comboBoxFond.Size = new System.Drawing.Size(145, 23);
            this.comboBoxFond.TabIndex = 94;
            this.comboBoxFond.Text = "Выберите фонд";
            this.comboBoxFond.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPrice.Location = new System.Drawing.Point(83, 406);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(145, 22);
            this.textBoxPrice.TabIndex = 93;
            this.textBoxPrice.Text = "1";
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxLatName_TextChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(23, 456);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(209, 18);
            this.labelTime.TabIndex = 91;
            this.labelTime.Text = "До начала марофона осталось";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(22, 405);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPrice.Size = new System.Drawing.Size(57, 20);
            this.labelPrice.TabIndex = 87;
            this.labelPrice.Text = "Сумма:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFond
            // 
            this.labelFond.AutoSize = true;
            this.labelFond.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFond.Location = new System.Drawing.Point(25, 377);
            this.labelFond.Name = "labelFond";
            this.labelFond.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFond.Size = new System.Drawing.Size(54, 20);
            this.labelFond.TabIndex = 86;
            this.labelFond.Text = "Взнос:";
            this.labelFond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(232, 43);
            this.labelText.Name = "labelText";
            this.labelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelText.Size = new System.Drawing.Size(589, 60);
            this.labelText.TabIndex = 81;
            this.labelText.Text = "Пожалуйста, заполните всю информацию, чтобы зарегистрироваться на Skills\r\nMaratho" +
    "n 2016 проводимом в Москве, Russiа. С вами свяжутся после регистрации\r\nдля уточн" +
    "ения оплаты и другой информации.";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReg.Location = new System.Drawing.Point(499, 451);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(129, 29);
            this.buttonReg.TabIndex = 80;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(645, 451);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 29);
            this.buttonCancel.TabIndex = 79;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEvent.Location = new System.Drawing.Point(230, 12);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEvent.Size = new System.Drawing.Size(256, 26);
            this.labelEvent.TabIndex = 78;
            this.labelEvent.Text = "Регистрация на марафон";
            this.labelEvent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDollars
            // 
            this.labelDollars.AutoSize = true;
            this.labelDollars.Font = new System.Drawing.Font("Open Sans Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDollars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.labelDollars.Location = new System.Drawing.Point(490, 377);
            this.labelDollars.Name = "labelDollars";
            this.labelDollars.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDollars.Size = new System.Drawing.Size(106, 51);
            this.labelDollars.TabIndex = 103;
            this.labelDollars.Text = "500$";
            this.labelDollars.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney.Location = new System.Drawing.Point(21, 146);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMoney.Size = new System.Drawing.Size(154, 26);
            this.labelMoney.TabIndex = 102;
            this.labelMoney.Text = "Вид марафона";
            this.labelMoney.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(494, 146);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 104;
            this.label1.Text = "Варианты комплектов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 339);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 105;
            this.label2.Text = "Детали спонсорства";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(494, 339);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(247, 26);
            this.label3.TabIndex = 106;
            this.label3.Text = "Регистрационный взнос";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(26, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(253, 26);
            this.checkBox1.TabIndex = 107;
            this.checkBox1.Text = "42km Полный марафон (145$)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(26, 216);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(215, 26);
            this.checkBox2.TabIndex = 108;
            this.checkBox2.Text = "21km Полумарафон (75$)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(26, 248);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(234, 26);
            this.checkBox3.TabIndex = 109;
            this.checkBox3.Text = "5km Малая дистанция (20$)";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Open Sans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(499, 184);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(214, 40);
            this.radioButton1.TabIndex = 110;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вариант А (0$): Номер бегуна +\r\nRFID браслет.";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Open Sans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(499, 230);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(202, 40);
            this.radioButton2.TabIndex = 111;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Вариант B (20$): вариант А + \r\nбейсболка + бутылка воды.\r\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Open Sans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(498, 276);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(215, 40);
            this.radioButton3.TabIndex = 112;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Вариант С (45$): вариант В + \r\nфутболка + сувенирный буклет.\r\n";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.Image = global::MarSkills.Properties.Resources.logo_2016_full_colour;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(211, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 77;
            this.Logo.TabStop = false;
            // 
            // RegisterEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(830, 494);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDollars);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.comboBoxFond);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelFond);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.Logo);
            this.Name = "RegisterEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация на марафон";
            this.Load += new System.EventHandler(this.RegisterEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxFond;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFond;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelDollars;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}