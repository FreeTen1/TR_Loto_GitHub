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
    public partial class Main_for_admin : Form
    {
        public Main_for_admin()
        {
            InitializeComponent();
        }

        private void Main_for_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_for_admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lotteryDataSet2.all_types_for_admin". При необходимости она может быть перемещена или удалена.
            this.all_types_for_adminTableAdapter.Fill(this.lotteryDataSet2.all_types_for_admin);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lotteryDataSet1.AllTickets_for_admin". При необходимости она может быть перемещена или удалена.
            this.allTickets_for_adminTableAdapter.Fill(this.lotteryDataSet1.AllTickets_for_admin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_tickets add_t = new add_tickets();
            add_t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_types add_type = new add_types();
            add_type.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TLL7DT0\SQLEXPRESS;Initial Catalog=lottery;Integrated Security=True");
            connection.Open();
            this.all_types_for_adminTableAdapter.Fill(this.lotteryDataSet2.all_types_for_admin); //обновление представления
            this.allTickets_for_adminTableAdapter.Fill(this.lotteryDataSet1.AllTickets_for_admin);
            connection.Close();
        }

        private void button_for_delete_type_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TLL7DT0\SQLEXPRESS;Initial Catalog=lottery;Integrated Security=True");
                SqlCommand Total = new SqlCommand("dbo.del_type", connection); // Хранимая процедура
                Total.CommandType = CommandType.StoredProcedure;
                Total.Parameters.AddWithValue("@id", Convert.ToInt32(textBox_for_delete_type.Text));
                connection.Open();
                Total.ExecuteNonQuery();
                connection.Close();
                textBox_for_delete_type.Text = "";
            }
            catch
            {
                MessageBox.Show("что-то пошло не так, попробуй снова");
            }
        }
    }
}
