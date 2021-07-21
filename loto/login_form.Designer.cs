namespace loto
{
    partial class Login_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.input_login = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.label_avtoriz = new System.Windows.Forms.Label();
            this.label_register = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(12, 88);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(94, 32);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Login:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(12, 151);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(147, 32);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password:";
            // 
            // input_login
            // 
            this.input_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_login.Location = new System.Drawing.Point(107, 91);
            this.input_login.Name = "input_login";
            this.input_login.Size = new System.Drawing.Size(275, 28);
            this.input_login.TabIndex = 2;
            this.input_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_login_KeyPress);
            // 
            // input_password
            // 
            this.input_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_password.Location = new System.Drawing.Point(161, 153);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(221, 28);
            this.input_password.TabIndex = 3;
            this.input_password.UseSystemPasswordChar = true;
            // 
            // button_input
            // 
            this.button_input.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_input.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_input.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_input.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_input.Location = new System.Drawing.Point(107, 203);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(184, 70);
            this.button_input.TabIndex = 4;
            this.button_input.Text = "ВХОД";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // label_avtoriz
            // 
            this.label_avtoriz.AutoSize = true;
            this.label_avtoriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_avtoriz.Location = new System.Drawing.Point(23, 9);
            this.label_avtoriz.Name = "label_avtoriz";
            this.label_avtoriz.Size = new System.Drawing.Size(347, 61);
            this.label_avtoriz.TabIndex = 5;
            this.label_avtoriz.Text = "Авторизация";
            // 
            // label_register
            // 
            this.label_register.AutoSize = true;
            this.label_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_register.ForeColor = System.Drawing.Color.Blue;
            this.label_register.Location = new System.Drawing.Point(115, 285);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(149, 18);
            this.label_register.TabIndex = 6;
            this.label_register.Text = "зарегистрироваться";
            this.label_register.Click += new System.EventHandler(this.label_register_Click);
            this.label_register.MouseEnter += new System.EventHandler(this.label_register_MouseEnter);
            this.label_register.MouseLeave += new System.EventHandler(this.label_register_MouseLeave);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(402, 312);
            this.Controls.Add(this.label_register);
            this.Controls.Add(this.label_avtoriz);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лото";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox input_login;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Label label_avtoriz;
        private System.Windows.Forms.Label label_register;
    }
}

