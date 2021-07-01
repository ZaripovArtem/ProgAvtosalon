namespace avtosalon
{
    partial class AddOrders
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
            this.label = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_ModelCar = new System.Windows.Forms.TextBox();
            this.Order = new System.Windows.Forms.Button();
            this.Color_Other = new System.Windows.Forms.Button();
            this.Color_Blue = new System.Windows.Forms.Button();
            this.Color_Black = new System.Windows.Forms.Button();
            this.Color_Red = new System.Windows.Forms.Button();
            this.Color_White = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.Text_Color = new System.Windows.Forms.TextBox();
            this.Text_BrandCar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.label.Controls.Add(this.label2);
            this.label.Controls.Add(this.Text_ModelCar);
            this.label.Controls.Add(this.Order);
            this.label.Controls.Add(this.Color_Other);
            this.label.Controls.Add(this.Color_Blue);
            this.label.Controls.Add(this.Color_Black);
            this.label.Controls.Add(this.Color_Red);
            this.label.Controls.Add(this.Color_White);
            this.label.Controls.Add(this.color);
            this.label.Controls.Add(this.label3);
            this.label.Controls.Add(this.label_ID);
            this.label.Controls.Add(this.Text_Color);
            this.label.Controls.Add(this.Text_BrandCar);
            this.label.Controls.Add(this.panel2);
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(800, 450);
            this.label.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(21, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Модель Авто";
            // 
            // Text_ModelCar
            // 
            this.Text_ModelCar.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_ModelCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.Text_ModelCar.Location = new System.Drawing.Point(211, 212);
            this.Text_ModelCar.Multiline = true;
            this.Text_ModelCar.Name = "Text_ModelCar";
            this.Text_ModelCar.Size = new System.Drawing.Size(196, 47);
            this.Text_ModelCar.TabIndex = 21;
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(35)))));
            this.Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Order.FlatAppearance.BorderSize = 0;
            this.Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order.ForeColor = System.Drawing.Color.White;
            this.Order.Location = new System.Drawing.Point(241, 372);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(316, 52);
            this.Order.TabIndex = 20;
            this.Order.Text = "Добавить заказ";
            this.Order.UseVisualStyleBackColor = false;
            this.Order.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Color_Other
            // 
            this.Color_Other.BackColor = System.Drawing.SystemColors.Window;
            this.Color_Other.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color_Other.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.Color_Other.Location = new System.Drawing.Point(485, 276);
            this.Color_Other.Name = "Color_Other";
            this.Color_Other.Size = new System.Drawing.Size(303, 58);
            this.Color_Other.TabIndex = 19;
            this.Color_Other.Text = "Другое (Если хотите выбрать другой цвет)";
            this.Color_Other.UseVisualStyleBackColor = false;
            this.Color_Other.Click += new System.EventHandler(this.Color_Other_Click);
            // 
            // Color_Blue
            // 
            this.Color_Blue.BackColor = System.Drawing.SystemColors.Window;
            this.Color_Blue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color_Blue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.Color_Blue.Location = new System.Drawing.Point(669, 212);
            this.Color_Blue.Name = "Color_Blue";
            this.Color_Blue.Size = new System.Drawing.Size(119, 38);
            this.Color_Blue.TabIndex = 18;
            this.Color_Blue.Text = "Синий";
            this.Color_Blue.UseVisualStyleBackColor = false;
            this.Color_Blue.Click += new System.EventHandler(this.Color_Blue_Click);
            // 
            // Color_Black
            // 
            this.Color_Black.BackColor = System.Drawing.SystemColors.Window;
            this.Color_Black.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color_Black.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.Color_Black.Location = new System.Drawing.Point(669, 145);
            this.Color_Black.Name = "Color_Black";
            this.Color_Black.Size = new System.Drawing.Size(119, 38);
            this.Color_Black.TabIndex = 17;
            this.Color_Black.Text = "Черный";
            this.Color_Black.UseVisualStyleBackColor = false;
            this.Color_Black.Click += new System.EventHandler(this.Color_Black_Click);
            // 
            // Color_Red
            // 
            this.Color_Red.BackColor = System.Drawing.SystemColors.Window;
            this.Color_Red.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color_Red.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.Color_Red.Location = new System.Drawing.Point(485, 212);
            this.Color_Red.Name = "Color_Red";
            this.Color_Red.Size = new System.Drawing.Size(119, 38);
            this.Color_Red.TabIndex = 16;
            this.Color_Red.Text = "Красный";
            this.Color_Red.UseVisualStyleBackColor = false;
            this.Color_Red.Click += new System.EventHandler(this.Color_Red_Click);
            // 
            // Color_White
            // 
            this.Color_White.BackColor = System.Drawing.SystemColors.Window;
            this.Color_White.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color_White.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.Color_White.Location = new System.Drawing.Point(485, 145);
            this.Color_White.Name = "Color_White";
            this.Color_White.Size = new System.Drawing.Size(119, 38);
            this.Color_White.TabIndex = 15;
            this.Color_White.Text = "Белый";
            this.Color_White.UseVisualStyleBackColor = false;
            this.Color_White.Click += new System.EventHandler(this.Color_White_Click);
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color.ForeColor = System.Drawing.SystemColors.Window;
            this.color.Location = new System.Drawing.Point(593, 106);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(88, 31);
            this.color.TabIndex = 14;
            this.color.Text = "Цвета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(66, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Цвет";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.Window;
            this.label_ID.Location = new System.Drawing.Point(25, 152);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(164, 31);
            this.label_ID.TabIndex = 12;
            this.label_ID.Text = "Марка Авто";
            // 
            // Text_Color
            // 
            this.Text_Color.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.Text_Color.Location = new System.Drawing.Point(211, 284);
            this.Text_Color.Multiline = true;
            this.Text_Color.Name = "Text_Color";
            this.Text_Color.Size = new System.Drawing.Size(196, 45);
            this.Text_Color.TabIndex = 11;
            // 
            // Text_BrandCar
            // 
            this.Text_BrandCar.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_BrandCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.Text_BrandCar.Location = new System.Drawing.Point(211, 146);
            this.Text_BrandCar.Multiline = true;
            this.Text_BrandCar.Name = "Text_BrandCar";
            this.Text_BrandCar.Size = new System.Drawing.Size(196, 45);
            this.Text_BrandCar.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(16)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(773, 0);
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
            this.label1.Size = new System.Drawing.Size(800, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить заказ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // AddOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrders";
            this.Text = "AddOrders";
            this.label.ResumeLayout(false);
            this.label.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox Text_Color;
        private System.Windows.Forms.TextBox Text_BrandCar;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Button Color_Other;
        private System.Windows.Forms.Button Color_Blue;
        private System.Windows.Forms.Button Color_Black;
        private System.Windows.Forms.Button Color_Red;
        private System.Windows.Forms.Button Color_White;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_ModelCar;
    }
}