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

namespace dnevnik410a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string CS = "Data Source=DESKTOP-6LPEK0P\\SQLEXPRESS;Initial catalog=dnevnik410a;Integrated security=true";
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            DataTable tabela = new DataTable();
            da.Fill(tabela);
            textBox1.Text = tabela.Rows[0][0].ToString();
            textBox2.Text = tabela.Rows[0][1].ToString();
            textBox3.Text = tabela.Rows[0][2].ToString();
        }
    }
}
