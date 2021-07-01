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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
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

        private void buttonCheckAuto_Click(object sender, EventArgs e)
        {
            CheckCars CheckCars = new CheckCars();
            CheckCars.Show();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddOrders addorders = new AddOrders();
            addorders.Show();  
        }
    }
}
