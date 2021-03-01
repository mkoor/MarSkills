namespace MarSkills
{
    partial class RegisterRunner
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
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxReturnPassw = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelReturnPassw = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelRunner = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.textBoxPhoto = new System.Windows.Forms.TextBox();
            this.buttonPhotoIn = new System.Windows.Forms.Button();
            this.labelBirth = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(17, 355);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(209, 18);
            this.labelTime.TabIndex = 64;
            this.labelTime.Text = "До начала марофона осталось";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxFirstName.Location = new System.Drawing.Point(166, 216);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(247, 22);
            this.textBoxFirstName.TabIndex = 55;
            this.textBoxFirstName.Text = "Ваше имя";
            this.textBoxFirstName.Click += new System.EventHandler(this.textBoxFirstName_TextChanged);
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // textBoxReturnPassw
            // 
            this.textBoxReturnPassw.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReturnPassw.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxReturnPassw.Location = new System.Drawing.Point(166, 188);
            this.textBoxReturnPassw.Name = "textBoxReturnPassw";
            this.textBoxReturnPassw.Size = new System.Drawing.Size(247, 22);
            this.textBoxReturnPassw.TabIndex = 54;
            this.textBoxReturnPassw.Text = "Повторите пароль";
            this.textBoxReturnPassw.Click += new System.EventHandler(this.textBoxReturnPassw_TextChanged);
            this.textBoxReturnPassw.TextChanged += new System.EventHandler(this.textBoxReturnPassw_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxEmail.Location = new System.Drawing.Point(166, 133);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(247, 22);
            this.textBoxEmail.TabIndex = 53;
            this.textBoxEmail.Text = "primer@mail.ru";
            this.textBoxEmail.Click += new System.EventHandler(this.textBoxEmail_TextChanged);
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(119, 273);
            this.labelGender.Name = "labelGender";
            this.labelGender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGender.Size = new System.Drawing.Size(41, 20);
            this.labelGender.TabIndex = 52;
            this.labelGender.Text = "Пол:";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelGender.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(84, 244);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLastName.Size = new System.Drawing.Size(76, 20);
            this.labelLastName.TabIndex = 51;
            this.labelLastName.Text = "Фамилия:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(118, 218);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFirstName.Size = new System.Drawing.Size(42, 20);
            this.labelFirstName.TabIndex = 50;
            this.labelFirstName.Text = "Имя:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelReturnPassw
            // 
            this.labelReturnPassw.AutoSize = true;
            this.labelReturnPassw.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReturnPassw.Location = new System.Drawing.Point(16, 188);
            this.labelReturnPassw.Name = "labelReturnPassw";
            this.labelReturnPassw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelReturnPassw.Size = new System.Drawing.Size(146, 20);
            this.labelReturnPassw.TabIndex = 49;
            this.labelReturnPassw.Text = "Повторите пароль:";
            this.labelReturnPassw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(95, 160);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPassword.Size = new System.Drawing.Size(67, 20);
            this.labelPassword.TabIndex = 48;
            this.labelPassword.Text = "Пароль:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(112, 135);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 47;
            this.labelEmail.Text = "Email:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(232, 43);
            this.labelText.Name = "labelText";
            this.labelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelText.Size = new System.Drawing.Size(581, 40);
            this.labelText.TabIndex = 43;
            this.labelText.Text = "Пожалуйста, заполните всю информацию, чтобы зарегистрироваться в качестве\r\nбегуна" +
    ".";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReg.Location = new System.Drawing.Point(504, 350);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(129, 29);
            this.buttonReg.TabIndex = 42;
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
            this.buttonCancel.Location = new System.Drawing.Point(661, 350);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 29);
            this.buttonCancel.TabIndex = 41;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelRunner
            // 
            this.labelRunner.AutoSize = true;
            this.labelRunner.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRunner.Location = new System.Drawing.Point(230, 12);
            this.labelRunner.Name = "labelRunner";
            this.labelRunner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRunner.Size = new System.Drawing.Size(205, 26);
            this.labelRunner.TabIndex = 40;
            this.labelRunner.Text = "Регистрация бегуна";
            this.labelRunner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPassword.Location = new System.Drawing.Point(166, 161);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(247, 22);
            this.textBoxPassword.TabIndex = 66;
            this.textBoxPassword.Text = "Введите пароль";
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxLastName.Location = new System.Drawing.Point(166, 244);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(247, 22);
            this.textBoxLastName.TabIndex = 67;
            this.textBoxLastName.Text = "Ваша фамилия";
            this.textBoxLastName.Click += new System.EventHandler(this.textBoxLatName_TextChanged);
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLatName_TextChanged);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(166, 272);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(145, 23);
            this.comboBoxGender.TabIndex = 68;
            this.comboBoxGender.Text = "Выберите пол";
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            this.comboBoxGender.Click += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoto.Location = new System.Drawing.Point(500, 218);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPhoto.Size = new System.Drawing.Size(88, 20);
            this.labelPhoto.TabIndex = 69;
            this.labelPhoto.Text = "Фото файл:";
            this.labelPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPhoto
            // 
            this.textBoxPhoto.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPhoto.Location = new System.Drawing.Point(504, 241);
            this.textBoxPhoto.Name = "textBoxPhoto";
            this.textBoxPhoto.Size = new System.Drawing.Size(189, 22);
            this.textBoxPhoto.TabIndex = 70;
            // 
            // buttonPhotoIn
            // 
            this.buttonPhotoIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.buttonPhotoIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPhotoIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhotoIn.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPhotoIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPhotoIn.Location = new System.Drawing.Point(699, 238);
            this.buttonPhotoIn.Name = "buttonPhotoIn";
            this.buttonPhotoIn.Size = new System.Drawing.Size(91, 26);
            this.buttonPhotoIn.TabIndex = 71;
            this.buttonPhotoIn.Text = "Выбрать...";
            this.buttonPhotoIn.UseVisualStyleBackColor = false;
            this.buttonPhotoIn.Click += new System.EventHandler(this.buttonPhotoIn_Click);
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirth.Location = new System.Drawing.Point(500, 273);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBirth.Size = new System.Drawing.Size(120, 20);
            this.labelBirth.TabIndex = 72;
            this.labelBirth.Text = "Дата рождения:";
            this.labelBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(626, 300);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(164, 23);
            this.comboBoxCountry.TabIndex = 75;
            this.comboBoxCountry.Text = "Выберите страну";
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            this.comboBoxCountry.Click += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.Location = new System.Drawing.Point(557, 301);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCountry.Size = new System.Drawing.Size(63, 20);
            this.labelCountry.TabIndex = 74;
            this.labelCountry.Text = "Страна:";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirth.Location = new System.Drawing.Point(626, 274);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(164, 22);
            this.dateTimePickerBirth.TabIndex = 76;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxImage.Location = new System.Drawing.Point(680, 81);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(109, 135);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 77;
            this.pictureBoxImage.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::MarSkills.Properties.Resources.logo_2016_full_colour;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(211, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 39;
            this.Logo.TabStop = false;
            // 
            // RegisterRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(819, 396);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.buttonPhotoIn);
            this.Controls.Add(this.textBoxPhoto);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxReturnPassw);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelReturnPassw);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelRunner);
            this.Controls.Add(this.Logo);
            this.Name = "RegisterRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация бегуна";
            this.Load += new System.EventHandler(this.RegisterRunner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxReturnPassw;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelReturnPassw;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelRunner;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.TextBox textBoxPhoto;
        private System.Windows.Forms.Button buttonPhotoIn;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}