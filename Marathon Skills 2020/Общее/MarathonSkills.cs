using System;
using Marathon_Skills_2020.Общее;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2020.Общее
{
    public partial class MarathonSkills : Form
    {
        public MarathonSkills()
        {
            InitializeComponent();
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
        // устанавливаем Таймер до Марафона
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime marathonSkills = new DateTime(2020, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonSkills - DateTime.Now;
            lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона! ";
        }
        
        private void MarathonSkills_Load(object sender, EventArgs e)
        {
            // запускаем таймер
            timer1.Start();
        }
        // назад в главное окно Системы
        private void btn_back_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form1 home = new Form1();
            home.ShowDialog();
            Close();
        }
    }
}
