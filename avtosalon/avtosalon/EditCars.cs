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
    public partial class EditCars : Form
    {
       
        public EditCars()
        {
            InitializeComponent();
            LoadData();
        }

        public int carsid;
        private void LoadData()
        {
            DB db = new DB();

            db.openConnection();


            string query = "SELECT * FROM `cars`";

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
         
            if (IsValid())
            {
                DB db = new DB();
                MySqlCommand com = new MySqlCommand("INSERT INTO `cars` (`id`, `brand`, `model`, `price`) VALUES (@id, @brand, @model, @price)", db.GetConnection());

                com.Parameters.Add("@id", MySqlDbType.VarChar).Value = text_ID.Text;
                com.Parameters.Add("@brand", MySqlDbType.VarChar).Value = text_Brand.Text;
                com.Parameters.Add("@model", MySqlDbType.VarChar).Value = text_Model.Text;
                com.Parameters.Add("@price", MySqlDbType.VarChar).Value = text_Price.Text;
                //   if ()


                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `cars` WHERE `id` = @cID", db.GetConnection());

                command.Parameters.Add("@cID", MySqlDbType.VarChar).Value = text_ID.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Автомобиль с таким ID уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else

                {

                    for (int i = 0; i < text_ID.Text.Length; i++)
                    {
                        if (Char.IsDigit(text_ID.Text[i]))
                        {
                            db.openConnection();
                            com.ExecuteNonQuery();
                            db.closeConnection();

                            MessageBox.Show("Автомобиль был добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dataGridView1.Rows.Clear();
                            LoadData();
                            ResetForms();
                        }
                        else
                        {
                            MessageBox.Show("ID может быть только цифрой");
                            return;
                        }
                    }
                }

            }

        }

        private bool IsValid()
        {
            if (text_Brand.Text == string.Empty)
            {
                MessageBox.Show("Введите название марки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (text_Model.Text == string.Empty)
            {
                MessageBox.Show("Введите название модели", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (text_Price.Text == string.Empty)
            {
                MessageBox.Show("Введите цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            ResetForms();
        }
        void ResetForms()
        {
            carsid = 0;
            text_Brand.Clear();
            text_Model.Clear();
            text_Price.Clear();
            text_ID.Clear();

            text_Brand.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            carsid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            text_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            text_Brand.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            text_Model.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            text_Price.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (carsid > 0)
            { 
                DB db = new DB();
                MySqlCommand com = new MySqlCommand("UPDATE `cars` SET brand = @brand, model = @model, price = @price WHERE id = @ID", db.GetConnection());
                com.Parameters.AddWithValue("@brand", text_Brand.Text);
                com.Parameters.AddWithValue("@model", text_Model.Text);
                com.Parameters.AddWithValue("@price", text_Price.Text);
                com.Parameters.AddWithValue("@ID", this.carsid);


                // char carID = (char)this.carsid;

                string carID = this.carsid.ToString();

                for (int i=0; i<text_ID.Text.Length; i++)
                {
                    if (carID[i] == text_ID.Text[i])
                    {
                        continue;
                    }
                    else
                    {
                        MessageBox.Show("ID автомобиля изменять нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        text_ID.Text = carID;
                        return;
                    }

                }


                db.openConnection();
                com.ExecuteNonQuery();
                db.closeConnection();

                MessageBox.Show("Информация об Автомобиле была Обновлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.Rows.Clear();
                LoadData();
                ResetForms();
            }
            else
            {
                MessageBox.Show("Выберите автомобиль, информацию которого хотите Обновить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (carsid > 0)
            {
                DB db = new DB();
                MySqlCommand com = new MySqlCommand("DELETE FROM `cars` WHERE id = @ID", db.GetConnection());

                com.Parameters.AddWithValue("@ID", this.carsid);
                db.openConnection();
                com.ExecuteNonQuery();
                db.closeConnection();

                MessageBox.Show("Информация об Автомобиле была Удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.Rows.Clear();
                LoadData();
                ResetForms();
            }
            else
            {
                MessageBox.Show("Выберите автомобиль, информацию которого хотите Удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ModerMain ModerMain = new ModerMain();
            ModerMain.Show();
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
