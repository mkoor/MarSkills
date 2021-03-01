namespace MarSkills
{
    partial class AdminMenu
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonInvent = new System.Windows.Forms.Button();
            this.buttonOrganiz = new System.Windows.Forms.Button();
            this.buttonVoul = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(99, 210);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(209, 18);
            this.labelTime.TabIndex = 83;
            this.labelTime.Text = "До начала марофона осталось";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonInvent
            // 
            this.buttonInvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.buttonInvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInvent.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInvent.Location = new System.Drawing.Point(296, 155);
            this.buttonInvent.Name = "buttonInvent";
            this.buttonInvent.Size = new System.Drawing.Size(273, 37);
            this.buttonInvent.TabIndex = 87;
            this.buttonInvent.Text = "Инвентарь";
            this.buttonInvent.UseVisualStyleBackColor = false;
            // 
            // buttonOrganiz
            // 
            this.buttonOrganiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.buttonOrganiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrganiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrganiz.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrganiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOrganiz.Location = new System.Drawing.Point(11, 155);
            this.buttonOrganiz.Name = "buttonOrganiz";
            this.buttonOrganiz.Size = new System.Drawing.Size(273, 37);
            this.buttonOrganiz.TabIndex = 86;
            this.buttonOrganiz.Text = "Благотворительные организации";
            this.buttonOrganiz.UseVisualStyleBackColor = false;
            // 
            // buttonVoul
            // 
            this.buttonVoul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.buttonVoul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVoul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoul.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVoul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVoul.Location = new System.Drawing.Point(296, 112);
            this.buttonVoul.Name = "buttonVoul";
            this.buttonVoul.Size = new System.Drawing.Size(273, 37);
            this.buttonVoul.TabIndex = 85;
            this.buttonVoul.Text = "Волонтеры";
            this.buttonVoul.UseVisualStyleBackColor = false;
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.buttonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUsers.Location = new System.Drawing.Point(11, 112);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(273, 37);
            this.buttonUsers.TabIndex = 84;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::MarSkills.Properties.Resources.logo_2016_full_colour;
            this.Logo.Location = new System.Drawing.Point(11, 15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(166, 79);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 79;
            this.Logo.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(487, 56);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(82, 29);
            this.buttonBack.TabIndex = 103;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(487, 21);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(82, 29);
            this.buttonExit.TabIndex = 102;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdmin.Location = new System.Drawing.Point(217, 38);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAdmin.Size = new System.Drawing.Size(237, 26);
            this.labelAdmin.TabIndex = 101;
            this.labelAdmin.Text = "Меню администратора";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(591, 248);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonInvent);
            this.Controls.Add(this.buttonOrganiz);
            this.Controls.Add(this.buttonVoul);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.Logo);
            this.Name = "AdminMenu";
            this.Text = "Меню администратора";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonInvent;
        private System.Windows.Forms.Button buttonOrganiz;
        private System.Windows.Forms.Button buttonVoul;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelAdmin;
    }
}