using Marathon_Skills_2020.Администрация;
using Marathon_Skills_2020.Бегун;
using Marathon_Skills_2020.Общее.ConnectionStrings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2020.Общее
{
    public partial class Login_Window : Form
    {
        public Login_Window()
        {
            InitializeComponent();
            // вызываем метод передвижения формы
            FormMovement();
            // кнопка закрытия формы
            btn_close.Click += (s, e) => { Close(); };
            // кнопка свернуть окно
            btn_minimize.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            // обращаемся к этому методу
            PrivatePassword();
            // user hints
            #region User hints
            txt_login.Text = "Введите логин";
            txt_login.ForeColor = Color.CornflowerBlue;

            txt_Password.Text = "Введите пароль";
            txt_Password.UseSystemPasswordChar = false;
            txt_Password.ForeColor = Color.CornflowerBlue;
            #endregion
        }
        // метод передвижени формы
        private void FormMovement()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        // устанавливаем таймер до начала Марафона
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime marathonSkills = new DateTime(2020, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonSkills - DateTime.Now;
            lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона! ";
        }
        // переход в главное окно Системы
        private void btn_back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Уважаемый, вы действительно хотите покинуть окно Авторизации в системе?", 
                "Подтвреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ActiveForm.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                Close();
            }
        }

        private void Login_Window_Load(object sender, EventArgs e)
        {
            // зупскаем таймер
            timer1.Start();
        }

        // метод приватного ввода пароля
        // чисто от себя
        private void PrivatePassword()
        {
            txt_Password.TextChanged += (s, e) => { txt_Password.UseSystemPasswordChar = true; };
            btn_ShowPassword.MouseDown += (s, e) => { txt_Password.UseSystemPasswordChar = false; };
            btn_ShowPassword.MouseUp += (s, e) =>
            {
                if(txt_Password.Text == "Введите пароль" || txt_Password.Text == "")
                    txt_Password.UseSystemPasswordChar = false;
                else
                    txt_Password.UseSystemPasswordChar = true;
            };
        }

        // Подсказки 
        #region User hints 
        private void txt_login_Enter(object sender, EventArgs e)
        {
            if(txt_login.Text == "Введите логин")
            {
                txt_login.Text = "";
                txt_login.ForeColor = Color.Black;
            }
        }

        private void txt_login_Leave(object sender, EventArgs e)
        {
            if(txt_login.Text == "")
            {
                txt_login.Text = "Введите логин";
                txt_login.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if(txt_Password.Text == "Введите пароль")
            {
                txt_Password.Text = "";
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.ForeColor = Color.Black;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if(txt_Password.Text == "")
            {
                txt_Password.Text = "Введите пароль";
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.ForeColor = Color.CornflowerBlue;
            }
        }
        #endregion

        private void Login_Window_KeyDown(object sender, KeyEventArgs e)
        {
            // по нажатию на клавишу Enter, срабатывает событие Login_Click
            if (e.KeyValue == (char)Keys.Enter)
                btn_Login.PerformClick();
            // по нажатию на клавишу Escape, срабатывет событие Back_Click
            if (e.KeyValue == (char)Keys.Escape)
                btn_back.PerformClick();
        }
        public static string email = "";
        private async void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(Connection.GetString()))
                {
                    await connection.OpenAsync();
                    SqlCommand commandLogin = new SqlCommand("SELECT * FROM [User] WHERE Email = '" + txt_login.Text.Trim() + "' and Password = '" + txt_Password.Text.Trim() + "'", connection);
                    using (SqlDataReader reader = commandLogin.ExecuteReader())
                    {
                        if(!reader.HasRows)
                            MessageBox.Show("Такого клоуна в системе не обнаружено! Пожалуйста, разуйте глаза и удостоверьтесь в правильности" +
                                " логина и пароля и только потом повторите попытку авторизации, смекаете?", "Не верный логин или пароль!", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            while (reader.Read())
                            {
                                email = reader["Email"].ToString();
                                if(reader["RoleId"].ToString() == "R")
                                {
                                    ActiveForm.Hide();
                                    MenuRunner_Window menu_Runner = new MenuRunner_Window();
                                    menu_Runner.ShowDialog();
                                    Close();
                                }
                                if(reader["RoleId"].ToString() == "A")
                                {
                                    ActiveForm.Hide();
                                    Admin_Window admin = new Admin_Window();
                                    admin.ShowDialog();
                                    Close();
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
