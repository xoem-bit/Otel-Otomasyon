using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231116042_muhammet_efe_kök_proje_2
{
    internal class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BMG5BKD\\MSSQLSERVER01;Initial Catalog=Pansiyon;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
