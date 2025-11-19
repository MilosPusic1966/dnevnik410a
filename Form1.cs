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
using System.Reflection.Emit;

namespace dnevnik410a
{
    public partial class Form1 : Form
    {
        int br_sloga;
        DataTable tabela;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void prikazi()
        {
            if (br_sloga == tabela.Rows.Count-1)
               button6.Enabled = false;
            else button6.Enabled = true;
            if (br_sloga == 0)
                button2.Enabled = false;
            else button2.Enabled = true;

            textBox1.Text = tabela.Rows[br_sloga][0].ToString();
            textBox2.Text = tabela.Rows[br_sloga][1].ToString();
            textBox3.Text = tabela.Rows[br_sloga][2].ToString();
            textBox4.Text = tabela.Rows[br_sloga][3].ToString();
            textBox5.Text = tabela.Rows[br_sloga][4].ToString();
            textBox6.Text = tabela.Rows[br_sloga][5].ToString();
            textBox7.Text = tabela.Rows[br_sloga][6].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            br_sloga = 0;
            string CS = "Data Source=DESKTOP-6LPEK0P\\SQLEXPRESS;Initial catalog=dnevnik410a;Integrated security=true";
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            prikazi();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            br_sloga++;
            prikazi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            br_sloga = 0;
            prikazi();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            br_sloga--; 
            prikazi();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            br_sloga = tabela.Rows.Count- 1;
            prikazi();
        }
    }
}
