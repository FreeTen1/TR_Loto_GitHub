namespace loto
{
    partial class Register_form
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
            this.label_avtoriz = new System.Windows.Forms.Label();
            this.reg_surname = new System.Windows.Forms.TextBox();
            this.reg_name = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.reg_login = new System.Windows.Forms.TextBox();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.reg_number = new System.Windows.Forms.TextBox();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.label_card_number = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_avtoriz
            // 
            this.label_avtoriz.AutoSize = true;
            this.label_avtoriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_avtoriz.Location = new System.Drawing.Point(306, 9);
            this.label_avtoriz.Name = "label_avtoriz";
            this.label_avtoriz.Size = new System.Drawing.Size(339, 61);
            this.label_avtoriz.TabIndex = 12;
            this.label_avtoriz.Text = "Регистрация";
            this.label_avtoriz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reg_surname
            // 
            this.reg_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_surname.Location = new System.Drawing.Point(615, 107);
            this.reg_surname.Name = "reg_surname";
            this.reg_surname.Size = new System.Drawing.Size(238, 28);
            this.reg_surname.TabIndex = 10;
            // 
            // reg_name
            // 
            this.reg_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_name.Location = new System.Drawing.Point(219, 107);
            this.reg_name.Name = "reg_name";
            this.reg_name.Size = new System.Drawing.Size(238, 28);
            this.reg_name.TabIndex = 9;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_surname.Location = new System.Drawing.Point(463, 103);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(146, 32);
            this.label_surname.TabIndex = 8;
            this.label_surname.Text = "Фамилия:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(135, 102);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(78, 32);
            this.label_name.TabIndex = 7;
            this.label_name.Text = "Имя:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(115, 146);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(98, 32);
            this.label_login.TabIndex = 13;
            this.label_login.Text = "логин:";
            // 
            // reg_login
            // 
            this.reg_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_login.Location = new System.Drawing.Point(219, 151);
            this.reg_login.Name = "reg_login";
            this.reg_login.Size = new System.Drawing.Size(238, 28);
            this.reg_login.TabIndex = 14;
            this.reg_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reg_login_KeyPress);
            // 
            // reg_password
            // 
            this.reg_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_password.Location = new System.Drawing.Point(615, 151);
            this.reg_password.Name = "reg_password";
            this.reg_password.Size = new System.Drawing.Size(238, 28);
            this.reg_password.TabIndex = 15;
            this.reg_password.UseSystemPasswordChar = true;
            // 
            // reg_number
            // 
            this.reg_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_number.Location = new System.Drawing.Point(219, 197);
            this.reg_number.Name = "reg_number";
            this.reg_number.Size = new System.Drawing.Size(238, 28);
            this.reg_number.TabIndex = 16;
            this.reg_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reg_number_KeyPress);
            // 
            // reg_email
            // 
            this.reg_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_email.Location = new System.Drawing.Point(615, 197);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(238, 28);
            this.reg_email.TabIndex = 17;
            // 
            // button_register
            // 
            this.button_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_register.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_register.Location = new System.Drawing.Point(219, 248);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(634, 70);
            this.button_register.TabIndex = 18;
            this.button_register.Text = "ЗАРЕГЕСТРИРОВАТЬСЯ";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(487, 146);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(122, 32);
            this.label_password.TabIndex = 19;
            this.label_password.Text = "Пароль:";
            // 
            // label_card_number
            // 
            this.label_card_number.AutoSize = true;
            this.label_card_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_card_number.Location = new System.Drawing.Point(15, 191);
            this.label_card_number.Name = "label_card_number";
            this.label_card_number.Size = new System.Drawing.Size(197, 32);
            this.label_card_number.TabIndex = 20;
            this.label_card_number.Text = "Номер карты:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_email.Location = new System.Drawing.Point(514, 192);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(95, 32);
            this.label_email.TabIndex = 21;
            this.label_email.Text = "Email:";
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(877, 344);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_card_number);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.reg_email);
            this.Controls.Add(this.reg_number);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.reg_login);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_avtoriz);
            this.Controls.Add(this.reg_surname);
            this.Controls.Add(this.reg_name);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_avtoriz;
        private System.Windows.Forms.TextBox reg_surname;
        private System.Windows.Forms.TextBox reg_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox reg_login;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.TextBox reg_number;
        private System.Windows.Forms.TextBox reg_email;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_card_number;
        private System.Windows.Forms.Label label_email;
    }
}