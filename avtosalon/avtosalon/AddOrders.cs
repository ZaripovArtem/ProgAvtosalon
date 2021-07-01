using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtosalon
{
    public partial class AddOrders : Form
    {
        public AddOrders()
        {
            InitializeComponent();
        }

        private void Color_White_Click(object sender, EventArgs e)
        {
            Text_Color.Text = "Белый";
        }

        private void Color_Black_Click(object sender, EventArgs e)
        {
            Text_Color.Text = "Черный";
        }

        private void Color_Red_Click(object sender, EventArgs e)
        {
            Text_Color.Text = "Красный";
        }

        private void Color_Blue_Click(object sender, EventArgs e)
        {
            Text_Color.Text = "Синий";
        }

        private void Color_Other_Click(object sender, EventArgs e)
        {
            Text_Color.Text = "Другой";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Text_Color.Text == "Черный" || Text_Color.Text == "Белый" || Text_Color.Text == "Красный" || Text_Color.Text == "Синий" || Text_Color.Text == "Другой")
            {
                // MessageBox.Show("Привет");
                String CarID;
                String BrandCar = Text_BrandCar.Text;
                String ModelCar = Text_ModelCar.Text;
                String CarsColor = Text_Color.Text;

                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `cars` WHERE `brand` = @uBrand AND `model` = @uModel" , db.GetConnection()); // where brand and model

                command.Parameters.Add("@uBrand", MySqlDbType.VarChar).Value = BrandCar;
                command.Parameters.Add("@uModel", MySqlDbType.VarChar).Value = ModelCar;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory; // Текущая директория
                    string ClientID;
                    string surname;
                    string name;
                    string patronymic;
                    string telephoneNumber;
                    CarID = table.Rows[0][0].ToString();

                    string CarColor = this.Text_Color.Text;

                    using (FileStream fileStream = File.OpenRead($"{path}/DataUser.txt"))
                    {
                        byte[] array = new byte[fileStream.Length];
                        fileStream.Read(array, 0, array.Length);

                        // декодируем байты в строку
                        string textFromFile = System.Text.Encoding.Default.GetString(array);
                        string[] splitTextFromFile = textFromFile.Split(' ');

                        ClientID = splitTextFromFile[0];
                        surname = splitTextFromFile[1];
                        name = splitTextFromFile[2];
                        patronymic = splitTextFromFile[3];
                        telephoneNumber = splitTextFromFile[4];
                    }
                    MySqlCommand com = new MySqlCommand("INSERT INTO `orders` (`id Заказа`, `id Клиента`, `фамилия`, `Имя`, `Отчество`, `id Автомобиля`, `Цвет`) VALUES (NULL, @idUser, @surname, @name, @patronymic, @idCar, @color)", db.GetConnection());

                    com.Parameters.Add("@idUser", MySqlDbType.VarChar).Value = ClientID;
                    com.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
                    com.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    com.Parameters.Add("patronymic", MySqlDbType.VarChar).Value = patronymic;
                    com.Parameters.Add("idCar", MySqlDbType.VarChar).Value = CarID; ////
                    com.Parameters.Add("@color", MySqlDbType.VarChar).Value = Text_Color.Text;

                    db.openConnection();

                    if (com.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Заказ был создан, ожидайте звонка");
                        Text_BrandCar.Clear();
                        Text_Color.Clear();
                        Text_ModelCar.Clear();
                    }
                       
                    else
                        MessageBox.Show("Заказ не был создан");

                    db.closeConnection();
                }

                else
                    MessageBox.Show("Неверное id Автомобиля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                MessageBox.Show("Неверный цвет Автомобиля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm mainForm = new mainForm();
            mainForm.Show();
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
