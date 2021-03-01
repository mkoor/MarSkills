namespace MarSkills
{
    partial class ListOfCharities
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
            this.labelCharties = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(120, 414);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(209, 18);
            this.labelTime.TabIndex = 83;
            this.labelTime.Text = "До начала марофона осталось";
            // 
            // labelCharties
            // 
            this.labelCharties.AutoSize = true;
            this.labelCharties.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCharties.Location = new System.Drawing.Point(222, 19);
            this.labelCharties.Name = "labelCharties";
            this.labelCharties.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCharties.Size = new System.Drawing.Size(414, 26);
            this.labelCharties.TabIndex = 80;
            this.labelCharties.Text = "Список благотворительных организаций";
            this.labelCharties.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.buttonBack.TabIndex = 82;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::MarSkills.Properties.Resources.logo_2016_full_colour;
            this.Logo.Location = new System.Drawing.Point(13, 13);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(196, 83);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 79;
            this.Logo.TabStop = false;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(223, 48);
            this.labelText.Name = "labelText";
            this.labelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelText.Size = new System.Drawing.Size(607, 40);
            this.labelText.TabIndex = 84;
            this.labelText.Text = "Это - список всех благотворительных учреждений, которые поддерживаются в \r\nMarath" +
    "on Skills 2016. Спасибо за помощь! Вы поддерживаете их, спонсируя бегунов.\r\n";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListOfCharities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCharties);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.buttonBack);
            this.Name = "ListOfCharities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Благотворительные организации";
            this.Load += new System.EventHandler(this.ListOfCharities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelCharties;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelText;
    }
}