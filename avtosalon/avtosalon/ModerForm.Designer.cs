namespace avtosalon
{
    partial class ModerForm
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
            this.BackToLogin = new System.Windows.Forms.Label();
            this.buttonModerLogin = new System.Windows.Forms.Button();
            this.ModerPassField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ModerLoginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.BackToLogin);
            this.panel1.Controls.Add(this.buttonModerLogin);
            this.panel1.Controls.Add(this.ModerPassField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ModerLoginField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 450);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // BackToLogin
            // 
            this.BackToLogin.AutoSize = true;
            this.BackToLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToLogin.ForeColor = System.Drawing.Color.White;
            this.BackToLogin.Location = new System.Drawing.Point(89, 398);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(232, 22);
            this.BackToLogin.TabIndex = 8;
            this.BackToLogin.Text = "Вернуться к авторизации";
            this.BackToLogin.Click += new System.EventHandler(this.BackToLogin_Click);
            // 
            // buttonModerLogin
            // 
            this.buttonModerLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(35)))));
            this.buttonModerLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModerLogin.FlatAppearance.BorderSize = 0;
            this.buttonModerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModerLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModerLogin.ForeColor = System.Drawing.Color.White;
            this.buttonModerLogin.Location = new System.Drawing.Point(98, 322);
            this.buttonModerLogin.Name = "buttonModerLogin";
            this.buttonModerLogin.Size = new System.Drawing.Size(210, 52);
            this.buttonModerLogin.TabIndex = 7;
            this.buttonModerLogin.Text = "Войти";
            this.buttonModerLogin.UseVisualStyleBackColor = false;
            this.buttonModerLogin.Click += new System.EventHandler(this.buttonModerLogin_Click);
            // 
            // ModerPassField
            // 
            this.ModerPassField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModerPassField.Location = new System.Drawing.Point(97, 231);
            this.ModerPassField.Name = "ModerPassField";
            this.ModerPassField.Size = new System.Drawing.Size(251, 48);
            this.ModerPassField.TabIndex = 6;
            this.ModerPassField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::avtosalon.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(27, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // ModerLoginField
            // 
            this.ModerLoginField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModerLoginField.Location = new System.Drawing.Point(98, 140);
            this.ModerLoginField.Multiline = true;
            this.ModerLoginField.Name = "ModerLoginField";
            this.ModerLoginField.Size = new System.Drawing.Size(251, 64);
            this.ModerLoginField.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::avtosalon.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(27, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(16)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 100);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(370, 0);
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
            this.label1.Size = new System.Drawing.Size(397, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация персонала";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModerForm";
            this.Text = "ModerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonModerLogin;
        private System.Windows.Forms.TextBox ModerPassField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox ModerLoginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BackToLogin;
    }
}