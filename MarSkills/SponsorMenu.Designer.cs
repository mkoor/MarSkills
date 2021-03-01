namespace MarSkills
{
    partial class SponsorMenu
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelSponsor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelText = new System.Windows.Forms.Label();
            this.labelInfoSpons = new System.Windows.Forms.Label();
            this.labelSponsRun = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCard = new System.Windows.Forms.TextBox();
            this.textBoxNumCard = new System.Windows.Forms.TextBox();
            this.textBoxMonCard = new System.Windows.Forms.TextBox();
            this.textBoxYearCard = new System.Windows.Forms.TextBox();
            this.textBoxCVC = new System.Windows.Forms.TextBox();
            this.comboBoxRunner = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDollars = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOk.Location = new System.Drawing.Point(483, 401);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(129, 29);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Заплатить";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(629, 401);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 29);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelSponsor
            // 
            this.labelSponsor.AutoSize = true;
            this.labelSponsor.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsor.Location = new System.Drawing.Point(227, 12);
            this.labelSponsor.Name = "labelSponsor";
            this.labelSponsor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSponsor.Size = new System.Drawing.Size(163, 26);
            this.labelSponsor.TabIndex = 8;
            this.labelSponsor.Text = "Спонсор бегуна";
            this.labelSponsor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(229, 43);
            this.labelText.Name = "labelText";
            this.labelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelText.Size = new System.Drawing.Size(571, 60);
            this.labelText.TabIndex = 14;
            this.labelText.Text = "Пожалуйста, выберите бегуна, которого вы хотели бы спонсировать и сумму,\r\nкоторую" +
    " вы хотели бы спонсировать. Спасибо за вашу поддержку бегунов и их\r\nблаготворите" +
    "льных учреждений.";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInfoSpons
            // 
            this.labelInfoSpons.AutoSize = true;
            this.labelInfoSpons.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoSpons.Location = new System.Drawing.Point(12, 132);
            this.labelInfoSpons.Name = "labelInfoSpons";
            this.labelInfoSpons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInfoSpons.Size = new System.Drawing.Size(254, 26);
            this.labelInfoSpons.TabIndex = 15;
            this.labelInfoSpons.Text = "Информация о Спонсоре";
            this.labelInfoSpons.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSponsRun
            // 
            this.labelSponsRun.AutoSize = true;
            this.labelSponsRun.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsRun.Location = new System.Drawing.Point(509, 132);
            this.labelSponsRun.Name = "labelSponsRun";
            this.labelSponsRun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSponsRun.Size = new System.Drawing.Size(224, 26);
            this.labelSponsRun.TabIndex = 16;
            this.labelSponsRun.Text = "Благотворительность";
            this.labelSponsRun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney.Location = new System.Drawing.Point(505, 220);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMoney.Size = new System.Drawing.Size(233, 26);
            this.labelMoney.TabIndex = 17;
            this.labelMoney.Text = "Сумма пожертвования";
            this.labelMoney.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 196);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ваше имя:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(84, 223);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Бегун:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(83, 251);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Карта:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 280);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Номер карты:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 309);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Срок действия:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(97, 337);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "CVC:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxName.Location = new System.Drawing.Point(143, 197);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(247, 22);
            this.textBoxName.TabIndex = 24;
            this.textBoxName.Click += new System.EventHandler(this.textBoxName_Enter);
            // 
            // textBoxCard
            // 
            this.textBoxCard.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCard.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCard.Location = new System.Drawing.Point(143, 252);
            this.textBoxCard.Name = "textBoxCard";
            this.textBoxCard.Size = new System.Drawing.Size(247, 22);
            this.textBoxCard.TabIndex = 26;
            this.textBoxCard.Click += new System.EventHandler(this.textBoxCard_Enter);
            // 
            // textBoxNumCard
            // 
            this.textBoxNumCard.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumCard.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxNumCard.Location = new System.Drawing.Point(143, 280);
            this.textBoxNumCard.Name = "textBoxNumCard";
            this.textBoxNumCard.Size = new System.Drawing.Size(247, 22);
            this.textBoxNumCard.TabIndex = 27;
            this.textBoxNumCard.Click += new System.EventHandler(this.textBoxNumCard_Enter);
            // 
            // textBoxMonCard
            // 
            this.textBoxMonCard.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMonCard.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxMonCard.Location = new System.Drawing.Point(143, 309);
            this.textBoxMonCard.Name = "textBoxMonCard";
            this.textBoxMonCard.Size = new System.Drawing.Size(35, 22);
            this.textBoxMonCard.TabIndex = 28;
            this.textBoxMonCard.Click += new System.EventHandler(this.textBoxMonCard_Enter);
            // 
            // textBoxYearCard
            // 
            this.textBoxYearCard.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYearCard.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxYearCard.Location = new System.Drawing.Point(184, 309);
            this.textBoxYearCard.Name = "textBoxYearCard";
            this.textBoxYearCard.Size = new System.Drawing.Size(36, 22);
            this.textBoxYearCard.TabIndex = 29;
            this.textBoxYearCard.Click += new System.EventHandler(this.textBoxYearCard_Enter);
            // 
            // textBoxCVC
            // 
            this.textBoxCVC.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCVC.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCVC.Location = new System.Drawing.Point(143, 337);
            this.textBoxCVC.Name = "textBoxCVC";
            this.textBoxCVC.Size = new System.Drawing.Size(50, 22);
            this.textBoxCVC.TabIndex = 30;
            this.textBoxCVC.Click += new System.EventHandler(this.textBoxCVC_Enter);
            // 
            // comboBoxRunner
            // 
            this.comboBoxRunner.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRunner.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxRunner.FormattingEnabled = true;
            this.comboBoxRunner.Location = new System.Drawing.Point(143, 224);
            this.comboBoxRunner.Name = "comboBoxRunner";
            this.comboBoxRunner.Size = new System.Drawing.Size(247, 23);
            this.comboBoxRunner.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(545, 175);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Фонд \"Дари Добро\"";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPrice.Location = new System.Drawing.Point(575, 323);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(88, 22);
            this.textBoxPrice.TabIndex = 33;
            this.textBoxPrice.Text = "500";
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice.Click += new System.EventHandler(this.textBoxPrice_Enter);
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged_1);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.buttonPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlus.Location = new System.Drawing.Point(669, 322);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(35, 23);
            this.buttonPlus.TabIndex = 35;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.buttonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMin.Location = new System.Drawing.Point(534, 322);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(35, 23);
            this.buttonMin.TabIndex = 36;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(14, 406);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(209, 18);
            this.labelTime.TabIndex = 37;
            this.labelTime.Text = "До начала марофона осталось";
            // 
            // labelDollars
            // 
            this.labelDollars.AutoSize = true;
            this.labelDollars.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDollars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.labelDollars.Location = new System.Drawing.Point(580, 263);
            this.labelDollars.Name = "labelDollars";
            this.labelDollars.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDollars.Size = new System.Drawing.Size(77, 37);
            this.labelDollars.TabIndex = 38;
            this.labelDollars.Text = "500$";
            this.labelDollars.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logo
            // 
            this.Logo.Image = global::MarSkills.Properties.Resources.logo_2016_full_colour;
            this.Logo.Location = new System.Drawing.Point(9, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(211, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // SponsorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.labelDollars);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxRunner);
            this.Controls.Add(this.textBoxCVC);
            this.Controls.Add(this.textBoxYearCard);
            this.Controls.Add(this.textBoxMonCard);
            this.Controls.Add(this.textBoxNumCard);
            this.Controls.Add(this.textBoxCard);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelSponsRun);
            this.Controls.Add(this.labelInfoSpons);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelSponsor);
            this.Controls.Add(this.Logo);
            this.Name = "SponsorMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спонсировать бегуна";
            this.Load += new System.EventHandler(this.SponsorMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelSponsor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelInfoSpons;
        private System.Windows.Forms.Label labelSponsRun;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCard;
        private System.Windows.Forms.TextBox textBoxNumCard;
        private System.Windows.Forms.TextBox textBoxMonCard;
        private System.Windows.Forms.TextBox textBoxYearCard;
        private System.Windows.Forms.TextBox textBoxCVC;
        private System.Windows.Forms.ComboBox comboBoxRunner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDollars;
    }
}