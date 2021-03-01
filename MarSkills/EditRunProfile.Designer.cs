namespace MarSkills
{
    partial class EditRunProfile
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
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.buttonPhotoIn = new System.Windows.Forms.Button();
            this.textBoxPhoto = new System.Windows.Forms.TextBox();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxReturnPassw = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelReturnPassw = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelYourEmail = new System.Windows.Forms.Label();
            this.labelNePassw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxImage.Location = new System.Drawing.Point(679, 37);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(109, 135);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 103;
            this.pictureBoxImage.TabStop = false;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirth.Location = new System.Drawing.Point(137, 253);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(164, 22);
            this.dateTimePickerBirth.TabIndex = 102;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(137, 279);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(164, 23);
            this.comboBoxCountry.TabIndex = 101;
            this.comboBoxCountry.Text = "Выберите страну";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.Location = new System.Drawing.Point(68, 280);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCountry.Size = new System.Drawing.Size(63, 20);
            this.labelCountry.TabIndex = 100;
            this.labelCountry.Text = "Страна:";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirth.Location = new System.Drawing.Point(11, 252);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBirth.Size = new System.Drawing.Size(120, 20);
            this.labelBirth.TabIndex = 99;
            this.labelBirth.Text = "Дата рождения:";
            this.labelBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPhotoIn
            // 
            this.buttonPhotoIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.buttonPhotoIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPhotoIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhotoIn.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPhotoIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPhotoIn.Location = new System.Drawing.Point(698, 194);
            this.buttonPhotoIn.Name = "buttonPhotoIn";
            this.buttonPhotoIn.Size = new System.Drawing.Size(91, 26);
            this.buttonPhotoIn.TabIndex = 98;
            this.buttonPhotoIn.Text = "Выбрать...";
            this.buttonPhotoIn.UseVisualStyleBackColor = false;
            this.buttonPhotoIn.Click += new System.EventHandler(this.buttonPhotoIn_Click);
            // 
            // textBoxPhoto
            // 
            this.textBoxPhoto.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPhoto.Location = new System.Drawing.Point(503, 197);
            this.textBoxPhoto.Name = "textBoxPhoto";
            this.textBoxPhoto.Size = new System.Drawing.Size(189, 22);
            this.textBoxPhoto.TabIndex = 97;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoto.Location = new System.Drawing.Point(499, 174);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPhoto.Size = new System.Drawing.Size(88, 20);
            this.labelPhoto.TabIndex = 96;
            this.labelPhoto.Text = "Фото файл:";
            this.labelPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(137, 222);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(145, 23);
            this.comboBoxGender.TabIndex = 95;
            this.comboBoxGender.Text = "Выберите пол";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxLastName.Location = new System.Drawing.Point(137, 192);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(247, 22);
            this.textBoxLastName.TabIndex = 94;
            this.textBoxLastName.Text = "Ваша фамилия";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPassword.Location = new System.Drawing.Point(542, 292);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(247, 22);
            this.textBoxPassword.TabIndex = 93;
            this.textBoxPassword.Text = "Введите пароль";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(16, 382);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(209, 18);
            this.labelTime.TabIndex = 92;
            this.labelTime.Text = "До начала марофона осталось";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxFirstName.Location = new System.Drawing.Point(137, 164);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(247, 22);
            this.textBoxFirstName.TabIndex = 91;
            this.textBoxFirstName.Text = "Ваше имя";
            // 
            // textBoxReturnPassw
            // 
            this.textBoxReturnPassw.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReturnPassw.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxReturnPassw.Location = new System.Drawing.Point(542, 319);
            this.textBoxReturnPassw.Name = "textBoxReturnPassw";
            this.textBoxReturnPassw.Size = new System.Drawing.Size(247, 22);
            this.textBoxReturnPassw.TabIndex = 90;
            this.textBoxReturnPassw.Text = "Повторите пароль";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(90, 223);
            this.labelGender.Name = "labelGender";
            this.labelGender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGender.Size = new System.Drawing.Size(41, 20);
            this.labelGender.TabIndex = 88;
            this.labelGender.Text = "Пол:";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(55, 194);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLastName.Size = new System.Drawing.Size(76, 20);
            this.labelLastName.TabIndex = 87;
            this.labelLastName.Text = "Фамилия:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(89, 166);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFirstName.Size = new System.Drawing.Size(42, 20);
            this.labelFirstName.TabIndex = 86;
            this.labelFirstName.Text = "Имя:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelReturnPassw
            // 
            this.labelReturnPassw.AutoSize = true;
            this.labelReturnPassw.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReturnPassw.Location = new System.Drawing.Point(392, 319);
            this.labelReturnPassw.Name = "labelReturnPassw";
            this.labelReturnPassw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelReturnPassw.Size = new System.Drawing.Size(146, 20);
            this.labelReturnPassw.TabIndex = 85;
            this.labelReturnPassw.Text = "Повторите пароль:";
            this.labelReturnPassw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(471, 291);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPassword.Size = new System.Drawing.Size(67, 20);
            this.labelPassword.TabIndex = 84;
            this.labelPassword.Text = "Пароль:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(83, 140);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 83;
            this.labelEmail.Text = "Email:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(503, 377);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(129, 29);
            this.buttonSave.TabIndex = 81;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(660, 377);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 29);
            this.buttonCancel.TabIndex = 80;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::MarSkills.Properties.Resources.logo_2016_full_colour;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(211, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 78;
            this.Logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEdit.Location = new System.Drawing.Point(300, 48);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEdit.Size = new System.Drawing.Size(266, 26);
            this.labelEdit.TabIndex = 79;
            this.labelEdit.Text = "Редактирование профиля";
            this.labelEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelYourEmail
            // 
            this.labelYourEmail.AutoSize = true;
            this.labelYourEmail.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYourEmail.Location = new System.Drawing.Point(137, 140);
            this.labelYourEmail.Name = "labelYourEmail";
            this.labelYourEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelYourEmail.Size = new System.Drawing.Size(97, 18);
            this.labelYourEmail.TabIndex = 104;
            this.labelYourEmail.Text = "primer@mail.ru";
            this.labelYourEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNePassw
            // 
            this.labelNePassw.AutoSize = true;
            this.labelNePassw.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNePassw.Location = new System.Drawing.Point(391, 246);
            this.labelNePassw.Name = "labelNePassw";
            this.labelNePassw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNePassw.Size = new System.Drawing.Size(148, 26);
            this.labelNePassw.TabIndex = 105;
            this.labelNePassw.Text = "Смена пароля";
            this.labelNePassw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditRunProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(822, 428);
            this.Controls.Add(this.labelNePassw);
            this.Controls.Add(this.labelYourEmail);
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
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelReturnPassw);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.labelEdit);
            this.Name = "EditRunProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать профиль";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Button buttonPhotoIn;
        private System.Windows.Forms.TextBox textBoxPhoto;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxReturnPassw;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelReturnPassw;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelYourEmail;
        private System.Windows.Forms.Label labelNePassw;
    }
}