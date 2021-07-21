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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_register_MouseEnter(object sender, EventArgs e)
        {
            label_register.ForeColor = Color.Brown;
        }

        private void label_register_MouseLeave(object sender, EventArgs e)
        {
            label_register.ForeColor = Color.Blue;
        }

        private void label_register_Click(object sender, EventArgs e)
        {

            Register_form register_Form = new Register_form();
            register_Form.ShowDialog();
            
        }

        private void input_login_KeyPress(object sender, KeyPressEventArgs e)
        {
           if ((e.KeyChar <= 64 || e.KeyChar >= 91) && (e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 96 || e.KeyChar >= 123) && e.KeyChar != 8)
           {
                e.Handled = true;
           }

        }

        private void button_input_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TLL7DT0\SQLEXPRESS;Initial Catalog=lottery;Integrated Security=True");

            string admin = "Select login, password From User_inf where (login = '" + input_login.Text.Trim() + "' and password = '" + input_password.Text.Trim() + "' and root = 1)"; // Различать Админа и Юзера
            SqlDataAdapter sda_admin = new SqlDataAdapter(admin, connection);
            DataTable dtb_admin = new DataTable();
            sda_admin.Fill(dtb_admin);
            if(dtb_admin.Rows.Count == 1)
            {
                Hide();
                Main_for_admin main_For_admin = new Main_for_admin();
                main_For_admin.Show();
            }
            else
            {
                string user = "Select login, password From User_inf where (login = '" + input_login.Text.Trim() + "' and password = '" + input_password.Text.Trim() + "' and root = 0)"; // Различать Админа и Юзера
                SqlDataAdapter sda_user = new SqlDataAdapter(user, connection);
                DataTable dtb_user = new DataTable();
                sda_user.Fill(dtb_user);
                if (dtb_user.Rows.Count == 1)
                {
                    Hide();
                    Main_for_user main_For_User = new Main_for_user(input_login.Text);
                    main_For_User.Show();
                }
                else
                {
                    MessageBox.Show("Некорректные данные!");
                }
            }
        }
        
    }
}
