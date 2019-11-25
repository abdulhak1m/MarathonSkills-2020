namespace Marathon_Skills_2020.Бегун
{
    partial class NewRunner_Window
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ShowPassword = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_cpassword = new System.Windows.Forms.TextBox();
            this.btn_showCPassword = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pc_picture = new System.Windows.Forms.PictureBox();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.btn_DownloadImg = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmb_Country = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.marathonSkillsDataSet = new Marathon_Skills_2020.MarathonSkillsDataSet();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTableAdapter = new Marathon_Skills_2020.MarathonSkillsDataSetTableAdapters.GenderTableAdapter();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new Marathon_Skills_2020.MarathonSkillsDataSetTableAdapters.CountryTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Done = new System.Windows.Forms.Button();
            this.logo.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
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
            this.logo.Size = new System.Drawing.Size(816, 65);
            this.logo.TabIndex = 17;
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
            this.topPanel.Size = new System.Drawing.Size(816, 25);
            this.topPanel.TabIndex = 16;
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
            this.btn_minimize.Location = new System.Drawing.Point(766, 0);
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
            this.btn_close.Location = new System.Drawing.Point(791, 0);
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
            this.lbl_Timer.Location = new System.Drawing.Point(0, 539);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(816, 45);
            this.lbl_Timer.TabIndex = 18;
            this.lbl_Timer.Text = "Timer";
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 45);
            this.label1.TabIndex = 19;
            this.label1.Text = "Регистрация Бегуна в системе";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ShowPassword
            // 
            this.btn_ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPassword.FlatAppearance.BorderSize = 0;
            this.btn_ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ShowPassword.ForeColor = System.Drawing.Color.White;
            this.btn_ShowPassword.Image = global::Marathon_Skills_2020.Properties.Resources._visible_16;
            this.btn_ShowPassword.Location = new System.Drawing.Point(354, 180);
            this.btn_ShowPassword.Name = "btn_ShowPassword";
            this.btn_ShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btn_ShowPassword.TabIndex = 20;
            this.btn_ShowPassword.UseVisualStyleBackColor = false;
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Location = new System.Drawing.Point(61, 184);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(284, 19);
            this.txt_Password.TabIndex = 23;
            this.txt_Password.Enter += new System.EventHandler(this.txt_Password_Enter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_Password_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(61, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 5);
            this.panel2.TabIndex = 21;
            // 
            // txt_login
            // 
            this.txt_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_login.Location = new System.Drawing.Point(61, 141);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(284, 19);
            this.txt_login.TabIndex = 24;
            this.txt_login.Enter += new System.EventHandler(this.txt_login_Enter);
            this.txt_login.Leave += new System.EventHandler(this.txt_login_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(61, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 5);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(61, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 5);
            this.panel3.TabIndex = 21;
            // 
            // txt_cpassword
            // 
            this.txt_cpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cpassword.Location = new System.Drawing.Point(61, 231);
            this.txt_cpassword.Name = "txt_cpassword";
            this.txt_cpassword.Size = new System.Drawing.Size(284, 19);
            this.txt_cpassword.TabIndex = 23;
            this.txt_cpassword.Enter += new System.EventHandler(this.txt_cpassword_Enter);
            this.txt_cpassword.Leave += new System.EventHandler(this.txt_cpassword_Leave);
            // 
            // btn_showCPassword
            // 
            this.btn_showCPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showCPassword.FlatAppearance.BorderSize = 0;
            this.btn_showCPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showCPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showCPassword.ForeColor = System.Drawing.Color.White;
            this.btn_showCPassword.Image = global::Marathon_Skills_2020.Properties.Resources._visible_16;
            this.btn_showCPassword.Location = new System.Drawing.Point(354, 231);
            this.btn_showCPassword.Name = "btn_showCPassword";
            this.btn_showCPassword.Size = new System.Drawing.Size(25, 25);
            this.btn_showCPassword.TabIndex = 20;
            this.btn_showCPassword.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(61, 292);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 5);
            this.panel4.TabIndex = 21;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Location = new System.Drawing.Point(61, 273);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(284, 19);
            this.txt_name.TabIndex = 23;
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(61, 341);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 5);
            this.panel5.TabIndex = 21;
            // 
            // txt_surname
            // 
            this.txt_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_surname.Location = new System.Drawing.Point(61, 322);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(284, 19);
            this.txt_surname.TabIndex = 23;
            this.txt_surname.Enter += new System.EventHandler(this.txt_surnane_Enter);
            this.txt_surname.Leave += new System.EventHandler(this.txt_surnane_Leave);
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.DataSource = this.genderBindingSource;
            this.cmb_Gender.DisplayMember = "Gender";
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Gender.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Location = new System.Drawing.Point(61, 365);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(284, 28);
            this.cmb_Gender.TabIndex = 25;
            this.cmb_Gender.ValueMember = "Gender";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(61, 397);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(284, 5);
            this.panel6.TabIndex = 21;
            // 
            // pc_picture
            // 
            this.pc_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pc_picture.Location = new System.Drawing.Point(487, 188);
            this.pc_picture.Name = "pc_picture";
            this.pc_picture.Size = new System.Drawing.Size(298, 214);
            this.pc_picture.TabIndex = 26;
            this.pc_picture.TabStop = false;
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_FileName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_FileName.Location = new System.Drawing.Point(574, 135);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(211, 50);
            this.lbl_FileName.TabIndex = 27;
            this.lbl_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_DownloadImg
            // 
            this.btn_DownloadImg.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_DownloadImg.FlatAppearance.BorderSize = 0;
            this.btn_DownloadImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DownloadImg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_DownloadImg.ForeColor = System.Drawing.Color.White;
            this.btn_DownloadImg.Location = new System.Drawing.Point(577, 418);
            this.btn_DownloadImg.Name = "btn_DownloadImg";
            this.btn_DownloadImg.Size = new System.Drawing.Size(120, 37);
            this.btn_DownloadImg.TabIndex = 8;
            this.btn_DownloadImg.Text = "Загрузить";
            this.btn_DownloadImg.UseVisualStyleBackColor = false;
            this.btn_DownloadImg.Click += new System.EventHandler(this.btn_DownloadImg_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(61, 491);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(284, 5);
            this.panel7.TabIndex = 21;
            // 
            // cmb_Country
            // 
            this.cmb_Country.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.countryBindingSource, "CountryName", true));
            this.cmb_Country.DataSource = this.countryBindingSource;
            this.cmb_Country.DisplayMember = "CountryName";
            this.cmb_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Country.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmb_Country.FormattingEnabled = true;
            this.cmb_Country.Location = new System.Drawing.Point(61, 459);
            this.cmb_Country.Name = "cmb_Country";
            this.cmb_Country.Size = new System.Drawing.Size(284, 28);
            this.cmb_Country.TabIndex = 25;
            this.cmb_Country.ValueMember = "CountryCode";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 418);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 26);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(58, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Год рождения:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // marathonSkillsDataSet
            // 
            this.marathonSkillsDataSet.DataSetName = "MarathonSkillsDataSet";
            this.marathonSkillsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.marathonSkillsDataSet;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.marathonSkillsDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Done
            // 
            this.btn_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Done.FlatAppearance.BorderSize = 0;
            this.btn_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Done.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Done.ForeColor = System.Drawing.Color.White;
            this.btn_Done.Location = new System.Drawing.Point(487, 499);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(298, 37);
            this.btn_Done.TabIndex = 8;
            this.btn_Done.Text = "Готово";
            this.btn_Done.UseVisualStyleBackColor = false;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // NewRunner_Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 584);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.btn_DownloadImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.pc_picture);
            this.Controls.Add(this.cmb_Country);
            this.Controls.Add(this.cmb_Gender);
            this.Controls.Add(this.btn_showCPassword);
            this.Controls.Add(this.btn_ShowPassword);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_cpassword);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewRunner_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewRunner_Window";
            this.Load += new System.EventHandler(this.NewRunner_Window_Load);
            this.logo.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ShowPassword;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_cpassword;
        private System.Windows.Forms.Button btn_showCPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pc_picture;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.Button btn_DownloadImg;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cmb_Country;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private MarathonSkillsDataSet marathonSkillsDataSet;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private MarathonSkillsDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private MarathonSkillsDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Done;
    }
}