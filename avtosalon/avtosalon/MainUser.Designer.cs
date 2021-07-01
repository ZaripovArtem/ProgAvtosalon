namespace avtosalon
{
    partial class mainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCheckAuto = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.buttonCheckAuto);
            this.panel1.Controls.Add(this.buttonAddOrder);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // buttonCheckAuto
            // 
            this.buttonCheckAuto.BackColor = System.Drawing.Color.White;
            this.buttonCheckAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckAuto.FlatAppearance.BorderSize = 0;
            this.buttonCheckAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckAuto.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.buttonCheckAuto.Location = new System.Drawing.Point(227, 326);
            this.buttonCheckAuto.Name = "buttonCheckAuto";
            this.buttonCheckAuto.Size = new System.Drawing.Size(341, 52);
            this.buttonCheckAuto.TabIndex = 9;
            this.buttonCheckAuto.Text = "Просмотр Авто";
            this.buttonCheckAuto.UseVisualStyleBackColor = false;
            this.buttonCheckAuto.Click += new System.EventHandler(this.buttonCheckAuto_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.BackColor = System.Drawing.Color.White;
            this.buttonAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddOrder.FlatAppearance.BorderSize = 0;
            this.buttonAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddOrder.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.buttonAddOrder.Location = new System.Drawing.Point(227, 150);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(341, 52);
            this.buttonAddOrder.TabIndex = 8;
            this.buttonAddOrder.Text = "Добавить заказ";
            this.buttonAddOrder.UseVisualStyleBackColor = false;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
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
            this.label1.Text = "Автосалон";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Text = "main";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCheckAuto;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}