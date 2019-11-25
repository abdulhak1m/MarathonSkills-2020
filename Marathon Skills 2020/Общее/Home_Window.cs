using Marathon_Skills_2020.Бегун;
using Marathon_Skills_2020.Общее;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // при загрузке формы, пользователь системы должен видеть стартовую панель
            panel_start.BringToFront();
            // вызываем метод передвижения формы
            FormMovement();
            // кнопка закрытия формы
            btn_close.Click += (s, e) => { Close(); };
            // кнопка свернуть окно
            btn_minimize.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
        }
        // метод передвижени формы
        private void FormMovement()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        // устанавливаем таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime marathonSkills = new DateTime(2020, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonSkills - DateTime.Now;
            lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона! ";
        }
        // при загрузке формы, запускаем таймер
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_WantRunner_Click(object sender, EventArgs e)
        {
            panel_runner.BringToFront();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            panel_start.BringToFront();
        }
        // переходим в форму MarathonSkills
        private void btn_EventInfo_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MarathonSkills marathon = new MarathonSkills();
            marathon.ShowDialog();
            Close();
        }
        // метод, переход в окно авторизации
        private void Login()
        {
            ActiveForm.Hide();
            Login_Window login_Window = new Login_Window();
            login_Window.ShowDialog();
            Close();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            Login();
        }
        // переходим в окно Регистрации бегуна
        private void btn_NewRunner_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            NewRunner_Window newRunner = new NewRunner_Window();
            newRunner.ShowDialog();
            Close();
        }
    }
}
