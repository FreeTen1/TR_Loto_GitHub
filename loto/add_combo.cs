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
    public partial class add_combo : Form
    {
        public add_combo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TLL7DT0\SQLEXPRESS;Initial Catalog=lottery;Integrated Security=True");
                SqlCommand Total = new SqlCommand("dbo.add_ticket_ComboWin", connection); // Хранимая процедура
                Total.CommandType = CommandType.StoredProcedure;
                int type = Convert.ToInt32(textBox1.Text);
                Total.Parameters.AddWithValue("@type", type);
                Total.Parameters.AddWithValue("@kombo", textBox2.Text);
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
