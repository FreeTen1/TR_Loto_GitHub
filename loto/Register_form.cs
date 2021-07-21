using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loto
{
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();
        }

        private void reg_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 64 || e.KeyChar >= 91) && (e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 96 || e.KeyChar >= 123) &&  e.KeyChar != 8)
            {
                MessageBox.Show("Некорректные символы!");
                e.Handled = true;
            }
                
        }
        private void reg_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                MessageBox.Show("Некорректные символы!");
                e.Handled = true;
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if ((reg_name.Text != "") && (reg_surname.Text != "") && (reg_login.Text != "") && (reg_password.Text!="") && (reg_number.Text!="") && (reg_email.Text != ""))
            {
                try
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TLL7DT0\SQLEXPRESS;Initial Catalog=lottery;Integrated Security=True");
                    SqlCommand Total = new SqlCommand("dbo.add_user_inf", connection); // Хранимая процедура
                    Total.CommandType = CommandType.StoredProcedure;
                    Total.Parameters.AddWithValue("@name", reg_name.Text);
                    Total.Parameters.AddWithValue("@surname", reg_surname.Text);
                    Total.Parameters.AddWithValue("@login", reg_login.Text);
                    Total.Parameters.AddWithValue("@password", reg_password.Text);
                    Total.Parameters.AddWithValue("@card_nubmer", reg_number.Text);
                    Total.Parameters.AddWithValue("@email", reg_email.Text);
                    connection.Open();
                    Total.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Готово!");
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("что-то пошло не так, проверте данные и попытайтесь снова)))");
                }

            }
            else
            {
                MessageBox.Show("не все данные введены!");
            }
            

        }


    }
}
