namespace avtosalon
{
    partial class EditCars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Марка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Модель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.label_Brand = new System.Windows.Forms.Label();
            this.label_Model = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.text_Price = new System.Windows.Forms.TextBox();
            this.text_Model = new System.Windows.Forms.TextBox();
            this.text_Brand = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Марка,
            this.Модель,
            this.Цена});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(446, 344);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle5;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Марка
            // 
            this.Марка.HeaderText = "Марка";
            this.Марка.Name = "Марка";
            this.Марка.ReadOnly = true;
            // 
            // Модель
            // 
            this.Модель.HeaderText = "Модель";
            this.Модель.Name = "Модель";
            this.Модель.ReadOnly = true;
            // 
            // Цена
            // 
            this.Цена.HeaderText = "Цена";
            this.Цена.Name = "Цена";
            this.Цена.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(833, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Просмотр/Редактирование/Удаление Автомобилей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.text_ID);
            this.panel1.Controls.Add(this.button_reset);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_Insert);
            this.panel1.Controls.Add(this.label_Brand);
            this.panel1.Controls.Add(this.label_Model);
            this.panel1.Controls.Add(this.label_Price);
            this.panel1.Controls.Add(this.text_Price);
            this.panel1.Controls.Add(this.text_Model);
            this.panel1.Controls.Add(this.text_Brand);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 450);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(505, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // text_ID
            // 
            this.text_ID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.text_ID.Location = new System.Drawing.Point(594, 284);
            this.text_ID.Multiline = true;
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(216, 35);
            this.text_ID.TabIndex = 11;
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.Window;
            this.button_reset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.button_reset.Location = new System.Drawing.Point(691, 390);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(119, 38);
            this.button_reset.TabIndex = 10;
            this.button_reset.Text = "Сбросить";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.SystemColors.Window;
            this.button_Delete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.button_Delete.Location = new System.Drawing.Point(492, 390);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(119, 38);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.SystemColors.Window;
            this.button_Update.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.button_Update.Location = new System.Drawing.Point(691, 335);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(119, 38);
            this.button_Update.TabIndex = 8;
            this.button_Update.Text = "Обновить";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.BackColor = System.Drawing.SystemColors.Window;
            this.button_Insert.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.button_Insert.Location = new System.Drawing.Point(492, 335);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(119, 38);
            this.button_Insert.TabIndex = 7;
            this.button_Insert.Text = "Добавить";
            this.button_Insert.UseVisualStyleBackColor = false;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // label_Brand
            // 
            this.label_Brand.AutoSize = true;
            this.label_Brand.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Brand.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Brand.Location = new System.Drawing.Point(474, 123);
            this.label_Brand.Name = "label_Brand";
            this.label_Brand.Size = new System.Drawing.Size(98, 31);
            this.label_Brand.TabIndex = 4;
            this.label_Brand.Text = "Марка";
            // 
            // label_Model
            // 
            this.label_Model.AutoSize = true;
            this.label_Model.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Model.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Model.Location = new System.Drawing.Point(471, 177);
            this.label_Model.Name = "label_Model";
            this.label_Model.Size = new System.Drawing.Size(107, 31);
            this.label_Model.TabIndex = 5;
            this.label_Model.Text = "Модель";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Price.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Price.Location = new System.Drawing.Point(486, 230);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(77, 31);
            this.label_Price.TabIndex = 6;
            this.label_Price.Text = "Цена";
            // 
            // text_Price
            // 
            this.text_Price.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.text_Price.Location = new System.Drawing.Point(594, 227);
            this.text_Price.Multiline = true;
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(216, 35);
            this.text_Price.TabIndex = 2;
            // 
            // text_Model
            // 
            this.text_Model.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.text_Model.Location = new System.Drawing.Point(594, 174);
            this.text_Model.Multiline = true;
            this.text_Model.Name = "text_Model";
            this.text_Model.Size = new System.Drawing.Size(216, 35);
            this.text_Model.TabIndex = 3;
            // 
            // text_Brand
            // 
            this.text_Brand.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.text_Brand.Location = new System.Drawing.Point(594, 121);
            this.text_Brand.Multiline = true;
            this.text_Brand.Name = "text_Brand";
            this.text_Brand.Size = new System.Drawing.Size(216, 35);
            this.text_Brand.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(16)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 100);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(806, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EditCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCars";
            this.Text = "EditCars";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Марка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Модель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox text_Price;
        private System.Windows.Forms.TextBox text_Model;
        private System.Windows.Forms.TextBox text_Brand;
        private System.Windows.Forms.Label label_Brand;
        private System.Windows.Forms.Label label_Model;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_ID;
    }
}