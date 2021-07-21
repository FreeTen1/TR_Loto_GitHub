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
    public partial class add_types : Form
    {
        public add_types()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TLL7DT0\SQLEXPRESS;Initial Catalog=lottery;Integrated Security=True");
                SqlCommand Total = new SqlCommand("dbo.add_type", connection); // Хранимая процедура
                Total.CommandType = CommandType.StoredProcedure;
                Total.Parameters.AddWithValue("@name", textBox1.Text);
                Total.Parameters.AddWithValue("@date", textBox2.Text);
                Total.Parameters.AddWithValue("@price", Convert.ToInt32(textBox3.Text));
                Total.Parameters.AddWithValue("@xprice", Convert.ToInt32(textBox4.Text));
                connection.Open();
                Total.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Готово!");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так, попробуй снова");
            }
        }
    }
}
