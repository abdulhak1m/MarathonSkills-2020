using Marathon_Skills_2020.Общее.ConnectionStrings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2020.Бегун
{
    public partial class NewRunner_Window : Form
    {
        public NewRunner_Window()
        {
            InitializeComponent();
            // вызываем метод передвижения формы
            FormMovement();
            // кнопка закрытия формы
            btn_close.Click += (s, e) => { Close(); };
            // кнопка свернуть окно
            btn_minimize.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            PrivatePassword(txt_Password, btn_ShowPassword);
            PrivatePassword(txt_cpassword, btn_showCPassword);
            #region

            txt_login.Text = "Введите логин*";
            txt_login.ForeColor = Color.CornflowerBlue;

            txt_Password.Text = "Введите пароль*";
            txt_Password.UseSystemPasswordChar = false;
            txt_Password.ForeColor = Color.CornflowerBlue;

            txt_cpassword.Text = "Подтвредите пароль*";
            txt_cpassword.UseSystemPasswordChar = false;
            txt_cpassword.ForeColor = Color.CornflowerBlue;

            txt_name.Text = "Введите имя*";
            txt_name.ForeColor = Color.CornflowerBlue;

            txt_surname.Text = "Введите фамилию*";
            txt_surname.ForeColor = Color.CornflowerBlue;
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

        private void NewRunner_Window_Load(object sender, EventArgs e)
        {
            // запускаем таймер
            timer1.Start();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.marathonSkillsDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.marathonSkillsDataSet.Gender);

        }
        // вернуться в главное меню системы
        private void btn_back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Уважаемый, вы действительно хотите покинуть окно регистрации в системе?",
           "Подтвреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ActiveForm.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                Close();
            }
        }
        // устанавливаем таймер до Марафона
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime marathonSkills = new DateTime(2020, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonSkills - DateTime.Now;
            lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона! ";
        }
        // загурзить фотографию
        OpenFileDialog fileDialog = new OpenFileDialog();
        private void DownloadImage()
        {
            fileDialog.InitialDirectory = @"B:\Pinterest";
            fileDialog.Filter = "Image File (*.BMP; *.PNG;*.JPG;*.JPEG;*.GIF)|*.BMP; *.PNG;*.JPG;*.JPEG;*.GIF|All Files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                pc_picture.Image = Image.FromFile(fileDialog.FileName);
                pc_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pc_picture.BorderStyle = BorderStyle.None;
                lbl_FileName.Text = fileDialog.SafeFileName.ToString();
            }
        }

        private void btn_DownloadImg_Click(object sender, EventArgs e)
        {
            DownloadImage();
        }
        #region User Hints
        private void txt_login_Enter(object sender, EventArgs e)
        {
            if (txt_login.Text == "Введите логин*")
            {
                txt_login.Text = "";
                txt_login.ForeColor = Color.Black;
            }
        }

        private void txt_login_Leave(object sender, EventArgs e)
        {
            if (txt_login.Text == "")
            {
                txt_login.Text = "Введите логин*";
                txt_login.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Введите пароль*")
            {
                txt_Password.Text = "";
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.ForeColor = Color.Black;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Введите пароль*";
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txt_cpassword_Enter(object sender, EventArgs e)
        {
            if (txt_cpassword.Text == "Подтвредите пароль*")
            {
                txt_cpassword.Text = "";
                txt_cpassword.UseSystemPasswordChar = false;
                txt_cpassword.ForeColor = Color.Black;
            }
        }

        private void txt_cpassword_Leave(object sender, EventArgs e)
        {
            if (txt_cpassword.Text == "")
            {
                txt_cpassword.Text = "Подтвредите пароль*";
                txt_cpassword.UseSystemPasswordChar = false;
                txt_cpassword.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text == "Введите имя*")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.Black;
            }
        }

        private void txt_surnane_Enter(object sender, EventArgs e)
        {
            if (txt_surname.Text == "Введите фамилию*")
            {
                txt_surname.Text = "";
                txt_surname.ForeColor = Color.Black;
            }
        }

        private void txt_surnane_Leave(object sender, EventArgs e)
        {
            if (txt_surname.Text == "")
            {
                txt_surname.Text = "Введите фамилию*";
                txt_surname.ForeColor = Color.CornflowerBlue;
            }
        }
        #endregion

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.Text = "Введите имя*";
                txt_name.ForeColor = Color.CornflowerBlue;
            }
        }

        // метод приватного ввода пароля
        // чисто от себя
        private void PrivatePassword(TextBox text, Button btn)
        {
            text.TextChanged += (s, e) => { text.UseSystemPasswordChar = true; };
            btn.MouseDown += (s, e) => { text.UseSystemPasswordChar = false; };
            btn.MouseUp += (s, e) =>
            {
                if (text.Text == "Введите пароль" || text.Text == "")
                    text.UseSystemPasswordChar = false;
                else
                    text.UseSystemPasswordChar = true;
            };
        }
        // проверяем пароли на совпадение
        private bool CheckPassword()
        {
            if (txt_Password.Text == "" || txt_Password.Text == "Введите пароль*" &&
                txt_cpassword.Text == "" || txt_cpassword.Text == "Подтвредите пароль*")
            {
                if (txt_Password.Text != txt_cpassword.Text)
                {
                    MessageBox.Show("Внимание! Парли не совпадают!", "Оё, явно косяк Клоун!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                    return true;
            }
            else
                return false;
        }
        private async void btn_Done_Click(object sender, EventArgs e)
        {
            //if (!CheckPassword())
            //    return;
            // разбиваем изображение на бинарный код
            MemoryStream ms = new MemoryStream();
            pc_picture.Image.Save(ms, pc_picture.Image.RawFormat);
            byte[] a = ms.GetBuffer();
            ms.Close();
            try
            {
                Regex emailRegex = new Regex(@"\w{2,10}@\w{2,10}.\w{2,10}");
                Match emailMatch = emailRegex.Match(txt_login.Text);
                if(emailMatch.Value == "")
                    MessageBox.Show("Некорректный формат почты! Пожалуйста, внимательно прочтите, какой набор символов вы ввели и повторите попытку!",
                        "Некорректный формать логина!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool digit = false;
                    bool lowchar = false;
                    bool spec = false;

                    for(int i = 0; i < txt_Password.TextLength; i++)
                    {
                        if (char.IsDigit(txt_Password.Text[i]))
                        {
                            digit = true;
                            break;
                        }
                    }
                    for (int i = 0; i < txt_Password.TextLength; i++)
                    {
                        if (char.IsLower(txt_Password.Text[i]))
                        {
                            lowchar = true;
                            break;
                        }
                    }
                    for (int i = 0; i < txt_Password.TextLength; i++)
                    {
                        if (txt_Password.Text[i] == '!' || txt_Password.Text[i] == '@' || txt_Password.Text[i] == '$' || 
                            txt_Password.Text[i] == '%' || txt_Password.Text[i] == '^' || txt_Password.Text[i] == '#')
                        {
                            spec = true;
                            break;
                        }
                    }
                    if(txt_Password.TextLength < 6 || !spec || !lowchar || !digit)
                        MessageBox.Show("Некорректный формат пароля! Пароль должени состоять не менее из 6-ти символов," +
                            " где как минимум должна быть одна цифра, одна буква нижнего регистра и один из следующих знаков !,@,#,$,%,^", 
                            "Ваш пароль не соответствует требованиям безопасности системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    DateTime dataofbirth = Convert.ToDateTime(dateTimePicker1.Value);
                    if(DateTime.Now.Year - dataofbirth.Year < 10)
                        MessageBox.Show("Внимание! На момент регистрации, возраст Бегун должно быть больше 10-ти лет!", 
                            "Недопустимый возраст Бегуна!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        using(SqlConnection connection = new SqlConnection(Connection.GetString()))
                        {
                            await connection.OpenAsync();
                            SqlCommand command = new SqlCommand("INSERT INTO [User] VALUES (@e, @p, @f, @l, @r)", connection);
                            command.Parameters.AddWithValue("@e", txt_login.Text);
                            command.Parameters.AddWithValue("@p", txt_Password.Text);
                            command.Parameters.AddWithValue("@f", txt_name.Text);
                            command.Parameters.AddWithValue("@l", txt_surname.Text);
                            command.Parameters.AddWithValue("@r", "R");
                            await command.ExecuteNonQueryAsync();
                            SqlCommand command1 = new SqlCommand("INSERT INTO [Runners] VALUES (@e, @g, @n_img, @img, @dob, @c)", connection);
                            command1.Parameters.AddWithValue("@e", txt_login.Text);
                            command1.Parameters.AddWithValue("@g", cmb_Gender.SelectedValue);
                            command1.Parameters.AddWithValue("@n_img", lbl_FileName.Text);
                            command1.Parameters.AddWithValue("@img", a);
                            command1.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                            command1.Parameters.AddWithValue("@c", cmb_Country.SelectedValue);
                            await command1.ExecuteNonQueryAsync();
                            MessageBox.Show("!");
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
