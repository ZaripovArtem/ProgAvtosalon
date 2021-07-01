namespace avtosalon
{
    partial class CheckOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idЗаказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idКлиента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отчество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idАвтомобиля = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цвет = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text_Surname = new System.Windows.Forms.TextBox();
            this.label_Surname = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_Patronymic = new System.Windows.Forms.TextBox();
            this.text_Car = new System.Windows.Forms.TextBox();
            this.text_Color = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Patronymic = new System.Windows.Forms.Label();
            this.label_Car = new System.Windows.Forms.Label();
            this.label_Color = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(16)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 100);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(1128, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1164, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Просмотр/Редактирование/Удаление Заказов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idЗаказа,
            this.idКлиента,
            this.Фамилия,
            this.Имя,
            this.Отчество,
            this.idАвтомобиля,
            this.Цвет});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 340);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idЗаказа
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.idЗаказа.DefaultCellStyle = dataGridViewCellStyle2;
            this.idЗаказа.HeaderText = "id Заказа";
            this.idЗаказа.Name = "idЗаказа";
            this.idЗаказа.ReadOnly = true;
            // 
            // idКлиента
            // 
            this.idКлиента.HeaderText = "id Клиента";
            this.idКлиента.Name = "idКлиента";
            this.idКлиента.ReadOnly = true;
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.ReadOnly = true;
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Имя";
            this.Имя.Name = "Имя";
            this.Имя.ReadOnly = true;
            // 
            // Отчество
            // 
            this.Отчество.HeaderText = "Отчество";
            this.Отчество.Name = "Отчество";
            this.Отчество.ReadOnly = true;
            // 
            // idАвтомобиля
            // 
            this.idАвтомобиля.HeaderText = "id Автомобиля";
            this.idАвтомобиля.Name = "idАвтомобиля";
            this.idАвтомобиля.ReadOnly = true;
            // 
            // Цвет
            // 
            this.Цвет.HeaderText = "Цвет";
            this.Цвет.Name = "Цвет";
            this.Цвет.ReadOnly = true;
            // 
            // text_Surname
            // 
            this.text_Surname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.text_Surname.Location = new System.Drawing.Point(926, 123);
            this.text_Surname.Multiline = true;
            this.text_Surname.Name = "text_Surname";
            this.text_Surname.Size = new System.Drawing.Size(216, 35);
            this.text_Surname.TabIndex = 2;
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Surname.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Surname.Location = new System.Drawing.Point(774, 127);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(132, 31);
            this.label_Surname.TabIndex = 6;
            this.label_Surname.Text = "Фамилия";
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.SystemColors.Window;
            this.button_Update.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.button_Update.Location = new System.Drawing.Point(1033, 405);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(119, 38);
            this.button_Update.TabIndex = 8;
            this.button_Update.Text = "Обновить";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.SystemColors.Window;
            this.button_Delete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.button_Delete.Location = new System.Drawing.Point(758, 405);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(119, 38);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.Window;
            this.button_reset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.button_reset.Location = new System.Drawing.Point(895, 405);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(119, 38);
            this.button_reset.TabIndex = 10;
            this.button_reset.Text = "Сбросить";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // text_Name
            // 
            this.text_Name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.text_Name.Location = new System.Drawing.Point(926, 173);
            this.text_Name.Multiline = true;
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(216, 35);
            this.text_Name.TabIndex = 11;
            // 
            // text_Patronymic
            // 
            this.text_Patronymic.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Patronymic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.text_Patronymic.Location = new System.Drawing.Point(926, 224);
            this.text_Patronymic.Multiline = true;
            this.text_Patronymic.Name = "text_Patronymic";
            this.text_Patronymic.Size = new System.Drawing.Size(216, 35);
            this.text_Patronymic.TabIndex = 12;
            // 
            // text_Car
            // 
            this.text_Car.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Car.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.text_Car.Location = new System.Drawing.Point(926, 275);
            this.text_Car.Multiline = true;
            this.text_Car.Name = "text_Car";
            this.text_Car.Size = new System.Drawing.Size(216, 35);
            this.text_Car.TabIndex = 13;
            // 
            // text_Color
            // 
            this.text_Color.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.text_Color.Location = new System.Drawing.Point(926, 331);
            this.text_Color.Multiline = true;
            this.text_Color.Name = "text_Color";
            this.text_Color.Size = new System.Drawing.Size(216, 35);
            this.text_Color.TabIndex = 14;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Name.Location = new System.Drawing.Point(803, 177);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(68, 31);
            this.label_Name.TabIndex = 15;
            this.label_Name.Text = "Имя";
            // 
            // label_Patronymic
            // 
            this.label_Patronymic.AutoSize = true;
            this.label_Patronymic.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Patronymic.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Patronymic.Location = new System.Drawing.Point(774, 228);
            this.label_Patronymic.Name = "label_Patronymic";
            this.label_Patronymic.Size = new System.Drawing.Size(127, 31);
            this.label_Patronymic.TabIndex = 16;
            this.label_Patronymic.Text = "Отчество";
            // 
            // label_Car
            // 
            this.label_Car.AutoSize = true;
            this.label_Car.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Car.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Car.Location = new System.Drawing.Point(791, 279);
            this.label_Car.Name = "label_Car";
            this.label_Car.Size = new System.Drawing.Size(103, 31);
            this.label_Car.TabIndex = 17;
            this.label_Car.Text = "id Авто";
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Color.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Color.Location = new System.Drawing.Point(803, 335);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(74, 31);
            this.label_Color.TabIndex = 18;
            this.label_Color.Text = "Цвет";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label_Color);
            this.panel1.Controls.Add(this.label_Car);
            this.panel1.Controls.Add(this.label_Patronymic);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.text_Color);
            this.panel1.Controls.Add(this.text_Car);
            this.panel1.Controls.Add(this.text_Patronymic);
            this.panel1.Controls.Add(this.text_Name);
            this.panel1.Controls.Add(this.button_reset);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.label_Surname);
            this.panel1.Controls.Add(this.text_Surname);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 453);
            this.panel1.TabIndex = 4;
            // 
            // CheckOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 453);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckOrders";
            this.Text = "CheckOrders";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗаказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn idКлиента;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отчество;
        private System.Windows.Forms.DataGridViewTextBoxColumn idАвтомобиля;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цвет;
        private System.Windows.Forms.TextBox text_Surname;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_Patronymic;
        private System.Windows.Forms.TextBox text_Car;
        private System.Windows.Forms.TextBox text_Color;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Patronymic;
        private System.Windows.Forms.Label label_Car;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.Panel panel1;
    }
}