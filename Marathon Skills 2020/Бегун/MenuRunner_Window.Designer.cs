namespace Marathon_Skills_2020.Бегун
{
    partial class MenuRunner_Window
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
            this.logo = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Contacts = new System.Windows.Forms.Button();
            this.btn_EditProfile = new System.Windows.Forms.Button();
            this.btn_MarathonSkills2020 = new System.Windows.Forms.Button();
            this.logo.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Marathon_Skills_2020.Properties.Resources.wsrlogo_01;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Controls.Add(this.btn_back);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 25);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(704, 65);
            this.logo.TabIndex = 13;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 19);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(88, 29);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.btn_minimize);
            this.topPanel.Controls.Add(this.btn_close);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(704, 25);
            this.topPanel.TabIndex = 12;
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Image = global::Marathon_Skills_2020.Properties.Resources.icons8_m5acos_minimize_16;
            this.btn_minimize.Location = new System.Drawing.Point(654, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(25, 25);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = global::Marathon_Skills_2020.Properties.Resources.icons8_shutdown_16;
            this.btn_close.Location = new System.Drawing.Point(679, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Timer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Timer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Timer.Location = new System.Drawing.Point(0, 352);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(704, 45);
            this.lbl_Timer.TabIndex = 14;
            this.lbl_Timer.Text = "Timer";
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Contacts
            // 
            this.btn_Contacts.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Contacts.FlatAppearance.BorderSize = 0;
            this.btn_Contacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contacts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Contacts.ForeColor = System.Drawing.Color.White;
            this.btn_Contacts.Location = new System.Drawing.Point(182, 260);
            this.btn_Contacts.Name = "btn_Contacts";
            this.btn_Contacts.Size = new System.Drawing.Size(346, 66);
            this.btn_Contacts.TabIndex = 15;
            this.btn_Contacts.Text = "Контакты";
            this.btn_Contacts.UseVisualStyleBackColor = false;
            // 
            // btn_EditProfile
            // 
            this.btn_EditProfile.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_EditProfile.FlatAppearance.BorderSize = 0;
            this.btn_EditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditProfile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditProfile.ForeColor = System.Drawing.Color.White;
            this.btn_EditProfile.Location = new System.Drawing.Point(182, 188);
            this.btn_EditProfile.Name = "btn_EditProfile";
            this.btn_EditProfile.Size = new System.Drawing.Size(346, 66);
            this.btn_EditProfile.TabIndex = 16;
            this.btn_EditProfile.Text = "Редактирование профиля";
            this.btn_EditProfile.UseVisualStyleBackColor = false;
            // 
            // btn_MarathonSkills2020
            // 
            this.btn_MarathonSkills2020.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_MarathonSkills2020.FlatAppearance.BorderSize = 0;
            this.btn_MarathonSkills2020.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MarathonSkills2020.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_MarathonSkills2020.ForeColor = System.Drawing.Color.White;
            this.btn_MarathonSkills2020.Location = new System.Drawing.Point(182, 116);
            this.btn_MarathonSkills2020.Name = "btn_MarathonSkills2020";
            this.btn_MarathonSkills2020.Size = new System.Drawing.Size(346, 66);
            this.btn_MarathonSkills2020.TabIndex = 17;
            this.btn_MarathonSkills2020.Text = "Регистрация на MarathonSkills2020";
            this.btn_MarathonSkills2020.UseVisualStyleBackColor = false;
            // 
            // MenuRunner_Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 397);
            this.Controls.Add(this.btn_Contacts);
            this.Controls.Add(this.btn_EditProfile);
            this.Controls.Add(this.btn_MarathonSkills2020);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MenuRunner_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuRunner_Window";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuRunner_Window_KeyDown);
            this.logo.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Contacts;
        private System.Windows.Forms.Button btn_EditProfile;
        private System.Windows.Forms.Button btn_MarathonSkills2020;
    }
}