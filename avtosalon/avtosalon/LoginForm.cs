using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace avtosalon
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass`= @uP", db.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();

                string path = AppDomain.CurrentDomain.BaseDirectory;
                using (FileStream fileStream = new FileStream($"{path}/DataUser.txt", FileMode.Create))
                {
                    string surname = table.Rows[0][3].ToString();
                    string name = table.Rows[0][4].ToString();
                    string patronymic = table.Rows[0][5].ToString();
                    string number = table.Rows[0][6].ToString();
                    string id = table.Rows[0][0].ToString();

                    // Преобразование строки в байты
                    byte[] array = System.Text.Encoding.Default.GetBytes(id + " " + name + " " + surname + " " + patronymic + " " + number);
                    fileStream.Write(array, 0, array.Length);
                }
                mainForm mainForm = new mainForm();
                    mainForm.Show();
            }
     
            else
                MessageBox.Show("Неверное имя пользователя или пароль");

        }

        private void registerName_Click(object sender, EventArgs e)
        {
            this.Hide(); // прячем это окно
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void loginModer_Click(object sender, EventArgs e)
        {
            this.Hide(); // прячем это окно
            ModerForm ModerForm = new ModerForm();
            ModerForm.Show();
        }

 
    }
}
