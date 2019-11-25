using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2020.Администрация
{
    public partial class Admin_Window : Form
    {
        public Admin_Window()
        {
            InitializeComponent();
            // вызываем метод передвижения формы
            FormMovement();
            // кнопка закрытия формы
            btn_close.Click += (s, e) => { Close(); };
            // кнопка свернуть окно
            btn_minimize.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            // обращаемся к этому методу
        }
        // метод передвижени формы
        private void FormMovement()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime marathonSkills = new DateTime(2020, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonSkills - DateTime.Now;
            lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона! ";
        }

        private void Admin_Window_Load(object sender, EventArgs e)
        {
            // запускаем таймер
            timer1.Start();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Уважаемый, вы действительно хотите покинуть профиль Администратора системы?",
            "Подтвреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ActiveForm.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                Close();
            }
        }

        private void Admin_Window_KeyDown(object sender, KeyEventArgs e)
        {
            // по нажатию на клавишу Escape, срабатывет событие Back_Click
            if (e.KeyValue == (char)Keys.Escape)
                btn_back.PerformClick();
        }
    }
}
