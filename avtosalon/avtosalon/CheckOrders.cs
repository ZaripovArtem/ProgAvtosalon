using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtosalon
{
    public partial class CheckOrders : Form
    {
        public CheckOrders()
        {
            InitializeComponent();
            LoadData();
        }

        public int orderid;
        private void LoadData()
        {
            DB db = new DB();

            db.openConnection();

            string query = "SELECT * FROM `orders`";

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString(); 
            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        void ResetForms()
        {
            orderid = 0;
            text_Surname.Clear();
            text_Name.Clear();
            text_Patronymic.Clear();
            text_Car.Clear();
            text_Color.Clear();

            text_Surname.Focus();
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (orderid > 0)
            {
                DB db = new DB();
                MySqlCommand com = new MySqlCommand("DELETE FROM `orders` WHERE `id Заказа` = @ID", db.GetConnection());

                com.Parameters.AddWithValue("@ID", this.orderid);
                db.openConnection();
                com.ExecuteNonQuery();
                db.closeConnection();

                MessageBox.Show("Информация о Заказе была Удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.Rows.Clear();
                LoadData();
                ResetForms();
            }
            else
            {
                MessageBox.Show("Выберите Заказ, информацию которого хотите Удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            ResetForms();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (orderid > 0)
            {
                DB db = new DB();
                MySqlCommand com = new MySqlCommand("UPDATE `orders` SET фамилия = @surname, Имя = @name, Отчество = @patronymic, `id Автомобиля` = @carsID, Цвет = @color WHERE `id Заказа` = @ID", db.GetConnection());

                com.Parameters.AddWithValue("@surname", text_Surname.Text);
                com.Parameters.AddWithValue("@name", text_Name.Text);
                com.Parameters.AddWithValue("@patronymic", text_Patronymic.Text);
                com.Parameters.AddWithValue("@carsID", text_Car.Text);
                com.Parameters.AddWithValue("@color", text_Color.Text);

                com.Parameters.AddWithValue("@ID", this.orderid);

                db.openConnection();
                com.ExecuteNonQuery();
                db.closeConnection();

                MessageBox.Show("Информация о Заказе была Обновлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.Rows.Clear();
                LoadData();
                ResetForms();
            }
            else
            {
                MessageBox.Show("Выберите Заказ, информацию которого хотите Обновить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            text_Surname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            text_Name.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            text_Patronymic.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            text_Car.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            text_Color.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ModerMain moderMain = new ModerMain();
            moderMain.Show();
        }

        Point lastPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
