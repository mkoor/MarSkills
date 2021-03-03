namespace MarSkills
{
    partial class MyRaceRezults
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
            this.labelResults = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelText = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelG = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.listViewRezults = new System.Windows.Forms.ListView();
            this.Marathon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Distant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllWin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WinForCategories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(10, 421);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(209, 18);
            this.labelTime.TabIndex = 88;
            this.labelTime.Text = "До начала марофона осталось";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResults.Location = new System.Drawing.Point(221, 18);
            this.labelResults.Name = "labelResults";
            this.labelResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelResults.Size = new System.Drawing.Size(172, 26);
            this.labelResults.TabIndex = 86;
            this.labelResults.Text = "Мои результаты";
            this.labelResults.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(222, 47);
            this.labelText.Name = "labelText";
            this.labelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelText.Size = new System.Drawing.Size(521, 60);
            this.labelText.TabIndex = 89;
            this.labelText.Text = "Это - список всех ваших прошлых результатов гонки для Marathon Skills.\r\nОбщее мес" +
    "то сравнивает всех бегунов.\r\nМесто по категории compares runners in the gender a" +
    "nd age categories.";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(748, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(82, 29);
            this.buttonBack.TabIndex = 87;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG.Location = new System.Drawing.Point(223, 119);
            this.labelG.Name = "labelG";
            this.labelG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelG.Size = new System.Drawing.Size(46, 22);
            this.labelG.TabIndex = 90;
            this.labelG.Text = "Пол:";
            this.labelG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(400, 119);
            this.labelA.Name = "labelA";
            this.labelA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelA.Size = new System.Drawing.Size(192, 22);
            this.labelA.TabIndex = 91;
            this.labelA.Text = "Возрастная категория:";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(266, 120);
            this.labelGender.Name = "labelGender";
            this.labelGender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGender.Size = new System.Drawing.Size(68, 20);
            this.labelGender.TabIndex = 92;
            this.labelGender.Text = "мужской";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(588, 121);
            this.labelAge.Name = "labelAge";
            this.labelAge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAge.Size = new System.Drawing.Size(50, 20);
            this.labelAge.TabIndex = 93;
            this.labelAge.Text = "18-29";
            this.labelAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Logo
            // 
            this.Logo.Image = global::MarSkills.Properties.Resources.logo_2016_full_colour;
            this.Logo.Location = new System.Drawing.Point(12, 18);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(204, 89);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 85;
            this.Logo.TabStop = false;
            // 
            // listViewRezults
            // 
            this.listViewRezults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Marathon,
            this.Distant,
            this.Time,
            this.AllWin,
            this.WinForCategories});
            this.listViewRezults.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewRezults.FullRowSelect = true;
            this.listViewRezults.GridLines = true;
            this.listViewRezults.HideSelection = false;
            this.listViewRezults.Location = new System.Drawing.Point(13, 154);
            this.listViewRezults.MultiSelect = false;
            this.listViewRezults.Name = "listViewRezults";
            this.listViewRezults.Size = new System.Drawing.Size(817, 251);
            this.listViewRezults.TabIndex = 94;
            this.listViewRezults.UseCompatibleStateImageBehavior = false;
            this.listViewRezults.View = System.Windows.Forms.View.Details;
            this.listViewRezults.SelectedIndexChanged += new System.EventHandler(this.listViewClients_SelectedIndexChanged);
            // 
            // Marathon
            // 
            this.Marathon.Text = "Марафон";
            this.Marathon.Width = 146;
            // 
            // Distant
            // 
            this.Distant.Text = "Дистанция";
            this.Distant.Width = 159;
            // 
            // Time
            // 
            this.Time.Text = "Время";
            this.Time.Width = 170;
            // 
            // AllWin
            // 
            this.AllWin.Text = "Общее место";
            this.AllWin.Width = 176;
            // 
            // WinForCategories
            // 
            this.WinForCategories.Text = "Место по категории";
            this.WinForCategories.Width = 181;
            // 
            // MyRaceRezults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.listViewRezults);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.buttonBack);
            this.Name = "MyRaceRezults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои результаты";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.ListView listViewRezults;
        private System.Windows.Forms.ColumnHeader Marathon;
        private System.Windows.Forms.ColumnHeader Distant;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader AllWin;
        private System.Windows.Forms.ColumnHeader WinForCategories;
    }
}