namespace MarSkills
{
    partial class SponsInfo
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
            this.labelText = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSponsor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDollars = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(224, 58);
            this.labelText.Name = "labelText";
            this.labelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelText.Size = new System.Drawing.Size(504, 40);
            this.labelText.TabIndex = 43;
            this.labelText.Text = "Спасибо за поддержку бегуна в Marathon Skills 2016!\r\nВаше пожертвование пойдет в " +
    "его благотворительную организацию.";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Logo
            // 
            this.Logo.Image = global::MarSkills.Properties.Resources.logo_2016_full_colour;
            this.Logo.Location = new System.Drawing.Point(5, 16);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(211, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 39;
            this.Logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(309, 342);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(129, 29);
            this.buttonExit.TabIndex = 41;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSponsor
            // 
            this.labelSponsor.AutoSize = true;
            this.labelSponsor.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsor.Location = new System.Drawing.Point(223, 23);
            this.labelSponsor.Name = "labelSponsor";
            this.labelSponsor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSponsor.Size = new System.Drawing.Size(420, 26);
            this.labelSponsor.TabIndex = 40;
            this.labelSponsor.Text = "Спасибо за вашу спонсорскую поддержку!";
            this.labelSponsor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(168, 137);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(429, 39);
            this.label1.TabIndex = 65;
            this.label1.Text = "Иван Прудов (204) из Russia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(302, 191);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(150, 33);
            this.label2.TabIndex = 66;
            this.label2.Text = "Фонд кошек";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDollars
            // 
            this.labelDollars.AutoSize = true;
            this.labelDollars.Font = new System.Drawing.Font("Open Sans Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDollars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.labelDollars.Location = new System.Drawing.Point(288, 239);
            this.labelDollars.Name = "labelDollars";
            this.labelDollars.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDollars.Size = new System.Drawing.Size(185, 87);
            this.labelDollars.TabIndex = 67;
            this.labelDollars.Text = "500$";
            this.labelDollars.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(204, 407);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(209, 18);
            this.labelTime.TabIndex = 68;
            this.labelTime.Text = "До начала марофона осталось";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click_2);
            // 
            // SponsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDollars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelSponsor);
            this.Name = "SponsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация для спонсора";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSponsor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDollars;
        private System.Windows.Forms.Label labelTime;
    }
}