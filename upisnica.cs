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
    public partial class upisnica : Form
    {
        public upisnica()
        {
            InitializeComponent();
        }

        private void Combo1Populate()
        {
            SqlConnection veza = konekcija.povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable godina = new DataTable();
            adapter.Fill(godina);
            comboBox1.DataSource=godina;
            comboBox1.ValueMember= "id";
            comboBox1.DisplayMember= "naziv";
        }
        private void upisnica_Load(object sender, EventArgs e)
        {
            Combo1Populate();
        }
    }
}
