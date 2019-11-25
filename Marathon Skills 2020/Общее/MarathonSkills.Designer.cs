namespace Marathon_Skills_2020.Общее
{
    partial class MarathonSkills
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_BMI = new System.Windows.Forms.Button();
            this.btn_MarathonSkills = new System.Windows.Forms.Button();
            this.btn_BMR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.logo.SuspendLayout();
            this.SuspendLayout();
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
            this.topPanel.Size = new System.Drawing.Size(555, 25);
            this.topPanel.TabIndex = 3;
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
            this.btn_minimize.Location = new System.Drawing.Point(505, 0);
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
            this.btn_close.Location = new System.Drawing.Point(530, 0);
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
            this.lbl_Timer.Location = new System.Drawing.Point(0, 426);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(555, 45);
            this.lbl_Timer.TabIndex = 5;
            this.lbl_Timer.Text = "Timer";
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_BMI
            // 
            this.btn_BMI.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_BMI.FlatAppearance.BorderSize = 0;
            this.btn_BMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BMI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_BMI.ForeColor = System.Drawing.Color.White;
            this.btn_BMI.Location = new System.Drawing.Point(105, 253);
            this.btn_BMI.Name = "btn_BMI";
            this.btn_BMI.Size = new System.Drawing.Size(346, 66);
            this.btn_BMI.TabIndex = 6;
            this.btn_BMI.Text = "BMI калькулятор";
            this.btn_BMI.UseVisualStyleBackColor = false;
            // 
            // btn_MarathonSkills
            // 
            this.btn_MarathonSkills.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_MarathonSkills.FlatAppearance.BorderSize = 0;
            this.btn_MarathonSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MarathonSkills.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_MarathonSkills.ForeColor = System.Drawing.Color.White;
            this.btn_MarathonSkills.Location = new System.Drawing.Point(105, 181);
            this.btn_MarathonSkills.Name = "btn_MarathonSkills";
            this.btn_MarathonSkills.Size = new System.Drawing.Size(346, 66);
            this.btn_MarathonSkills.TabIndex = 7;
            this.btn_MarathonSkills.Text = "MarathonSkills 2020";
            this.btn_MarathonSkills.UseVisualStyleBackColor = false;
            // 
            // btn_BMR
            // 
            this.btn_BMR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_BMR.FlatAppearance.BorderSize = 0;
            this.btn_BMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BMR.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_BMR.ForeColor = System.Drawing.Color.White;
            this.btn_BMR.Location = new System.Drawing.Point(105, 325);
            this.btn_BMR.Name = "btn_BMR";
            this.btn_BMR.Size = new System.Drawing.Size(346, 66);
            this.btn_BMR.TabIndex = 6;
            this.btn_BMR.Text = "BMR калькулятор";
            this.btn_BMR.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(50, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Подробная ифнормация о MarathonSkills 2020";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Marathon_Skills_2020.Properties.Resources.wsrlogo_01;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Controls.Add(this.btn_back);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 25);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(555, 65);
            this.logo.TabIndex = 9;
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
            // MarathonSkills
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 471);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BMR);
            this.Controls.Add(this.btn_BMI);
            this.Controls.Add(this.btn_MarathonSkills);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarathonSkills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarathonSkills";
            this.Load += new System.EventHandler(this.MarathonSkills_Load);
            this.topPanel.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_BMI;
        private System.Windows.Forms.Button btn_MarathonSkills;
        private System.Windows.Forms.Button btn_BMR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button btn_back;
    }
}