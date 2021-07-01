using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace avtosalon
{
    public partial class ModerForm : Form
    {
        public ModerForm()
        {
            InitializeComponent();
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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

        private void buttonModerLogin_Click(object sender, EventArgs e)
        {
            String ModerLoginUser = ModerLoginField.Text;
            String ModerPassUser = ModerPassField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `manager` WHERE `login` = @uL AND `pass`= @uP", db.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = ModerLoginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = ModerPassUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                ModerMain ModerMain = new ModerMain();
                ModerMain.Show();
            }

            else
                MessageBox.Show("No");
        }
    }
}
