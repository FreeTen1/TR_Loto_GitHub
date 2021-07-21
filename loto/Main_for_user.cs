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
    public partial class Main_for_user : Form
    {
        int id;
        int price;
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TLL7DT0\SQLEXPRESS;Initial Catalog=lottery;Integrated Security=True");
        public Main_for_user(string name)
        {
            InitializeComponent();
            SqlCommand Total = new SqlCommand("Select dbo.userid('" + name + "');", connection); //Скалярная функция, чтобы узнать id
            connection.Open();
            id = (int)Total.ExecuteScalar();
            label_user_login.Text = name;
            connection.Close();

            SqlCommand Total1 = new SqlCommand("Select dbo.user_cash('" + id + "');", connection); //Скалярная функция, чтобы узнать cash
            connection.Open();
            int cash = (int)Total1.ExecuteScalar();
            label_cash.Text = Convert.ToString(cash);
            connection.Close();



            SqlCommand Total2 = new SqlCommand("Select * From dbo.UserTickets('" + id + "');", connection);//Табличная ф
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(Total2);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dataGridView1.DataSource = dtb;
            connection.Close();
        }

        private void Main_for_user_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lotteryDataSet3.tickets_for_buy". При необходимости она может быть перемещена или удалена.
            this.tickets_for_buyTableAdapter1.Fill(this.lotteryDataSet3.tickets_for_buy);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lotteryDataSet5.tickets_for_buy". При необходимости она может быть перемещена или удалена.
            this.tickets_for_buyTableAdapter.Fill(this.lotteryDataSet5.tickets_for_buy);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //try
            //{ 

            //InitializeComponent();
            SqlCommand Total12 = new SqlCommand("Select dbo.type_info ('" + textBox_for_buy.Text + "');", connection); //Скалярная функция, чтобы узнать id
            connection.Open();
            int type = (int)Total12.ExecuteScalar();
            connection.Close();


            SqlCommand Total = new SqlCommand("Select dbo.price_ticket('" + type + "');", connection); //Скалярная функция, чтобы узнать id
            connection.Open();
             price = (int)Total.ExecuteScalar();
             connection.Close();

             SqlCommand Total4 = new SqlCommand("dbo.buy_ticket", connection); // Хранимая процедура
             Total4.CommandType = CommandType.StoredProcedure;
             Total4.Parameters.AddWithValue("@userid", id);
             Total4.Parameters.AddWithValue("@price", price);
             connection.Open();
             Total4.ExecuteNonQuery();
             connection.Close();

             SqlCommand Total5 = new SqlCommand("Select dbo.user_cash('" + id + "');", connection); //Скалярная функция, чтобы узнать cash
             connection.Open();
             int cash = (int)Total5.ExecuteScalar();
             label_cash.Text = Convert.ToString(cash);
             connection.Close();

            SqlCommand Total3 = new SqlCommand("dbo.update_user", connection); // Хранимая процедура
            Total3.CommandType = CommandType.StoredProcedure;
            Total3.Parameters.AddWithValue("@ticketid", Convert.ToInt32(textBox_for_buy.Text));
            Total3.Parameters.AddWithValue("@userid", id);
            connection.Open();
            Total3.ExecuteNonQuery();
            connection.Close();

            //}
            //catch
            //{
            //   MessageBox.Show("что-то пошло не так, попробуй снова");
            //}

            SqlCommand Total1 = new SqlCommand("Select * From dbo.UserTickets('" + id + "');", connection); //Обновление табличной ф
            SqlDataAdapter sda = new SqlDataAdapter(Total1);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dataGridView1.DataSource = dtb;

            this.tickets_for_buyTableAdapter1.Fill(this.lotteryDataSet3.tickets_for_buy); //обновление представления

            connection.Close();
        }

        private void Main_for_user_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                MessageBox.Show("Некорректные символы!");
                e.Handled = true;
            }
        }

        private void button_for_cash_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Total4 = new SqlCommand("dbo.update_cash", connection); // Хранимая процедура
                Total4.CommandType = CommandType.StoredProcedure;
                Total4.Parameters.AddWithValue("@userid", id);
                Total4.Parameters.AddWithValue("@cash", Convert.ToInt32(textBox_for_cash.Text));
                connection.Open();
                Total4.ExecuteNonQuery();
                connection.Close();

                SqlCommand Total5 = new SqlCommand("Select dbo.user_cash('" + id + "');", connection); //Скалярная функция, чтобы узнать cash
                connection.Open();
                int cash = (int)Total5.ExecuteScalar();
                label_cash.Text = Convert.ToString(cash);
                connection.Close();
            }
            catch
            {
                MessageBox.Show("что-то пошло не так, попробуй снова");
            }
        }

    }
}
