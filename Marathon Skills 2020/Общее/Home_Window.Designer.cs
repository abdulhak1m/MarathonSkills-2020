namespace Marathon_Skills_2020
{
    partial class Form1
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
            this.panel_runner = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.btn_NewRunner = new System.Windows.Forms.Button();
            this.panel_start = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_EventInfo = new System.Windows.Forms.Button();
            this.btn_WantRunner = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_runner.SuspendLayout();
            this.panel_start.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_runner
            // 
            this.panel_runner.Controls.Add(this.panel1);
            this.panel_runner.Controls.Add(this.btn_Back);
            this.panel_runner.Controls.Add(this.btn_SignIn);
            this.panel_runner.Controls.Add(this.btn_NewRunner);
            this.panel_runner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_runner.Location = new System.Drawing.Point(0, 25);
            this.panel_runner.Name = "panel_runner";
            this.panel_runner.Size = new System.Drawing.Size(604, 386);
            this.panel_runner.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Marathon_Skills_2020.Properties.Resources.wsrlogo_01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 65);
            this.panel1.TabIndex = 11;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(494, 282);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(98, 40);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Назад";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_SignIn.FlatAppearance.BorderSize = 0;
            this.btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignIn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SignIn.ForeColor = System.Drawing.Color.White;
            this.btn_SignIn.Location = new System.Drawing.Point(126, 196);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(352, 73);
            this.btn_SignIn.TabIndex = 1;
            this.btn_SignIn.Text = "Авторизоваться";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // btn_NewRunner
            // 
            this.btn_NewRunner.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_NewRunner.FlatAppearance.BorderSize = 0;
            this.btn_NewRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewRunner.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_NewRunner.ForeColor = System.Drawing.Color.White;
            this.btn_NewRunner.Location = new System.Drawing.Point(126, 117);
            this.btn_NewRunner.Name = "btn_NewRunner";
            this.btn_NewRunner.Size = new System.Drawing.Size(352, 73);
            this.btn_NewRunner.TabIndex = 2;
            this.btn_NewRunner.Text = "Я новичок";
            this.btn_NewRunner.UseVisualStyleBackColor = false;
            this.btn_NewRunner.Click += new System.EventHandler(this.btn_NewRunner_Click);
            // 
            // panel_start
            // 
            this.panel_start.Controls.Add(this.logo);
            this.panel_start.Controls.Add(this.btn_Login);
            this.panel_start.Controls.Add(this.btn_EventInfo);
            this.panel_start.Controls.Add(this.btn_WantRunner);
            this.panel_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_start.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_start.Location = new System.Drawing.Point(0, 25);
            this.panel_start.Name = "panel_start";
            this.panel_start.Size = new System.Drawing.Size(604, 386);
            this.panel_start.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Marathon_Skills_2020.Properties.Resources.wsrlogo_01;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(604, 65);
            this.logo.TabIndex = 10;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(494, 282);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(98, 41);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Войти";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_EventInfo
            // 
            this.btn_EventInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_EventInfo.FlatAppearance.BorderSize = 0;
            this.btn_EventInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EventInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EventInfo.ForeColor = System.Drawing.Color.White;
            this.btn_EventInfo.Location = new System.Drawing.Point(126, 196);
            this.btn_EventInfo.Name = "btn_EventInfo";
            this.btn_EventInfo.Size = new System.Drawing.Size(352, 73);
            this.btn_EventInfo.TabIndex = 0;
            this.btn_EventInfo.Text = "Узнать больше о событии";
            this.btn_EventInfo.UseVisualStyleBackColor = false;
            this.btn_EventInfo.Click += new System.EventHandler(this.btn_EventInfo_Click);
            // 
            // btn_WantRunner
            // 
            this.btn_WantRunner.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_WantRunner.FlatAppearance.BorderSize = 0;
            this.btn_WantRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WantRunner.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_WantRunner.ForeColor = System.Drawing.Color.White;
            this.btn_WantRunner.Location = new System.Drawing.Point(126, 117);
            this.btn_WantRunner.Name = "btn_WantRunner";
            this.btn_WantRunner.Size = new System.Drawing.Size(352, 73);
            this.btn_WantRunner.TabIndex = 0;
            this.btn_WantRunner.Text = "Я хочу стать бегуном";
            this.btn_WantRunner.UseVisualStyleBackColor = false;
            this.btn_WantRunner.Click += new System.EventHandler(this.btn_WantRunner_Click);
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
            this.topPanel.Size = new System.Drawing.Size(604, 25);
            this.topPanel.TabIndex = 0;
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
            this.btn_minimize.Location = new System.Drawing.Point(554, 0);
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
            this.btn_close.Location = new System.Drawing.Point(579, 0);
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
            this.lbl_Timer.Location = new System.Drawing.Point(0, 366);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(604, 45);
            this.lbl_Timer.TabIndex = 1;
            this.lbl_Timer.Text = "Timer";
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 411);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.panel_start);
            this.Controls.Add(this.panel_runner);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_runner.ResumeLayout(false);
            this.panel_start.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_runner;
        private System.Windows.Forms.Panel panel_start;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_WantRunner;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_EventInfo;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Button btn_NewRunner;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel panel1;
    }
}

