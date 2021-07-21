using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loto
{
    public partial class add_tickets : Form
    {
        public add_tickets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_random add_r = new add_random();
            add_r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_combo add_c = new add_combo();
            add_c.Show();
        }
    }
}
