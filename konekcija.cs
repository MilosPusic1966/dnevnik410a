using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dnevnik410a
{
    internal class konekcija
    {
        public static SqlConnection povezi()
        {
            string CS = "Data Source=DESKTOP-6LPEK0P\\SQLEXPRESS;Initial catalog=dnevnik410a;Integrated security=true";
            SqlConnection veza = new SqlConnection(CS); 
            return veza;
        }
    }
}
