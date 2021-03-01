namespace MarSkills
{
    partial class Glavnaya
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCity = new System.Windows.Forms.Label();
            this.buttonRunner = new System.Windows.Forms.Button();
            this.buttonSponsor = new System.Windows.Forms.Button();
            this.buttonInfoAbout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMyTime = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(411, 77);
            this.labelCity.Name = "labelCity";
            this.labelCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCity.Size = new System.Drawing.Size(135, 22);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "Москва, Россия";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonRunner
            // 
            this.buttonRunner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.buttonRunner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunner.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRunner.Location = new System.Drawing.Point(66, 149);
            this.buttonRunner.Name = "buttonRunner";
            this.buttonRunner.Size = new System.Drawing.Size(477, 48);
            this.buttonRunner.TabIndex = 2;
            this.buttonRunner.Text = "Я хочу стать бегуном";
            this.buttonRunner.UseVisualStyleBackColor = false;
            this.buttonRunner.Click += new System.EventHandler(this.buttonRunner_Click);
            // 
            // buttonSponsor
            // 
            this.buttonSponsor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.buttonSponsor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSponsor.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSponsor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSponsor.Location = new System.Drawing.Point(66, 212);
            this.buttonSponsor.Name = "buttonSponsor";
            this.buttonSponsor.Size = new System.Drawing.Size(477, 48);
            this.buttonSponsor.TabIndex = 3;
            this.buttonSponsor.Text = "Я хочу стать спонсором бегуна";
            this.buttonSponsor.UseVisualStyleBackColor = false;
            this.buttonSponsor.Click += new System.EventHandler(this.buttonSponsor_Click);
            // 
            // buttonInfoAbout
            // 
            this.buttonInfoAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.buttonInfoAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfoAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfoAbout.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfoAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInfoAbout.Location = new System.Drawing.Point(66, 275);
            this.buttonInfoAbout.Name = "buttonInfoAbout";
            this.buttonInfoAbout.Size = new System.Drawing.Size(477, 48);
            this.buttonInfoAbout.TabIndex = 4;
            this.buttonInfoAbout.Text = "Я хочу узнать больше о событии";
            this.buttonInfoAbout.UseVisualStyleBackColor = false;
            this.buttonInfoAbout.Click += new System.EventHandler(this.buttonEvent_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(414, 25);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(129, 29);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(127, 351);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(209, 18);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "До начала марофона осталось";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // labelMyTime
            // 
            this.labelMyTime.AutoSize = true;
            this.labelMyTime.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMyTime.Location = new System.Drawing.Point(390, 99);
            this.labelMyTime.Name = "labelMyTime";
            this.labelMyTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMyTime.Size = new System.Drawing.Size(46, 22);
            this.labelMyTime.TabIndex = 7;
            this.labelMyTime.Text = "дата";
            this.labelMyTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logo
            // 
            this.Logo.Image = global::MarSkills.Properties.Resources.logo_2016_full_colour;
            this.Logo.Location = new System.Drawing.Point(66, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(290, 124);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Glavnaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(611, 394);
            this.Controls.Add(this.labelMyTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonInfoAbout);
            this.Controls.Add(this.buttonSponsor);
            this.Controls.Add(this.buttonRunner);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.Logo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Glavnaya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button buttonRunner;
        private System.Windows.Forms.Button buttonSponsor;
        private System.Windows.Forms.Button buttonInfoAbout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMyTime;
    }
}

