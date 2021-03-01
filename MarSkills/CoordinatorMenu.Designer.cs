namespace MarSkills
{
    partial class CoordinatorMenu
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
            this.buttonSponsor = new System.Windows.Forms.Button();
            this.buttonRunner = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCoordinator = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSponsor
            // 
            this.buttonSponsor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.buttonSponsor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSponsor.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSponsor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSponsor.Location = new System.Drawing.Point(297, 109);
            this.buttonSponsor.Name = "buttonSponsor";
            this.buttonSponsor.Size = new System.Drawing.Size(273, 37);
            this.buttonSponsor.TabIndex = 96;
            this.buttonSponsor.Text = "Спонсоры";
            this.buttonSponsor.UseVisualStyleBackColor = false;
            // 
            // buttonRunner
            // 
            this.buttonRunner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.buttonRunner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunner.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRunner.Location = new System.Drawing.Point(12, 109);
            this.buttonRunner.Name = "buttonRunner";
            this.buttonRunner.Size = new System.Drawing.Size(273, 37);
            this.buttonRunner.TabIndex = 95;
            this.buttonRunner.Text = "Бегуны";
            this.buttonRunner.UseVisualStyleBackColor = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(96, 171);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(209, 18);
            this.labelTime.TabIndex = 94;
            this.labelTime.Text = "До начала марофона осталось";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(488, 19);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(82, 29);
            this.buttonExit.TabIndex = 93;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCoordinator
            // 
            this.labelCoordinator.AutoSize = true;
            this.labelCoordinator.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinator.Location = new System.Drawing.Point(225, 36);
            this.labelCoordinator.Name = "labelCoordinator";
            this.labelCoordinator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCoordinator.Size = new System.Drawing.Size(214, 26);
            this.labelCoordinator.TabIndex = 92;
            this.labelCoordinator.Text = "Меню координатора";
            this.labelCoordinator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logo
            // 
            this.Logo.Image = global::MarSkills.Properties.Resources.logo_2016_full_colour;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(166, 79);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 91;
            this.Logo.TabStop = false;
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
            this.buttonBack.Location = new System.Drawing.Point(488, 54);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(82, 29);
            this.buttonBack.TabIndex = 100;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // CoordinatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(585, 214);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSponsor);
            this.Controls.Add(this.buttonRunner);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelCoordinator);
            this.Controls.Add(this.Logo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "CoordinatorMenu";
            this.Text = "Меню координатора";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSponsor;
        private System.Windows.Forms.Button buttonRunner;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCoordinator;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonBack;
    }
}