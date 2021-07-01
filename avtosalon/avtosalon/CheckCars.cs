using MySql.Data.MySqlClient;
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

namespace avtosalon
{
    public partial class CheckCars : Form
    {
        public CheckCars()
        {
            InitializeComponent();
            LoadData();
        }

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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
